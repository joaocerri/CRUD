using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class FormPesquisar : Form
    {
        public FormPesquisar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormPesquisar.ActiveForm.Close();

        }

       

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pessoa pessoaBuscada = Cadastro.PesquisarCPF(txtPesquisa.Text);
            txtNome.Text = pessoaBuscada != null ? pessoaBuscada.Nome : "Não encontrado";
            txtIdade.Text = pessoaBuscada != null ? $"{pessoaBuscada.Idade}" : "Não encontrado";
            txtCPF.Text = pessoaBuscada != null ? pessoaBuscada.Cpf : "Não encontrado";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            txtNome.Clear();
            txtIdade.Clear();
            txtCPF.Clear();
        }
    }
}
