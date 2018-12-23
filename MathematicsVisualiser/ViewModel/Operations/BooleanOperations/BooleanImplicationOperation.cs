using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.BooleanOperations
{
	class BooleanImplicationOperation : BinaryOperation<BooleanWrapper, BooleanWrapper, BooleanWrapper>
	{
		public BooleanImplicationOperation() : base("Boolean Implication", null, BinaryOperator.GetCenteredOperator("->"))
		{
			Calculate();
		}

		protected override void Calculate()
		{
			ResultOperand.WrappedItem = !FirstOperand.WrappedItem || SecondOperand.WrappedItem;
		}
	}
}
