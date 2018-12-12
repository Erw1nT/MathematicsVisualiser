using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.Point2DOperations
{
	class Point2DNegateOperation : UnaryOperation<Point2DWrapper, Point2DWrapper>
	{

		public Point2DNegateOperation() : base("Point 2D negate", UnaryOperator.GetPrefixOperator("-", OperatorPosition.Center))
		{
		}

		protected override void Calculate()
		{
			
			var wrappedItem = BaseOperand.WrappedItem;
			ResultOperand.WrappedItem = new System.Windows.Point(-wrappedItem.X, -wrappedItem.Y);

		}
		
	}
}
