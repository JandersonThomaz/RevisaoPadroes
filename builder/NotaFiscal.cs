using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoPadroes
{
    public class NotaFiscal
    {
        public NotaFiscal(string cliente, string fornecedor, string numero)
        {
            Cliente = cliente;
            Fornecedor = fornecedor;
            Numero = numero;
        }
        public string Numero { get; set; }
        public string Fornecedor { get; set; }
        public string Cliente { get; set; }
    }
}
