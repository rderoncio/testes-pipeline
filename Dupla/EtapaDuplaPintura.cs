using System;
using System.Text;
using Pipeline.Interface;

namespace Pipeline.Dupla
{
    class EtapaDuplaPintura : IEtapaDupla<StringBuilder>
    {
        public IEtapaDupla<StringBuilder> ProximaEtapa { get; set; }

        public StringBuilder Processar(StringBuilder entrada)
        {
            string[] cores = { "BRANCO", "VERMELHO", "PRETO", "CINZA", "GRAFITE" };
            Random aleatorio = new Random();
            string corAleatorio = cores[aleatorio.Next(0, cores.Length)];

            entrada.Insert(0, $"[{corAleatorio}]", 1);
            entrada.Insert(entrada.Length, $"[{corAleatorio}]", 1);

            entrada = ProximaEtapa?.Processar(entrada) ?? entrada;

            return entrada;
        }
    }
}