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

namespace petserv
{
    public partial class FormServico : MetroFramework.Forms.MetroForm
    {
        private Petserv dgv;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\pethouse\\DBPethouse.mdf;Integrated Security=True");
        public FormServico()
        {
            InitializeComponent();
            dgv = new Petserv();
        }

        public void CarregaMdgv()
        {
        }

        private void FormServico_Load(object sender, EventArgs e)
        {
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Petserv petserv = new Petserv();
            petserv.InserirServ(mtbID.Text, mtbServico.Text);
            MessageBox.Show("Serviço inserido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Petserv> petservs = petserv.listaservico();
            mtbServico.Text = "";
        }

        private void MgServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
