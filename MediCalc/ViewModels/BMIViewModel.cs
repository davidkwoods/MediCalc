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
	public class BMIViewModel : ViewModelBase
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.BmiTitle); }
		}

		private double height;
		public string Height
		{
			get { return height.ToString(); }
			set
			{
				if (height.ToString() != value)
				{
					double temp;
					if (double.TryParse(value, out temp))
					{
						height = temp;
						NotifyPropertyChanged(() => Height);
						NotifyPropertyChanged(() => Result);
					}
				}
			}
		}

		private double weight;
		public String Weight
		{
			get { return weight.ToString(); }
			set
			{
				if (weight.ToString() != value)
				{
					double temp;
					if (double.TryParse(value, out temp))
					{
						weight = temp;
						NotifyPropertyChanged(() => Weight);
						NotifyPropertyChanged(() => Result);
					}
				}
			}
		}

		public double Result
		{
			get { return weight * 703 / Math.Pow(height, 2); }
		}

		public string Category
		{
			get
			{
				double res = Result;
				if (res < 18.5)
					return Strings.BmiUnderweight;
				if (res >= 18.5 && res < 25)
					return Strings.BmiNormal;
				if (res >= 25 && res < 30)
					return Strings.BmiOverweight;
				else
					return Strings.BmiObese;
			}
		}

		protected override void InitializeDesignTime()
		{
			weight = 150;
			height = 72;
		}

		protected override void InitializeRunTime()
		{
			InitializeDesignTime();
		}
	}
}
