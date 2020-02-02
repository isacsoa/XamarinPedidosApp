using System;
using System.Collections.Generic;
using System.Text;
using XPABusiness.Interfaces;

namespace XPABusiness.Descontos
{
    public class LavaRoupas : IDesconto
    {
        public decimal Calcula(ValorAplicadoBusiness valorAplicado, int quantidade)
        {
            if (valorAplicado.valor > 10 && valorAplicado.valor < 20)
                return valorAplicado.valor - (valorAplicado.valor * (decimal)0.1);
            else if (valorAplicado.valor > 20 && valorAplicado.valor < 30)
                return valorAplicado.valor - (valorAplicado.valor * (decimal)0.2);
            else if (valorAplicado.valor > 30)
                return valorAplicado.valor - (valorAplicado.valor * (decimal)0.3);

            else
                return valorAplicado.valor;

        }
    }
}
