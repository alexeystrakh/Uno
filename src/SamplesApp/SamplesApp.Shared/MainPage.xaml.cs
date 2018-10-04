using SamplesApp.Samples.NavigationViewSample;
using SamplesApp.Samples.RoutedEvents;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SamplesApp
{
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
		}

		private void OnNavigationView(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(NavigationViewPage));
		}

		private void OnUnitTests(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(Samples.UnitTests.UnitTestsPage));
		}

		private void OnRoutedEvents(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(RoutedEventsPage));
		}
	}
}
