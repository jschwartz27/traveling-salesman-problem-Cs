namespace traveling_salesman_problem_Cs.GeneticFunctions
{
    internal class MiscFunctions
    {
        public static Chromosome[] InitializeGenome(ushort nChromosome, ushort lChromosome)
        {
            /*
             * returns Genome (List of all Chromosomes) ordered by fitness
             */
            List<int> orderedChromosome = Enumerable.Range(0, lChromosome).ToList();
            Random rnd = new();
            List<int> randomChromosome;
            // int[] genome = Array.Empty<int>();
            Chromosome[] genome = new Chromosome[nChromosome];
            for (int i = 0; i < nChromosome; i++)
            {
                randomChromosome = orderedChromosome.OrderBy(a => rnd.Next()).ToList();
                genome[i] = new Chromosome(randomChromosome);
            }
            return genome;
        }

        public static void PrintGenome(Chromosome[] chromosome)
        {
            for (int i = 0; i < chromosome.Length; i++)
            {
                Console.WriteLine($"\nChromosome Number : {i + 1}");
                Console.WriteLine(chromosome[i]);
            }

        }
    }
}
