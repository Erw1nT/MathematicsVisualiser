using GalaSoft.MvvmLight;
using MathematicsVisualiser.ViewModel.Operations;
using MathematicsVisualiser.ViewModel.Operations.Point2DOperations;
using MathematicsVisualiser.ViewModel.Operations.Point3DOperations;
using System.Collections.Generic;

namespace MathematicsVisualiser.ViewModel
{

	public class MainViewModel : ViewModelBase
	{

		#region Constants

		#endregion

		#region Attributes

		private BaseOperationViewModel _selectedOperation;

		#endregion

		#region Construct

		/// <summary>
		/// Initializes a new instance of the MainViewModel class.
		/// </summary>
		public MainViewModel()
		{
			AllOperations = new List<BaseOperationViewModel>
			{
				new Point2DAddOperation(),
				new Point3DAddOperation()
			};
		}

		#endregion

		#region Methods

		#endregion

		#region Properties

		public List<BaseOperationViewModel> AllOperations
		{
			get;
		}

		public BaseOperationViewModel SelectedOperation
		{
			get { return _selectedOperation; }
			set
			{
				_selectedOperation = value;
				RaisePropertyChanged(() => SelectedOperation);
			}

		}

		#endregion

	}
}