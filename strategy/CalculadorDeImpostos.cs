using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoPadroes
{
    public class CalculadorDeImpostos
    {
        public decimal Calcular(Orcamento orcamento, IImposto imposto)
        {
            decimal resultado = imposto.Calcular(orcamento);

            return resultado;
        }
    }
}
