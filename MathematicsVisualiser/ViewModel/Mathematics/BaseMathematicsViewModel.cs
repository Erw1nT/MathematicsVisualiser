using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathematicsVisualiser.ViewModel.Operations;
using MathematicsVisualiser.ViewModel.Operations.Point2DOperations;

namespace MathematicsVisualiser.ViewModel.Mathematics
{
	public abstract class BaseMathematicsViewModel : BaseViewModel
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		protected BaseMathematicsViewModel(string name, bool isResult) : base(name)
		{

			if (!isResult)
			{
				Operations = new List<BaseOperationViewModel>();
				InitializeOperations();

			}

		}

		#endregion

		#region Methods

		protected abstract void InitializeOperations();

		#endregion

		#region Properties

		public readonly List<BaseOperationViewModel> Operations;

		#endregion

	}
}
