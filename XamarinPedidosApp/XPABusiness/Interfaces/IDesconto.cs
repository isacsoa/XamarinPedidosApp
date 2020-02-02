using System;
using System.Collections.Generic;
using System.Text;

namespace XPABusiness.Interfaces
{
    public interface IDesconto
    {
        decimal Calcula(ValorAplicadoBusiness valorAplicado, int quantidade);
    }
}
