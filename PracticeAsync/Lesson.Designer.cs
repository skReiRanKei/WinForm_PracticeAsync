namespace practiceAsync
{
    partial class Lesson
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReference = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Location = new System.Drawing.Point(625, 117);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.BackColor = System.Drawing.Color.White;
            this.txtOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutputPath.Location = new System.Drawing.Point(139, 78);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOutputPath.Size = new System.Drawing.Size(480, 19);
            this.txtOutputPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(72, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "出力パス";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblProgress.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProgress.Location = new System.Drawing.Point(404, 146);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(99, 13);
            this.lblProgress.TabIndex = 3;
            this.lblProgress.Text = "処理を開始します";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "非同期処理を理解するためのプログラムです。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "開始されると一定数のファイルの作成・書き込み・削除を行います。";
            // 
            // btnReference
            // 
            this.btnReference.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReference.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReference.Location = new System.Drawing.Point(625, 78);
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(84, 23);
            this.btnReference.TabIndex = 6;
            this.btnReference.Text = "参照";
            this.btnReference.UseVisualStyleBackColor = false;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(584, 46);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 12);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "回数：";
            // 
            // Lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 180);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnReference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.btnStart);
            this.Name = "Lesson";
            this.Text = "非同期処理レッスン";
            this.Load += new System.EventHandler(this.Lesson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.Label lblCount;
    }
}

