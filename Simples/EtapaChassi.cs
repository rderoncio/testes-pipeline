using System.Text;
using Pipeline.Interface;

namespace Pipeline
{
    class EtapaChassi : IEtapa<StringBuilder>
    {
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Append("[CHASSI]");
            return entrada;
        }
    }
}