using System.Windows.Input;
using System.Windows.Media.Media3D;
using GalaSoft.MvvmLight.CommandWpf;

namespace MathematicsVisualiser.ViewModel.Operations
{
	public abstract class BaseOperation<TFirstOperand, TResult> : BaseViewModel, IRenderable
		where TFirstOperand : IRenderable, new()
		where TResult : IRenderable, new()
	{
		#region Constants

		#endregion

		#region Attributes

		protected bool HasCalculated;

		#endregion

		#region Construct

		protected BaseOperation(string name) : base(name)
		{
			BaseOperand = new TFirstOperand();
			ResultOperand = new TResult();
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

		public TFirstOperand BaseOperand
		{
			get;
		}

		public TResult ResultOperand
		{
			get;
		}

		public abstract Model3D Content { get; }

		#endregion

	}
}
