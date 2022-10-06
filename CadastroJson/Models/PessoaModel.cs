using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CadastroJson.Models
{
    internal class PessoaModel
    {
        public int ID { get; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Endereco { get; set; }
        public PessoaModel(int iD, string nome, string cpf, string endereco)
        {
            ID = iD;
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }   
    }
}
