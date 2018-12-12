using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations
{
	public abstract class UnaryOperation<TBase, TResult> : BaseOperation<TBase, TResult>
		where TBase : new()
		where TResult : new()
	{
		protected UnaryOperation(string displayName, UnaryOperator firstOp) : base(displayName)
		{
			FirstOperator = firstOp;
		}

		public UnaryOperator FirstOperator
		{
			get;
		}

	}
}
