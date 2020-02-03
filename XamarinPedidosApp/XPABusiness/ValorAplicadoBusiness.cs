using System;
using XPABusiness.Interfaces;

namespace XPABusiness
{
    public class ValorAplicadoBusiness
    {
        public decimal valor { get; private set; }

        public ValorAplicadoBusiness(decimal valor)
        {
            this.valor = valor;
        }
        //Calcula desconto e retorna o valor cheio com base na quantidade
        public decimal AplicaValor(IDesconto desconto, int quantidade )
        {
            return desconto.Calcula(this, quantidade) * quantidade;
        }
    }
}
