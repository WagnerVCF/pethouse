namespace pethouse
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtbLogin = new MetroFramework.Controls.MetroTextBox();
            this.mtbSenha = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mtbLogin
            // 
            // 
            // 
            // 
            this.mtbLogin.CustomButton.Image = null;
            this.mtbLogin.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.mtbLogin.CustomButton.Name = "";
            this.mtbLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbLogin.CustomButton.TabIndex = 1;
            this.mtbLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbLogin.CustomButton.UseSelectable = true;
            this.mtbLogin.CustomButton.Visible = false;
            this.mtbLogin.Lines = new string[0];
            this.mtbLogin.Location = new System.Drawing.Point(83, 100);
            this.mtbLogin.MaxLength = 32767;
            this.mtbLogin.Name = "mtbLogin";
            this.mtbLogin.PasswordChar = '\0';
            this.mtbLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbLogin.SelectedText = "";
            this.mtbLogin.SelectionLength = 0;
            this.mtbLogin.SelectionStart = 0;
            this.mtbLogin.ShortcutsEnabled = true;
            this.mtbLogin.Size = new System.Drawing.Size(163, 23);
            this.mtbLogin.TabIndex = 2;
            this.mtbLogin.UseSelectable = true;
            this.mtbLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbSenha
            // 
            // 
            // 
            // 
            this.mtbSenha.CustomButton.Image = null;
            this.mtbSenha.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.mtbSenha.CustomButton.Name = "";
            this.mtbSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbSenha.CustomButton.TabIndex = 1;
            this.mtbSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbSenha.CustomButton.UseSelectable = true;
            this.mtbSenha.CustomButton.Visible = false;
            this.mtbSenha.Lines = new string[0];
            this.mtbSenha.Location = new System.Drawing.Point(83, 168);
            this.mtbSenha.MaxLength = 32767;
            this.mtbSenha.Name = "mtbSenha";
            this.mtbSenha.PasswordChar = '*';
            this.mtbSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbSenha.SelectedText = "";
            this.mtbSenha.SelectionLength = 0;
            this.mtbSenha.SelectionStart = 0;
            this.mtbSenha.ShortcutsEnabled = true;
            this.mtbSenha.Size = new System.Drawing.Size(163, 23);
            this.mtbSenha.TabIndex = 3;
            this.mtbSenha.UseSelectable = true;
            this.mtbSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbSenha.Click += new System.EventHandler(this.txtSenha_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Highlight = true;
            this.btnLogin.Location = new System.Drawing.Point(83, 213);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(83, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Login";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(83, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Senha";
            // 
            // btnSair
            // 
            this.btnSair.Highlight = true;
            this.btnSair.Location = new System.Drawing.Point(171, 213);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSair.UseSelectable = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 270);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.mtbSenha);
            this.Controls.Add(this.mtbLogin);
            this.Name = "FormLogin";
            this.Text = "Painel de Login";
            this.Load += new System.EventHandler(this.btnLogin_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox mtbLogin;
        private MetroFramework.Controls.MetroTextBox mtbSenha;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnSair;
    }
}