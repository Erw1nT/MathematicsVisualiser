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

		public static Vector3D ToVector3D(this Vector vector)
		{
			return new Vector3D(vector.X, vector.Y, 0);
		}

		public static Point3D ToPoint3D(this Vector3D vector3D)
		{
			return new Point3D(vector3D.X, vector3D.Y, vector3D.Z);
		}

		public static Point3D ToPoint3D(this Vector vector)
		{
			return new Point3D(vector.X, vector.Y, 0);
		}


	}
}
