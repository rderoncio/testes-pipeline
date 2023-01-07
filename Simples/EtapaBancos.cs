using System.Text;
using Pipeline.Interface;

namespace Pipeline
{
    class EtapaBancos : IEtapa<StringBuilder>
    {
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Insert(0, "[BANCO]", 2);
            entrada.Insert(entrada.Length, "[BANCO]", 2);
            return entrada;
        }
    }
}