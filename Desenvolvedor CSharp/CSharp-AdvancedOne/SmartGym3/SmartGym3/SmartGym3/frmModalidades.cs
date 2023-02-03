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

        //Instanciando a classe Modalidades
        Modalidades Modalidade;

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
            //Carrega o nome dos Coachs no ComboBox
            ListCoachesFRMModalidades();
            //Carrega as modalidades cadastradas no banco
            ListModalidades();
        }

        //Método responsável por listar no datagridview todas as modalidades que estão no banco de dados.
        private void ListModalidades()
        {
            try
            {
                Modalidade = new Modalidades();
                dtgModalidades.DataSource = Modalidade.ListModalidades();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        private void btnSavalModalidade_Click(object sender, EventArgs e)
        {
            try
            {
                Modalidade = new Modalidades();

                if (cbCoachModalidade.SelectedIndex == -1)
                {
                    MessageBox.Show("Você deve escolher um Coach!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtCodModalidade.Text == "0")
                    {
                        //Vamos verificar se o valor do campo código é igual ou diferente a 0, para podermos o caminho de um novo cadastro ou de uma atualização
                        //É neste momento que referenciamos a ligação do componente com os respectivos campos das tabelas
                        //a propriedade SelectedValue retorna o ID do Item selecionado no ComboBox
                        Modalidade.SaveNewModalidade(Convert.ToInt32(cbCoachModalidade.SelectedValue), Convert.ToDecimal(txtMensalidadeModalidade.Text), txtNomeModalidade.Text);

                        MessageBox.Show("Modalidade salva com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Carrega as modalidades cadastradas no banco e mostra no datagridview
                        ListModalidades();
                        ClearFrmModalities();
                    }
                    else
                    {
                        //Passa para o construtor as informações da modalidade, atualizando o que teve alteração. 
                        Modalidade.UpdateModalidade(Convert.ToInt32(txtCodModalidade.Text), Convert.ToInt32(cbCoachModalidade.SelectedValue), Convert.ToDecimal(txtMensalidadeModalidade.Text), txtNomeModalidade.Text);

                        MessageBox.Show("Modalidade alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Carrega as modalidades cadastradas no banco e mostra no datagridview
                        ListModalidades();
                        ClearFrmModalities();
                    }
     
                }                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);              
            }
        }

        //Método responsável por limpar as informações do formulário, após elas serem inseridas no banco de dados.
        private void ClearFrmModalities()
        {
            txtCodModalidade.Text = "0";
            txtMensalidadeModalidade.Clear();
            txtNomeModalidade.Clear();
            txtPesquisaModalidade.Clear();
            cbCoachModalidade.SelectedIndex = -1;

        }

        private void btnNovaModalidade_Click(object sender, EventArgs e)
        {
            ClearFrmModalities();
        }

        private void dtgModalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //A variável sender é responsável por informar o tipo do objeto que recebeu o clique. 
            //Enquanto a variável "e" obtem todas as propriedades do objeto clicado. 
            try
            {
                //Vamos verificar se o usuário clicou na coluna que possui o icone de "Editar"
                if (dtgModalidades.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                    MessageBox.Show("As informações a serem editadas estão na caixa: 'Informações da Modalidade'!", "Editar informações", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Carrega todas as informações dao DataGridView para os TextBoxes do formulário. 
                    txtCodModalidade.Text = dtgModalidades.Rows[e.RowIndex].Cells["idModalidade"].Value.ToString();
                    txtMensalidadeModalidade.Text = dtgModalidades.Rows[e.RowIndex].Cells["valorMensalidade"].Value.ToString();
                    txtNomeModalidade.Text = dtgModalidades.Rows[e.RowIndex].Cells["nomeModalidade"].Value.ToString();
                    cbCoachModalidade.Text = dtgModalidades.Rows[e.RowIndex].Cells["nomeCoach"].Value.ToString();

                }
                else if (dtgModalidades.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    MessageBox.Show("Deseja Realmente Excluir?", "Excluir Modalidade:", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    try
                    {
                        //Como o método para exclusão de Modalidades está na classe Modalidades, precisamos instanciá-la para acessarmos seus métodos. 
                        Modalidades Modalidade = new Modalidades();

                        //Acessando o método de Exclusão
                        Modalidade.DeleteModality(Convert.ToInt32(dtgModalidades.Rows[e.RowIndex].Cells["idModalidade"].Value));

                        //Mensagem de aviso que a exclusão aconteceu da forma correta. 
                        MessageBox.Show("A Modalidade foi excluída com sucesso!", "Exclusão realizada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
