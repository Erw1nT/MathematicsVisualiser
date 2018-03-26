using GalaSoft.MvvmLight;
using MathematicsVisualiser.ViewModel.Mathematics;
using MathematicsVisualiser.ViewModel.Mathematics.Wrapper;
using System.Collections.Generic;

namespace MathematicsVisualiser.ViewModel
{

	public class MainViewModel : ViewModelBase
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		/// <summary>
		/// Initializes a new instance of the MainViewModel class.
		/// </summary>
		public MainViewModel()
		{
			Sources = new List<BaseMathematicsViewModel>();
			Sources.Add(new Point2DWrapper(false));
		}

		#endregion

		#region Methods

		#endregion

		#region Properties

		public List<BaseMathematicsViewModel> Sources
		{
			get;
			set;
		}

		public BaseMathematicsViewModel SelectedItem
		{
			get;
			set;
		}

		#endregion

	}
}