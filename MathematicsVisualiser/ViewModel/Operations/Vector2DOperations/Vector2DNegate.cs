using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.Vector2DOperations
{
	class Vector2DNegate : UnaryOperation<Vector2DWrapper, Vector2DWrapper>
	{
		public Vector2DNegate() : base("Vector 2D Negate", UnaryOperator.GetPrefixOperator("-", OperatorPosition.Center))
		{
		}

		protected override void Calculate()
		{

			var wrappedItem = BaseOperand.WrappedItem;
			ResultOperand.WrappedItem = new System.Windows.Vector(-wrappedItem.X, -wrappedItem.Y);

		}
	}
}
