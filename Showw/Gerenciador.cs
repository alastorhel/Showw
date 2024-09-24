


namespace Showw;



public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao questaoCorrente;
     
     Label labelPontuacao;
     Label labelNivel;


    public Gerenciador(Label labelPergunta, Button BotaoResposta1, Button BotaoResposta2, Button BotaoResposta3, Button BotaoResposta4, Button BotaoResposta5, Label labelPontuacao, Label labelNivel)
    {
        CriarQuestoes(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        this.labelPontuacao = labelPontuacao;
        this.labelNivel = labelNivel;
    }


    public void ProximaPergunta()
    {
        var numRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);
        while (ListaQuestoesRespondidas.Contains(numRandomico))
            numRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);
        ListaQuestoesRespondidas.Add(numRandomico);
        questaoCorrente = ListaQuestoes[numRandomico];
        questaoCorrente.Desenhar();
    }
    public async void VerificaCorreto(int resposta)
    {
            
              

        if (questaoCorrente!.VerificarResposta(resposta))
        {
            await Task.Delay(1500);
             labelPontuacao.Text = "Pontuação:R$" + Pontuacao.ToString();
            labelNivel.Text = "Nivel" + NivelAtual.ToString();
            AdicionaPontucao(NivelAtual);
            NivelAtual++;
            ProximaPergunta();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Fim", "Você Errou!!Melhore", "Ok");
            Inicializar();
        }

        void AdicionaPontucao(int coisa)
        {
            if (coisa == 1)
                Pontuacao = 1000;
            else if (coisa == 2)
                Pontuacao = 2000;
            else if (coisa == 3)
                Pontuacao = 5000;
            else if (coisa == 4)
                Pontuacao = 10000;
            else if (coisa == 5)
                Pontuacao = 20000;
            else if (coisa == 6)
                Pontuacao = 50000;
            else if (coisa == 7)
                Pontuacao = 100000;
            else if (coisa == 8)
                Pontuacao = 200000;
            else if (coisa == 9)
                Pontuacao = 500000;
            else
                Pontuacao = 1000000;
        }

    }

    public int Pontuacao { get; private set; }
    int NivelAtual = 0;

    void Inicializar()
    {
        Pontuacao = 0;
        NivelAtual = 0;
        ProximaPergunta();
        labelPontuacao.Text = "Pontuação:R$" + Pontuacao.ToString();
            labelNivel.Text = "Nivel" + NivelAtual.ToString();
    }


    void CriarQuestoes(Label labelPergunta, Button BotaoResposta1, Button BotaoResposta2, Button BotaoResposta3, Button BotaoResposta4, Button BotaoResposta5)
    {
        var Q1 = new Questao();
        Q1.Nivel = 1;
        Q1.pergunta = "Qual elemento que se diz saber tudo é perder tudo";
        Q1.resposta1 = "morte";
        Q1.resposta2 = "energia";
        Q1.resposta3 = "medo";
        Q1.resposta4 = "sangue";
        Q1.resposta5 = "conhecimento";
        Q1.respostacerta = 5;
        Q1.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();
        Q2.Nivel = 1;
        Q2.pergunta = "Quem foi o primeiro a morrer em OSF?";
        Q2.resposta1 = "Liz";
        Q2.resposta2 = "Joui";
        Q2.resposta3 = "César";
        Q2.resposta4 = "Arthur";
        Q2.resposta5 = "Cris";
        Q2.respostacerta = 5;
        Q2.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q2);

        var Q4 = new Questao();
        Q4.Nivel = 1;
        Q4.pergunta = "Qual é o nome do boss final de OSF";
        Q4.resposta1 = "Magistrada";
        Q4.resposta2 = "Diabo";
        Q4.resposta3 = "Anfitriao";
        Q4.resposta4 = "Deus da morte";
        Q4.resposta5 = "Verissimo";
        Q4.respostacerta = 4;
        Q4.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q4);

        var Q5 = new Questao();
        Q5.Nivel = 1;
        Q5.pergunta = "Quem mais deu dano no César?";
        Q5.resposta1 = "Porta";
        Q5.resposta2 = "Deus da morte";
        Q5.resposta3 = "Aracnideo";
        Q5.resposta4 = "Gangue";
        Q5.resposta5 = "Anfitriap";
        Q5.respostacerta = 1;
        Q5.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q5);

        var Q6 = new Questao();
        Q6.Nivel = 1;
        Q6.pergunta = "Qual elemento do Arthur?";
        Q6.resposta1 = "Morte";
        Q6.resposta2 = "Sangue";
        Q6.resposta3 = "Energia";
        Q6.resposta4 = "Medo";
        Q6.resposta5 = "Conhecimento";
        Q6.respostacerta = 2;
        Q6.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q6);

        var Q7 = new Questao();
        Q7.Nivel = 1;
        Q7.pergunta = "Qual elemento do Kaiser";
        Q7.resposta1 = "Morte";
        Q7.resposta2 = "Sangue";
        Q7.resposta3 = "Energia";
        Q7.resposta4 = "Medo";
        Q7.resposta5 = "Conhecimento";
        Q7.respostacerta = 3;
        Q7.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q7);

        var Q8 = new Questao();
        Q8.Nivel = 1;
        Q8.pergunta = "Qual elemento do Dante";
        Q8.resposta1 = "Sangue";
        Q8.resposta2 = "conhecimento";
        Q8.resposta3 = "Morte";
        Q8.resposta4 = "Energia";
        Q8.resposta5 = "Medo";
        Q8.respostacerta = 3;
        Q8.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q8);


        var Q9 = new Questao();
        Q9.Nivel = 1;
        Q9.pergunta = "Quem portava a reliquia de conhecimento?";
        Q9.resposta1 = "Deus da Morte";
        Q9.resposta2 = "Magistrada";
        Q9.resposta3 = "Kian";
        Q9.resposta4 = "Anfitriao";
        Q9.resposta5 = "Diabo";
        Q9.respostacerta = 2;
        Q9.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q9);

        var Q10 = new Questao();
        Q10.Nivel = 1;
        Q10.pergunta = "O que a Carina tirou do Kian?";
        Q10.resposta1 = "Sua forca";
        Q10.resposta2 = "Seus rituais";
        Q10.resposta3 = "Seu conhecimento";
        Q10.resposta4 = "Sua imortalidade";
        Q10.resposta5 = "Seus capangas";
        Q10.respostacerta = 2;
        Q10.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q10);


        var Q11 = new Questao();
        Q11.Nivel = 1;
        Q11.pergunta = "Quem portava a reliquia de conhecimento?";
        Q11.resposta1 = "Deus da Morte";
        Q11.resposta2 = "Kian";
        Q11.resposta3 = "Magistrada";
        Q11.resposta4 = "Anfitriao";
        Q11.resposta5 = "Diabo";
        Q11.respostacerta = 3;
        Q11.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q11);



        var Q12 = new Questao();
        Q12.Nivel = 2;
        Q12.pergunta = "Que equipe matou a fámilia Leone?";
        Q12.resposta1 = "Equipe E";
        Q12.resposta2 = "Equipe Kelvin";
        Q12.resposta3 = "Time Kian";
        Q12.resposta4 = "Equipe Abutres";
        Q12.resposta5 = "Equipe S";
        Q12.respostacerta = 3;
        Q12.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q12);



        var Q13 = new Questao();
        Q13.Nivel = 2;
        Q13.pergunta = "Em que arma o Anfitriao esta preso?";
        Q13.resposta1 = "Faca";
        Q13.resposta2 = "Foice";
        Q13.resposta3 = "Espada";
        Q13.resposta4 = "Katana";
        Q13.resposta5 = "Pistola";
        Q13.respostacerta = 4;
        Q13.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q13);

        var Q14 = new Questao();
        Q14.Nivel = 2;
        Q14.pergunta = "Qual elemento era o elemento de Kian?";
        Q14.resposta1 = "conhecimento";
        Q14.resposta2 = "energia";
        Q14.resposta3 = "medo";
        Q14.resposta4 = "sangue";
        Q14.resposta5 = "morte";
        Q14.respostacerta = 1;
        Q14.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q14);

        var Q15 = new Questao();
        Q15.Nivel = 2;
        Q15.pergunta = "Quem foi saco de pancada do Kian?";
        Q15.resposta1 = "Liz";
        Q15.resposta2 = "Joui";
        Q15.resposta3 = "César";
        Q15.resposta4 = "Arthur";
        Q15.resposta5 = "Cris";
        Q15.respostacerta = 2;
        Q15.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q15);

        var Q16 = new Questao();
        Q16.Nivel = 2;
        Q16.pergunta = "Qual elemento suplanta a reliquia de energia";
        Q16.resposta1 = "conhecimento";
        Q16.resposta2 = "energia";
        Q16.resposta3 = "medo";
        Q16.resposta4 = "sangue";
        Q16.resposta5 = "morte";
        Q16.respostacerta = 1;
        Q16.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q16);

        var Q17 = new Questao();
        Q17.Nivel = 2;
        Q17.pergunta = "Quem matou a Liz?";
        Q17.resposta1 = "Kian";
        Q17.resposta2 = "Deus da morte";
        Q17.resposta3 = "Aracnideo";
        Q17.resposta4 = "Carina";
        Q17.resposta5 = "Gal";
        Q17.respostacerta = 5;
        Q17.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q17);

        var Q18 = new Questao();
        Q18.Nivel = 2;
        Q18.pergunta = "De qual elemento a Agatha é?";
        Q18.resposta1 = "Morte";
        Q18.resposta2 = "Sangue";
        Q18.resposta3 = "Energia";
        Q18.resposta4 = "Medo";
        Q18.resposta5 = "Conhecimento";
        Q18.respostacerta = 2;
        Q18.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q18);

        var Q19 = new Questao();
        Q19.Nivel = 2;
        Q19.pergunta = "Que membro o Arthur perdeu em Santo Berço?";
        Q19.resposta1 = "olho";
        Q19.resposta2 = "lingua";
        Q19.resposta3 = "perna";
        Q19.resposta4 = "braço";
        Q19.resposta5 = "pé";
        Q19.respostacerta = 4;
        Q19.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q19);

        var Q20 = new Questao();
        Q20.Nivel = 2;
        Q20.pergunta = "Quem era Kian em desconjuração?";
        Q20.resposta1 = "Fernando";
        Q20.resposta2 = "Luciano";
        Q20.resposta3 = "Beatrice";
        Q20.resposta4 = "Dante";
        Q20.resposta5 = "Liz";
        Q20.respostacerta = 2;
        Q20.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q20);


        var Q21 = new Questao();
        Q21.Nivel = 2;
        Q21.pergunta = "Quem foi o primeiro a morrer(player) em Desconjuração?";
        Q21.resposta1 = "Erin";
        Q21.resposta2 = "Beatrice";
        Q21.resposta3 = "Gal";
        Q21.resposta4 = "Joui";
        Q21.resposta5 = "Fernando";
        Q21.respostacerta = 2;
        Q21.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q21);

        var Q22 = new Questao();
        Q22.Nivel = 3;
        Q22.pergunta = "Quem foi o primeiro a morrer do time Kian?";
        Q22.resposta1 = "Gal";
        Q22.resposta2 = "T-Bag";
        Q22.resposta3 = "Damir";
        Q22.resposta4 = "Artemis";
        Q22.resposta5 = "Rufus";
        Q22.respostacerta = 4;
        Q22.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q22);


        var Q23 = new Questao();
        Q23.Nivel = 3;
        Q23.pergunta = "Quem foi o último a portar da relíquia de energia?";
        Q23.resposta1 = "Thiago";
        Q23.resposta2 = "Kian";
        Q23.resposta3 = "Verissimo";
        Q23.resposta4 = "Arnaldo Frits";
        Q23.resposta5 = "Agatha";
        Q23.respostacerta = 4;
        Q23.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q23);



        var Q24 = new Questao();
        Q24.Nivel = 3;
        Q24.pergunta = "Quem fez um contrato com o Diabo?";
        Q24.resposta1 = "Joui";
        Q24.resposta2 = "Kian";
        Q24.resposta3 = "Arthur";
        Q24.resposta4 = "Carina";
        Q24.resposta5 = "Os leones";
        Q24.respostacerta = 2;
        Q24.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q24);



        var Q25 = new Questao();
        Q25.Nivel = 3;
        Q25.pergunta = "Quem porta a Reliquia de sangue?";
        Q25.resposta1 = "Henri";
        Q25.resposta2 = "Joui";
        Q25.resposta3 = "Dante";
        Q25.resposta4 = "Fernando";
        Q25.resposta5 = "Erin";
        Q25.respostacerta = 1;
        Q25.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q25);


        var Q26 = new Questao();
        Q26.Nivel = 3;
        Q26.pergunta = "Quem foi o primerio personagem a enlouquecer?";
        Q26.resposta1 = "Arthur";
        Q26.resposta2 = "Joui";
        Q26.resposta3 = "Dante";
        Q26.resposta4 = "Fernando";
        Q26.resposta5 = "Erin";
        Q26.respostacerta = 5;
        Q26.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q26);


        var Q27 = new Questao();
        Q27.Nivel = 3;
        Q27.pergunta = "Qual o único personagem do Time Kian 'sobreviveu'?";
        Q27.resposta1 = "Rufus";
        Q27.resposta2 = "Damir";
        Q27.resposta3 = "T-bag";
        Q27.resposta4 = "Artemis";
        Q27.resposta5 = "Gal";
        Q27.respostacerta = 2;
        Q27.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q27);


        var Q28 = new Questao();
        Q28.Nivel = 3;
        Q28.pergunta = "Qual personagem morreu em Sdol?";
        Q28.resposta1 = "Chico";
        Q28.resposta2 = "Lírio";
        Q28.resposta3 = "Xande";
        Q28.resposta4 = "Guizo";
        Q28.resposta5 = "Dara";
        Q28.respostacerta = 3;
        Q28.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q28);


        var Q29 = new Questao();
        Q29.Nivel = 3;
        Q29.pergunta = "Qual o nome da filha do Verissimo?";
        Q29.resposta1 = "Joui";
        Q29.resposta2 = "Mia";
        Q29.resposta3 = "Dante";
        Q29.resposta4 = "Fernando";
        Q29.resposta5 = "Arthur";
        Q29.respostacerta = 2;
        Q29.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q29);


        var Q30 = new Questao();
        Q30.Nivel = 3;
        Q30.pergunta = "Quem foi para Tenebris na Temporada de Sdol?";
        Q30.resposta1 = "Guizo";
        Q30.resposta2 = "Dara";
        Q30.resposta3 = "Gal";
        Q30.resposta4 = "Chico";
        Q30.resposta5 = "Lírio";
        Q30.respostacerta = 1;
        Q30.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q30);

        var Q31 = new Questao();
        Q31.Nivel = 3;
        Q31.pergunta = "Qual classe o Xande é?";
        Q31.resposta1 = "Combatente";
        Q31.resposta2 = "Especialista";
        Q31.resposta3 = "Mundano";
        Q31.resposta4 = "Ocultista";
        Q31.resposta5 = "Sobrevivente";
        Q31.respostacerta = 4;
        Q31.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q31);


        var Q32 = new Questao();
        Q32.Nivel = 4;
        Q32.pergunta = "Qual classe o Chico é?";
        Q32.resposta1 = "Combatente";
        Q32.resposta2 = "Especialista";
        Q32.resposta3 = "Mundano";
        Q32.resposta4 = "Ocultista";
        Q32.resposta5 = "Sobrevivente";
        Q32.respostacerta = 2;
        Q32.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q32);


        var Q33 = new Questao();
        Q33.Nivel = 4;
        Q33.pergunta = "Qual classe o Lírio é?";
        Q33.resposta1 = "Combatente";
        Q33.resposta2 = "Especialista";
        Q33.resposta3 = "Mundano";
        Q33.resposta4 = "Ocultista";
        Q33.resposta5 = "Sobrevivente";
        Q33.respostacerta = 1;
        Q33.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q33);


        var Q34 = new Questao();
        Q34.Nivel = 4;
        Q34.pergunta = "Qual classe o Guizo é?";
        Q34.resposta1 = "Combatente";
        Q34.resposta2 = "Especialista";
        Q34.resposta3 = "Mundano";
        Q34.resposta4 = "Ocultista";
        Q34.resposta5 = "Sobrevivente";
        Q34.respostacerta = 4;
        Q34.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q34);


        var Q35 = new Questao();
        Q35.Nivel = 4;
        Q35.pergunta = "Qual classe a Dara é?";
        Q35.resposta1 = "Combatente";
        Q35.resposta2 = "Especialista";
        Q35.resposta3 = "Mundano";
        Q35.resposta4 = "Ocultista";
        Q35.resposta5 = "Sobrevivente";
        Q35.respostacerta = 2;
        Q35.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q35);


        var Q36 = new Questao();
        Q36.Nivel = 4;
        Q36.pergunta = "Qual elemento a Amélie segue?";
        Q36.resposta1 = "sangue";
        Q36.resposta2 = "morte";
        Q36.resposta3 = "conhecimento";
        Q36.resposta4 = "medo";
        Q36.resposta5 = "Energia";
        Q36.respostacerta = 5;
        Q36.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q36);



        var Q37 = new Questao();
        Q37.Nivel = 4;
        Q37.pergunta = "Qual elemento o Milo/Miguel segue?";
        Q37.resposta1 = "sangue";
        Q37.resposta2 = "morte";
        Q37.resposta3 = "conhecimento";
        Q37.resposta4 = "medo";
        Q37.resposta5 = "Energia";
        Q37.respostacerta = 2;
        Q37.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q37);


        var Q38 = new Questao();
        Q38.Nivel = 4;
        Q38.pergunta = "Qual foi o Boss Final de Osni?";
        Q38.resposta1 = "Diabo";
        Q38.resposta2 = "Deus da Morte";
        Q38.resposta3 = "Amigo Imaginario";
        Q38.resposta4 = "Enpap";
        Q38.resposta5 = "Telopsia";
        Q38.respostacerta = 3;
        Q38.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q38);



        var Q39 = new Questao();
        Q39.Nivel = 4;
        Q39.pergunta = "Em OSNI quem teve a primeira experiencia com um quadro?";
        Q39.resposta1 = "Barbara";
        Q39.resposta2 = "Milo";
        Q39.resposta3 = "Olivier";
        Q39.resposta4 = "Amelie";
        Q39.resposta5 = "Wandebas";
        Q39.respostacerta = 4;
        Q39.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q39);


        var Q40 = new Questao();
        Q40.Nivel = 4;
        Q40.pergunta = "Qual player foi o primeiro player a morrer em OSNI?";
        Q40.resposta1 = "Barbara";
        Q40.resposta2 = "Milo";
        Q40.resposta3 = "Olivier";
        Q40.resposta4 = "Amelie";
        Q40.resposta5 = "Wandebas";
        Q40.respostacerta = 1;
        Q40.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q40);


        var Q41 = new Questao();
        Q41.Nivel = 4;
        Q41.pergunta = "Quem saiu vivo de OSNI?";
        Q41.resposta1 = "Barbara e Milo";
        Q41.resposta2 = "Amelie e Olivier";
        Q41.resposta3 = "Wandebas e Milo";
        Q41.resposta4 = "Amelie e Barbara";
        Q41.resposta5 = "Todos";
        Q41.respostacerta = 2;
        Q41.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q41);


        var Q42 = new Questao();
        Q42.Nivel = 5;
        Q42.pergunta = "Quem era o traidor de OSNI?";
        Q42.resposta1 = "Barnabé";
        Q42.resposta2 = "Evandro";
        Q42.resposta3 = "Bisteca";
        Q42.resposta4 = "Livia";
        Q42.resposta5 = "Cavalcante";
        Q42.respostacerta = 1;
        Q42.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q42);


        var Q43 = new Questao();
        Q43.Nivel = 5;
        Q43.pergunta = "Qual era o nome do Gatinho de OSNI?";
        Q43.resposta1 = "File";
        Q43.resposta2 = "Bisteca";
        Q43.resposta3 = "Toicinho";
        Q43.resposta4 = "Listrado";
        Q43.resposta5 = "Pingado";
        Q43.respostacerta = 2;
        Q43.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q43);



        var Q44 = new Questao();
        Q44.Nivel = 5;
        Q44.pergunta = "OSNI se passa em que lugar?";
        Q44.resposta1 = "Trem";
        Q44.resposta2 = "Barco";
        Q44.resposta3 = "Prédio";
        Q44.resposta4 = "Ilha";
        Q44.resposta5 = "Hospital";
        Q44.respostacerta = 4;
        Q44.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q39);


        var Q45 = new Questao();
        Q45.Nivel = 5;
        Q45.pergunta = "Qual o nome da Ilha onde ocorreu OSNI?";
        Q45.resposta1 = "Maldivas";
        Q45.resposta2 = "Hanbel";
        Q45.resposta3 = "Caribe";
        Q45.resposta4 = "Típora";
        Q45.resposta5 = "Coquinhas";
        Q45.respostacerta = 4;
        Q45.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q45);

        var Q46 = new Questao();
        Q46.Nivel = 5;
        Q46.pergunta = "Qual classe a Barbara era?";
        Q46.resposta1 = "Combatente";
        Q46.resposta2 = "Especialista";
        Q46.resposta3 = "Mundano";
        Q46.resposta4 = "Ocultista";
        Q46.resposta5 = "Sobrevivente";
        Q46.respostacerta = 5;
        Q46.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q46);

        var Q47 = new Questao();
        Q47.Nivel = 5;
        Q47.pergunta = "Quem fez uma aparição especial no final de OSNI?";
        Q47.resposta1 = "Henri";
        Q47.resposta2 = "Joui";
        Q47.resposta3 = "Dante";
        Q47.resposta4 = "Fernando";
        Q47.resposta5 = "Arthur";
        Q47.respostacerta = 5;
        Q47.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q47);

        var Q48 = new Questao();
        Q48.Nivel = 5;
        Q48.pergunta = "Em que ano se passa SDOL?";
        Q48.resposta1 = "2022";
        Q48.resposta2 = "2015";
        Q48.resposta3 = "1997";
        Q48.resposta4 = "2000";
        Q48.resposta5 = "1897";
        Q48.respostacerta = 3;
        Q48.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q48);

        var Q49 = new Questao();
        Q49.Nivel = 5;
        Q49.pergunta = "Qual era os principais elementos de SDOL?";
        Q49.resposta1 = "Morte e Sangue";
        Q49.resposta2 = "Energia e Sangue";
        Q49.resposta3 = "Morte e Conhecimento";
        Q49.resposta4 = "Conhecimento e Energia";
        Q49.resposta5 = "Conhecimento e Sangue";
        Q49.respostacerta = 4;
        Q49.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q49);

        var Q50 = new Questao();
        Q50.Nivel = 5;
        Q50.pergunta = "Qual era os principais elementos de OSNI?";
        Q50.resposta1 = "Morte e Sangue";
        Q50.resposta2 = "Energia e Sangue";
        Q50.resposta3 = "Morte e Conhecimento";
        Q50.resposta4 = "Conhecimento e Energia";
        Q50.resposta5 = "Conhecimento e Sangue";
        Q50.respostacerta = 1;
        Q50.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaQuestoes.Add(Q50);





    }

}