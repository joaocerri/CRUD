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
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Itens na lista agora: {Cadastro.listaPessoas.Count.ToString()}");
            this.cadastroBindingSource.DataSource = Cadastro.listaPessoas;
        }

    }
}
