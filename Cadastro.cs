using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    internal class Cadastro
    {
        public static BindingList<Pessoa> listaPessoas = new BindingList<Pessoa>();
        
        public static void CadastrarPessoa(Pessoa newpessoa)
        {
            if (newpessoa != null)
            {
               listaPessoas.Add(newpessoa);
            }
        }

        public static Pessoa PesquisarCPF(string cpf) 
        {
            foreach (Pessoa pessoa in listaPessoas)
            {
                if (pessoa.Cpf == cpf)
                {
                    return pessoa;
                }
            }
            return null;
        }
         public static bool RemoverPessoa(string cpf)
         {
            foreach (Pessoa pessoa in listaPessoas)
            {
                if (pessoa.Cpf == cpf)
                {
                    listaPessoas.Remove(pessoa);
                    return true;
                }
            }
            return false;
        }

        public static void EditarPessoa(Pessoa currentpessoa, Pessoa newpessoa)
        {
            if (newpessoa != null)
            {
                currentpessoa.Nome = newpessoa.Nome;
                currentpessoa.Idade = newpessoa.Idade;
                currentpessoa.Cpf = newpessoa.Cpf;

                MessageBox.Show("Cadastro editado com sucesso!");
            }
            else
                MessageBox.Show("Erro ao editar o cadastro!");
        }
    }
}
