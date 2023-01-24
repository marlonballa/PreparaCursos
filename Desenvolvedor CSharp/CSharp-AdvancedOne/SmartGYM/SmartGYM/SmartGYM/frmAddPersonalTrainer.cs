using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGYM
{
    public partial class frmAddPersonalTrainer : Form
    {
        public frmAddPersonalTrainer()
        {
            InitializeComponent();
        }

        private void btnSaveAddPersonalTrainer_Click(object sender, EventArgs e)
        {
            //Evento do botão salvar que grava as informações através do método "AddPersonalTrainer", criado na classe Personal Trainer. 
            try
            {
                //Instanciando a classe "Personal Trainer" para que seja possível criar um novo objeto deste tipo. 
                PersonalTrainer newPersonalTrainer = new PersonalTrainer();
                //Acessa o método que adiciona um novo personal trainer a base de dados. 
                newPersonalTrainer.AddPersonalTrainer(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, txtCpf.Text, Convert.ToDecimal(txtSalario.Value), txtTelefone.Text, txtObservacao.Text);

                MessageBox.Show("Personal Trainer adicionado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Aconteceu um erro inesperado!", error.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
