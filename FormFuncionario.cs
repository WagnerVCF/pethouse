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

namespace pethouse
{
    public partial class FormFuncionario : MetroFramework.Forms.MetroForm
    {
        private Pethouse dgv;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\pethouse\\DBPethouse.mdf;Integrated Security=True");
        public FormFuncionario()
        {
            InitializeComponent();
            dgv = new Pethouse();
        }

        public void CarregaMdgv()
        {
            String query = "SELECT * FROM Funcionarios";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable usuario = new DataTable();
            da.Fill(usuario);
            this.MgUsuario.DataSource = usuario;
            conn.Close();
        }


        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            Pethouse pethouse = new Pethouse();
            List<Pethouse> pethouses = pethouse.listafuncionario();
            MgUsuario.DataSource = pethouses;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string senha = dgv.Base64Encode(mtbSenha.Text);
            Pethouse pethouse = new Pethouse();
            string genero = Convert.ToString(mtbGenero.SelectedItem);
            pethouse.InserirFunc(mtbNome.Text, mtbLogin.Text, senha, mtbCelular.Text, mtbDataAdm.Text, mtbGenero.Text);
            MessageBox.Show("Funcionário inserido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Pethouse> funcionario = pethouse.listafuncionario();
            MgUsuario.DataSource = funcionario;
            mtbNome.Text = "";
            mtbLogin.Text = "";
            mtbSenha.Text = "";
            mtbCelular.Text = "";
            mtbDataAdm.Text = "";
            mtbGenero.Text = "";
            mtbGenero.SelectedIndex = -1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string senha = dgv.Base64Encode(mtbSenha.Text);
                conn.Open();
                SqlCommand cmd = new SqlCommand("AtualizarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(mtbId.Text.Trim());
                cmd.Parameters.AddWithValue("@login", SqlDbType.NChar).Value = mtbLogin.Text.Trim();
                cmd.Parameters.AddWithValue("@senha", SqlDbType.NChar).Value = mtbSenha;
                cmd.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, "Usuário atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                CarregaMdgv();
                mtbId.Text = "";
                mtbLogin.Text = "";
                mtbSenha.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(mtbId.Text.Trim());
                Pethouse pethouse = new Pethouse();
                pethouse.ExcluirFunc(id);
                MessageBox.Show("Funcionário excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Pethouse> funcionario = pethouse.listafuncionario();
                MgUsuario.DataSource = funcionario;
                mtbNome.Text = "";
                mtbLogin.Text = "";
                mtbSenha.Text = "";
                mtbCelular.Text = "";
                mtbDataAdm.Text = "";
                mtbGenero.Text = "";
                mtbGenero.SelectedIndex = -1;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void MgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.MgUsuario.Rows[e.RowIndex];
                mtbId.Text = row.Cells[0].Value.ToString();
                mtbNome.Text = row.Cells[1].Value.ToString();
                mtbLogin.Text = row.Cells[2].Value.ToString();
                mtbSenha.Text = row.Cells[3].Value.ToString();
                mtbCelular.Text = row.Cells[4].Value.ToString();
            }
        }

        private void MgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
