using System;
using System.Collections.Generic;
using System.Text;
using XPABusiness.Interfaces;

namespace XPABusiness.Descontos
{
    public class CameraFotografica : IDesconto
    {
        public decimal Calcula(ValorAplicadoBusiness valorAplicado, int quantidade)
        {
            if (quantidade == 2)
                return valorAplicado.valor - (valorAplicado.valor * (decimal)0.1);
            else if (quantidade > 2)
                return valorAplicado.valor - (valorAplicado.valor * (decimal)0.15);
            else
                return valorAplicado.valor;
        }
    }
}
