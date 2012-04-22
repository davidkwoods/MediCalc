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
	public class ABCD2ViewModel : ViewModelBase
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.ABCD2Title); }
		}

		private int age;
		public int Age
		{
			get { return age; }
			set
			{
				if (age != value)
				{
					age = value;
					NotifyPropertyChanged(() => Age);
					NotifyPropertyChanged(() => Score);
					NotifyPropertyChanged(() => Risk);
				}
			}
		}

		private int bloodPressure;
		public int BloodPressure
		{
			get { return bloodPressure; }
			set
			{
				if (bloodPressure != value)
				{
					bloodPressure = value;
					NotifyPropertyChanged(() => BloodPressure);
					NotifyPropertyChanged(() => Score);
					NotifyPropertyChanged(() => Risk);
				}
			}
		}

		private int clinicalFeatures;
		public int ClinicalFeatures
		{
			get { return clinicalFeatures; }
			set
			{
				if (clinicalFeatures != value)
				{
					clinicalFeatures = value;
					NotifyPropertyChanged(() => ClinicalFeatures);
					NotifyPropertyChanged(() => Score);
					NotifyPropertyChanged(() => Risk);
				}
			}
		}

		private int duration;
		public int Duration
		{
			get { return duration; }
			set
			{
				if (duration != value)
				{
					duration = value;
					NotifyPropertyChanged(() => Duration);
					NotifyPropertyChanged(() => Score);
					NotifyPropertyChanged(() => Risk);
				}
			}
		}

		private int diabetes;
		public int Diabetes
		{
			get { return diabetes; }
			set
			{
				if (diabetes != value)
				{
					diabetes = value;
					NotifyPropertyChanged(() => Diabetes);
					NotifyPropertyChanged(() => Score);
					NotifyPropertyChanged(() => Risk);
				}
			}
		}

		public int Score
		{
			get { return Age + BloodPressure + ClinicalFeatures + Duration + Diabetes; }
		}

		public string Risk
		{
			get
			{
				int score = Score;
				if (score < 4)
					return Strings.ABCD2Low;
				if (score < 6)
					return Strings.ABCD2Mod;
				else
					return Strings.ABCD2High;
			}
		}

		protected override void InitializeDesignTime()
		{
			Age = 0;
			BloodPressure = 0;
			ClinicalFeatures = 0;
			Duration = 0;
			Diabetes = 0;
		}

		protected override void InitializeRunTime()
		{
			InitializeDesignTime();
		}
	}
}
