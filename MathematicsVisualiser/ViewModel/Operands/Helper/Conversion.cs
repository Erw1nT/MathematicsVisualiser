using System.Windows;
using System.Windows.Media.Media3D;

namespace MathematicsVisualiser.ViewModel.Operands.Helper
{
	static class Conversion
	{

		public static Vector ToVector(this Point point)
		{
			return new Vector(point.X, point.Y);
		}

		public static Vector3D ToVector3D(this Point3D point)
		{
			return new Vector3D(point.X, point.Y, point.Z);
		}

	}
}
