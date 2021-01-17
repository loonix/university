namespace Quem_Quer_Ser_Fixe.structs
{
    public class structs
    {
       public struct questoes
        {
            public int id;
            public string questao;
            public respostas resposta;
        }

        public struct respostas
        {
            public string respostaUser;
            public string respostaCorrectaId;
            public string respostaCorrectaNome;
            public string resposta1;
            public string resposta2;
            public string resposta3;
            public string resposta4;
        }

        public struct pontuacoes
        {
            public string userName;
            public string pontos;
        }
    }
}
