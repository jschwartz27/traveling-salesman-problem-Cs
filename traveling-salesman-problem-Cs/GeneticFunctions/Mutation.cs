namespace traveling_salesman_problem_Cs.GeneticFunctions
{
    internal class Mutation
    {
        private readonly int[] Chromosome;

        public Mutation(int[] chromosome)
        {
            this.Chromosome = chromosome;
        }
        public int[] Mutate()
        {
            Random rnd = new();
            int rIndex1 = rnd.Next(Chromosome.Length);
            int rIndex2 = rnd.Next(Chromosome.Length);  // Need to make sure numbers do not repeat!!
            // TODO does this update Chromosome??
            return Swap(Chromosome, rIndex1, rIndex2);
        }

        private static int[] Swap(int[] newC, int indexA, int indexB)
        {
            (newC[indexB], newC[indexA]) = (newC[indexA], newC[indexB]);
            return newC;
        }
    }
}
 