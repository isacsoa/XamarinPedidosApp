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

        public decimal AplicaValor(IDesconto desconto, int quantidade )
        {
            return desconto.Calcula(this, quantidade);
        }
    }
}
