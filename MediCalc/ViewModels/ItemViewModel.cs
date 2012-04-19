﻿using System;
using System.ComponentModel;

namespace MediCalc.ViewModels
{
	public class ItemViewModel : ObservableObject
	{
		private string _lineOne;
		/// <summary>
		/// Sample ViewModel property; this property is used in the view to display its value using a Binding.
		/// </summary>
		/// <returns></returns>
		public string LineOne
		{
			get
			{
				return _lineOne;
			}
			set
			{
				if (value != _lineOne)
				{
					_lineOne = value;
					NotifyPropertyChanged(() => LineOne);
				}
			}
		}

		private string _lineTwo;
		/// <summary>
		/// Sample ViewModel property; this property is used in the view to display its value using a Binding.
		/// </summary>
		/// <returns></returns>
		public string LineTwo
		{
			get
			{
				return _lineTwo;
			}
			set
			{
				if (value != _lineTwo)
				{
					_lineTwo = value;
					NotifyPropertyChanged(() => LineTwo);
				}
			}
		}

		private string _lineThree;
		/// <summary>
		/// Sample ViewModel property; this property is used in the view to display its value using a Binding.
		/// </summary>
		/// <returns></returns>
		public string LineThree
		{
			get
			{
				return _lineThree;
			}
			set
			{
				if (value != _lineThree)
				{
					_lineThree = value;
					NotifyPropertyChanged(() => LineThree);
				}
			}
		}

		private string target;
		public string Target
		{
			get { return target; }
			set
			{
				if (target != value)
				{
					target = value;
					NotifyPropertyChanged(() => Target);
				}
			}
		}
	}
}