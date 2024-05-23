using Microsoft.Maui.Controls;

namespace Talleer._2._0
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

        }


        private void GoToStackLayoutButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayou());
        }
        
        
        private void GoToGridLayoutButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayou());
        }
    }

}
