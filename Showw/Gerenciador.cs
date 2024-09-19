


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


       public void ProximaPergunta()
       {
        var numRandomico = Random.Shared.Next(0, ListaQuestoes.Count -1);
        while(ListaQuestoesRespondidas.Contains(numRandomico))
        numRandomico = Random.Shared.Next(0,ListaQuestoes.Count -1);
        ListaQuestoesRespondidas.Add(numRandomico);
        questaoCorrente = ListaQuestoes[numRandomico];
        questaoCorrente.Desenhar();
       }
    public async void VerificaCorreto(int resposta)
    {
        if (questaoCorrente!.VerificarResposta(resposta))
        {
            await Task.Delay(1500);
            ProximaPergunta();
        }
    }

    void CriarQuestoes(Label labelPergunta, Button BotaoResposta1, Button BotaoResposta2, Button BotaoResposta3, Button BotaoResposta4, Button BotaoResposta5)
    {
        var Q1 = new Questao();
        Q1.pergunta  = "Qual elemento que se diz saber tudo é perder tudo";
        Q1.resposta1 = "morte";
        Q1.resposta2 =  "energia";
        Q1.resposta3 = "medo";
        Q1.resposta4 = "sangue";
        Q1.resposta5 = "conhecimento";
        Q1.respostacerta = 5;
        Q1.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();

        Q2.pergunta  = "Quem foi o primeiro a morrer em OSF?";
        Q2.resposta1 = "Liz";
        Q2.resposta2 =  "Joui";
        Q2.resposta3 = "César";
        Q2.resposta4 = "Arthur";
        Q2.resposta5 = "Cris";
        Q2.respostacerta = 5;
        Q2.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();

        Q3.pergunta  = "Qual é o nome do boss final de OSF";
        Q3.resposta1 = "Magistrada";
        Q3.resposta2 =  "Diabo";
        Q3.resposta3 = "Anfitriao";
        Q3.resposta4 = "Deus da morte";
        Q3.resposta5 = "Verissimo";
        Q3.respostacerta = 4;
        Q3.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q3);

         var Q4 = new Questao();

        Q4.pergunta  = "Quem mais deu dano no César?";
        Q4.resposta1 = "Porta";
        Q4.resposta2 =  "Deus da morte";
        Q4.resposta3 = "Aracnideo";
        Q4.resposta4 = "Gangue";
        Q4.resposta5 = "Anfitriap";
        Q4.respostacerta = 1;
        Q4.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q4);

         var Q5 = new Questao();

        Q5.pergunta  = "Qual elemento do Arthur?";
        Q5.resposta1 = "Morte";
        Q5.resposta2 =  "Sangue";
        Q5.resposta3 = "Energia";
        Q5.resposta4 = "Medo";
        Q5.resposta5 = "Conhecimento";
        Q5.respostacerta = 2;
        Q5.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q5);

        var Q6 = new Questao();

        Q6.pergunta  = "Qual elemento do Kaiser";
        Q6.resposta1 = "Morte";
        Q6.resposta2 =  "Sangue";
        Q6.resposta3 = "Energia";
        Q6.resposta4 = "Medo";
        Q6.resposta5 = "Conhecimento";
        Q6.respostacerta = 3;
        Q6.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q6);

         var Q7 = new Questao();

        Q7.pergunta  = "Qual elemento do Dante";
        Q7.resposta1 = "Sangue";
        Q7.resposta2 =  "conhecimento";
        Q7.resposta3 = "Morte";
        Q7.resposta4 = "Energia";
        Q7.resposta5 = "Medo";
        Q7.respostacerta = 3;
        Q7.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q7);


        var Q8 = new Questao();

        Q8.pergunta  = "Quem portava a reliquia de conhecimento?";
        Q8.resposta1 = "Deus da Morte";
        Q8.resposta2 =  "Magistrada";
        Q8.resposta3 = "Kian";
        Q8.resposta4 = "Anfitriao";
        Q8.resposta5 = "Diabo";
        Q8.respostacerta = 2;
        Q8.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q8);

        var Q9 = new Questao();

        Q9.pergunta  = "O que a Carina tirou do Kian?";
        Q9.resposta1 = "Sua forca";
        Q9.resposta2 =  "Seus rituais";
        Q9.resposta3 = "Seu conhecimento";
        Q9.resposta4 = "Sua imortalidade";
        Q9.resposta5 = "Seus capangas";
        Q9.respostacerta = 2;
        Q9.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q9);


        var Q10 = new Questao();

        Q10.pergunta  = "Quem portava a reliquia de conhecimento?";
        Q10.resposta1 = "Deus da Morte";
        Q10.resposta2 =  "Kian";
        Q10.resposta3 = "Magistrada";
        Q10.resposta4 = "Anfitriao";
        Q10.resposta5 = "Diabo";
        Q10.respostacerta = 5;
        Q10.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q10);



        var Q11 = new Questao();

        Q11.pergunta  = "Quem portava a reliquia de conhecimento?";
        Q11.resposta1 = "Deus da Morte";
        Q11.resposta2 =  "Kian";
        Q11.resposta3 = "Magistrada";
        Q11.resposta4 = "Anfitriao";
        Q11.resposta5 = "Diabo";
        Q11.respostacerta = 5;
        Q11.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q11);



        var Q12 = new Questao();

        Q12.pergunta  = "Quem portava a reliquia de conhecimento?";
        Q12.resposta1 = "Deus da Morte";
        Q12.resposta2 =  "Kian";
        Q12.resposta3 = "Magistrada";
        Q12.resposta4 = "Anfitriao";
        Q12.resposta5 = "Diabo";
        Q12.respostacerta = 5;
        Q12.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q12);


        
        

    }

}