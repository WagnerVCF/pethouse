namespace petserv
{
    partial class FormServico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MgServico = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtbID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtbServico = new MetroFramework.Controls.MetroTextBox();
            this.btnInserir = new MetroFramework.Controls.MetroButton();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.MgServico)).BeginInit();
            this.SuspendLayout();
            // 
            // MgServico
            // 
            this.MgServico.AllowUserToResizeRows = false;
            this.MgServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.MgServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MgServico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MgServico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MgServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MgServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MgServico.DefaultCellStyle = dataGridViewCellStyle2;
            this.MgServico.EnableHeadersVisualStyles = false;
            this.MgServico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MgServico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.MgServico.Location = new System.Drawing.Point(12, 165);
            this.MgServico.Name = "MgServico";
            this.MgServico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MgServico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MgServico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MgServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MgServico.Size = new System.Drawing.Size(435, 220);
            this.MgServico.Style = MetroFramework.MetroColorStyle.Blue;
            this.MgServico.TabIndex = 1;
            this.MgServico.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MgServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MgServico_CellContentClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ID";
            // 
            // mtbID
            // 
            // 
            // 
            // 
            this.mtbID.CustomButton.Image = null;
            this.mtbID.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.mtbID.CustomButton.Name = "";
            this.mtbID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbID.CustomButton.TabIndex = 1;
            this.mtbID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbID.CustomButton.UseSelectable = true;
            this.mtbID.CustomButton.Visible = false;
            this.mtbID.Lines = new string[0];
            this.mtbID.Location = new System.Drawing.Point(39, 80);
            this.mtbID.MaxLength = 32767;
            this.mtbID.Name = "mtbID";
            this.mtbID.PasswordChar = '\0';
            this.mtbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbID.SelectedText = "";
            this.mtbID.SelectionLength = 0;
            this.mtbID.SelectionStart = 0;
            this.mtbID.ShortcutsEnabled = true;
            this.mtbID.Size = new System.Drawing.Size(92, 23);
            this.mtbID.TabIndex = 3;
            this.mtbID.UseSelectable = true;
            this.mtbID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Serviço";
            // 
            // mtbServico
            // 
            // 
            // 
            // 
            this.mtbServico.CustomButton.Image = null;
            this.mtbServico.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.mtbServico.CustomButton.Name = "";
            this.mtbServico.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbServico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbServico.CustomButton.TabIndex = 1;
            this.mtbServico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbServico.CustomButton.UseSelectable = true;
            this.mtbServico.CustomButton.Visible = false;
            this.mtbServico.Lines = new string[0];
            this.mtbServico.Location = new System.Drawing.Point(70, 117);
            this.mtbServico.MaxLength = 32767;
            this.mtbServico.Name = "mtbServico";
            this.mtbServico.PasswordChar = '\0';
            this.mtbServico.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbServico.SelectedText = "";
            this.mtbServico.SelectionLength = 0;
            this.mtbServico.SelectionStart = 0;
            this.mtbServico.ShortcutsEnabled = true;
            this.mtbServico.Size = new System.Drawing.Size(158, 23);
            this.mtbServico.TabIndex = 5;
            this.mtbServico.UseSelectable = true;
            this.mtbServico.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbServico.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnInserir
            // 
            this.btnInserir.Highlight = true;
            this.btnInserir.Location = new System.Drawing.Point(372, 76);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnInserir.UseSelectable = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Highlight = true;
            this.btnSair.Location = new System.Drawing.Point(372, 117);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSair.UseSelectable = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 398);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.mtbServico);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtbID);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MgServico);
            this.Name = "FormServico";
            this.Text = "Serviço";
            this.Load += new System.EventHandler(this.FormServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MgServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid MgServico;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtbID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtbServico;
        private MetroFramework.Controls.MetroButton btnInserir;
        private MetroFramework.Controls.MetroButton btnSair;
    }
}