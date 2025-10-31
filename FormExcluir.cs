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
    public partial class FormExcluir : Form
    {
        public FormExcluir()
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool Excluir = Cadastro.RemoverPessoa(txtPesquisa.Text);

            if (Excluir)
            {
                MessageBox.Show("Cadastro excluído com sucesso!");
                txtNome.Clear();
                txtIdade.Clear();
                txtCPF.Clear();
                txtPesquisa.Clear();
            }
            else
            {
                MessageBox.Show("CPF não encontrado. Exclusão não realizada.");
            }
        }
    }
}
