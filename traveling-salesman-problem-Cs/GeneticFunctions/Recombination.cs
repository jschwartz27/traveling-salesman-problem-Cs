namespace traveling_salesman_problem_Cs.GeneticFunctions
{
    class Recombination
    {
        private readonly int[] Chromosome1;
        private readonly int[] Chromosome2;
        public Recombination(int[] chromosome1, int[] chromosome2)
        {
            this.Chromosome1 = chromosome1;
            this.Chromosome2 = chromosome2;
        }
        public int[] Recombine()
        {
            int[] newChromosome = { 1, 2, 3 };
            return newChromosome;
        }
    }
}
