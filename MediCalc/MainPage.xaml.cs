using System.Windows;
using Microsoft.Phone.Controls;
using System;

namespace MediCalc
{
	public partial class MainPage : PhoneApplicationPage
	{
		// Constructor
		public MainPage()
		{
			InitializeComponent();

			// Set the data context of the listbox control to the sample data
			DataContext = App.ViewModel;
			this.Loaded += new RoutedEventHandler(MainPage_Loaded);
		}

		// Load data for the ViewModel Items
		private void MainPage_Loaded(object sender, RoutedEventArgs e)
		{
			if (!App.ViewModel.IsDataLoaded)
			{
				App.ViewModel.LoadData();
			}
		}

		private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			MediCalc.ViewModels.ItemViewModel item = e.AddedItems[0] as MediCalc.ViewModels.ItemViewModel;
			NavigationService.Navigate(new Uri(item.Target, UriKind.Relative));
		}
	}
}