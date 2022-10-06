using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CadastroJson.Models
{
    internal class ProdutoPedidoModel
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public int Qtd { get; set; }
        public ProdutoPedidoModel(int id, string nome, int qtd)
        {
            ID = id;
            Nome = nome;
            Qtd = qtd;
        }   
    }
}
