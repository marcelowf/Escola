namespace SistemaEscolar
{
    class Escola
    {
        public string NomeEscola { get; }
        private List<Turma> turmas;

        public Escola(string nomeEscola)
        {
            NomeEscola = nomeEscola;
            turmas = new List<Turma>();
        }

        public void AdicionarTurma(Turma turma)
        {
            turmas.Add(turma);
            Console.WriteLine($"Turma {turma.AnoTurma} adicionada à escola {NomeEscola}.");
        }

        public void ExibirInformacoesEscola()
        {
            Console.WriteLine($"Escola: {NomeEscola}");

            if (turmas.Count > 0)
            {
                Console.WriteLine("Turmas:");
                foreach (var turma in turmas)
                {
                    Console.Write($"- Ano: {turma.AnoTurma}\n");
                }
            }
            else
            {
                Console.Write("Nenhuma turma cadastrada.");
            }
        }
    }
}
