using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CadastroPessoas.WPF
{
    /// <summary>
    /// Lógica interna para CadastrarPessoa.xaml
    /// </summary>
    public partial class CadastrarPessoa : Window
    {
        public CadastrarPessoa()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IRepositorio<Pessoa> repositorioPessoa = new PessoaRepositorio();
            Pessoa pessoa = new Pessoa
            {
                nome = txbNome.Text,
                idade = Convert.ToInt32(txbIdade.Text),
                endereco = txbEndereco.Text
            };

            repositorioPessoa.Adicionar(pessoa);
            Close();
        }
    }
}
