using System.Windows.Input;
using System.Windows.Media.Media3D;
using GalaSoft.MvvmLight.CommandWpf;
using MathematicsVisualiser.ViewModel.Operands.Wrapper;

namespace MathematicsVisualiser.ViewModel.Operations
{
	public abstract class BaseOperation<TFirstOperand, TResult> : BaseViewModel, IRenderable
		where TFirstOperand : BaseWrapper, new()
		where TResult : BaseWrapper, new()
	{
		#region Constants

		#endregion

		#region Attributes

		protected bool HasCalculated;

		#endregion

		#region Construct

		protected BaseOperation(string name) : base(name)
		{
			FirstOperand = new TFirstOperand();

			ResultOperand = new TResult()
			{
				IsReadOnly = true
			};

			CalculateCommand = new RelayCommand(CalculateCommandExecute);
			HasCalculated = false;
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

		private void CalculateCommandExecute()
		{
			Calculate();
			HasCalculated = true;
			RaisePropertyChanged(nameof(Content));
		}

		#endregion

		#region Properties

		public TFirstOperand FirstOperand
		{
			get;
		}

		public TResult ResultOperand
		{
			get;
		}

		public virtual bool IsRotationAllowed
		{
			get
			{
				return true;
			}

		}

		public abstract Model3D Content { get; }

		#endregion

	}
}
