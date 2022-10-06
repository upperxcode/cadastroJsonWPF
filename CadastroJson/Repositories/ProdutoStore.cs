using _CadastroJson.Exceptions;
using _CadastroJson.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _CadastroJson.Repositories
{
    internal class ProdutoStore
    {
        
        private ObservableCollection<ProdutoModel> produto = new ObservableCollection<ProdutoModel>();
        private String FileName = @"produto.json";

        public ProdutoStore()
        {
            LoadJson();
        }

        private void LoadJson()
        {

            if (File.Exists(FileName))
            {
                produto = JsonConvert.DeserializeObject<ObservableCollection<ProdutoModel>>(File.ReadAllText(FileName));
            }
            else
            {
                Console.WriteLine("Arquivo não existe!");
            }
        }

        public ObservableCollection<ProdutoModel> Items
        {
            get => produto;

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

        public void Update(ProdutoModel model)
        {
            int index = Index(model.ID);

            if (index == -1)
            {
                throw new DataBaseErrorCadastroJsonException("Erro ao tentar salvar no arquivo, o registro não existe!");
            }

            Items[index].Nome = model.Nome;
            Items[index].Codigo = model.Codigo;
            Items[index].Valor = model.Valor;
            Commit();
        }

        public void Remove(ProdutoModel model)
        {
            int index = Index(model.ID);
            if (index == -1)
            {
                throw new DataBaseErrorCadastroJsonException("Erro ao tentar salvar excluir, o registro não existe!");
            }

            Items.RemoveAt(index);
            Commit();

        }

        public void Add(ProdutoModel model)
        {
            produto.Add(model);
            Commit();

        }

        public void Commit()
        {
            File.WriteAllText(FileName, JsonConvert.SerializeObject(produto));

            using (StreamWriter file = File.CreateText(FileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, produto);
            }
        }

    }
}
