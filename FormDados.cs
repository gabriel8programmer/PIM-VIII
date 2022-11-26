using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_CRUD
{
    public partial class FormDados : Form
    {
        public FormDados()
        {
            InitializeComponent();
        }

        private void FormDados_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*CHAMAR O FORM QUE REALIZA PESQUISAS*/
            FormPesquisa pesquisa = new FormPesquisa();
            pesquisa.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void mtxtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pesquisarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormPesquisa formPesquisa = new FormPesquisa();
            formPesquisa.Show();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
