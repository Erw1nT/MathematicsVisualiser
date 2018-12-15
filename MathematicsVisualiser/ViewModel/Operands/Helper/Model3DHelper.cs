using System.Windows;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;

namespace MathematicsVisualiser.ViewModel.Operands.Helper
{
	static class Model3DHelper
	{

		public static MeshGeometry3D ToGeometry3D(this Point point)
		{
			var meshBuilder = new MeshBuilder();
			meshBuilder.AddSphere(point.ToPoint3D(), 0.1);
			return meshBuilder.ToMesh();
		}

		public static MeshGeometry3D ToGeometry3D(this Point3D point)
		{
			var meshBuilder = new MeshBuilder();
			meshBuilder.AddSphere(point, 0.1);
			return meshBuilder.ToMesh();
		}

		public static MeshGeometry3D ToGeometry3D(this Vector vector, Point point = new Point())
		{
			var meshBuilder = new MeshBuilder();

			var startPoint = point.ToPoint3D();
			var endPoint = point.ToPoint3D() + vector.ToVector3D();
			meshBuilder.AddArrow(startPoint, endPoint, 0.1);

			return meshBuilder.ToMesh();

		}

		public static MeshGeometry3D ToGeometry3D(this Vector3D vector, Point3D point = new Point3D())
		{
			var meshBuilder = new MeshBuilder();

			var startPoint = point;
			var endPoint = point + vector;
			meshBuilder.AddArrow(startPoint, endPoint, 0.1);

			return meshBuilder.ToMesh();
		}

	}
}
