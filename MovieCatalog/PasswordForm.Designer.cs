namespace VideoLibrary
{
    partial class PasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.BtnConfirmPwd = new System.Windows.Forms.Button();
            this.labelPwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(143, 102);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(153, 20);
            this.textBoxPwd.TabIndex = 0;
            this.textBoxPwd.UseSystemPasswordChar = true;
            // 
            // BtnConfirmPwd
            // 
            this.BtnConfirmPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnConfirmPwd.Location = new System.Drawing.Point(160, 145);
            this.BtnConfirmPwd.Name = "BtnConfirmPwd";
            this.BtnConfirmPwd.Size = new System.Drawing.Size(120, 30);
            this.BtnConfirmPwd.TabIndex = 1;
            this.BtnConfirmPwd.Text = "Войти";
            this.BtnConfirmPwd.UseVisualStyleBackColor = true;
            this.BtnConfirmPwd.Click += new System.EventHandler(this.BtnConfirmPwd_Click);
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPwd.Location = new System.Drawing.Point(120, 60);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(200, 20);
            this.labelPwd.TabIndex = 2;
            this.labelPwd.Text = "Введите пароль админа:";
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.BtnConfirmPwd);
            this.Controls.Add(this.textBoxPwd);
            this.Name = "PasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Button BtnConfirmPwd;
        private System.Windows.Forms.Label labelPwd;
    }
}