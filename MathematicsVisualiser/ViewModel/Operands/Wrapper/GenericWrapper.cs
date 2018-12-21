using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	public abstract class GenericWrapper<T> : BaseWrapper
		where T : struct
	{

		#region Constants

		#endregion

		#region Attributes

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
				return (T) InternalWrappedItem;
			}

			set
			{
				InternalWrappedItem = value;
				RaisePropertyChanged(nameof(WrappedItem));
				RaisePropertyChanged(null);
			}
		}

		protected KeyValuePair<T, GeometryModel3D>? LastCalculation;

		#endregion

	}
}
