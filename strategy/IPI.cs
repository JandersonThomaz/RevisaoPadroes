using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoPadroes
{
    public class IPI: IImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            decimal resultado = orcamento.Valor * 0.08m;

            return resultado;
        }
    }
}
