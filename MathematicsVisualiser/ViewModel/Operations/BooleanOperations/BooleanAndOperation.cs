using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.BooleanOperations
{
	class BooleanAndOperation : BinaryOperation<BooleanWrapper, BooleanWrapper, BooleanWrapper>
	{
		public BooleanAndOperation() : base("Boolean And", null, BinaryOperator.GetCenteredOperator("AND"))
		{
			Calculate();
		}

		protected override void Calculate()
		{
			ResultOperand.WrappedItem = FirstOperand.WrappedItem && SecondOperand.WrappedItem;
		}
	}
}
