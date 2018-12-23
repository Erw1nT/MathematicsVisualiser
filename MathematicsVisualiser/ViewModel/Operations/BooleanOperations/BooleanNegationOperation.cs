using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations.BooleanOperations
{
	class BooleanNegationOperation : UnaryOperation<BooleanWrapper, BooleanWrapper>
	{
		public BooleanNegationOperation() : base("Boolean negation", UnaryOperator.GetPrefixOperator("¬", OperatorPosition.Center))
		{
			Calculate();
		}

		protected override void Calculate()
		{
			ResultOperand.WrappedItem = !FirstOperand.WrappedItem;
		}
	}
}
