namespace MediCalc.ViewModels
{
	public class ApgarViewModel : ViewModelBase
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.ApgarTitle); }
		}

		private int appearance;
		public int Appearance
		{
			get { return appearance; }
			set
			{
				if (appearance != value)
				{
					appearance = value;
					NotifyPropertyChanged(() => Appearance);
					NotifyPropertyChanged(() => Score);
				}
			}
		}

		private int pulse;
		public int Pulse
		{
			get { return pulse; }
			set
			{
				if (pulse != value)
				{
					pulse = value;
					NotifyPropertyChanged(() => Pulse);
					NotifyPropertyChanged(() => Score);
				}
			}
		}

		private int grimace;
		public int Grimace
		{
			get { return grimace; }
			set
			{
				if (grimace != value)
				{
					grimace = value;
					NotifyPropertyChanged(() => Grimace);
					NotifyPropertyChanged(() => Score);
				}
			}
		}

		private int activity;
		public int Activity
		{
			get { return activity; }
			set
			{
				if (activity != value)
				{
					activity = value;
					NotifyPropertyChanged(() => Activity);
					NotifyPropertyChanged(() => Score);
				}
			}
		}

		private int respiration;
		public int Respiration
		{
			get { return respiration; }
			set
			{
				if (respiration != value)
				{
					respiration = value;
					NotifyPropertyChanged(() => Respiration);
					NotifyPropertyChanged(() => Score);
				}
			}
		}

		public int Score
		{
			get { return Appearance + Pulse + Grimace + Activity + Respiration; }
		}

		protected override void InitializeDesignTime()
		{
			Activity = 1;
			Appearance = 1;
			Pulse = 1;
			Grimace = 1;
			Respiration = 1;
		}

		protected override void InitializeRunTime()
		{
			InitializeDesignTime();
		}
	}
}
