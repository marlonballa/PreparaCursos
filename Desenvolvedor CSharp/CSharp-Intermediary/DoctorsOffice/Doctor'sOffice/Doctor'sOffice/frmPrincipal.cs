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

namespace Doctor_sOffice
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString;
                SqlConnection connection;
                connectionString = @"Data Source=DESKTOP-CTIOBN5\MARLONBALLA;Initial Catalog=ConsultasDoctorsOffice;User Id=sa;Password=Marlon1993*";
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Conexão efetuada com sucesso!");
                connection.Close(); 
            }
            catch (SqlException connectionError)
            {
                MessageBox.Show($"Não foi dessa vez! {connectionError}");
            }


        }
    }
}
