
namespace Showw
{
    public partial class QuestaoPage : ContentPage
    {
        Gerenciador gerenciador;

        public object S { get; private set; }



        public QuestaoPage()
        {
            InitializeComponent();
            gerenciador = new Gerenciador(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5, labelPontuacao, labelNivel);
            gerenciador.ProximaPergunta();
        }

        void OnButton1Clicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreto(1);
        }


        void OnButton2Clicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreto(2);
        }



        void OnButton3Clicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreto(3);
        }


        void OnButton4Clicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreto(4);
        }

        void OnButton5Clicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreto(5);
        }

        void Jinx(object sender, EventArgs args)
        {
            var a = new RetiraErrada();
            a.ConfiguraDesenho(BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
            a.RealizaAjuda(gerenciador.novaQuestao);
            coisa2.IsVisible = false;
        }

        int pulou = 0;
        void Vitrius(object sender, EventArgs args)
        {
             if (pulou == 0)
                (sender as Button).IsVisible = false;

            else
            {
                gerenciador.ProximaPergunta();
                pulou++;
            }
        }


            int pulou1 = 1;
            void Vitrius1(object sender, EventArgs args)
            {
                  if (pulou1 == 1)
                    (sender as Button).IsVisible = false;

                else
                {
                    gerenciador.ProximaPergunta();
                    pulou1++;
                }
            }

                

                int pulou2 = 2;
                void Vitrius2(object sender, EventArgs args)
                {

                    if (pulou2 == 2)
                        (sender as Button).IsVisible = false;

                    else
                    {
                        gerenciador.ProximaPergunta();
                        pulou2++;
                    }
                }




            

            void Lucy(object sender, EventArgs args)
            {
                var a = new Universitarios();
                a.ConfiguraDesenho(BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
                a.RealizaAjuda(gerenciador.novaQuestao);
                coisa1.IsVisible = false;
            }


        }
    }
