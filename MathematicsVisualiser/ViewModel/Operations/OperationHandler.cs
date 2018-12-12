using System.Collections.Generic;
using MathematicsVisualiser.ViewModel.Operations.Vector3DOperations;

namespace MathematicsVisualiser.ViewModel.Operations
{
	/// <summary>
	/// This class contains the Dictionary of the types and their respective operations.
	/// </summary>
	public static class OperationHandler
	{

		private static List<BaseViewModel> _operations;

		public static List<BaseViewModel> Operations
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

			var pointOperations = new List<BaseViewModel>();
			pointOperations.Add(new Point2DOperations.Point2DNegateOperation());
			pointOperations.Add(new Point2DOperations.Point2DAddOperation());
			pointOperations.Add(new Point2DOperations.Point2DAngleBetweenLineSegmentsOperation());

			var vectorOperations = new List<BaseViewModel>();
			vectorOperations.Add(new Vector2DOperations.Vector2DAddOperation());
			vectorOperations.Add(new Vector2DOperations.Vector2DDotProduct());

			var vector3DOperations = new List<BaseViewModel>();
			vector3DOperations.Add(new Vector3DDotProduct());

			_operations = new List<BaseViewModel>();
			_operations.AddRange(pointOperations);
			_operations.AddRange(vectorOperations);
			_operations.AddRange(vector3DOperations);

		}
	}
}
