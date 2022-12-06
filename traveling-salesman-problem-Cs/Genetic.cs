using traveling_salesman_problem_Cs.GeneticFunctions;

namespace traveling_salesman_problem_Cs
{
    class GeneticAlgorithm
    {
        readonly ushort nGenerations;
        readonly ushort lChromosome;
        readonly ushort nChromosomes;

        public GeneticAlgorithm(ushort nGenerations, ushort lChromosome, ushort nChromosomes) {
            this.nGenerations = nGenerations;
            this.lChromosome = lChromosome;
            this.nChromosomes = nChromosomes;
        }

        public void Evolve() {
            Chromosome[] genome = MiscFunctions.InitializeGenome(this.nChromosomes, this.lChromosome);
            MiscFunctions.PrintGenome(genome);
            Chromosome fstChromosome = genome[0];
        }
    }
}

/*
 create generic genetic functions e.g. initialize genome

make generic functions e.g.
    1. get two unique indices in range
    2. load csv of location points
    3. eval euclidean geometry

chromosome type being chromosome and fitness
 */
