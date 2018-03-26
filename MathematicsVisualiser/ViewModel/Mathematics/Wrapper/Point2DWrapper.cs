using MathematicsVisualiser.ViewModel.Operations.Point2DOperations;
using System.Windows;

namespace MathematicsVisualiser.ViewModel.Mathematics.Wrapper
{
	public class Point2DWrapper : GenericWrapper<Point>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Point2DWrapper(bool isResult) : base("Point 2D", isResult)
		{
			
		}

		#endregion

		#region Methods

		protected override void InitializeOperations()
		{
			Operations.Add(new Point2DAddOperation());
		}

		#endregion

		#region Properties

		#endregion

	}
}
