using System;

namespace RevisaoPadroes
{
    class Program
    {
        static void Main(string[] args)
        {
            //builder
            NotaFiscal notaFiscal =
                new NotaFiscalBuilder()
                .ComNumero("123")
                .ComFornecedor("Hoader")
                .ComCliente("Giovanna")
                .Constroi();



            // strategy
            Orcamento orcamentoDeFestaJunina = new Orcamento();

            orcamentoDeFestaJunina.Valor = 2000;

            CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();

            decimal valorDoImposto = calculadorDeImpostos.Calcular(orcamentoDeFestaJunina, new IPI());

            


            //factory

            Carro palio = new CarroVermelhoDaFiatFactory().Criar();

            Console.WriteLine(palio.Cor);

            Console.ReadKey();



        }
    }
}
