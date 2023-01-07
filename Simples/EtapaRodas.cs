using System.Text;
using Pipeline.Interface;

namespace Pipeline
{
    class EtapaRodas : IEtapa<StringBuilder>
    {
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Insert(0, "[RODA]", 2);
            entrada.Insert(entrada.Length, "[RODA]", 2);
            return entrada;
        }
    }
}