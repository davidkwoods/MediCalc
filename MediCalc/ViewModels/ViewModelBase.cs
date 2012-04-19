using System.Windows;
using System.ComponentModel;

namespace MediCalc.ViewModels
{
	public abstract class ViewModelBase : ObservableObject
	{
		protected static bool IsInDesignMode
		{
			get
			{
				return DesignerProperties.GetIsInDesignMode(Deployment.Current);
			}
		}

		protected ViewModelBase()
		{
			if (IsInDesignMode)
				InitializeDesignTime();
			else
				InitializeRunTime();
		}

		protected abstract void InitializeDesignTime();
		protected abstract void InitializeRunTime();
	}
}
