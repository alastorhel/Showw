namespace Showw;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void Voltar(object sender, EventArgs e)
	{
		Application.Current.MainPage = new QuestaoPage();
	}
}

