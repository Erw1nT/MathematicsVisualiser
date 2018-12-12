using System.Windows;
using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.Point2DOperations
{
	class Point2DAngleBetweenLineSegmentsOperation : TernaryOperation<Point2DWrapper, Point2DWrapper, Point2DWrapper, DoubleWrapper>
	{
		public Point2DAngleBetweenLineSegmentsOperation() : base("Point 2D Angle between linesegments", 
			UnaryOperator.GetPrefixOperator("∠", OperatorPosition.Center), 
			BinaryOperator.GetCenteredOperator(","),
			BinaryOperator.GetCenteredOperator(","))
		{
		}

		protected override void Calculate()
		{
			var pt1 = BaseOperand.WrappedItem;
			var pt2 = SecondOperand.WrappedItem;
			var pt3 = ThirdOperand.WrappedItem;

			var v1 = pt2 - pt1;
			var v2 = pt2 - pt3;

			var result = Vector.AngleBetween(v1, v2);
			ResultOperand.WrappedItem = result;
		}
	}
}
