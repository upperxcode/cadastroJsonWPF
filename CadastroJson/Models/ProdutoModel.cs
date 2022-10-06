using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _CadastroJson.Models
{
    internal class ProdutoModel
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public String Codigo { get; set; }
        public decimal Valor { get; set; }

        public ProdutoModel(int iD, string nome, string codigo, decimal valor)
        {
            ID = iD;
            Nome = nome;
            Codigo = codigo;
            Valor = valor;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
