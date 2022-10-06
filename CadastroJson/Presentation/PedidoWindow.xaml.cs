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
using System.Windows.Input;
using _CadastroJson.Presentation.Components;
using System.Windows.Data;
using System.Xml.Linq;
using static _CadastroJson.PedidoWindow;
using System.Text.RegularExpressions;

namespace _CadastroJson
{
    public partial class PedidoWindow : Window
    {


        private ProdutoStore Produtos = new ProdutoStore();
        private ObservableCollection<ProdutoPedidoModel> ProdutosPedido = new ObservableCollection<ProdutoPedidoModel>();

        public PedidoWindow()
        {
            InitializeComponent();
            cbProdutos.IsEditable = true;
            cbProdutos.IsTextSearchEnabled = false;
            cbProdutos.ItemsSource = Produtos.Items;

            ProdutoGrid.ItemsSource = ProdutosPedido;
        }

        private void Cb_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Cb_OnPreviewTextInput.IsDropDownOpen = true;
        }

        public ObservableCollection<string> ItemList { get; set; }

        private void BtnSave(object sender, RoutedEventArgs e) { }
        private void WindowLoaded(object sender, RoutedEventArgs e) { }
        private void BtnUpdate(object sender, RoutedEventArgs e) { }
        private void BtnRemove(object sender, RoutedEventArgs e) { }
        private void BtnInsert(object sender, RoutedEventArgs e) { }
        private void BntFilter_Click(object sender, RoutedEventArgs e) { }
        private void PedidoGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) { }

        private void RemoveProduto(object sender, RoutedEventArgs e)
        {
            ProdutoPedidoModel row = ProdutoGrid.CurrentItem as ProdutoPedidoModel;

            if (row == null)
            {
                return;
            }
            
            for(int i=0;i<ProdutosPedido.Count;i++)
            {
                if (ProdutosPedido[i].ID == row.ID)
                {
                    ProdutosPedido.RemoveAt(i);
                }
            }
        }
        
        private void AddProduto(object sender, RoutedEventArgs e)
        {

            var item = (ProdutoModel)CollectionViewSource.GetDefaultView(Produtos.Items).CurrentItem;

            try
            {
                int qtd = int.Parse(txtQtd.Text);
                ProdutosPedido.Add(new ProdutoPedidoModel(item.ID, item.Nome, qtd));
                Console.WriteLine($"items {(item as ProdutoModel).Codigo}");
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }



    }
}