using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoas
{
    public partial class FrmPessoas : Form
    {

        private List<Pessoa> _pessoas = new List<Pessoa>();
        private static readonly object locker = new Object();

        public FrmPessoas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Thread
            Thread thread = new Thread(PreencherDataGridView);
            thread.Start();
            */

            // Sem thread
            // PreencherDataGridView

            Task minhaTask = Task.Run(() =>
            {
                IRepositorio<Pessoa> repositorioPessoas = new PessoaRepositorio();
                _pessoas = repositorioPessoas.SelecionarTodos();
            });

            var awaiter = minhaTask.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                dgvPessoas.DataSource = _pessoas;
                dgvPessoas.Refresh();
            });

        }

        private void PreencherDataGridView()
        {

            Thread thread = new Thread(PreencherListaPessoas);
            Thread thread2 = new Thread(PreencherListaPessoas2);
            thread2.Start();
            thread.Start();
            // Espera a thread anterior terminar a execução para continuar
            thread.Join();
            thread2.Join();

            dgvPessoas.Invoke((MethodInvoker)delegate { dgvPessoas.DataSource = _pessoas; dgvPessoas.Refresh(); });

            // Sem thread
            //dgvPessoas.DataSource = pessoas;
            //dgvPessoas.Refresh();

        }

        private void PreencherListaPessoas()
        {
            lock (locker)
            {
                IRepositorio<Pessoa> repositorioPessoas = new PessoaRepositorio();
                List<Pessoa> pessoas = repositorioPessoas.SelecionarTodos();
                foreach (Pessoa p in pessoas)
                {
                    p.nome += " T1";
                    _pessoas.Add(p);
                }
            }
        }

        private void PreencherListaPessoas2()
        {
            try
            {
                //teste tratamento de erro
                //throw new Exception("Teste erro!");
                lock (locker)
                {
                    IRepositorio<Pessoa> repositorioPessoas = new PessoaRepositorio();
                    List<Pessoa> pessoas = repositorioPessoas.SelecionarTodos();
                    foreach (Pessoa p in pessoas)
                    {
                        p.nome += " T2";
                        _pessoas.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdicionarPessoa_Click(object sender, EventArgs e)
        {
            FrmAdicionarPessoa TelaCadastroPessoas = new FrmAdicionarPessoa();
            TelaCadastroPessoas.ShowDialog();
            PreencherDataGridView();
        }
    }
}
