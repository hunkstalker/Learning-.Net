﻿using Tasker.MAUI.MVVM.Views;

namespace Tasker.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainView());
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		Window window = base.CreateWindow(activationState);

		window.Height = 760;
		window.Width = 480;

		return window;
	}
}
