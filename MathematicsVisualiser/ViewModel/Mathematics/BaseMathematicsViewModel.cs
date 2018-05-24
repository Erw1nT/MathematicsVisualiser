using MathematicsVisualiser.ViewModel.Operations;
using System;
using System.Collections.Generic;

namespace MathematicsVisualiser.ViewModel.Mathematics
{
	public abstract class BaseMathematicsViewModel : BaseViewModel
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		protected BaseMathematicsViewModel(string name, BaseOperationViewModel parentOperation) : base(name)
		{

			if (parentOperation is null)
			{
				throw new ArgumentNullException();
			}

			ParentOperation = parentOperation;
			Commands = new List<CommandWrapper>();
			InitializeCommands();
		}

		#endregion

		#region Methods

		protected abstract void InitializeCommands();

		#endregion

		#region Properties

		protected BaseOperationViewModel ParentOperation
		{
			get;
		}

		public List<CommandWrapper> Commands
		{
			get;
		}

		#endregion

	}
}
