using GalaSoft.MvvmLight;

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
		
		#region Properties

		public string DisplayName
		{
			get;
		}

		#endregion
		
	}
}
