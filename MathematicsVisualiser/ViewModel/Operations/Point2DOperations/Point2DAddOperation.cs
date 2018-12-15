using MathematicsVisualiser.ViewModel.Operands.Helper;
using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.Point2DOperations
{
	class Point2DAddOperation : BinaryOperation<Point2DWrapper, Point2DWrapper, Point2DWrapper>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Point2DAddOperation() : base("Point 2D add", null, BinaryOperator.GetCenteredOperator("+"))
		{
		}

		#endregion

		#region Methods

		protected override void Calculate()
		{

			var point1 = FirstOperand;
			var point2 = SecondOperand;

			var result = point1.WrappedItem + point2.WrappedItem.ToVector();
			ResultOperand.WrappedItem = result;
		}

		#endregion

		#region Properties

		#endregion

	}
}
