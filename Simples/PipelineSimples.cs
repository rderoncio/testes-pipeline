using System.Text;
using System.Collections.Generic;
using Pipeline.Interface;

namespace Pipeline.Simples
{
    class PipelineSimples<T> : IPipeline<T>
    {
        private IList<IEtapa<T>> etapas = new List<IEtapa<T>>();

        public IPipeline<T> AddEtapa(IEtapa<T> etapa)
        {
            etapas.Add(etapa);
            return this;
        }

        public T Processar(T entrada)
        {
            foreach (var etapa in etapas)
            {
                entrada = etapa.Processar(entrada);
            }

            return etapas[0].Processar(entrada);
        }
    }
}