using MathematicsVisualiser.ViewModel.Operands.Wrapper;
using MathematicsVisualiser.ViewModel.Operators;
using System.Windows.Media.Media3D;

namespace MathematicsVisualiser.ViewModel.Operations.Matrix3DOperations
{
	class Matrix3DRotationAroundAxis : TernaryOperation<Matrix3DWrapper, Vector3DWrapper, DoubleWrapper, Matrix3DWrapper>
	{
		public Matrix3DRotationAroundAxis() : base("Matrix 3D rotate around axis", null, BinaryOperator.GetSubscriptOperator(","), BinaryOperator.GetSubscriptOperator(","))
		{
		}

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		#endregion

		#region Methods

		#endregion

		#region Properties

		#endregion
		protected override void Calculate()
		{
			var mat = FirstOperand.WrappedItem;
			var axis = SecondOperand.WrappedItem;
			var angle = ThirdOperand.WrappedItem;

			var rotation = new RotateTransform3D(new AxisAngleRotation3D(axis, angle));
			var result = rotation.Value;
			ResultOperand.WrappedItem = mat * result;
		}
	}
}
