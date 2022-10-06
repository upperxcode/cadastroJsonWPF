using _CadastroJson.Models;
using _CadastroJson.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace _CadastroJson
{
    enum DataState
    {
        Update,
        Insert,
        None
    }

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            State = DataState.None;
        }

        private DataState State { get; set; }
        private PessoaStore pessoa = new PessoaStore();
        private PedidoStore pedido = new PedidoStore();
        List<PedidoPessoaModel> PedidoPessoa = new List<PedidoPessoaModel>();


        private string _TextSearch;
        public string TextSearch
        {
            get { return _TextSearch; }
            set
            {
                _TextSearch = value;
                OnPropertyChanged("TextSearch");
                PessoaGrid.Items.Refresh();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


        private int GenerateId()
        {
            Guid guid = Guid.NewGuid();
            Random random = new Random();
            return random.Next();
        }
        private void ClearFields()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
        }

        private void BtnInsert(object sender, RoutedEventArgs e)
        {
            ClearFields();
            txtNome.Focus();
            State = DataState.Insert;

        }

         private void BtnRemove(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Confirmar a exclusão do registro?", "Exclusão de reigstro", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.No)
            { 
                return;
            }
            PessoaModel row = PessoaGrid.CurrentItem as PessoaModel;
            try
            {
                pessoa.Remove(row);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnUpdate(object sender, RoutedEventArgs e)
        {
            PessoaModel row = PessoaGrid.CurrentItem as PessoaModel;
            try
            {
                txtId.Text = row.ID.ToString();
                txtNome.Text = row.Nome;
                txtCpf.Text = row.Cpf;
                txtEndereco.Text = row.Endereco;
                txtNome.Focus();
                State = DataState.Update;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            PessoaGrid.ItemsSource = pessoa.Items;
            
        }

        private void LoadPedido()
        {
            PedidoGrid.ItemsSource = null;

            PessoaModel row = PessoaGrid.CurrentItem as PessoaModel;
            if (row == null)
            {
                Console.WriteLine("Nenhuma linha selecionada!");
                return;
            }
            PedidoPessoa.Clear();

            var _pedidos = pedido.Items.Where(v => v.PessoaId == row.ID);
            foreach (var item in _pedidos)
            {
                PedidoPessoa.Add(new PedidoPessoaModel(item.DataVenda, 
                                                       item.ValorTotal, 
                                                       item.FormaPagamento, 
                                                       item.Status) );
            }
            PedidoGrid.ItemsSource = PedidoPessoa; 
    }

        private void UpdateStatusPedido(object sender, RoutedEventArgs e)
        {
            PedidoPessoaModel row = PedidoGrid.CurrentItem as PedidoPessoaModel;

            if (row == null || !(sender is System.Windows.Controls.Primitives.ButtonBase))
            {
                Console.WriteLine("Nenhuma linha selecionada!");
                return;
            }

            String nameButtton = (sender as System.Windows.Controls.Primitives.ButtonBase).Name;

            if (nameButtton == "btnPago")
            {
                (PedidoGrid.CurrentItem as PedidoPessoaModel).Status = Utils.Status2String(PedidoStatus.Pago);
            } else if (nameButtton == "btnEnviado")
            {
                (PedidoGrid.CurrentItem as PedidoPessoaModel).Status = Utils.Status2String(PedidoStatus.Enviado);
            }
            if (nameButtton == "btnRecebido")
            {
                (PedidoGrid.CurrentItem as PedidoPessoaModel).Status = Utils.Status2String(PedidoStatus.Recebido);
            }

            PedidoGrid.Items.Refresh();
  
        }
        private void BtnSave(object sender, RoutedEventArgs e)
        {

            if (State == DataState.None)
            {
                return;
            }
            Models.PessoaModel p1 = new Models.PessoaModel(State == DataState.Insert ? GenerateId() : int.Parse(txtId.Text), txtNome.Text, txtCpf.Text, txtEndereco.Text);

            if (State == DataState.Insert)
            {
                pessoa.Add(p1);
            }
            else
            {
                pessoa.Update(p1);
            }

            PessoaGrid.Items.Refresh();

        }

        private void FilterName(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(TextSearch))
            {
                return;
            }
            // var i =  (item as PessoaModel).Nome.IndexOf(TextSearch, StringComparison.OrdinalIgnoreCase) >= 0);
        }

       // private void BtnRemove(object sender, RoutedEventArgs e)
       // {
       //     State = DataState.None;
       // }

        private void ShowPedido(object sender, RoutedEventArgs e)
        {
            var window = new PedidoWindow
            {
                Owner = this
            };
            window.ShowDialog();

        }


        private void PessoaGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            LoadPedido();

        }

        private bool FilterAnalysis(String nome, String cpf)
        {
            String filter = txtFilterNome.Text.ToLower();
            bool filteredNome = string.IsNullOrEmpty(filter) || (nome.ToLower().Contains(filter) ? true : false);
            filter = txtFilterCpf.Text.ToLower();
            bool filteredCpf = string.IsNullOrEmpty(filter) || (cpf.ToLower().Contains(filter) ? true : false);

            return (filteredNome && filteredCpf);
        }
        private void BntFilter_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtFilterNome.Text) && String.IsNullOrEmpty(txtFilterCpf.Text))
            {
                WindowLoaded(sender, e);
                return;

            }

            var ListFilted = pessoa.Items.Where(vl => FilterAnalysis(vl.Nome, vl.Cpf));

            PessoaGrid.ItemsSource = ListFilted;
            PessoaGrid.Items.Refresh();

        }
    }
}

