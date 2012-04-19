using System;
using System.ComponentModel;
using System.Linq.Expressions;
namespace MediCalc
{
	public abstract class ObservableObject : INotifyPropertyChanged
	{
		#region Events
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		#region Methods
		protected virtual void NotifyPropertyChanged(string propertyName)
		{
			if (propertyName == null)
				throw new ArgumentNullException("propertyName");
			PropertyChangedEventHandler propertyChangedHandler = PropertyChanged;
			if (propertyChangedHandler != null)
			{
				propertyChangedHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		protected virtual void NotifyPropertyChanged<TProperty>(Expression<Func<TProperty>> property)
		{
			var lambda = (LambdaExpression)property;
			MemberExpression memberExpression;
			if (lambda.Body is UnaryExpression)
			{
				var unaryExpression = (UnaryExpression)lambda.Body;
				memberExpression = (MemberExpression)unaryExpression.Operand;
			}
			else
			{
				memberExpression = (MemberExpression)lambda.Body;
			}
			NotifyPropertyChanged(memberExpression.Member.Name);
		}
		#endregion
	}
}
