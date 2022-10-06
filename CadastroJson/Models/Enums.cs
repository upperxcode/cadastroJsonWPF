
using System;

namespace _CadastroJson.Models
{

    public enum PedidoStatus
    {
        Pendente,
        Pago,
        Enviado,
        Recebido
    }
    public enum PedidoFormaPagamento
    {
        Dinheiro,
        Cartao,
        Boleto
    }

    public class Utils
    {
        static public String Status2String(PedidoStatus status)
        {
            return Enum.GetName(typeof(PedidoStatus), status);
        }

        static public String FormaPagamento2String(PedidoFormaPagamento formaPagamento)
        {
            return Enum.GetName(typeof(PedidoFormaPagamento), formaPagamento);
        }
    }


}