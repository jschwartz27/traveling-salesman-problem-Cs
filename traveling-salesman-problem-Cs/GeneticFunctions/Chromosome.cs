namespace traveling_salesman_problem_Cs.GeneticFunctions
{
    public readonly struct Chromosome
    {
        public float Fitness { get; init; }
        public List<int> Alleles { get; init; }
        public Chromosome(List<int> alleles)
        {
            this.Alleles = alleles;
            this.Fitness = Evaluation.Evaluate(alleles);
        }
        public override string ToString() => $"Fitness : {Fitness}\nChromosome : {string.Join(", ", Alleles)}";
    }
}
