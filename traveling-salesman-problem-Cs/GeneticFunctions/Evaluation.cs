namespace traveling_salesman_problem_Cs.GeneticFunctions
{
    class Evaluation
    {

        private readonly int[] Chromosome;

        public Evaluation(int[] chromosome)
        {
            this.Chromosome = chromosome;
        }

        public float Evaluate()
        {
            return 5.5f;
        }
    }
}
