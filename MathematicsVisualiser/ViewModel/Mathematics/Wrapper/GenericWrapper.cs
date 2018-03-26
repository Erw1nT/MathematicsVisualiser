namespace MathematicsVisualiser.ViewModel.Mathematics.Wrapper
{
	public abstract class GenericWrapper<T> : BaseMathematicsViewModel where T : struct
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		protected GenericWrapper(string name, bool isResult) : base(name, isResult)
		{
			WrappedItem = new T();
		}

		#endregion

		#region Methods

		#endregion

		#region Properties

		public readonly T WrappedItem;

		#endregion

	}
}
