


using System.Security.Cryptography.X509Certificates;

namespace Showw;



public class Gerenciador
{
    List<Questao> ListaTodasQuestoes = new List<Questao>();
    List<Questao> ListaTodasQuestoesRespondidas = new List<Questao>();
    public Questao novaQuestao;

    Label labelPontuacao;
    Label labelNivel;


    public Gerenciador(Label labelPergunta, Button BotaoResposta1, Button BotaoResposta2, Button BotaoResposta3, Button BotaoResposta4, Button BotaoResposta5, Label labelPontuacao, Label labelNivel)
    {
        CriarQuestoes(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        this.labelPontuacao = labelPontuacao;
        this.labelNivel = labelNivel;

    
    }

    public Questao GetQuestaoCorrente()
    {
        return Questao.Corrente;
    }

    public async void VerificaCorreto(int resposta)
    {



        if (novaQuestao!.VerificarResposta(resposta))
        {
            await Task.Delay(1500);
            AdicionaPontucao(NivelAtual);
            NivelAtual++;
            ProximaPergunta();
            labelPontuacao.Text = "Pontuação:R$" + Pontuacao.ToString();
            labelNivel.Text = "Nivel" + NivelAtual.ToString();

            if (NivelAtual == 10)
            {
                Application.Current.MainPage = new MainPage();
            }

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
    int NivelAtual = 1;

    void Inicializar()
    {

        Pontuacao = 0;
        NivelAtual = 1;
        ListaTodasQuestoesRespondidas.Clear();
        ProximaPergunta();
        labelPontuacao.Text = "Pontuação:R$" + Pontuacao.ToString();
        labelNivel.Text = "Nivel" + NivelAtual.ToString();

    }

    

    public void ProximaPergunta()
    {
        var ListaQuestoes = ListaTodasQuestoes.Where(d => d.Nivel == NivelAtual).ToList();
        var numRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);

        novaQuestao = ListaQuestoes[numRandomico];

        while (ListaTodasQuestoesRespondidas.Contains(novaQuestao))
        {
            numRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);
            novaQuestao = ListaQuestoes[numRandomico];
        }

        ListaTodasQuestoesRespondidas.Add(novaQuestao);

        novaQuestao.Desenhar();
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

        ListaTodasQuestoes.Add(Q1);

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

        ListaTodasQuestoes.Add(Q2);

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

        ListaTodasQuestoes.Add(Q4);

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

        ListaTodasQuestoes.Add(Q5);

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

        ListaTodasQuestoes.Add(Q6);

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

        ListaTodasQuestoes.Add(Q7);

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

        ListaTodasQuestoes.Add(Q8);


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

        ListaTodasQuestoes.Add(Q9);

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

        ListaTodasQuestoes.Add(Q10);


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

        ListaTodasQuestoes.Add(Q11);



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

        ListaTodasQuestoes.Add(Q12);



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

        ListaTodasQuestoes.Add(Q13);

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

        ListaTodasQuestoes.Add(Q14);

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

        ListaTodasQuestoes.Add(Q15);

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

        ListaTodasQuestoes.Add(Q16);

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

        ListaTodasQuestoes.Add(Q17);

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

        ListaTodasQuestoes.Add(Q18);

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

        ListaTodasQuestoes.Add(Q19);

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

        ListaTodasQuestoes.Add(Q20);


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

        ListaTodasQuestoes.Add(Q21);

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

        ListaTodasQuestoes.Add(Q22);


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

        ListaTodasQuestoes.Add(Q23);



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

        ListaTodasQuestoes.Add(Q24);



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

        ListaTodasQuestoes.Add(Q25);


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

        ListaTodasQuestoes.Add(Q26);


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

        ListaTodasQuestoes.Add(Q27);


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

        ListaTodasQuestoes.Add(Q28);


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

        ListaTodasQuestoes.Add(Q29);


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

        ListaTodasQuestoes.Add(Q30);

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

        ListaTodasQuestoes.Add(Q31);


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

        ListaTodasQuestoes.Add(Q32);


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

        ListaTodasQuestoes.Add(Q33);


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

        ListaTodasQuestoes.Add(Q34);


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

        ListaTodasQuestoes.Add(Q35);


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

        ListaTodasQuestoes.Add(Q36);



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

        ListaTodasQuestoes.Add(Q37);


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

        ListaTodasQuestoes.Add(Q38);



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

        ListaTodasQuestoes.Add(Q39);


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

        ListaTodasQuestoes.Add(Q40);


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

        ListaTodasQuestoes.Add(Q41);


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

        ListaTodasQuestoes.Add(Q42);


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

        ListaTodasQuestoes.Add(Q43);



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

        ListaTodasQuestoes.Add(Q39);


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

        ListaTodasQuestoes.Add(Q45);

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

        ListaTodasQuestoes.Add(Q46);

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

        ListaTodasQuestoes.Add(Q47);

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

        ListaTodasQuestoes.Add(Q48);

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

        ListaTodasQuestoes.Add(Q49);

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

        ListaTodasQuestoes.Add(Q50);


        var Q51 = new Questao();
        Q51.Nivel = 5;
        Q51.pergunta = "Quantas temporadas tem Ordem Paranormal?";
        Q51.resposta1 = "3";
        Q51.resposta2 = "4";
        Q51.resposta3 = "5";
        Q51.resposta4 = "2";
        Q51.resposta5 = "7";
        Q51.respostacerta = 5;
        Q51.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q51);

        var Q52 = new Questao();
        Q52.Nivel = 6;
        Q52.pergunta = "Quem era a Degolificada?";
        Q52.resposta1 = "Agatha";
        Q52.resposta2 = "Gabriel";
        Q52.resposta3 = "Liz";
        Q52.resposta4 = "Daniel";
        Q52.resposta5 = "Alex";
        Q52.respostacerta = 2;
        Q52.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q52);

        var Q53 = new Questao();
        Q53.Nivel = 6;
        Q53.pergunta = "Qual era o nome do Orfanato de Ordem";
        Q53.resposta1 = "SantaMegaFreira";
        Q53.resposta2 = "SantoBerço";
        Q53.resposta3 = "SantaMeneFreda";
        Q53.resposta4 = "Universal";
        Q53.resposta5 = "Adventista";
        Q53.respostacerta = 3;
        Q53.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q53);

        var Q54 = new Questao();
        Q54.Nivel = 6;
        Q54.pergunta = "Qual monstro era o Padre do Orfanato?";
        Q54.resposta1 = "Enpap";
        Q54.resposta2 = "Mulher Afogada";
        Q54.resposta3 = "Sukal";
        Q54.resposta4 = "Zumbi de Sangue";
        Q54.resposta5 = "Telopsia";
        Q54.respostacerta = 1;
        Q54.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q54);

        var Q55 = new Questao();
        Q55.Nivel = 6;
        Q55.pergunta = "Qual monstro era a Freira do Orfanato";
        Q55.resposta1 = "Enpap";
        Q55.resposta2 = "Mulher Afogada";
        Q55.resposta3 = "Sukal";
        Q55.resposta4 = "Zumbi de Sangue";
        Q55.resposta5 = "Telopsia";
        Q55.respostacerta = 3;
        Q55.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q55);

        var Q56 = new Questao();
        Q56.Nivel = 6;
        Q56.pergunta = "Qual o nome da criança que foi amarrada a Leonardo Gomes?";
        Q56.resposta1 = "Eduarda";
        Q56.resposta2 = "Hugo";
        Q56.resposta3 = "Fernando";
        Q56.resposta4 = "Tim";
        Q56.resposta5 = "Rogerio";
        Q56.respostacerta = 4;
        Q56.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q56);

        var Q57 = new Questao();
        Q57.Nivel = 6;
        Q57.pergunta = "Qual era nome da amada de Dante";
        Q57.resposta1 = "Beatrice";
        Q57.resposta2 = "Liz";
        Q57.resposta3 = "Erin";
        Q57.resposta4 = "Artemis";
        Q57.resposta5 = "Jasmin";
        Q57.respostacerta = 5;
        Q57.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q57);


        var Q58 = new Questao();
        Q58.Nivel = 6;
        Q58.pergunta = "Quem foi o Boss Final de Calamidade";
        Q58.resposta1 = "Deus da Morte";
        Q58.resposta2 = "Magistrada";
        Q58.resposta3 = "Kian";
        Q58.resposta4 = "Anfitriao";
        Q58.resposta5 = "Diabo";
        Q58.respostacerta = 3;
        Q58.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q58);

        var Q59 = new Questao();
        Q59.Nivel = 6;
        Q59.pergunta = "Qual elemento suplanta o elemento de Morte?";
        Q59.resposta1 = "Sangue";
        Q59.resposta2 = "Energia";
        Q59.resposta3 = "Medo";
        Q59.resposta4 = "conhecimento";
        Q59.resposta5 = "Morte";
        Q59.respostacerta = 2;
        Q59.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q59);


        var Q60 = new Questao();
        Q60.Nivel = 6;
        Q60.pergunta = "Quem tirou um braço de Gal?";
        Q60.resposta1 = "Arthur";
        Q60.resposta2 = "Kian";
        Q60.resposta3 = "Dante";
        Q60.resposta4 = "Carina";
        Q60.resposta5 = "Joui";
        Q60.respostacerta = 5;
        Q60.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q60);



        var Q61 = new Questao();
        Q61.Nivel = 6;
        Q61.pergunta = "Qual o nome do amigo do Rubens?";
        Q61.resposta1 = "Joui ";
        Q61.resposta2 = "Jhonny Tabasco";
        Q61.resposta3 = "Arnaldo Frits";
        Q61.resposta4 = "Verissimo";
        Q61.resposta5 = "Balu";
        Q61.respostacerta = 2;
        Q61.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q61);



        var Q62 = new Questao();
        Q62.Nivel = 7;
        Q62.pergunta = "Qual nome do filho(a) de Arnaldo ?";
        Q62.resposta1 = "Beatrice ";
        Q62.resposta2 = "Liz Hebber";
        Q62.resposta3 = "Joui Jouki";
        Q62.resposta4 = "Arthur Cevero";
        Q62.resposta5 = "Thiago Frits";
        Q62.respostacerta = 5;
        Q62.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q62);

        var Q63 = new Questao();
        Q63.Nivel = 7;
        Q63.pergunta = "O que tinha no bolso de Arnaldo quando adiquiriu a reliquia de Energia?";
        Q63.resposta1 = "Uma Pulseira";
        Q63.resposta2 = "Um Relógio";
        Q63.resposta3 = "Uma carta";
        Q63.resposta4 = "Uma Faca";
        Q63.resposta5 = "Um Sigilo";
        Q63.respostacerta = 2;
        Q63.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q63);

        var Q64 = new Questao();
        Q64.Nivel = 7;
        Q64.pergunta = "Onde se passa a Temporada de Calamidade";
        Q64.resposta1 = "Itália";
        Q64.resposta2 = "Brasil";
        Q64.resposta3 = "Alemanha";
        Q64.resposta4 = "Japão";
        Q64.resposta5 = "França";
        Q64.respostacerta = 1;
        Q64.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q64);

        var Q65 = new Questao();
        Q65.Nivel = 7;
        Q65.pergunta = "Qual o nome da  Família da Carina";
        Q65.resposta1 = "Os Arghents";
        Q65.resposta2 = "Os Wolfs";
        Q65.resposta3 = "Os Carvalhos";
        Q65.resposta4 = "Os Leones";
        Q65.resposta5 = "Os Truines";
        Q65.respostacerta = 4;
        Q65.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q65);

        var Q66 = new Questao();
        Q66.Nivel = 7;
        Q66.pergunta = "Qual era o nome do 'filho(a)' de Gal?";
        Q66.resposta1 = "Arthur ";
        Q66.resposta2 = "Clarissa";
        Q66.resposta3 = "Dagan";
        Q66.resposta4 = "Carina";
        Q66.resposta5 = "Damir";
        Q66.respostacerta = 3;
        Q66.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q66);

        var Q67 = new Questao();
        Q67.Nivel = 7;
        Q67.pergunta = "Quem traiu a Ordem e Calamidade?";
        Q67.resposta1 = "Fernando";
        Q67.resposta2 = "Clarissa";
        Q67.resposta3 = "Dante";
        Q67.resposta4 = "Luciano";
        Q67.resposta5 = "Carina";
        Q67.respostacerta = 2;
        Q67.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q67);

        var Q68 = new Questao();
        Q68.Nivel = 7;
        Q68.pergunta = "Qual foi o primeiro boss de Calamidade?";
        Q68.resposta1 = "Amigo Imaginario";
        Q68.resposta2 = "Enpap";
        Q68.resposta3 = "Carente";
        Q68.resposta4 = "Sukal";
        Q68.resposta5 = "Zumbi de Sangue";
        Q68.respostacerta = 3;
        Q68.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q68);

        var Q69 = new Questao();
        Q69.Nivel = 7;
        Q69.pergunta = "Quem foi o primeiro player a morrer em Quarentena?";
        Q69.resposta1 = "Diego Thalles";
        Q69.resposta2 = "Jeffrey Bacon";
        Q69.resposta3 = "Luis M.";
        Q69.resposta4 = "Dr.Benito Camelo";
        Q69.resposta5 = "Lucie Pocharde";
        Q69.respostacerta = 5;
        Q69.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q69);

        var Q70 = new Questao();
        Q70.Nivel = 7;
        Q70.pergunta = "Que monstro matou a Lucie?";
        Q70.resposta1 = "Infecticidio";
        Q70.resposta2 = "Nidere";
        Q70.resposta3 = "Ceifador Espiral";
        Q70.resposta4 = "Sukal";
        Q70.resposta5 = "Zumbi de Sangue";
        Q70.respostacerta = 2;
        Q70.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q70);

        var Q71 = new Questao();
        Q71.Nivel = 7;
        Q71.pergunta = "Qual o monstro que estava preso nas intalações do laboratoria na Antartica?";
        Q71.resposta1 = "Infecticidio";
        Q71.resposta2 = "Nidere";
        Q71.resposta3 = "Ceifador Espiral";
        Q71.resposta4 = "Sukal";
        Q71.resposta5 = "Zumbi de Sangue";
        Q71.respostacerta = 1;
        Q71.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q71);

        var Q72 = new Questao();
        Q72.Nivel = 8;
        Q72.pergunta = "Qual foi o nome dado para a mansão de Desconjuração?";
        Q72.resposta1 = "Mansão Assombrada";
        Q72.resposta2 = "Mansão Encapetada";
        Q72.resposta3 = "Mansão Santificada";
        Q72.resposta4 = "Mansão Endiabrada";
        Q72.resposta5 = "Mansão Enjuriada";
        Q72.respostacerta = 4;
        Q72.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q72);

        var Q73 = new Questao();
        Q73.Nivel = 8;
        Q73.pergunta = "Quem foi o primeiro a morrer na Mansão Endiabrada?";
        Q73.resposta1 = "Beatrcie";
        Q73.resposta2 = "Trsitan";
        Q73.resposta3 = "Tim";
        Q73.resposta4 = "Eduarda";
        Q73.resposta5 = "Luciano";
        Q73.respostacerta = 2;
        Q73.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q73);

        var Q74 = new Questao();
        Q74.Nivel = 8;
        Q74.pergunta = "Em qual sentido que o Dante perdeu por conta do paranormal?";
        Q74.resposta1 = "Tato";
        Q74.resposta2 = "Paladar";
        Q74.resposta3 = "Olfato";
        Q74.resposta4 = "Visão";
        Q74.resposta5 = "Audição";
        Q74.respostacerta = 4;
        Q74.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q74);

        var Q75 = new Questao();
        Q75.Nivel = 8;
        Q75.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q75.resposta1 = "Kaiser";
        Q75.resposta2 = "Joui";
        Q75.resposta3 = "Arthur ";
        Q75.resposta4 = "Dante";
        Q75.resposta5 = "Erin";
        Q75.respostacerta = 1;
        Q75.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q75);

        var Q76 = new Questao();
        Q76.Nivel = 8;
        Q76.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q76.resposta1 = "Kaiser";
        Q76.resposta2 = "Joui";
        Q76.resposta3 = "Arthur";
        Q76.resposta4 = "Dante";
        Q76.resposta5 = "Erin";
        Q76.respostacerta = 1;
        Q76.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q76);



        var Q77 = new Questao();
        Q77.Nivel = 8;
        Q77.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q77.resposta1 = "Kaiser";
        Q77.resposta2 = "Joui";
        Q77.resposta3 = "Arthur";
        Q77.resposta4 = "Dante";
        Q77.resposta5 = "Erin";
        Q77.respostacerta = 1;
        Q77.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q77);




        var Q78 = new Questao();
        Q78.Nivel = 8;
        Q78.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q78.resposta1 = "Kaiser";
        Q78.resposta2 = "Joui";
        Q78.resposta3 = "Arthur";
        Q78.resposta4 = "Dante";
        Q78.resposta5 = "Erin";
        Q78.respostacerta = 1;
        Q78.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q78);




        var Q79 = new Questao();
        Q79.Nivel = 8;
        Q79.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q79.resposta1 = "Kaiser";
        Q79.resposta2 = "Joui";
        Q79.resposta3 = "Arthur";
        Q79.resposta4 = "Dante";
        Q79.resposta5 = "Erin";
        Q79.respostacerta = 1;
        Q79.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q79);



        var Q80 = new Questao();
        Q80.Nivel = 8;
        Q80.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q80.resposta1 = "Kaiser";
        Q80.resposta2 = "Joui";
        Q80.resposta3 = "Arthur";
        Q80.resposta4 = "Dante";
        Q80.resposta5 = "Erin";
        Q80.respostacerta = 1;
        Q80.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q80);




        var Q81 = new Questao();
        Q81.Nivel = 8;
        Q81.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q81.resposta1 = "Kaiser";
        Q81.resposta2 = "Joui";
        Q81.resposta3 = "Arthur";
        Q81.resposta4 = "Dante";
        Q81.resposta5 = "Erin";
        Q81.respostacerta = 1;
        Q81.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q81);




        var Q82 = new Questao();
        Q82.Nivel = 9;
        Q82.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q82.resposta1 = "Kaiser";
        Q82.resposta2 = "Joui";
        Q82.resposta3 = "Arthur";
        Q82.resposta4 = "Dante";
        Q82.resposta5 = "Erin";
        Q82.respostacerta = 1;
        Q82.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q82);




        var Q83 = new Questao();
        Q83.Nivel = 9;
        Q83.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q83.resposta1 = "Kaiser";
        Q83.resposta2 = "Joui";
        Q83.resposta3 = "Arthur";
        Q83.resposta4 = "Dante";
        Q83.resposta5 = "Erin";
        Q83.respostacerta = 1;
        Q83.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q83);

        var Q84 = new Questao();
        Q84.Nivel = 9;
        Q84.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q84.resposta1 = "Kaiser";
        Q84.resposta2 = "Joui";
        Q84.resposta3 = "Arthur";
        Q84.resposta4 = "Daante";
        Q84.resposta5 = "Erin";
        Q84.respostacerta = 1;
        Q84.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q84);

        var Q85 = new Questao();
        Q85.Nivel = 9;
        Q85.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q85.resposta1 = "Kaiser";
        Q85.resposta2 = "Joui";
        Q85.resposta3 = "Arthur";
        Q85.resposta4 = "Dante";
        Q85.resposta5 = "Erin";
        Q85.respostacerta = 1;
        Q85.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q85);

        var Q86 = new Questao();
        Q86.Nivel = 9;
        Q86.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q86.resposta1 = "Kaiser";
        Q86.resposta2 = "Joui";
        Q86.resposta3 = "Arthur";
        Q86.resposta4 = "Dante";
        Q86.resposta5 = "Erin";
        Q86.respostacerta = 1;
        Q86.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q86);


        var Q87 = new Questao();
        Q87.Nivel = 9;
        Q87.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q87.resposta1 = "Kaiser";
        Q87.resposta2 = "Joui";
        Q87.resposta3 = "Arthur";
        Q87.resposta4 = "Dante";
        Q87.resposta5 = "Erin";
        Q87.respostacerta = 1;
        Q87.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q87);

        var Q88 = new Questao();
        Q88.Nivel = 9;
        Q88.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q88.resposta1 = "Kaiser";
        Q88.resposta2 = "Joui";
        Q88.resposta3 = "Arthur";
        Q88.resposta4 = "Dante";
        Q88.resposta5 = "Erin";
        Q88.respostacerta = 1;
        Q88.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q88);

        var Q89 = new Questao();
        Q89.Nivel = 9;
        Q89.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q89.resposta1 = "Kaiser";
        Q89.resposta2 = "Joui";
        Q89.resposta3 = "Arthur";
        Q89.resposta4 = "Dante";
        Q89.resposta5 = "Erin";
        Q89.respostacerta = 1;
        Q89.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q89);


        var Q90 = new Questao();
        Q90.Nivel = 9;
        Q90.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q90.resposta1 = "Kaiser";
        Q90.resposta2 = "Joui";
        Q90.resposta3 = "Arthur";
        Q90.resposta4 = "Dante";
        Q90.resposta5 = "Erin";
        Q90.respostacerta = 1;
        Q90.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q90);


        var Q91 = new Questao();
        Q91.Nivel = 9;
        Q91.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q91.resposta1 = "Kaiser";
        Q91.resposta2 = "Joui";
        Q91.resposta3 = "Arthur";
        Q91.resposta4 = "Dante";
        Q91.resposta5 = "Erin";
        Q91.respostacerta = 1;
        Q91.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q91);


        var Q92 = new Questao();
        Q92.Nivel = 10;
        Q92.pergunta = "Que personagem disse 'CINÉRARIA'";
        Q92.resposta1 = "Kaiser";
        Q92.resposta2 = "Joui";
        Q92.resposta3 = "Arthur";
        Q92.resposta4 = "Dante";
        Q92.resposta5 = "Erin";
        Q92.respostacerta = 1;
        Q92.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);

        ListaTodasQuestoes.Add(Q92);



        var Q93 = new Questao();
        Q93.Nivel = 10;
        Q93.pergunta = "Qual a capital da França?";
        Q93.resposta1 = "Berlim";
        Q93.resposta2 = "Madrid";
        Q93.resposta3 = "Paris";
        Q93.resposta4 = "Lisboa";
        Q93.resposta5 = "Roma";
        Q93.respostacerta = 3;
        Q93.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListaTodasQuestoes.Add(Q93);

        var Q94 = new Questao();
        Q94.Nivel = 10;
        Q94.pergunta = "Qual é o maior planeta do sistema solar?";
        Q94.resposta1 = "Terra";
        Q94.resposta2 = "Marte";
        Q94.resposta3 = "Júpiter";
        Q94.resposta4 = "Saturno";
        Q94.resposta5 = "Netuno";
        Q94.respostacerta = 3;
        Q94.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListaTodasQuestoes.Add(Q94);

        var Q95 = new Questao();
        Q95.Nivel = 10;
        Q95.pergunta = "Qual o elemento químico com símbolo 'O'?";
        Q95.resposta1 = "Ouro";
        Q95.resposta2 = "Oxigênio";
        Q95.resposta3 = "Prata";
        Q95.resposta4 = "Água";
        Q95.resposta5 = "Ferro";
        Q95.respostacerta = 2;
        Q95.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListaTodasQuestoes.Add(Q95);

        var Q96 = new Questao();
        Q96.Nivel = 10;
        Q96.pergunta = "Quem escreveu 'Dom Casmurro'?";
        Q96.resposta1 = "Machado de Assis";
        Q96.resposta2 = "Joaquim Maria Machado";
        Q96.resposta3 = "Clarice Lispector";
        Q96.resposta4 = "José de Alencar";
        Q96.resposta5 = "Graciliano Ramos";
        Q96.respostacerta = 1;
        Q96.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListaTodasQuestoes.Add(Q96);

        var Q97 = new Questao();
        Q97.Nivel = 10;
        Q97.pergunta = "Qual é o oceano mais profundo do mundo?";
        Q97.resposta1 = "Atlântico";
        Q97.resposta2 = "Índico";
        Q97.resposta3 = "Pacífico";
        Q97.resposta4 = "Ártico";
        Q97.resposta5 = "Antártico";
        Q97.respostacerta = 3;
        Q97.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListaTodasQuestoes.Add(Q97);

        var Q98 = new Questao();
        Q98.Nivel = 10;
        Q98.pergunta = "Qual a fórmula da água?";
        Q98.resposta1 = "CO2";
        Q98.resposta2 = "H2O";
        Q98.resposta3 = "NaCl";
        Q98.resposta4 = "C6H12O6";
        Q98.resposta5 = "H2SO4";
        Q98.respostacerta = 2;
        Q98.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListaTodasQuestoes.Add(Q98);

        var Q99 = new Questao();
        Q99.Nivel = 10;
        Q99.pergunta = "Qual o maior animal terrestre?";
        Q99.resposta1 = "Elefante";
        Q99.resposta2 = "Girafa";
        Q99.resposta3 = "Rinoceronte";
        Q99.resposta4 = "Hipopótamo";
        Q99.resposta5 = "Baleia Azul";
        Q99.respostacerta = 1;
        Q99.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListaTodasQuestoes.Add(Q99);

        var Q100 = new Questao();
        Q100.Nivel = 10;
        Q100.pergunta = "Qual é a capital do Brasil?";
        Q100.resposta1 = "São Paulo";
        Q100.resposta2 = "Brasília";
        Q100.resposta3 = "Rio de Janeiro";
        Q100.resposta4 = "Salvador";
        Q100.resposta5 = "Fortaleza";
        Q100.respostacerta = 2;
        Q100.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListaTodasQuestoes.Add(Q100);


        var Q101 = new Questao();
        Q101.Nivel = 10;
        Q101.pergunta = "Qual é a capital do Brasil?";
        Q101.resposta1 = "São Paulo";
        Q101.resposta2 = "Brasília";
        Q101.resposta3 = "Rio de Janeiro";
        Q101.resposta4 = "Salvador";
        Q101.resposta5 = "Fortaleza";
        Q101.respostacerta = 2;
        Q101.ConfigurarEstruturaDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListaTodasQuestoes.Add(Q101);

     


    }

   
}