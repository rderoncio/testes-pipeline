using System.Text;
using System.Collections.Generic;
using Pipeline.Interface;

namespace Pipeline.Dupla
{
    class PipelineDuplo<T> : IPipeline<T>
    {
        private IList<IEtapaDupla<T>> etapas = new List<IEtapaDupla<T>>();

        public PipelineDuplo<T> AddEtapa(IEtapaDupla<T> etapa)
        {
            etapas.Add(etapa);
            return this;
        }

        public T Processar(T entrada)
        {
            for (int i = 0; i < etapas.Count - 1; i++)
            {
                etapas[i].ProximaEtapa = etapas[i + 1];
            }

            return etapas[0].Processar(entrada);
        }
    }
}