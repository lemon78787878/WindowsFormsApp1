namespace WindowsFormsApp1
{
    partial class Form1
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("ＭＳ 明朝", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MessageLabel.Location = new System.Drawing.Point(293, 212);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(355, 33);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "操作内容を表示します";
            this.MessageLabel.Click += new System.EventHandler(this.MessageLabel_Click);
            // 
            // ActionButton
            // 
            this.ActionButton.Font = new System.Drawing.Font("Meiryo UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ActionButton.Location = new System.Drawing.Point(172, 212);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(115, 33);
            this.ActionButton.TabIndex = 1;
            this.ActionButton.Text = "Action";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            this.ActionButton.MouseLeave += new System.EventHandler(this.ActionButton_MouseLeave);
            this.ActionButton.MouseHover += new System.EventHandler(this.ActionButton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.MessageLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
    private System.Windows.Forms.Button ActionButton;
  }
}

