using _CadastroJson.Exceptions;
using _CadastroJson.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Documents;

namespace _CadastroJson.Repositories
{
    internal class PedidoStore
    {
        private ObservableCollection<PedidoModel> pedido = new ObservableCollection<PedidoModel>();

        private String FileName = @"pedido.json";
        public PedidoStore()
        {
            LoadJson();
        }

 
        private void LoadJson()
        {

            if (File.Exists(FileName))
            {
                pedido = JsonConvert.DeserializeObject<ObservableCollection<PedidoModel>>(File.ReadAllText(FileName));
            }
            else
            {
                Console.WriteLine("Arquivo não existe!");
            }
        }

        public ObservableCollection<PedidoModel> Items
        {
            get => pedido;

        }

        private int Index(int id)
        {
            int i;

            for (i = 0; i < Items.Count; i++)
            {
                if (Items[i].ID == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public void UpdateStatus(PedidoModel model)
        {
            int index = Index(model.ID);

            if (index == -1)
            {
                throw new DataBaseErrorCadastroJsonException("Erro ao tentar alterar o status, o registro não existe!");
            }
            Items[index].Status = model.Status;
            Commit();
        }

         

        public void Add(PedidoModel model)
        {
            List<ProdutoModel> produtos = new List<ProdutoModel>();

            decimal value = 0;
            foreach (var item in model.Produtos)
            {
                ProdutoModel produto = produtos.Find(x => x.ID == item.ID);
                if (produto == null)
                {
                    Console.WriteLine($"Produto ID {model.ID} não encontrado na tabela produtos");
                }
                value += produto.Valor * item.Qtd;
            }
            model.ValorTotal = value;
            pedido.Add(model);
            Commit();

        }

        public void Commit()
        {
            File.WriteAllText(FileName, JsonConvert.SerializeObject(pedido));

            using (StreamWriter file = File.CreateText(FileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, pedido);
            }
        }


    }
}
