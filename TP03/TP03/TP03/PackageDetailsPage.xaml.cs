using TP03;

namespace TP03;

public partial class PackageDetailsPage : ContentPage
{
    public PackageDetailsPage(Package package)
    {
        InitializeComponent();
        BindingContext = package;
    }

}