using System.Globalization;

namespace NetMauiLocalizationSample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    

    void HindiToolbarItem_Clicked(System.Object sender, System.EventArgs e)
    {
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hi");
        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hi");
        Application.Current.MainPage = new AppShell();
    }

    void EnglishToolbarItem_Clicked(System.Object sender, System.EventArgs e)
    {
        //get lang as "en"
        string lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
        Application.Current.MainPage = new AppShell();
    }
}


