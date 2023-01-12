using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingSupplies
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Realiza a conexão com o banco de dados
            using (SqlConnection connectBuildingSupplies = new SqlConnection(ConnectionBuildingSupplies.returnStringConnectionBuildingSupplies))
            {
                try
                {
                    connectBuildingSupplies.Open();
                    MessageBox.Show("Seja bem-vindo ao Building Supplies!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Eita, algo deu errado! Mas, já vamos resolver :)");
                }
            }
        }
    }
}
