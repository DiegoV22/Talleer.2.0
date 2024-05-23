namespace Talleer._2._0;

public partial class StackLayou : ContentPage
{
	public StackLayou()
	{
		InitializeComponent();
	}
    private void GoToSFlexLayoutButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayout());
    }


}