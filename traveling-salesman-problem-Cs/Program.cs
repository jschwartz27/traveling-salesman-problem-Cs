using traveling_salesman_problem_Cs;

namespace Gtraveling_salesman_problem_Csenetic
{
    class Program
    {
        public record Parameters
        (
            ushort nGenerations,
            ushort lChromosome,
            ushort nChromosomes
        );

        static void Main(string[] arg)
        {
            Parameters parameters = new(5, 10, 1);
            new GeneticAlgorithm(
                parameters.nGenerations,
                parameters.lChromosome,
                parameters.nChromosomes
            ).Evolve();
        }
    }
}
