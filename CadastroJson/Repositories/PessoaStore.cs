using _CadastroJson.Models;
using Newtonsoft.Json;
using static _CadastroJson.MainWindow;
using System.Windows;
using System.IO;
using System.Collections.ObjectModel;
using _CadastroJson.Exceptions;
using System;


namespace _CadastroJson.Repositories
{

     internal class PessoaStore
    {
        //private List<PessoaModel> pessoa = new List<PessoaModel>();
        private ObservableCollection<PessoaModel> pessoa = new ObservableCollection<PessoaModel>();
        private String FileName = @"pessoa.json";
            
        public PessoaStore()
        {
            LoadJson();
        }

        private void LoadJson()
        {

            if (File.Exists(FileName))
            {
                pessoa = JsonConvert.DeserializeObject<ObservableCollection<PessoaModel>>(File.ReadAllText(FileName));
            }
            else
            {
                Console.WriteLine("Arquivo não existe!");
            }
        }

        public ObservableCollection<PessoaModel> Items
        {
            get => pessoa;

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

        public void Update(PessoaModel model)
        {
            int index = Index(model.ID);

            if (index == -1)
            {
                throw new DataBaseErrorCadastroJsonException("Erro ao tentar salvar no arquivo, o registro não existe!");
            }

            Items[index].Nome = model.Nome;
            Items[index].Cpf = model.Cpf;
            Items[index].Endereco = model.Endereco;
            Commit();
        }

        public void Remove(PessoaModel model)
        {
            int index = Index(model.ID);
            if (index == -1)
            {
                throw new DataBaseErrorCadastroJsonException("Erro ao tentar salvar excluir, o registro não existe!");
            }

            Items.RemoveAt(index);
            Commit();

        }

        public void Add(PessoaModel model)
        {
            pessoa.Add(model);
            Commit();

        }

        public void Commit()
        {
            File.WriteAllText(FileName, JsonConvert.SerializeObject(pessoa));

            using (StreamWriter file = File.CreateText(FileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, pessoa);
            }
        }


    }
}


