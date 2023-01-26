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
                PersonalTrainer.SaveNewCoach(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, txtTelefone.Text, txtCPF.Text, Convert.ToDecimal(txtSalario.Text), txtObservacoes.Text);

                MessageBox.Show("Coach cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void frmCoachs_Load(object sender, EventArgs e)
        {
            //Quando o formulário for carregado, os registros dos coaches serão exibidos no DataGridView do frmCoaches
            listCoachesFrmCoaches();    

        }
    }
}
