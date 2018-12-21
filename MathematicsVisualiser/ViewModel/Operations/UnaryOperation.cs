using System.Windows.Media.Media3D;
using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations
{
	public abstract class UnaryOperation<TBase, TResult> : BaseOperation<TBase, TResult>
		where TBase : BaseWrapper, new()
		where TResult : BaseWrapper, new()
	{
		/// <param name="displayName"> Name of the operation.</param>
		/// <param name="firstOp"> First operator. This one is positioned as desired around the first operand. </param>
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

				var cont1 = FirstOperand.Content;
				var cont2 = ResultOperand.Content;

				var group = new Model3DGroup();
				group.Children.Add(cont1);
				group.Children.Add(cont2);

				return group;
			}
		}

	}
}
