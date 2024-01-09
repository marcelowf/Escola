namespace SistemaEscolar
{
    class Professor : Pessoa
    {
        public string MateriaProfessor { get; }
        public double SalarioProfessor { get; set; }

        public Professor(string nomePessoa, string cpfPessoa, int idadePessoa, string materiaProfessor, double salarioProfessor)
            : base(nomePessoa, cpfPessoa, idadePessoa)
        {
            MateriaProfessor = materiaProfessor;
            SalarioProfessor = salarioProfessor;
        }
    }
}