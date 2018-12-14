using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using MathematicsVisualiser.ViewModel.Operands;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	class Point3DWrapper : GenericWrapper<Point3D>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Point3DWrapper() : base("Point 3D")
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
