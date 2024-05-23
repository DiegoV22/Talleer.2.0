namespace Talleer._2._0;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}
    private void IrGridLayoutBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridLayou());
    }
}