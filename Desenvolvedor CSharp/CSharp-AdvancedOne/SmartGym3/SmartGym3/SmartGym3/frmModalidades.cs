using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGym3
{
    public partial class frmModalidades : Form
    {
        public frmModalidades()
        {
            InitializeComponent();
        }

        //Método responsável por adicionar ao combobox os professores cadastrados
        public void ListCoachesFRMModalidades()
        {
            try
            {
                //Instancia um objeto da classe PersonalTrainer
                PersonalTrainer PersonalTrainer = new PersonalTrainer();
                //Atribui a propriedade DataSource, do Combobox, o resultado da pesquisa realizada pelo método ListCoaches da classe PersonalTrainer. 
                cbCoachModalidade.DataSource = PersonalTrainer.ListCoaches();

                /*
                 * A propriedade DisplayMember do Combobox permite exibir, no texto do combobox, a coluna que escolhermos.
                 * A propriedade ValueMember armazena os valores do item adicionado ao DisplayMember, como o id do professore, por exemplo. 
                 */

                cbCoachModalidade.DisplayMember = "NamePersonalTrainer";
                cbCoachModalidade.ValueMember = "IdPersonalTrainer";

                //Faz com que o combobox inicie em branco. 
                cbCoachModalidade.SelectedIndex = -1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmModalidades_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'smartGYMDataSet.Modalidades'. Você pode movê-la ou removê-la conforme necessário.
            this.modalidadesTableAdapter.Fill(this.smartGYMDataSet.Modalidades);
            ListCoachesFRMModalidades();
        }
    }
}
