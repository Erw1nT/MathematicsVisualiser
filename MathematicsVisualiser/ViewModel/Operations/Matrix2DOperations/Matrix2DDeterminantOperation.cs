using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.Matrix2DOperations
{
	class Matrix2DDeterminantOperation : UnaryOperation<Matrix2DWrapper, DoubleWrapper>
	{
		public Matrix2DDeterminantOperation() : base("Matrix 2D Determinant", UnaryOperator.GetSurroundingOperator("|", 3))
		{
		}

		protected override void Calculate()
		{
			var m = FirstOperand.WrappedItem;
			var deter = m.Determinant;

			ResultOperand.WrappedItem = deter;
		}
	}
}
