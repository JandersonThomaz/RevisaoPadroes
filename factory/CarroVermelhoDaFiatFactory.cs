using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoPadroes
{
    public class CarroVermelhoDaFiatFactory
    {
        public Carro Criar()
        {
            Carro carro = new Carro();

            carro.Farol = "Led";
            carro.Marca = "Fiat";
            carro.Modelo = "Attractive";
            carro.Rodas = "Liga leve aro 18";
            carro.Cor = "Vermelho";

            return carro;
        }
        
    }
}
