namespace traveling_salesman_problem_Cs.GeneticFunctions
{
    internal class MiscFunctions
    {
        public static int[] InitializeGenome(ushort nChromosome, ushort lChromosome)
        {
            /*
             * returns Genome (List of all Chromosomes) ordered by fitness
             */
            int[] orderedChromosome = Enumerable.Range(0, lChromosome).ToArray();
            Random rnd = new();
            int[] randomChromosome;
            int[] genome = Array.Empty<int>();  // new Chromosome[nChromosome];
            for (int i = 0; i < nChromosome; i++)
            {
                randomChromosome = orderedChromosome.OrderBy(a => rnd.Next()).ToArray();
                // genome.Append(randomChromosome);
                genome = randomChromosome.ToArray();
            }
            return genome;
        }

        public static void Print(int[] chromosome)
        {
            Console.WriteLine(string.Join(", ", chromosome));
        }
    }
}
