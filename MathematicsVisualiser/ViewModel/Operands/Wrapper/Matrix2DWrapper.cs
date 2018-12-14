using System.Windows.Media;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using MathematicsVisualiser.ViewModel.Operands;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	class Matrix2DWrapper : GenericWrapper<Matrix>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Matrix2DWrapper() : base("Matrix 2D")
		{
		}


		#endregion

		#region Methods

		#endregion

		#region Properties

		public override GeometryModel3D Content
		{
			get
			{
				throw new System.NotImplementedException();
			}
		}

		#endregion

	}
}
