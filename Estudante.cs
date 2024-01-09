namespace SistemaEscolar
{
    class Estudante : Pessoa
    {
        public string TurmaAluno { get; set; }
        public Responsavel Responsavel { get; set; }

        public Estudante(string nomePessoa, string cpfPessoa, int idadePessoa, string turmaAluno, Responsavel responsavel)
            : base(nomePessoa, cpfPessoa, idadePessoa)
        {
            TurmaAluno = turmaAluno;
            
            if (responsavel == null)
            {
                throw new ArgumentException("Um estudante deve ter um responsável associado.");
            }

            Responsavel = responsavel;
        }
    }
}
