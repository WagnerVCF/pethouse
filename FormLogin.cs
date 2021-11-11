using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace pethouse
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        private Pethouse dgv;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\pethouse\\DBPethouse.mdf;Integrated Security=True");
        public FormLogin()
        {
            InitializeComponent();
            dgv = new Pethouse();
            FormLogo logo = new FormLogo();
            logo.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            logo.Close();
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string senha = dgv.Base64Encode(mtbSenha.Text);
            string usu = "SELECT login, senha FROM Funcionarios WHERE login = @login AND senha = @senha";
            SqlCommand cmd = new SqlCommand(usu, conn);
            cmd.Parameters.AddWithValue("@login", SqlDbType.NChar).Value = mtbLogin.Text.Trim();
            //func converter senha > (cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = mtbSenha.Text.Trim();) <
            //func após criar os funcionarios senha > (cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = senha;) <
            cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = senha;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader usuario = cmd.ExecuteReader();
            if (usuario.HasRows)
            {
                this.Hide();
                FormFuncionario pri = new FormFuncionario();
                pri.Show();
                conn.Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Login ou senha inválidos! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbLogin.Text = "";
                mtbSenha.Text = "";
                mtbLogin.Focus();
                conn.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
