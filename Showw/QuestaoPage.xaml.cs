namespace Showw
{
    public partial class QuestaoPage : ContentPage
    {
        Gerenciador gerenciador;
        public QuestaoPage()
        {
            InitializeComponent();
            gerenciador = new Gerenciador(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5, labelPontuacao, labelNivel);
            gerenciador.ProximaPergunta();
        }

        void OnButton1Clicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreto(1);
        }

       
        void  OnButton2Clicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreto(2);
        }

       

       void  OnButton3Clicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreto(3);
        }


       void  OnButton4Clicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreto(4);
        }

        void  OnButton5Clicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreto(5);
        }

    
    }
}