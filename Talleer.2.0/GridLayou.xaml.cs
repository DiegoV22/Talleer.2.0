namespace Talleer._2._0;

public partial class GridLayou : ContentPage
{
	public GridLayou()
	{
		InitializeComponent();
	}
    private void IrStack(object sender, EventArgs e)
    {
        Navigation.PushAsync(new StackLayou());
    }
    private void GoToAbsoluteLayoutButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayout());
    }
}