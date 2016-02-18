using System;

using Xamarin.Forms;

namespace HelloWorld
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application

			FormattedString formattedString = new FormattedString();
			formattedString.Spans.Add(new Span
				{
					Text = "I "
				});
			formattedString.Spans.Add(new Span
				{
					Text = "love",
					FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
					FontAttributes = FontAttributes.Bold
				});
			formattedString.Spans.Add(new Span
				{
					Text = " Xamarin.Forms!"
				});
			
			MainPage = new ContentPage {
				Content = new Label {
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
					FormattedText = formattedString,
					//Text = "Welcome to Xamarin Forms!",
					//BackgroundColor = Color.Yellow,
					//FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
					//FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
					//TextColor = Color.Blue
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

