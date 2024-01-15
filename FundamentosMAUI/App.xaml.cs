namespace FundamentosMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ContentPage()
		{
			Content = new Label() { Text = new NameDevice().GetName() }
		};
	}
}

