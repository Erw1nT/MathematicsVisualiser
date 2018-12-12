using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.Vector3DOperations
{
	class Vector3DDotProduct : BinaryOperation<Vector3DWrapper, Vector3DWrapper, DoubleWrapper>
	{
		public Vector3DDotProduct() : base("Vector 3D DotProduct", null, BinaryOperator.GetCenteredOperator("x"))
		{
		}

		protected override void Calculate()
		{
			var v1 = BaseOperand.WrappedItem;
			var v2 = SecondOperand.WrappedItem;

			var result = System.Windows.Media.Media3D.Vector3D.DotProduct(v1, v2);
			ResultOperand.WrappedItem = result;
		}

	}
}
