using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace MathematicsVisualiser.ViewModel
{
	public class BaseViewModel : ViewModelBase
	{

		#region Attributes

		#endregion

		#region Construct

		public BaseViewModel(string name)
		{
			DisplayName = name;
		}
		
		#endregion
		
		#region Properties

		public string DisplayName
		{
			get;
			set;
		}

		#endregion
		
	}
}
