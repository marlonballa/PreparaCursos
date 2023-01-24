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

namespace SmartGym3
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            frmCoachs frmCoachs = new frmCoachs();
            frmCoachs.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Instanciamos um objeto da classe SqlConnection para realizar a conexão com nosso banco de dados. Este objeto espera como parâmetro, a classe que armazena a string de conexão e o método de leitura de seu valor. 
            using (SqlConnection newConnectionWithSmartGym = new SqlConnection(SmartGymDBConnection.stringConnectionSmartGym))
            {
                //Tenta realizar as intruções contidas em seu bloco
                try
                {
                    /*
                     * Uma vez que a classe foi instanciada e temos um objeto, podemos acessar seus métodos, para manipular nosso banco de dados. O primeiro método a ser utilizado é o Open(), que abre a conexão com o banco
                     */
                    newConnectionWithSmartGym.Open();
                    MessageBox.Show("Conectou!");
                }
                //Se houver algum erro no procedimento acima, será capturado neste bloco, para que possa ser tratado da forma correta. 
                catch (Exception)
                {
                    MessageBox.Show("Não Conectou!");
                }
                //Executa uma ação, independente do resultado dos blocos anteriores. 
                finally
                {
                    MessageBox.Show("Bem-vindo ao sistema da academia!");
                }

            }
        }
    }
}
