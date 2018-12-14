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

		//TODO: Aktualisiert nicht
		public abstract Model3D Content { get; }

		#endregion

	}
}
