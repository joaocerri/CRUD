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
    public partial class FormEditar : Form
    {
        public FormEditar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pessoa pessoaBuscada = Cadastro.PesquisarCPF(txtPesquisa.Text);
            txtNome.Text = pessoaBuscada != null ? pessoaBuscada.Nome : "Não encontrado";
            txtIdade.Text = pessoaBuscada != null ? $"{pessoaBuscada.Idade}" : "Não encontrado";
            txtCPF.Text = pessoaBuscada != null ? pessoaBuscada.Cpf : "Não encontrado";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Pessoa dadosatuais = Cadastro.PesquisarCPF(txtPesquisa.Text);
            Pessoa novosdados = new Pessoa();
            novosdados.Nome = txtNome.Text;
            novosdados.Idade = int.Parse(txtIdade.Text);
            novosdados.Cpf = txtCPF.Text;

            Cadastro.EditarPessoa(dadosatuais, novosdados);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtCPF.Clear();
        }
    }
}
