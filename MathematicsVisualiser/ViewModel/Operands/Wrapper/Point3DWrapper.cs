using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using MathematicsVisualiser.ViewModel.Operands.Helper;

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
				var mb = new MeshBuilder();
				mb.AddSphere(WrappedItem, 0.1);

				var mat = new DiffuseMaterial(System.Windows.Media.Brushes.Orange);
				var model = new GeometryModel3D(WrappedItem.ToGeometry3D(), mat);

				return model;
			}
		}

		#endregion
	}

}
