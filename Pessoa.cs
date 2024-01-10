namespace SistemaEscolar
{
    abstract class Pessoa
    {
        public string NomePessoa { get; }
        public string CpfPessoa { get; }
        public int DataNascimento { get; set; }

        public Pessoa(string nomePessoa, string cpfPessoa, int dataNascimento)
        {
            NomePessoa = nomePessoa;
            CpfPessoa = cpfPessoa;
            DataNascimento = dataNascimento;
        }
    }
}
