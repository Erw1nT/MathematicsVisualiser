using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.Matrix3DOperations
{
	class Matrix3DDetermintantOperation : UnaryOperation<Matrix3DWrapper, DoubleWrapper>
	{
		public Matrix3DDetermintantOperation() : base("Matrix 3D Determinant", UnaryOperator.GetSurroundingOperator("|", 4))
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
