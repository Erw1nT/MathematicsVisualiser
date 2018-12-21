using System.Windows;

namespace MathematicsVisualiser.ViewModel.Operands
{
	struct LineSegment2D
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
		public LineSegment2D(Point startPoint, Vector direction)
		{
			StartPoint = startPoint;
			Direction = direction;
			EndPoint = StartPoint + direction;
		}

		#endregion

		#region Methods

		#endregion

		#region Properties

		public Point StartPoint
		{
			get;
		}

		public Vector Direction
		{
			get;
		}

		public Point EndPoint
		{
			get;
		}

		#endregion

	}
}
