using MathematicsVisualiser.ViewModel.Operations;

namespace MathematicsVisualiser.ViewModel.Mathematics.Wrapper
{
	public abstract class GenericWrapper : BaseMathematicsViewModel
	{

		protected GenericWrapper(string name, BaseOperationViewModel parentOperation) : base(name, parentOperation)
		{

		}

		protected object InternalWrappedItem
		{
			get;
			set;
		}

	}

	public abstract class GenericWrapper<T> : GenericWrapper where T : new()
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		protected GenericWrapper(string name, BaseOperationViewModel parentOperation) : base(name, parentOperation)
		{
			WrappedItem = new T();
		}
		#endregion

		#region Methods
		#endregion

		#region Properties

		protected T WrappedItem
		{
			get
			{
				return (T) InternalWrappedItem;
			}
			set
			{
				InternalWrappedItem = value;
				RaisePropertyChanged(() => WrappedItem);
			}
		}

		#endregion
	}


}
