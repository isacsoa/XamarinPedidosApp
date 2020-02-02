using System;
using System.Collections.Generic;
using System.Text;
using XPABusiness.Interfaces;

namespace XPABusiness.Descontos
{
    public class Celulares : IDesconto
    {
        public decimal Calcula(ValorAplicadoBusiness valorAplicado, int quantidade)
        {
            if (valorAplicado.valor >= 1)
                return valorAplicado.valor - (valorAplicado.valor * (decimal)0.1);
            else
                return valorAplicado.valor;
        }
    }
}
