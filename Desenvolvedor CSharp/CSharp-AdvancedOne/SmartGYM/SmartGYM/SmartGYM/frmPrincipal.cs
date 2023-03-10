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

namespace SmartGYM
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Estabelece a conexão com o banco de dados a partir da classe e do método de conexão
            using (SqlConnection connectionSmartGYM = new SqlConnection(SmartGYMConnection.stringConnectionSmartGYM))
            {
                try
                {
                    connectionSmartGYM.Open(); //Abre a conexão com o banco de dados
                    MessageBox.Show("Seja muito bem-vindo ao SmartGym!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Houve um erro no processo de conexão com o banco de dados");
                }
            }

            ddmPeople.IsMainMenu = true;
        }

        private void btnShowMenuPeople_Click(object sender, EventArgs e)
        {
            ddmPeople.Show(btnShowMenuPeople, btnShowMenuPeople.Width, 0);
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpcoesColaboradores frmOpcoesColaboradores = new frmOpcoesColaboradores();
            frmOpcoesColaboradores.ShowDialog();
        }
    }
}
