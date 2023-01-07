using System.Text;
using Pipeline.Interface;

namespace Pipeline.Dupla
{
    class EtapaDuplaPortas : IEtapaDupla<StringBuilder>
    {
        public IEtapaDupla<StringBuilder> ProximaEtapa { get; set; }

        public StringBuilder Processar(StringBuilder entrada)
        {
            entrada.Insert(0, "[PORTA]", 2);
            entrada.Insert(entrada.Length, "[PORTA]", 2);

            entrada = ProximaEtapa?.Processar(entrada) ?? entrada;

            int posPortaEsquerda = entrada.ToString().IndexOf("[PORTA]");
            entrada.Insert(posPortaEsquerda, "[MAÇANETA]", 2);

            int posPortaDireita = entrada.ToString().LastIndexOf("[PORTA]") + 7;
            entrada.Insert(posPortaDireita, "[MAÇANETA]", 2);

            return entrada;
        }
    }
}