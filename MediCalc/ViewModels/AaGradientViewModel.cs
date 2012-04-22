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
	public class AaGradientViewModel : ViewModelBase
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.AaGradientTitle); }
		}

		private double fiO2;
		public string FiO2
		{
			get { return fiO2.ToString(); }
			set
			{
				if (fiO2.ToString() != value)
				{
					double temp;
					if (double.TryParse(value, out temp))
					{
						fiO2 = temp;
						NotifyPropertyChanged(() => FiO2);
						NotifyPropertyChanged(() => Result);
					}
				}
			}
		}

		private double paO2;
		public string PaO2
		{
			get { return paO2.ToString(); }
			set
			{
				if (paO2.ToString() != value)
				{
					double temp;
					if (double.TryParse(value, out temp))
					{
						paO2 = temp;
						NotifyPropertyChanged(() => PaO2);
						NotifyPropertyChanged(() => Result);
					}
				}
			}
		}

		private double paCO2;
		public string PaCO2
		{
			get { return paCO2.ToString(); }
			set
			{
				if (paCO2.ToString() != value)
				{
					double temp;
					if (double.TryParse(value, out temp))
					{
						paCO2 = temp;
						NotifyPropertyChanged(() => PaCO2);
						NotifyPropertyChanged(() => Result);
					}
				}
			}
		}

		public double Result
		{
			get  { return ((713 * fiO2) - (paCO2 / 0.8)) - paO2; }
		}

		protected override void InitializeDesignTime()
		{
			paO2 = 90;
			paCO2 = 40;
			fiO2 = 2;
		}

		protected override void InitializeRunTime()
		{
			InitializeDesignTime();
		}
	}
}
