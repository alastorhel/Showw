namespace Showw;



public class Questao
{

    public string pergunta;

    public string resposta1;

    public string resposta2;

    public string resposta3;

    public string resposta4;

    public string resposta5;

    public int respostacerta;

    public int nivel;

    Label labelpergunta;

    Button buttonResposta1;

    Button buttonResposta2;

    Button buttonResposta3;

    Button buttonResposta4;

    Button buttonResposta5;


    public void Desenhar()
    {
        labelpergunta.Text = pergunta;
        buttonResposta1.Text = resposta1;
        buttonResposta2.Text = resposta2;
        buttonResposta3.Text = resposta3;
        buttonResposta4.Text = resposta4;
        buttonResposta5.Text = resposta5;
    }

    public bool VerificarResposta(int respostaescolhida)
    {
        if (respostacerta == respostaescolhida)
        {
            var coisa = QualBotaoescolhido(respostaescolhida);
            coisa.BackgroundColor = Colors.Green;
            return true;
        }
        else
        {

            var coisaCorreto = QualBotaoescolhido(respostacerta);
            var coisaIncorreta = QualBotaoescolhido(respostaescolhida);
            coisaCorreto.BackgroundColor = Colors.Yellow;
            coisaIncorreta.BackgroundColor = Colors.Red;
            return false;

        }
    }

    public void ConfigurarEstruturaDesenho(Label pergunta, Button resposta1, Button resposta2, Button resposta3, Button resposta4, Button resposta5)
    {
        labelpergunta = pergunta;
        buttonResposta1 = resposta1;
        buttonResposta2 = resposta2;
        buttonResposta3 = resposta3;
        buttonResposta4 = resposta4;
        buttonResposta5 = resposta5;
    }

    public Questao(int respostaescolhida)
    {
        respostacerta = respostaescolhida;
    }

    public Questao(Label pergunta, Button resposta1, Button resposta2, Button resposta3, Button resposta4, Button resposta5)
    {
        labelpergunta = pergunta;
        buttonResposta1 = resposta1;
        buttonResposta2 = resposta2;
        buttonResposta3 = resposta3;
        buttonResposta4 = resposta4;
        buttonResposta5 = resposta5;

    }

    private Button QualBotaoescolhido(int respostaescolhida)
    {
        if (respostaescolhida == 1)
            return buttonResposta1;
        else if (respostaescolhida == 2)
            return buttonResposta2;
        else if (respostaescolhida == 3)
            return buttonResposta3;
        else if (respostaescolhida == 4)
            return buttonResposta4;
        else if (respostaescolhida == 5)
            return buttonResposta5;
        else 
                return null;
    }
}