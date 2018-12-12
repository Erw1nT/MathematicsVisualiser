using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.Vector2DOperations
{
	class Vector2DAddOperation : BinaryOperation<Vector2DWrapper, Vector2DWrapper,Vector2DWrapper>
	{

		public Vector2DAddOperation() : base("Vector 2D add", null, BinaryOperator.GetCenteredOperator("+"))
		{
		}

		protected override void Calculate()
		{
			var v1 = BaseOperand.WrappedItem;
			var v2 = SecondOperand.WrappedItem;

			var result = v1 + v2;
			
			ResultOperand.WrappedItem = result;
		}

	}
}
