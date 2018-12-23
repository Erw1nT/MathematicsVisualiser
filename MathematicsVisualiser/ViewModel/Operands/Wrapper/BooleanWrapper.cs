using System.Windows.Media.Media3D;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	class BooleanWrapper : GenericWrapper<bool>
	{
		public BooleanWrapper() : base("Boolean")
		{
		}

		public override Model3D Content
		{
			get
			{
				return null;
			}
		}
	}
}
