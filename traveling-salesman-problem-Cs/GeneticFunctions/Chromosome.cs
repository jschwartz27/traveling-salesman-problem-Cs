namespace traveling_salesman_problem_Cs.GeneticFunctions
{
    public readonly struct Chromosome
    {
        public float Fitness { get; init; }
        public ushort[] Alleles { get; init; }
        public Chromosome(float fitness, ushort[] alleles)
        {
            this.Fitness = fitness;
            this.Alleles = alleles;
        }
        public override string ToString() => $"({Fitness}, {Alleles})";
    }
}
