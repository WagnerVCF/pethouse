using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pethouse
{
    public partial class Principal : MetroFramework.Forms.MetroForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var func = new FormFuncionario();
            func.MdiParent = this.MdiParent;
            func.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cli = new FormCliente();
            cli.MdiParent = this.MdiParent;
            cli.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cli = new petserv.FormServico();
            cli.MdiParent = this.MdiParent;
            cli.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
