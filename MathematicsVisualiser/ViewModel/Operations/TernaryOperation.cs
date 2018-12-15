using System.Windows.Media.Media3D;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations
{
	abstract class TernaryOperation<TBase, TSecondOperand, TThirdOperand, TResult> : BinaryOperation<TBase, TSecondOperand, TResult>
		where TBase : IRenderable, new()
		where TSecondOperand : IRenderable, new()
		where TThirdOperand : IRenderable, new()
		where TResult : IRenderable, new()
	{
		/// <param name="displayName"> Name of the operation.</param>
		/// <param name="firstOp"> First operator. This one is positioned as desired around the first operand. </param>
		/// <param name="secondOp"> Second operator. This one is positioned between the first and second operand. </param>
		/// <param name="thirdOp"> Third operator. This one is positioned between the second and third operand.</param>
		protected TernaryOperation(string displayName, UnaryOperator firstOp, BinaryOperator secondOp, BinaryOperator thirdOp) : base(displayName, firstOp, secondOp)
		{
			ThirdOperand = new TThirdOperand();
			ThirdOperator = thirdOp;
		}

		public BinaryOperator ThirdOperator
		{
			get;
		}

		public TThirdOperand ThirdOperand
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
				var cont2 = SecondOperand.Content;
				var cont3 = ThirdOperand.Content;
				var cont4 = ResultOperand.Content;

				var group = new Model3DGroup();
				group.Children.Add(cont1);
				group.Children.Add(cont2);
				group.Children.Add(cont3);
				group.Children.Add(cont4);

				return group;
			}
		}

	}
}
