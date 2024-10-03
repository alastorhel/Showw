namespace Showw;

public abstract class IAjuda
{
    protected Button BotaoResposta1;
    protected Button BotaoResposta2;
    protected Button BotaoResposta3;
    protected Button BotaoResposta4;
    protected Button BotaoResposta5;
    protected Frame frameAjuda;

    public void ConfiguraDesenho(Button BotaoResposta1, Button BotaoResposta2, Button BotaoResposta3, Button BotaoResposta4, Button BotaoResposta5)
    {
        this.BotaoResposta1 = BotaoResposta1;
        this.BotaoResposta2 = BotaoResposta2;
        this.BotaoResposta3 = BotaoResposta3;
        this.BotaoResposta4 = BotaoResposta4;
        this.BotaoResposta5 = BotaoResposta5;
    }

    public void ConfiguraDesenho(Frame frameAjuda)
    {
        this.frameAjuda = frameAjuda;
    }

    public abstract void RealizaAjuda(Questao questao);

}