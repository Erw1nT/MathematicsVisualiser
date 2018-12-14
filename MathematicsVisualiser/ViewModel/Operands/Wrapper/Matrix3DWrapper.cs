using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using MathematicsVisualiser.ViewModel.Operands;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	class Matrix3DWrapper : GenericWrapper<Matrix3D>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Matrix3DWrapper() : base("Matrix 3D")
		{
		}

		#endregion

		#region Methods

		#endregion

		#region Properties

		public override Model3D Content
		{
			get
			{
				throw new System.NotImplementedException();
			}
		}

		#endregion
	}
}
