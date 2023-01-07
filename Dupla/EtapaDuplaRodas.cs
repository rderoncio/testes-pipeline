using System.Text;
using Pipeline.Interface;

namespace Pipeline.Dupla
{
    class EtapaDuplaRodas : IEtapaDupla<StringBuilder>
    {
        public IEtapaDupla<StringBuilder> ProximaEtapa { get; set; }
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Insert(0, "[RODA]", 2);
            entrada.Insert(entrada.Length, "[RODA]", 2);

            entrada = ProximaEtapa?.Processar(entrada) ?? entrada;

            return entrada;
        }
    }
}