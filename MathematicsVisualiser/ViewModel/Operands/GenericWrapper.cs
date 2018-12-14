using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace MathematicsVisualiser.ViewModel.Operands
{
	public abstract class GenericWrapper<T> : BaseViewModel, IRenderable
		where T : struct
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

		protected KeyValuePair<T, GeometryModel3D>? LastCalculation;

		public abstract Model3D Content
		{
			get;
		}

		public bool IsReadOnly
		{
			get;
		}

		#endregion

	}
}
