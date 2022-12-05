namespace traveling_salesman_problem_Cs.GeneticFunctions
{
    internal class MiscFunctions
    {
        public static int[] InitializeGenome(ushort nChromosome, ushort lChromosome)
        {
            List<int> orderedChromosome = Enumerable.Range(0, lChromosome).ToList();
            Random rnd = new();

            List<int> randomChromosome;
            int[] genome = {};
            for (int i = 0; i < nChromosome; i++)
            {
                randomChromosome = orderedChromosome.OrderBy(a => rnd.Next()).ToList();
                // genome.Append(randomChromosome);
                genome = randomChromosome.ToArray();
            }

            return genome;
        }
    }
}
