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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtCPF.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormCadastro.ActiveForm.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome =txtNome.Text;
            pessoa.Idade = int.Parse(txtIdade.Text);
            pessoa.Cpf = txtCPF.Text;
            Cadastro.CadastrarPessoa(pessoa);

            MessageBox.Show("Cadastro realizado com sucesso!");

            txtNome.Clear();
            txtIdade.Clear();
            txtCPF.Clear();
        }
        }
}
