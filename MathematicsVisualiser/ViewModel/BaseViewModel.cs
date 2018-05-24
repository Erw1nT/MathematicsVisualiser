using GalaSoft.MvvmLight;
using System.ComponentModel;

namespace MathematicsVisualiser.ViewModel
{
	public class BaseViewModel : ViewModelBase
	{

		#region Attributes

		#endregion

		#region Construct

		protected BaseViewModel(string name)
		{
			DisplayName = name;
		}

		#endregion

		#region Methods


		/// <summary>
		/// Provides a way to update all properties, as the RaisePropertyChanged-Methods
		/// in the ViewModelBase do not provide this functionality.
		/// </summary>
		protected void RaisePropertyChanged()
		{
			var handler = PropertyChangedHandler;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(string.Empty));
			}
		}

		#endregion

		#region Properties

		public string DisplayName
		{
			get;
		}

		#endregion

	}

}
