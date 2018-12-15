using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace MathematicsVisualiser.ViewModel.Operands.Helper
{
	static class Extensions
	{

		#region "Matrix 2D"

		public static Vector XAxis(this Matrix matrix)
		{
			return new Vector(matrix.M11, matrix.M12);
		}

		public static Vector YAxis(this Matrix matrix)
		{
			return new Vector(matrix.M21, matrix.M22);
		}

		public static Point Point(this Matrix matrix)
		{
			return new Point(matrix.OffsetX, matrix.OffsetY);
		}

		#endregion

		#region "Matrix 3D"

		public static Vector3D XAxis(this Matrix3D matrix)
		{
			return new Vector3D(matrix.M11, matrix.M12, matrix.M13);
		}

		public static Vector3D YAxis(this Matrix3D matrix)
		{
			return new Vector3D(matrix.M21, matrix.M22, matrix.M23);
		}

		public static Vector3D ZAxis(this Matrix3D matrix)
		{
			return new Vector3D(matrix.M31, matrix.M32, matrix.M33);
		}

		public static Point3D Point(this Matrix3D matrix)
		{
			return new Point3D(matrix.OffsetX, matrix.OffsetY, matrix.OffsetZ);
		}

		#endregion

	}
}
