using System;

namespace SistemaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma escola
            Escola minhaEscola = new Escola("Escola Primária");

            // Adicionando turmas à escola
            Turma turma1 = new Turma("1M1");
            minhaEscola.AdicionarTurma(turma1);

            Turma turma2 = new Turma("1M2");
            minhaEscola.AdicionarTurma(turma2);

            // Add professores
            Professor joaoPedroSilva = new Professor("João", "123456789", 1970, "Artes", 8.000);
            Professor fernandaFontes = new Professor("Maria", "987654321", 1960 , "Matematica", 9.000);

            // Add professores em turma
            turma1.AdicionarProfessor("Artes", joaoPedroSilva);
            turma1.AdicionarProfessor("Matematica", fernandaFontes);

            // Matriculando alunos
            Responsavel fernandoPereiraTadala = new Responsavel("Fernando", "645642554", 1970, "Pai", 2.500);
            Estudante lucasPereiraTadala = new Estudante("Lucas", "987654321", 2012, "1M1", fernandoPereiraTadala);
            turma1.MatricularAluno(lucasPereiraTadala);

            Responsavel sofiaSilva = new Responsavel("Sofia", "645888854", 1980, "Mae", 2.500);
            Estudante anaBeatrizSilva = new Estudante("Ana", "654321987", 2012, "1M1", sofiaSilva);
            turma1.MatricularAluno(anaBeatrizSilva);
            
            // Exibindo informacoes da escola
            minhaEscola.ExibirInformacoesEscola();

            // Exibindo informacoes da turma
            turma1.ListaDadosTurma();
        }
    }
}
