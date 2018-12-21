using System.Windows.Media.Media3D;

namespace MathematicsVisualiser.ViewModel.Operands
{
	struct LineSegment3D
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		/// <summary>
		/// Creates a new line segment.
		/// </summary>
		/// <param name="startPoint"> StartPoint or the line segment. </param>
		/// <param name="direction"> Direction from StartPoint to EndPoint. </param>
		public LineSegment3D(Point3D startPoint, Vector3D direction)
		{
			StartPoint = startPoint;
			Direction = direction;
			EndPoint = StartPoint + direction;
		}

		#endregion

		#region Methods

		#endregion

		#region Properties

		public Point3D StartPoint
		{
			get;
		}

		public Vector3D Direction
		{
			get;
		}

		public Point3D EndPoint
		{
			get;
		}

		#endregion

	}
}
