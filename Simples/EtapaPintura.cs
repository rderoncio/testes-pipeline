using System;
using System.Text;
using Pipeline.Interface;

namespace Pipeline
{
    class EtapaPintura : IEtapa<StringBuilder>
    {
        public StringBuilder Processar(StringBuilder entrada)
        {
            string[] cores = { "BRANCO", "VERMELHO", "PRETO", "CINZA", "GRAFITE" };
            Random aleatorio = new Random();
            string corAleatorio = cores[aleatorio.Next(0, cores.Length)];

            entrada.Insert(0, $"[{corAleatorio}]", 1);
            entrada.Insert(entrada.Length, $"[{corAleatorio}]", 1);
            return entrada;
        }
    }
}