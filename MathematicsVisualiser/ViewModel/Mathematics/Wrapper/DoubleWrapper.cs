using MathematicsVisualiser.ViewModel.Operations;

namespace MathematicsVisualiser.ViewModel.Mathematics.Wrapper
{
	class DoubleWrapper : GenericWrapper<double>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct
		public DoubleWrapper(BaseOperationViewModel parentOperation) : base("Double", parentOperation)
		{
		}
		#endregion

		#region Methods

		protected override void InitializeCommands()
		{
		}

		#endregion

		#region Properties

		public double Value
		{
			get
			{
				return (double) InternalWrappedItem;
			}
			set
			{
				WrappedItem = value;
				RaisePropertyChanged(() => Value);
				ParentOperation.CalulateResult(this);
			}
		}

		#endregion

	}
}
