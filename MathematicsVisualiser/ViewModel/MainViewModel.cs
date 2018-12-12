using GalaSoft.MvvmLight;

namespace MathematicsVisualiser.ViewModel
{

	public class MainViewModel : ViewModelBase
	{
		private BaseViewModel _selectedItem;

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

		}

		#endregion

		#region Methods

		#endregion

		#region Properties

		public BaseViewModel SelectedItem
		{
			get

			{
				return _selectedItem;
			}
			set
			{
				_selectedItem = value;
				RaisePropertyChanged(nameof(SelectedItem));
			}
		}

		#endregion

	}
}