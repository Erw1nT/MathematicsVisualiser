using System.Windows.Media.Media3D;
using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;

namespace MathematicsVisualiser.ViewModel.Operations
{
	public abstract class BinaryOperation<TBaseOperand, TSecondOperand, TResult> : UnaryOperation<TBaseOperand, TResult>
		where TBaseOperand : BaseWrapper, new()
		where TSecondOperand : BaseWrapper, new()
		where TResult : BaseWrapper, new()
	{

		/// <param name="displayName"> Name of the operation.</param>
		/// <param name="firstOp"> First operator. This one is positioned as desired around the first operand. </param>
		/// <param name="secondOp"> Second operator. This one is positioned between the first and second operand. </param>
		protected BinaryOperation(string displayName, UnaryOperator firstOp, BinaryOperator secondOp) : base(displayName, firstOp)
		{
			SecondOperand = new TSecondOperand();
			SecondOperator = secondOp;
		}

		public BinaryOperator SecondOperator
		{
			get;
		}

		public TSecondOperand SecondOperand
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
				var cont3 = ResultOperand.Content;

				var group = new Model3DGroup();
				group.Children.Add(cont1);
				group.Children.Add(cont2);
				group.Children.Add(cont3);

				return group;
			}
		}

	}
}