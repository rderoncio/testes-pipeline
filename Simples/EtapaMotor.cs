using System.Text;
using Pipeline.Interface;

namespace Pipeline
{
    class EtapaMotor : IEtapa<StringBuilder>
    {
        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Append("[MOTOR]");
            return entrada;
        }
    }
}