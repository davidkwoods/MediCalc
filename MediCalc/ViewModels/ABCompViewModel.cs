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
	public class ABCompViewModel : ViewModelBase
	{
		public string Title
		{
			get { return string.Format(Strings.FormulaTitleFormatString, Strings.AppTitle, Strings.ABCompTitle); }
		}

		private int ph;
		public int Ph
		{
			get { return ph; }
			set
			{
				if (ph != value)
				{
					ph = value;
					NotifyPropertyChanged(() => Ph);
					State = 0;
				}
			}
		}

		private int hco3;
		public int Hco3
		{
			get { return hco3; }
			set
			{
				if (hco3 != value)
				{
					hco3 = value;
					NotifyPropertyChanged(() => Hco3);
					State = 0;
				}
			}
		}

		private int pco2;
		public int Pco2
		{
			get { return pco2; }
			set
			{
				if (pco2 != value)
				{
					pco2 = value;
					NotifyPropertyChanged(() => Pco2);
					State = 0;
				}
			}
		}

		private AbState state;
		public AbState State
		{
			get { return state; }
			set
			{
				if (Ph == 0 && Pco2 == 0 && Hco3 == 0)
					state = AbState.MetaAcid;
				else if (Ph == 1 && Pco2 == 1 && Hco3 == 1)
					state = AbState.MetaAlka;
				else if (Ph == 0 && Pco2 == 1 && Hco3 == 1)
					state = AbState.RespAcid;
				else if (Ph == 1 && Pco2 == 0 && Hco3 == 0)
					state = AbState.RespAlka;
				else
					state = AbState.Unknown;
				NotifyPropertyChanged(() => IndicationString);
			}
		}

		public string IndicationString
		{
			get
			{
				switch (state)
				{
					case AbState.MetaAcid:
						return string.Format(Strings.IndicativeOfFormat, Strings.MetaAcid);
					case AbState.MetaAlka:
						return string.Format(Strings.IndicativeOfFormat, Strings.MetaAlka);
					case AbState.RespAcid:
						return string.Format(Strings.IndicativeOfFormat, Strings.RespAcid);
					case AbState.RespAlka:
						return string.Format(Strings.IndicativeOfFormat, Strings.RespAlka);
					default:
						return string.Format(Strings.IndicativeOfFormat, Strings.Unknown);
				}
			}
		}


		protected override void InitializeDesignTime()
		{
			Ph = 0;
			Pco2 = 0;
			Hco3 = 0;
		}

		protected override void InitializeRunTime()
		{
			InitializeDesignTime();
		}
	}

	enum AbState
	{
		Unknown = 0,
		MetaAcid = 1,
		MetaAlka = 2,
		RespAcid = 3,
		RespAlka = 4
	}
}
