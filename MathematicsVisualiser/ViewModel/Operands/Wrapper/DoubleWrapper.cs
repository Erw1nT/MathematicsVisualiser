using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	class DoubleWrapper : GenericWrapper<double>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public DoubleWrapper() : base("Double")
		{
		}

		#endregion

		#region Methods

		#endregion

		#region Properties

		public override Model3D Content
		{
			get
			{
				if (LastCalculation.HasValue && LastCalculation.Value.Key == WrappedItem)
				{
					return LastCalculation.Value.Value;
				}
				
				var t = TextCreator.CreateTextLabelModel3D(WrappedItem.ToString(CultureInfo.InvariantCulture), Brushes.Black, true, 1, new Point3D(), new Vector3D(1, 0, 0), new Vector3D(0, 1, 0));
				
				if (!LastCalculation.HasValue)
				{
					LastCalculation = new System.Collections.Generic.KeyValuePair<double, GeometryModel3D>(WrappedItem, t);
				}

				return t;
			}
		}

		#endregion


	}
}
