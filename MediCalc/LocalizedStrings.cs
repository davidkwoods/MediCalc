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

namespace MediCalc
{
	public class LocalizedStrings
	{
		private Strings strings;
		public Strings Strings
		{
			get
			{
				if (strings == null)
					strings = new Strings();
				return strings;
			}
		}
	}
}
