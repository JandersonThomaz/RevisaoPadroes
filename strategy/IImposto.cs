using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoPadroes
{
    public interface IImposto
    {
        decimal Calcular(Orcamento orcamento);
    }
}
