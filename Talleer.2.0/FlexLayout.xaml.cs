namespace Talleer._2._0;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}
    private async void OnImageTapped(object sender, EventArgs e)
    {
        // Navegar a la p�gina AbsoluteLayout
        await Navigation.PushAsync(new AbsoluteLayout());
    }
}