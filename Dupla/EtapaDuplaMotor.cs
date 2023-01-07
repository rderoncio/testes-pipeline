using System.Text;
using Pipeline.Interface;

namespace Pipeline.Dupla
{
    class EtapaDuplaMotor : IEtapaDupla<StringBuilder>
    {
        public IEtapaDupla<StringBuilder> ProximaEtapa { get; set; }

        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Append("[MOTOR]");

            entrada = ProximaEtapa?.Processar(entrada) ?? entrada;

            return entrada;
        }
    }
}