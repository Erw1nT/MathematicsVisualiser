using System.Windows.Media.Media3D;

namespace MathematicsVisualiser.ViewModel.Operands
{
	struct Plane
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Plane(Point3D point, Vector3D direction1, Vector3D direction2)
		{
			Point = point;
			Direction1 = direction1;
			Direction2 = direction2;
		}

		#endregion

		#region Methods

		#endregion

		#region Properties

		public Point3D Point
		{
			get;
		}

		public Vector3D Direction1
		{
			get;
		}

		public Vector3D Direction2
		{
			get;
		}

		#endregion

	}
}
