namespace Uno53;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        SwappableLayoutsItemsView.ItemsSource = CustomDataObject.GetDataObjects(true);
    }
}
