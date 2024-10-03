


namespace Showw;

public class RetiraErrada : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        switch (questao.respostacerta)
        {
            case 1:
                BotaoResposta2.IsVisible = false;
                BotaoResposta3.IsVisible = false;
                BotaoResposta4.IsVisible = false;
                BotaoResposta5.IsVisible = false;
                break;



            case 2:
                BotaoResposta1.IsVisible = false;
                BotaoResposta3.IsVisible = false;
                BotaoResposta4.IsVisible = false;
                BotaoResposta5.IsVisible = false;
                break;

            case 3:
                BotaoResposta1.IsVisible = false;
                BotaoResposta2.IsVisible = false;
                BotaoResposta4.IsVisible = false;
                BotaoResposta5.IsVisible = false;
                break;

            case 4:
                BotaoResposta1.IsVisible = false;
                BotaoResposta2.IsVisible = false;
                BotaoResposta3.IsVisible = false;
                BotaoResposta5.IsVisible = false;
                break;

            case 5:
                BotaoResposta1.IsVisible = false;
                BotaoResposta2.IsVisible = false;
                BotaoResposta3.IsVisible = false;
                BotaoResposta4.IsVisible = false;
                break;


        }
    }

    
}