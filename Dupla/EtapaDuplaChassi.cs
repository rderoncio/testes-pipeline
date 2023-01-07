using System.Text;
using Pipeline.Interface;

namespace Pipeline.Dupla
{
    class EtapaDuplaChassi : IEtapaDupla<StringBuilder>
    {
        public IEtapaDupla<StringBuilder> ProximaEtapa { get; set; }

        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Append("[CHASSI]");

            entrada = ProximaEtapa?.Processar(entrada) ?? entrada;

            return entrada;
        }
    }
}