using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations
{
	public abstract class BaseOperation<TFirstOperand, TResult> : BaseViewModel
		where TFirstOperand : new()
		where TResult : new()
	{
		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		protected BaseOperation(string name) : base(name)
		{
			BaseOperand = new TFirstOperand();
			ResultOperand = new TResult();
			CalculateCommand = new RelayCommand(Calculate);
		}

		#endregion

		#region Commands

		public ICommand CalculateCommand
		{
			get;
		}


		#endregion

		#region Methods

		protected abstract void Calculate();

		#endregion

		#region Properties

		public TFirstOperand BaseOperand
		{
			get;
		}

		public TResult ResultOperand
		{
			get;
		}

		#endregion

	}
}
