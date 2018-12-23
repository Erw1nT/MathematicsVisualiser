using System.Collections.Generic;
using MathematicsVisualiser.ViewModel.Operations.BooleanOperations;
using MathematicsVisualiser.ViewModel.Operations.Matrix2DOperations;
using MathematicsVisualiser.ViewModel.Operations.Matrix3DOperations;
using MathematicsVisualiser.ViewModel.Operations.Vector3DOperations;

namespace MathematicsVisualiser.ViewModel.Operations
{
	/// <summary>
	/// This class contains the Dictionary of the types and their respective operations.
	/// </summary>
	public static class OperationHandler
	{

		private static List<BaseViewModel> _operations;

		public static IEnumerable<BaseViewModel> Operations
		{
			get
			{
				if (_operations == null)
				{
					InitializeOperations();
				}

				return _operations;
			}

		}


		private static void InitializeOperations()
		{

			var booleanOperations = new List<BaseViewModel>();
			booleanOperations.Add(new BooleanNegationOperation());
			booleanOperations.Add(new BooleanAndOperation());
			booleanOperations.Add(new BooleanOrOperation());
			booleanOperations.Add(new BooleanImplicationOperation());
			booleanOperations.Add(new BooleanIdentityOperation());

			var pointOperations = new List<BaseViewModel>();
			pointOperations.Add(new Point2DOperations.Point2DNegateOperation());
			pointOperations.Add(new Point2DOperations.Point2DAddOperation());
			pointOperations.Add(new Point2DOperations.Point2DAngleBetweenLineSegmentsOperation());

			var vectorOperations = new List<BaseViewModel>();
			vectorOperations.Add(new Vector2DOperations.Vector2DAddOperation());
			vectorOperations.Add(new Vector2DOperations.Vector2DDotProduct());
			vectorOperations.Add(new Vector2DOperations.Vector2DNegate());

			var vector3DOperations = new List<BaseViewModel>();
			vector3DOperations.Add(new Vector3DDotProduct());

			var matrix2DOperations = new List<BaseViewModel>();
			matrix2DOperations.Add(new Matrix2DDeterminantOperation());

			var matrix3DOperations = new List<BaseViewModel>();
			matrix3DOperations.Add(new Matrix3DDetermintantOperation());
			matrix3DOperations.Add(new Matrix3DRotationAroundAxis());

			_operations = new List<BaseViewModel>();
			_operations.AddRange(pointOperations);
			_operations.AddRange(vectorOperations);
			_operations.AddRange(vector3DOperations);
			_operations.AddRange(matrix2DOperations);
			_operations.AddRange(matrix3DOperations);
			_operations.AddRange(booleanOperations);

		}
	}
}
