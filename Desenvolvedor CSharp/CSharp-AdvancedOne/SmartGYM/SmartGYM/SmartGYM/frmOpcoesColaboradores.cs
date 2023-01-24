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
    public partial class frmOpcoesColaboradores : Form
    {
        public frmOpcoesColaboradores()
        {
            InitializeComponent();
        }

        private void btnAddNewContributor_MouseEnter(object sender, EventArgs e)
        {
            btnAddNewContributor.BackColor = Color.FromArgb(4, 212, 96);
            pbAddNewContributor.Load("../../images/addNewIcon-White.png"); 
        }

        private void btnAddNewContributor_MouseLeave(object sender, EventArgs e)
        {
            btnAddNewContributor.BackColor = Color.FromArgb(70, 77, 83);
            pbAddNewContributor.Load("../../images/addNewIcon.png");
        }

        private void btnClosedThisScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            btnSearchContributor.BackColor = Color.FromArgb(4, 212, 96);
            pbSearchContributor.Load("../../images/searchIcon-White.png");
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            btnTimetableContributor.BackColor = Color.FromArgb(4, 212, 96);
            pbTimetableContributor.Load("../../images/timetableIcon-White.png");
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            btnEmployeeCosts.BackColor = Color.FromArgb(4, 212, 96);
            pbEmployeeCostsContributor.Load("../../images/iconTicketMedio-White.png");

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            btnSearchContributor.BackColor = Color.FromArgb(70, 77, 83);
            pbSearchContributor.Load("../../images/searchIcon.png");
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            btnTimetableContributor.BackColor = Color.FromArgb(70, 77, 83);
            pbTimetableContributor.Load("../../images/timetableIcon.png");
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            btnEmployeeCosts.BackColor = Color.FromArgb(70, 77, 83);
            pbEmployeeCostsContributor.Load("../../images/iconTicketMedio.png");
        }

        private void btnAddNewContributor_Click(object sender, EventArgs e)
        {
            frmAddPersonalTrainer frmAddPersonalTrainer = new frmAddPersonalTrainer();
            frmAddPersonalTrainer.ShowDialog();
        }
    }
}
