namespace SistemaEscolar
{
    class Responsavel : Pessoa
    {
        public string RelacaoComEstudante { get; set; }
        public double Mensalidade { get; set; } 

        public Responsavel(string nomePessoa, string cpfPessoa, int idadePessoa, string relacaoComEstudante, double mensalidade)
            : base(nomePessoa, cpfPessoa, idadePessoa)
        {
            RelacaoComEstudante = relacaoComEstudante;
            Mensalidade = mensalidade;
        }
    }
}