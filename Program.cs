using System;
using System.Text;
using Pipeline.Simples;
using Pipeline.Dupla;

namespace Pipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pipeline Simples: Montagem de veivulos");

            var montagemVeiculo = new PipelineSimples<StringBuilder>();
            montagemVeiculo.AddEtapa(new EtapaChassi());
            montagemVeiculo.AddEtapa(new EtapaMotor());
            montagemVeiculo.AddEtapa(new EtapaBancos());
            montagemVeiculo.AddEtapa(new EtapaCarroceria());
            montagemVeiculo.AddEtapa(new EtapaPortas());
            montagemVeiculo.AddEtapa(new EtapaPintura());

            for (int i = 0; i < 10; i++)
            {
                var veiculo = montagemVeiculo.Processar(new StringBuilder());
                Console.WriteLine($"Veiculo {i + 1:D2}: {veiculo.ToString()}");
            }

            Console.WriteLine("Pipeline Duplo: Montagem de veivulos");

            var montagemVeiculo2 = new PipelineDuplo<StringBuilder>();
            montagemVeiculo2.AddEtapa(new EtapaDuplaChassi());
            montagemVeiculo2.AddEtapa(new EtapaDuplaMotor());
            montagemVeiculo2.AddEtapa(new EtapaDuplaBancos());
            montagemVeiculo2.AddEtapa(new EtapaDuplaCarroceria());
            montagemVeiculo2.AddEtapa(new EtapaDuplaPortas());
            montagemVeiculo2.AddEtapa(new EtapaDuplaPintura());

            for (int i = 0; i < 10; i++)
            {
                var veiculo = montagemVeiculo2.Processar(new StringBuilder());
                Console.WriteLine($"Veiculo {i + 1:D2}: {veiculo.ToString()}");
            }

        }
    }
}
