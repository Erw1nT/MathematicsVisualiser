using System;
using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.BooleanOperations
{
	class BooleanIdentityOperation : BinaryOperation<BooleanWrapper, BooleanWrapper, BooleanWrapper>
	{
		public BooleanIdentityOperation() : base("Boolean Identity", null, BinaryOperator.GetCenteredOperator("↔"))
		{
			Calculate();
		}

		protected override void Calculate()
		{
			var b1 = FirstOperand.WrappedItem;
			var b2 = SecondOperand.WrappedItem;

			ResultOperand.WrappedItem = (b1 == b2);
		}
	}
}
