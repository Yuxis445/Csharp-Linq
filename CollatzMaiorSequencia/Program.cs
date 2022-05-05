using System.Diagnostics;

namespace CollatzMaiorSequencia {
    class Program {
        static void Main() {

            var stopwatch = new Stopwatch();
            Console.WriteLine("Sequência de Collatz\n");
            Console.WriteLine("Programa desenvolvido para achar o número inicial entre 1 e 1 milhão " +
             "que produz a maior sequência de Collatz.");


                var maxSequencia = 1;
                var count = 1;
                 stopwatch.Start();
                for (int i = 0; i < 1000001; i++)
                {
                    var sequenciaAtual = GetMaxSequencia(i);
                    maxSequencia = sequenciaAtual > count ? i : maxSequencia;
                    count = sequenciaAtual > count ? sequenciaAtual : count;

                }
                stopwatch.Stop();
            Console.WriteLine($"A maior sequência é: {maxSequencia}");
            Console.WriteLine($"Tempo decorrido para encontrar: {stopwatch.Elapsed}");
        }

        private static int GetMaxSequencia(int numero)
        {
            int numeroAtual = numero;
            List<int> sequencias = new();
            string sequencia = numero.ToString();

            sequencias.Add(numeroAtual);

            while (numeroAtual > 1)
            {
                if (numeroAtual % 2 == 0)
                    numeroAtual /= 2;
                else
                    numeroAtual = (3 * numeroAtual) + 1;

                sequencia += $",{numeroAtual}";
                sequencias.Add(numeroAtual);

                if (numeroAtual == 1)
                    break;
            }

            return sequencias.Count;
        }
    }
}
