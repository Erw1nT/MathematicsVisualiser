using MathematicsVisualiser.ViewModel.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsVisualiser.ViewModel.Operations
{
	public class BaseOperationViewModel : BaseViewModel
	{
		#region Constants

		private BaseMathematicsViewModel _result;

		#endregion

		#region Attributes

		#endregion

		#region Construct

		protected BaseOperationViewModel(string name, string text, BaseMathematicsViewModel target) : base(name)
		{
			Text = text;
			Target = target;
		}

		#endregion

		#region Methods

		#endregion

		#region Properties
		
		public string Text
		{
			get;
		}
		public readonly BaseMathematicsViewModel Target;

		public BaseMathematicsViewModel Result
		{
			get
			{
				return _result;
			}

			protected set
			{
				_result = value;
			}
		}

		#endregion

	}
}
