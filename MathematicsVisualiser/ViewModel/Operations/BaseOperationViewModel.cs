using MathematicsVisualiser.ViewModel.Mathematics.Wrapper;

namespace MathematicsVisualiser.ViewModel.Operations
{
	public abstract class BaseOperationViewModel : BaseViewModel
	{
		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		protected BaseOperationViewModel(string name) : base(name)
		{
		}

		#endregion

		#region Methods

		public abstract void CalulateResult(GenericWrapper from);

		public void Update()
		{
			RaisePropertyChanged();
		}

		#endregion

		#region Properties

		public GenericWrapper Result
		{
			get;
			protected set;
		}

		public GenericWrapper Operand1
		{
			get;
			set;
		}

		public GenericWrapper Operand2
		{
			get;
			set;
		}

		#endregion

	}
}
