using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MediCalc.ViewModels
{
	public class ViewModelLocator
	{
		private MainViewModel mainViewModel;
		public MainViewModel MainViewModel
		{
			get
			{
				if (mainViewModel == null)
					mainViewModel = new MainViewModel();
				return mainViewModel;
			}
		}

		private ApgarViewModel apgarViewModel;
		public ApgarViewModel ApgarViewModel
		{
			get
			{
				if (apgarViewModel == null)
					apgarViewModel = new ApgarViewModel();
				return apgarViewModel;
			}
		}

		private GFRViewModel gfrViewModel;
		public GFRViewModel GFRViewModel
		{
			get
			{
				if (gfrViewModel == null)
					gfrViewModel = new GFRViewModel();
				return gfrViewModel;
			}
		}

		private AaGradientViewModel aaGradientViewModel;
		public AaGradientViewModel AaGradientViewModel
		{
			get
			{
				if (aaGradientViewModel == null)
					aaGradientViewModel = new AaGradientViewModel();
				return aaGradientViewModel;
			}
		}

		private BMIViewModel bmiViewModel;
		public BMIViewModel BMIViewModel
		{
			get
			{
				if (bmiViewModel == null)
					bmiViewModel = new BMIViewModel();
				return bmiViewModel;
			}
		}

		private ABCD2ViewModel abcd2ViewModel;
		public ABCD2ViewModel ABCD2ViewModel
		{
			get
			{
				if (abcd2ViewModel == null)
					abcd2ViewModel = new ABCD2ViewModel();
				return abcd2ViewModel;
			}
		}
	}
}
