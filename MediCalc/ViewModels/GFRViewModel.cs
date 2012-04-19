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
	public class GFRViewModel : ViewModelBase
	{
		private bool isFemale;
		public bool IsFemale
		{
			get { return isFemale; }
			set
			{
				if (isFemale != value)
				{
					isFemale = value;
					NotifyPropertyChanged(() => IsFemale);
					NotifyPropertyChanged(() => GFR);
				}
			}
		}

		private bool isAM;
		public bool IsAM
		{
			get { return isAM; }
			set
			{
				if (isAM != value)
				{
					isAM = value;
					NotifyPropertyChanged(() => IsAM);
					NotifyPropertyChanged(() => GFR);
				}
			}
		}

		private double creatinine;
		public string Creatinine
		{
			get { return creatinine.ToString(); }
			set
			{
				if (creatinine.ToString() != value)
				{
					double temp;
					if (double.TryParse(value, out temp))
					{
						creatinine = temp;
						NotifyPropertyChanged(() => Creatinine);
						NotifyPropertyChanged(() => GFR);
					}
				}
			}
		}

		private int age;
		public string Age
		{
			get { return age.ToString(); }
			set
			{
				if (age.ToString() != value)
				{
					int temp;
					if (int.TryParse(value, out temp))
					{
						age = temp;
						NotifyPropertyChanged(() => Age);
						NotifyPropertyChanged(() => GFR);
					}
				}
			}
		}

		public double GFR
		{
			get { return Math.Pow(186*creatinine, -1.154) * Math.Pow(age, -0.203) * (IsFemale ? 0.742 : 1) * (IsAM ? 1.210 : 1); }
		}

		protected override void InitializeDesignTime()
		{
			IsFemale = true;
			IsAM = false;
			Creatinine = "1";
			Age = "24";
		}

		protected override void InitializeRunTime()
		{
			IsFemale = false;
			IsAM = false;
			Creatinine = "1";
			Age = "24";
		}
	}
}
