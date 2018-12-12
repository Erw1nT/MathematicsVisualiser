namespace MathematicsVisualiser.ViewModel.Operands
{
	public abstract class GenericWrapper<T> : BaseViewModel where T : new()
	{

		#region Constants

		#endregion

		#region Attributes

		private T _wrappedItem;

		#endregion

		#region Construct

		protected GenericWrapper(string name) : base(name)
		{
			WrappedItem = new T();
		}

		#endregion

		#region Methods

		#endregion

		#region Properties

		public T WrappedItem
		{
			get
			{
				return _wrappedItem;
			}

			set
			{
				_wrappedItem = value;
				RaisePropertyChanged(nameof(WrappedItem));
				RaisePropertyChanged(null);
			}
		}

		public bool IsReadOnly
		{
			get;
		}

		#endregion

	}
}
