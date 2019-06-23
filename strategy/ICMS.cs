using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoPadroes
{
    public class ICMS : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            decimal resultado = orcamento.Valor * 0.17m;

            return resultado;
        }
    }
}
