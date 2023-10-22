using TP03;

namespace TP03;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new PackageViewModel();
	}
}

