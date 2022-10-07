using System.Collections.ObjectModel;

namespace MauApp;

public partial class MaPage : ContentPage
{
	public MaPage()
	{
		InitializeComponent();
        SocialMedias = new ObservableCollection<SocialMedia>
        {
            new SocialMedia() { Name = "Facebook", ID = 0 },
            new SocialMedia() { Name = "Google Plus", ID = 1 }
        };
    }
    public ObservableCollection<SocialMedia> SocialMedias { get; set; } = new ObservableCollection<SocialMedia>();
}

public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}
