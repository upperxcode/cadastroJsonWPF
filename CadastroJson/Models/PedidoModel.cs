using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CadastroJson.Models
{


    class ItensProduto
    {
        public int ID { get; }
        public int Qtd { get; set; }
        public ItensProduto(int id, int qtd)
        {
            ID = id;
            Qtd = qtd;
        }
    }
    internal class PedidoModel
    {
        public int ID { get; }
        public int PessoaId { get; set; }
        public List<ItensProduto> Produtos { get; set; }
        public decimal ValorTotal { get; set;}
        public String FormaPagamento { get; private set; }
        public String Status { get; set; }
        public DateTime DataVenda { get; set; }
        public PedidoModel(int iD, int pessoaId, PedidoFormaPagamento formaPagamento)
        {
            ID = iD;
            PessoaId = pessoaId;
            Produtos = new List<ItensProduto>();
            FormaPagamento = Utils.FormaPagamento2String(formaPagamento);
            ValorTotal = 0;
            DataVenda = DateTime.Now;
            Status = Utils.Status2String(PedidoStatus.Pendente);
        }


    }
}
