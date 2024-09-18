

namespace Showw;



public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao questaoCorrente;

    public Gerenciador (Label labelPergunta, Button BotaoResposta1, Button BotaoResposta2, Button BotaoResposta3, Button BotaoResposta4, Button BotaoResposta5)
    {
        CriarQuestoes(labelPergunta,  BotaoResposta1,  BotaoResposta2, BotaoResposta3,  BotaoResposta4,  BotaoResposta5);
    }

    void CriarQuestoes(Label labelPergunta, Button BotaoResposta1, Button BotaoResposta2, Button BotaoResposta3, Button BotaoResposta4, Button BotaoResposta5)
    {
        var Q1 = new Questao();
        Q1.pergunta  = "";
        Q1.resposta1 = "";
        Q1.resposta2 =  "";
        Q1.resposta3 = "";
        Q1.resposta4 = "";
        Q1.resposta5 = "";
        Q1.respostaCorreta = 5;
        Q1.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();

        Q2.pergunta  = "";
        Q2.resposta1 = "";
        Q2.resposta2 =  "";
        Q2.resposta3 = "";
        Q2.resposta4 = "";
        Q2.resposta5 = "";
        Q2.respostaCorreta = 5;
        Q2.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();

        Q3.pergunta  = "";
        Q3.resposta1 = "";
        Q3.resposta2 =  "";
        Q3.resposta3 = "";
        Q3.resposta4 = "";
        Q3.resposta5 = "";
        Q3.respostaCorreta = 5;
        Q3.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q3);
    }

}