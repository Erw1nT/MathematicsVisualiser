using MathematicsVisualiser.ViewModel.Operands.Wrapper;

namespace MathematicsVisualiser.ViewModel.Operations.Vector2DOperations
{
	class Vector2DDotProduct : BinaryOperation<Vector2DWrapper, Vector2DWrapper, DoubleWrapper>
	{

		public Vector2DDotProduct() : base("Vector 2D DotProduct", null, Operators.BinaryOperator.GetCenteredOperator("x"))
		{
		}


		protected override void Calculate()
		{
			var v1 = FirstOperand.WrappedItem;
			var v2 = SecondOperand.WrappedItem;

			var result = v1 * v2;
			ResultOperand.WrappedItem = result;
		}

	}
}
