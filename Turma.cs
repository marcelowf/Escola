namespace SistemaEscolar
{
    class Turma
    {
        public string AnoTurma { get; }
        private Dictionary<string, Professor> professoresPorDisciplina;
        private List<Estudante> alunosMatriculados;

        public Turma(string anoTurma)
        {
            AnoTurma = anoTurma;
            professoresPorDisciplina = new Dictionary<string, Professor>();
            alunosMatriculados = new List<Estudante>();
        }

        public void AdicionarProfessor(string disciplina, Professor professor)
        {
            // Certifique-se de que não estamos substituindo um professor existente
            if (!professoresPorDisciplina.ContainsKey(disciplina))
            {
                professoresPorDisciplina.Add(disciplina, professor);
            }
            else
            {
                Console.WriteLine($"Já há um professor de {disciplina} para esta turma.");
            }
        }

        public void SubstituirProfessor(string disciplina, Professor novoProfessor)
        {
            // Substituir o professor se a disciplina existir
            if (professoresPorDisciplina.ContainsKey(disciplina))
            {
                professoresPorDisciplina[disciplina] = novoProfessor;
                Console.WriteLine($"Professor de {disciplina} substituído com sucesso.");
            }
            else
            {
                Console.WriteLine($"Não há professor de {disciplina} para substituir.");
            }
        }

        public void MatricularAluno(Estudante aluno)
        {
            alunosMatriculados.Add(aluno);
        }

        public void RemoverAluno(Estudante aluno)
        {
            if (alunosMatriculados.Contains(aluno))
            {
                alunosMatriculados.Remove(aluno);
                Console.WriteLine($"Aluno {aluno.NomePessoa} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Aluno {aluno.NomePessoa} não encontrado na turma.");
            }
        }

        public void ListaDadosTurma()
        {
            Console.WriteLine($"Dados da Turma {AnoTurma}:");

            Console.WriteLine("Professores:");

            foreach (var disciplina in professoresPorDisciplina.Keys)
            {
                Console.WriteLine($"- Nome: {professoresPorDisciplina[disciplina].NomePessoa} - Disciplina: {disciplina}.");
            }

            Console.WriteLine("Alunos Matriculados:");

            foreach (var aluno in alunosMatriculados)
            {
                Console.WriteLine($"- Nome: {aluno.NomePessoa}.");
            }
        }
    }
}