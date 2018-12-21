using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	public abstract class BaseWrapper : BaseViewModel, IRenderable
	{

		protected BaseWrapper(string name) : base(name)
		{
		}

		protected object InternalWrappedItem
		{
			get;
			set;
		}

		public bool IsReadOnly
		{
			get;
			set;
		}

		public abstract Model3D Content
		{
			get;
		}
	}
}
