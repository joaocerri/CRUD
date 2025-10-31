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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro formcadatro = new FormCadastro();
            formcadatro.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisar formpesquisar = new FormPesquisar();
            formpesquisar.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            FormExcluir formexcluir = new FormExcluir();
            formexcluir.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditar formeditar = new FormEditar();
            formeditar.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FormListar formelistar = new FormListar();
            formelistar.Show();
        }
    }
}
