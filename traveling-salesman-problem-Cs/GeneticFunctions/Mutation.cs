namespace traveling_salesman_problem_Cs.GeneticFunctions
{
    internal class Mutation
    {
        private readonly Chromosome Chromosome;

        public Mutation(Chromosome chromosome)
        {
            this.Chromosome = chromosome;
        }
        public void Mutate()
        {
            Random rnd = new();
            int rIndex1 = rnd.Next(Chromosome.Alleles.Count);
            int rIndex2 = rnd.Next(Chromosome.Alleles.Count);  // Need to make sure numbers do not repeat!!
            // TODO does this update Chromosome??
            // return Swap(Chromosome, rIndex1, rIndex2);
            // Must return Evaluate(Chromosome)
        }

        private static int[] Swap(int[] newC, int indexA, int indexB)
        {
            (newC[indexB], newC[indexA]) = (newC[indexA], newC[indexB]);
            return newC;
        }
    }
}
 