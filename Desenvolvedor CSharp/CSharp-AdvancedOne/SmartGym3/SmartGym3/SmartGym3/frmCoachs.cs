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
    public partial class frmCoachs : Form
    {
        public frmCoachs()
        {
            InitializeComponent();
        }

        private void btnSaveCoach_Click(object sender, EventArgs e)
        {
            //Evento do botão SaveCoach que grava as informações no banco de dados, atráves do método SaveNewCoach da classe PersonalTrainer. 
            try
            {
                PersonalTrainer PersonalTrainer = new PersonalTrainer();
                if (txtCodigo.Text == "0")
                {
                    MessageBox.Show("Você vai cadastrar um novo Coach!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PersonalTrainer.SaveNewCoach(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, txtTelefone.Text, txtCPF.Text, Convert.ToDecimal(txtSalario.Text), txtObservacoes.Text);

                    MessageBox.Show("Coach cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você vai atualizar as informações de um Coach!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PersonalTrainer.UpdateCoachInformations(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, txtCPF.Text, txtTelefone.Text, Convert.ToDecimal(txtSalario.Text),  txtObservacoes.Text);
                    MessageBox.Show("Informações do Coach alteradas com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                listCoachesFrmCoaches();
                ClearFrmCoaches();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Método para trazer todos os registros que o ListCoachs armazenou em um DataTable e mostrá-los no DataGridView.    
        private void listCoachesFrmCoaches()
        {
            try
            {
                PersonalTrainer PersonalTrainer = new PersonalTrainer();
                //Os dados serão listados dentro do DataGridView que está no frmCoaches
               dgvPersonalTrainer.DataSource = PersonalTrainer.ListCoaches();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFrmCoaches()
        {
            //Limpa os campos do formulário frmCoaches
            txtNome.Clear(); 
            txtEndereco.Clear(); 
            txtBairro.Clear(); 
            txtCidade.Clear(); 
            txtTelefone.Clear(); 
            txtCep.Clear(); 
            txtCPF.Clear(); 
            txtSalario.Clear();
            txtObservacoes.Clear();
        }

        private void frmCoachs_Load(object sender, EventArgs e)
        {
            //Quando o formulário for carregado, os registros dos coaches serão exibidos no DataGridView do frmCoaches
            listCoachesFrmCoaches();    

        }

        private void dgvPersonalTrainer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //A variável Sender é responsável por informar o tipo do componente que recebeu o clique
            //Enquanto a variável "e" obtem todas as propriedades do objeto clicado

            //Verifica se o usuário clicou na coluna "btnEditar", que contém o botão com icone de edição
            if (dgvPersonalTrainer.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                //Carrega todas as informações do Personal Trainer, que foram escolhidas para serem editadas. 
                //Vamos atribuir aos textboxs o conteúdo de cada coluna da tabela, de acordo com a linha que o usuário clicar.
                txtCodigo.Text = dgvPersonalTrainer.Rows[e.RowIndex].Cells["dgvColumIdPersonalTrainer"].Value.ToString();
                txtCPF.Text = dgvPersonalTrainer.Rows[e.RowIndex].Cells["dgvColumCPFPersonalTrainer"].Value.ToString();
                txtTelefone.Text = dgvPersonalTrainer.Rows[e.RowIndex].Cells["dgvColumPhonePersonalTrainer"].Value.ToString();
                txtCep.Text = dgvPersonalTrainer.Rows[e.RowIndex].Cells["dgvColumCEPPersonalTrainer"].Value.ToString();
                txtNome.Text = dgvPersonalTrainer.Rows[e.RowIndex].Cells["dgvColumNamePersonalTrainer"].Value.ToString();
                txtEndereco.Text = dgvPersonalTrainer.Rows[e.RowIndex].Cells["dgvColumAddressPersonalTrainer"].Value.ToString();
                txtBairro.Text = dgvPersonalTrainer.Rows[e.RowIndex].Cells["dgvColumDistrictPersonalTrainer"].Value.ToString();
                txtSalario.Text = dgvPersonalTrainer.Rows[e.RowIndex].Cells["dgvColumSalaryPersonalTrainer"].Value.ToString();
                txtCidade.Text = dgvPersonalTrainer.Rows[e.RowIndex].Cells["dgvColumCityPersonalTrainer"].Value.ToString();
                txtObservacoes.Text = dgvPersonalTrainer.Rows[e.RowIndex].Cells["dgvColumCommentsPersonalTrainer"].Value.ToString();
            }
        }

        private void btnNewCoach_Click(object sender, EventArgs e)
        {
            ClearFrmCoaches();
        }
    }
}
