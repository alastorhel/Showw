namespace Showw
{
    public partial class Questao1 : ContentPage
    {
        Gerenciador gerenciador;
        public Questao1()
        {
            InitializeComponent();
            gerenciador = new Gerenciador(labelPergunta, BotaoResposta1,  BotaoResposta2,  BotaoResposta3,  BotaoResposta4,  BotaoResposta5);
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