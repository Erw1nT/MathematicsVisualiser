using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.BooleanOperations
{
	class BooleanOrOperation : BinaryOperation<BooleanWrapper, BooleanWrapper, BooleanWrapper>
	{
		public BooleanOrOperation() : base("Boolean Or", null, BinaryOperator.GetCenteredOperator("OR"))
		{
			Calculate();
		}

		protected override void Calculate()
		{
			ResultOperand.WrappedItem = FirstOperand.WrappedItem || SecondOperand.WrappedItem;
		}
	}
}
