


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

        var Q4 = new Questao();

        Q4.pergunta  = "Qual é o nome do boss final de OSF";
        Q4.resposta1 = "Magistrada";
        Q4.resposta2 =  "Diabo";
        Q4.resposta3 = "Anfitriao";
        Q4.resposta4 = "Deus da morte";
        Q4.resposta5 = "Verissimo";
        Q4.respostacerta = 4;
        Q4.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q4);

         var Q5 = new Questao();

        Q5.pergunta  = "Quem mais deu dano no César?";
        Q5.resposta1 = "Porta";
        Q5.resposta2 =  "Deus da morte";
        Q5.resposta3 = "Aracnideo";
        Q5.resposta4 = "Gangue";
        Q5.resposta5 = "Anfitriap";
        Q5.respostacerta = 1;
        Q5.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q5);

         var Q6 = new Questao();

        Q6.pergunta  = "Qual elemento do Arthur?";
        Q6.resposta1 = "Morte";
        Q6.resposta2 =  "Sangue";
        Q6.resposta3 = "Energia";
        Q6.resposta4 = "Medo";
        Q6.resposta5 = "Conhecimento";
        Q6.respostacerta = 2;
        Q6.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q6);

        var Q7 = new Questao();

        Q7.pergunta  = "Qual elemento do Kaiser";
        Q7.resposta1 = "Morte";
        Q7.resposta2 =  "Sangue";
        Q7.resposta3 = "Energia";
        Q7.resposta4 = "Medo";
        Q7.resposta5 = "Conhecimento";
        Q7.respostacerta = 3;
        Q7.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q7);

         var Q8 = new Questao();

        Q8.pergunta  = "Qual elemento do Dante";
        Q8.resposta1 = "Sangue";
        Q8.resposta2 =  "conhecimento";
        Q8.resposta3 = "Morte";
        Q8.resposta4 = "Energia";
        Q8.resposta5 = "Medo";
        Q8.respostacerta = 3;
        Q8.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q8);


        var Q9 = new Questao();

        Q9.pergunta  = "Quem portava a reliquia de conhecimento?";
        Q9.resposta1 = "Deus da Morte";
        Q9.resposta2 =  "Magistrada";
        Q9.resposta3 = "Kian";
        Q9.resposta4 = "Anfitriao";
        Q9.resposta5 = "Diabo";
        Q9.respostacerta = 2;
        Q9.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q9);

        var Q10 = new Questao();

        Q10.pergunta  = "O que a Carina tirou do Kian?";
        Q10.resposta1 = "Sua forca";
        Q10.resposta2 =  "Seus rituais";
        Q10.resposta3 = "Seu conhecimento";
        Q10.resposta4 = "Sua imortalidade";
        Q10.resposta5 = "Seus capangas";
        Q10.respostacerta = 2;
        Q10.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q10);


        var Q11 = new Questao();

        Q11.pergunta  = "Quem portava a reliquia de conhecimento?";
        Q11.resposta1 = "Deus da Morte";
        Q11.resposta2 =  "Kian";
        Q11.resposta3 = "Magistrada";
        Q11.resposta4 = "Anfitriao";
        Q11.resposta5 = "Diabo";
        Q11.respostacerta = 3;
        Q11.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q11);



        var Q12 = new Questao();

        Q12.pergunta  = "Que equipe matou a fámilia Leone?";
        Q12.resposta1 = "Equipe E";
        Q12.resposta2 =  "Equipe Kelvin";
        Q12.resposta3 = "Time Kian";
        Q12.resposta4 = "Equipe Abutres";
        Q12.resposta5 = "Equipe S";
        Q12.respostacerta = 3;
        Q12.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q12);



        var Q13 = new Questao();

        Q13.pergunta  = "Em que arma o Anfitriao esta preso?";
        Q13.resposta1 = "Faca";
        Q13.resposta2 =  "Foice";
        Q13.resposta3 = "Espada";
        Q13.resposta4 = "Katana";
        Q13.resposta5 = "Pistola";
        Q13.respostacerta = 4;
        Q13.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q13);

         var Q14 = new Questao();
        Q14.pergunta  = "Qual elemento era o elemento de Kian?";
        Q14.resposta1 = "conhecimento";
        Q14.resposta2 =  "energia";
        Q14.resposta3 = "medo";
        Q14.resposta4 = "sangue";
        Q14.resposta5 = "morte";
        Q14.respostacerta = 1;
        Q14.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q14);

        var Q15 = new Questao();

        Q15.pergunta  = "Quem foi saco de pancada do Kian?";
        Q15.resposta1 = "Liz";
        Q15.resposta2 =  "Joui";
        Q15.resposta3 = "César";
        Q15.resposta4 = "Arthur";
        Q15.resposta5 = "Cris";
        Q15.respostacerta = 2;
        Q15.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q15);

        var Q16 = new Questao();

        Q16.pergunta  = "Qual elemento suplanta a reliquia de energia";
        Q16.resposta1 = "conhecimento";
        Q16.resposta2 =  "energia";
        Q16.resposta3 = "medo";
        Q16.resposta4 = "sangue";
        Q16.resposta5 = "morte";
        Q16.respostacerta = 1;
        Q16.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q16);

         var Q17 = new Questao();

        Q17.pergunta  = "Quem matou a Liz?";
        Q17.resposta1 = "Kian";
        Q17.resposta2 =  "Deus da morte";
        Q17.resposta3 = "Aracnideo";
        Q17.resposta4 = "Carina";
        Q17.resposta5 = "Gal";
        Q17.respostacerta = 5;
        Q17.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q17);

         var Q18 = new Questao();

        Q18.pergunta  = "De qual elemento a Agatha é?";
        Q18.resposta1 = "Morte";
        Q18.resposta2 =  "Sangue";
        Q18.resposta3 = "Energia";
        Q18.resposta4 = "Medo";
        Q18.resposta5 = "Conhecimento";
        Q18.respostacerta = 2;
        Q18.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q18);

        var Q19 = new Questao();

        Q19.pergunta  = "Que membro o Arthur perdeu em Santo Berço?";
        Q19.resposta1 = "olho";
        Q19.resposta2 =  "lingua";
        Q19.resposta3 = "perna";
        Q19.resposta4 = "braço";
        Q19.resposta5 = "pé";
        Q19.respostacerta = 4;
        Q19.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q19);

         var Q20 = new Questao();

        Q20.pergunta  = "Quem era Kian em desconjuração?";
        Q20.resposta1 = "Fernando";
        Q20.resposta2 =  "Luciano";
        Q20.resposta3 = "Beatrice";
        Q20.resposta4 = "Dante";
        Q20.resposta5 = "Liz";
        Q20.respostacerta = 2;
        Q20.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q20);


        var Q21 = new Questao();

        Q21.pergunta  = "Quem foi o primeiro a morrer(player) em Desconjuração?";
        Q21.resposta1 = "Erin";
        Q21.resposta2 =  "Beatrice";
        Q21.resposta3 = "Gal";
        Q21.resposta4 = "Joui";
        Q21.resposta5 = "Fernando";
        Q21.respostacerta = 2;
        Q21.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q21);

        var Q22 = new Questao();

        Q22.pergunta  = "Quem foi o primeiro a morrer do time Kian?";
        Q22.resposta1 = "Gal";
        Q22.resposta2 =  "T-Bag";
        Q22.resposta3 = "Damir";
        Q22.resposta4 = "Artemis";
        Q22.resposta5 = "Rufus";
        Q22.respostacerta = 4;
        Q22.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q22);


        var Q23 = new Questao();

        Q23.pergunta  = "Quem foi o último a portar da relíquia de energia?";
        Q23.resposta1 = "Thiago";
        Q23.resposta2 =  "Kian";
        Q23.resposta3 = "Verissimo";
        Q23.resposta4 = "Arnaldo Frits";
        Q23.resposta5 = "Agatha";
        Q23.respostacerta = 4;
        Q23.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q23);



        var Q24 = new Questao();

        Q24.pergunta  = "Quem fez um contrato com o Diabo?";
        Q24.resposta1 = "Joui";
        Q24.resposta2 =  "Kian";
        Q24.resposta3 = "Arthur";
        Q24.resposta4 = "Carina";
        Q24.resposta5 = "Os leones";
        Q24.respostacerta = 2;
        Q24.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q24);



        var Q25 = new Questao();

        Q25.pergunta  = "Quem porta a Reliquia de sangue?";
        Q25.resposta1 = "Henri";
        Q25.resposta2 =  "Joui";
        Q25.resposta3 = "Dante";
        Q25.resposta4 = "Fernando";
        Q25.resposta5 = "Erin";
        Q25.respostacerta = 1;
        Q25.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);

        ListaQuestoes.Add(Q25);

        
        

    }

}