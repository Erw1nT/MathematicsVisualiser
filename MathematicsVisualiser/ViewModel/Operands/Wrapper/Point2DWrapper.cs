using System;
using System.Windows;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using MathematicsVisualiser.ViewModel.Operands.Helper;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	public class Point2DWrapper : GenericWrapper<Point>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Point2DWrapper() : base("Point 2D")
		{
		}

		#endregion

		#region Methods

		#endregion

		#region Properties

		public double X
		{
			get
			{
				return WrappedItem.X;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.X) < 0.01)
				{
					return;
				}

				var p = new Point(value, WrappedItem.Y);
				WrappedItem = p;
				RaisePropertyChanged(nameof(X));
			}
		}

		public double Y
		{
			get
			{
				return WrappedItem.Y;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.Y) < 0.01)
				{
					return;
				}

				var p = new Point(WrappedItem.X, value);
				WrappedItem = p;
				RaisePropertyChanged(nameof(Y));
			}
		}

		public override Model3D Content
		{
			get
			{
				var mat = new DiffuseMaterial(System.Windows.Media.Brushes.Orange);
				var model = new GeometryModel3D(WrappedItem.ToGeometry3D(), mat);

				return model;
			}
		}

		#endregion


	}
}
