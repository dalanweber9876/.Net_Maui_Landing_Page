﻿namespace ChessApp;

public partial class LandingPage : ContentPage
{

    public LandingPage()
	{
		InitializeComponent();
	}

    private async void OnCounterClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void OpenSettings(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SettingsPage());
    }
}
