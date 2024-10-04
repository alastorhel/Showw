namespace Showw
{
public class Universitarios : IAjuda
{
        public override void RealizaAjuda(Questao questao)
        {
           var porcentagem = 100;
           for (int i = 0; i < 5; i ++)
           {
            int numeroRandomico = 0;
            if (porcentagem > 0)
            {
                numeroRandomico = Random.Shared.Next(0, porcentagem);
                porcentagem -= numeroRandomico;
                
            }
            switch(i)
            {
                case 0:
                BotaoResposta1.Text += "-" + numeroRandomico.ToString() + "%";
                break;

                case 1:
                BotaoResposta2.Text += "-" + numeroRandomico.ToString() + "%";
                break;

                
                case 2:
                BotaoResposta3.Text += "-" + numeroRandomico.ToString() + "%";
                break;

                case 3:
                BotaoResposta4.Text += "-" + numeroRandomico.ToString() + "%";
                break;

                case 4:
                BotaoResposta5.Text += "-" + numeroRandomico.ToString() + "%";
                break;
            }
           }
        }
    }
}