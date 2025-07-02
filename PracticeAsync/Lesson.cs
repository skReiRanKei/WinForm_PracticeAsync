using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceAsync
{
    public partial class Lesson : Form
    {
        #region "定数"
        // 実行回数
        private const int DO_COUNT = 1000;
        // 出力するファイル名（前半）
        private const string FILE_NM = "asyncTest_";
        // 出力するファイル名（拡張子）
        private const string FILE_EXTENSION = ".txt";
        #endregion

        #region "コンストラクタ"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Lesson()
        {
            InitializeComponent();
        }
        #endregion

        #region "privateメソッド"
        /// <summary>
        /// テキストの作成・書込・削除
        /// </summary>
        private void CreateWriteDelete()
        {
            try
            {
                // 作成
                CreateText();
                // 書込
                WriteText();
                // 削除
                DeleteText();
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// テキストの作成
        /// </summary>
        private void CreateText()
        {
            try
            {
                for (int i = 0; i < DO_COUNT; i++)
                {
                    // 画面の入力パスをベースにファイル情報を取得（テキストファイル：固定名_回数.txt）
                    FileInfo fileInfo = new FileInfo(Path.Combine(txtOutputPath.Text, $"{FILE_NM}_{i}{FILE_EXTENSION}"));
                    // 存在してない場合だけ作成
                    if (!File.Exists(fileInfo.FullName))
                    {
                        using (var stream = fileInfo.Create())
                        {

                        }
                        // 進捗用のラベルにファイル名を表示
                        SetLabelTextSafe($"作成：{fileInfo.Name}");
                    }
                }
            }
            catch
            {
                throw;
            }

        }
        /// <summary>
        /// テキストの書き込み
        /// </summary>
        private void WriteText()
        {
            try
            {
                // 書き込む内容を取得
                Guid g = System.Guid.NewGuid();
                string pass = g.ToString("N").Substring(0, 8);

                for (int i = 0; i < DO_COUNT; i++)
                {
                    // 画面の入力パスをベースにファイル情報を取得（テキストファイル：固定名_回数.txt）
                    FileInfo fileInfo = new FileInfo(Path.Combine(txtOutputPath.Text, $"{FILE_NM}_{i}{FILE_EXTENSION}"));
                    // 存在している場合のみ書込
                    if (File.Exists(fileInfo.FullName))
                    {
                        using (StreamWriter writer = new StreamWriter(fileInfo.FullName))
                        {
                            writer.WriteLine(pass);
                        }
                        // 進捗用のラベルにファイル名を表示
                        SetLabelTextSafe($"書込：{fileInfo.Name}");
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// テキストの削除
        /// </summary>
        private void DeleteText()
        {
            try
            {
                // 削除時はキーワードで検索して削除するのが一般的だが、ここではわざと時間がかかる処理を作成
                for (int i = 0; i < DO_COUNT; i++)
                {
                    // 画面の入力パスをベースにファイル情報を取得（テキストファイル：固定名_回数.txt）
                    FileInfo txt = new FileInfo(Path.Combine(txtOutputPath.Text, $"{FILE_NM}_{i}{FILE_EXTENSION}"));
                    // 存在している場合のみ削除
                    if (File.Exists(txt.FullName))
                    {
                        // 進捗用のラベルにファイル名を表示
                        SetLabelTextSafe($"削除：{txt.Name}");
                        // 削除
                        txt.Delete();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// ラベルの更新処理（進捗ラベル）
        /// </summary>
        /// <param name="message"></param>
        private void SetLabelTextSafe(string message)
        {
            if (lblProgress.InvokeRequired)
            {
                lblProgress.Invoke(new Action(() => lblProgress.Text = message));
            }
            else
            {
                lblProgress.Text = message;
            }
        }

        /// <summary>
        /// 非同期処理：作成から削除まで
        /// </summary>
        /// <returns></returns>
        private async Task CreateDelSet()
        {
            await Task.Run(() => CreateWriteDelete());
        }

        #endregion

        #region "イベント"
        /// <summary>
        /// ロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lesson_Load(object sender, EventArgs e)
        {
            // 画面コントロールの初期化
            lblCount.Text = $"繰り返し回数：{DO_COUNT}";
            lblProgress.Visible = false;
            lblProgress.Text = string.Empty;
        }

        /// <summary>
        /// 参照ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReference_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog dirDialog = new FolderBrowserDialog())
                {
                    // ダイアログを開く
                    if (dirDialog.ShowDialog() == DialogResult.OK)
                    {
                        // 選択されたフォルダパスをテキストボックスに入れる
                        txtOutputPath.Text = dirDialog.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        /// <summary>
        /// 開始ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // 出力先のディレクトリパスが存在しない場合は、処理を行わない
                if (!Directory.Exists(txtOutputPath.Text))
                {
                    MessageBox.Show("出力先が存在しません。処理を中断します。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblProgress.Visible = true;
                lblProgress.Text = "処理を開始します";

                // メイン処理：ファイルの作成と削除
                await CreateDelSet();

                // 終了メッセージの表示
                MessageBox.Show("End", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblProgress.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        #endregion

    }
}
