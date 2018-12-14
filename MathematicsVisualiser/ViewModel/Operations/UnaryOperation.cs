using System.Windows.Media.Media3D;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations
{
	public abstract class UnaryOperation<TBase, TResult> : BaseOperation<TBase, TResult>
		where TBase : IRenderable, new()
		where TResult : IRenderable, new()
	{
		protected UnaryOperation(string displayName, UnaryOperator firstOp) : base(displayName)
		{
			FirstOperator = firstOp;
		}

		public UnaryOperator FirstOperator
		{
			get;
		}

		public override Model3D Content
		{
			get
			{
				if (!HasCalculated)
				{
					return null;
				}

				var cont1 = BaseOperand.Content;

				return cont1;
			}
		}

	}
}
