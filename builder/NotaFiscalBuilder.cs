using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoPadroes
{
    public class NotaFiscalBuilder
    {
        private string numero;
        private string cliente;
        private string fornecedor;

        public NotaFiscalBuilder ComNumero(string numero)
        {
            this.numero = numero;

            return this;
        }

        public NotaFiscalBuilder ComCliente(string cliente)
        {
            this.cliente = cliente;

            return this;
        }

        public NotaFiscalBuilder ComFornecedor(string fornecedor)
        {
            this.fornecedor = fornecedor;

            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(cliente, fornecedor, numero);
        }
    }
}
