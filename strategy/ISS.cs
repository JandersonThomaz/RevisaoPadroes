using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoPadroes
{
    public class ISS : IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            decimal resultado = orcamento.Valor * 0.12m;

            return resultado;
        }
    }
}
