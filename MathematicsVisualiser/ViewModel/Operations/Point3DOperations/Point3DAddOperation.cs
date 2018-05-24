using MathematicsVisualiser.ViewModel.Mathematics.Wrapper;

namespace MathematicsVisualiser.ViewModel.Operations.Point3DOperations
{
	class Point3DAddOperation : BaseOperationViewModel
	{

		public Point3DAddOperation() : base("add a 3D Point to a 3D Point")
		{
			Operand1 = new Point3DWrapper(this);
			Operand2 = new Point3DWrapper(this);
			Result = new Point3DWrapper(this);
		}

		public override void CalulateResult(GenericWrapper from)
		{

			if (from == Result)
			{
				return;
			}

			var resultX = ((Point3DWrapper) Operand1).X + ((Point3DWrapper) Operand2).X;
			var resultY = ((Point3DWrapper) Operand1).Y + ((Point3DWrapper) Operand2).Y;
			var resultZ = ((Point3DWrapper) Operand1).Z + ((Point3DWrapper) Operand2).Z;

			((Point3DWrapper) Result).X = resultX;
			((Point3DWrapper) Result).Y = resultY;
			((Point3DWrapper) Result).Z = resultZ;
		}

	}
}
