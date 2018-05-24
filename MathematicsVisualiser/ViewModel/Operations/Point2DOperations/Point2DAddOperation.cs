using MathematicsVisualiser.ViewModel.Mathematics.Wrapper;

namespace MathematicsVisualiser.ViewModel.Operations.Point2DOperations
{
	class Point2DAddOperation : BaseOperationViewModel
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Point2DAddOperation() : base("add a 2D Point to a 2D Point")
		{
			Operand1 = new Point2DWrapper(this);
			Operand2 = new Point2DWrapper(this);
			Result = new Point2DWrapper(this);
		}

		#endregion

		#region Methods

		public override void CalulateResult(GenericWrapper from)
		{
			if (from == Result)
			{
				return;
			}

			var resultX = ((Point2DWrapper) Operand1).X + ((Point2DWrapper) Operand2).X;
			var resultY = ((Point2DWrapper) Operand1).Y + ((Point2DWrapper) Operand2).Y;

			((Point2DWrapper) Result).X = resultX;
			((Point2DWrapper) Result).Y = resultY;
		}

		#endregion

		#region Properties

		#endregion

	}
}
