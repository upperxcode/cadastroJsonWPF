using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace _CadastroJson.Models
{
    internal class PedidoPessoaModel
    {
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public String FormaPagamento { get; set; }
        public String Status { get; set; }

        public PedidoPessoaModel(DateTime dataVenda, decimal valorTotal, String formaPagamento, String status)
        {
            DataVenda = dataVenda;
            ValorTotal = valorTotal;
            FormaPagamento = formaPagamento;
            Status = status;

        }
        

    }
}

 