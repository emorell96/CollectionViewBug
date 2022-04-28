using System.Collections.ObjectModel;

namespace MauiApp2;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		BindingContext = this;
		InitializeComponent();
	}
	public ObservableCollection<TestItem> Items { get; } = new ObservableCollection<TestItem>();
	private async void OnCounterClicked(object sender, EventArgs e)
	{
		Items.Clear();
		for(int i = 0; i < 10; i++)
        {
			//remove this and you will see it bug out too.
			await Task.Delay(10);
			Items.Add(new TestItem
			{
				Name = $"Test Item {i}",
				Description = "Description"
			});
		}
		
	}
}

public class TestItem
{
	public string Name { get; set; }
	public string Description { get; set; }
}

