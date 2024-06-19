namespace FlipCoin.Views;

using FlipCoin.ViewModel;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
		BindingContext = new FlipViewModel();
	}
}