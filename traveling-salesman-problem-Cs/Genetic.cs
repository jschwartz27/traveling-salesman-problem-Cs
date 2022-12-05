using traveling_salesman_problem_Cs.GeneticFunctions;

namespace traveling_salesman_problem_Cs
{
    internal class Genetic
    {
        readonly int nGenerations;
        readonly ushort lChromosome;
        readonly ushort nChromosomes;

        public Genetic(int nGenerations, ushort lChromosome, ushort nChromosomes) {
            this.nGenerations = nGenerations;
            this.lChromosome = lChromosome;
            this.nChromosomes = nChromosomes;
        }

        public void Evolve() {
            int[] population = MiscFunctions.InitializeGenome(this.nChromosomes, this.lChromosome);
        
        }
    }

    public readonly struct Genome
    {
        public float Fitness { get; init; }
        public int[] Chromosome { get; init; }
        public Genome(float fitness, int[] chromosome) 
        {
            this.Fitness = fitness;
            this.Chromosome = chromosome;
        }
        public override string ToString() => $"({Fitness}, {Chromosome})";
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
