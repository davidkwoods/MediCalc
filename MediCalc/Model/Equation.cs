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

namespace MediCalc.Model
{
	public abstract class Equation : ObservableObject
	{
		private Equation opOne;
		public Equation OpOne
		{
			get { return opOne; }
			set
			{
				if (opOne != value)
				{
					opOne = value;
					NotifyPropertyChanged(() => OpOne);
				}
			}
		}

		private Equation opTwo;
		public Equation OpTwo
		{
			get { return opTwo; }
			set
			{
				if (opTwo != value)
				{
					opTwo = value;
					NotifyPropertyChanged(() => OpTwo);
				}
			}
		}

		public abstract double Evaluate();
	}
}
