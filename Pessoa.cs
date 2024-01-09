namespace SistemaEscolar
{
    class Pessoa
    {
        public string NomePessoa { get; }
        public string CpfPessoa { get; }
        public int IdadePessoa { get; set; }

        public Pessoa(string nomePessoa, string cpfPessoa, int idadePessoa)
        {
            NomePessoa = nomePessoa;
            CpfPessoa = cpfPessoa;
            IdadePessoa = idadePessoa;
        }
    }
}
