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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CadastroPessoas.WPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CarregarDataGrid()
        {
            IRepositorio<Pessoa> repositorioPessoas = new PessoaRepositorio();
            List<Pessoa> listaPessoas = repositorioPessoas.SelecionarTodos();
            dgrPessoas.ItemsSource = listaPessoas;
        }

        private void WindowMain_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarDataGrid();
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            CadastrarPessoa cadastrarPessoa = new CadastrarPessoa();
            cadastrarPessoa.ShowDialog();
            CarregarDataGrid();
        }
    }
}
