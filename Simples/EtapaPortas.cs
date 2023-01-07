using System.Text;
using Pipeline.Interface;

namespace Pipeline
{
    class EtapaPortas : IEtapa<StringBuilder>
    {
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Insert(0, "[PORTA]", 2);
            entrada.Insert(entrada.Length, "[PORTA]", 2);
            return entrada;
        }
    }
}