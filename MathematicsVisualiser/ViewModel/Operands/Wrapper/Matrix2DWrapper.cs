using System;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using MathematicsVisualiser.ViewModel.Operands.Helper;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	class Matrix2DWrapper : GenericWrapper<Matrix>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Matrix2DWrapper() : base("Matrix 2D")
		{
		}


		#endregion

		#region Methods

		#endregion

		#region Properties

		public double M11
		{
			get
			{
				return WrappedItem.M11;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M11) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M11 = value;
				WrappedItem = m;


				RaisePropertyChanged(nameof(M11));
			}
		}

		public double M12
		{
			get
			{
				return WrappedItem.M12;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M12) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M12 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M12));
			}
		}

		public double M21
		{
			get
			{
				return WrappedItem.M21;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M21) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M21 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M21));
			}
		}

		public double M22
		{
			get
			{
				return WrappedItem.M22;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M22) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M22 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M22));
			}
		}

		public double OffsetX
		{
			get
			{
				return WrappedItem.OffsetX;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.OffsetX) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.OffsetX = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(OffsetX));
			}
		}

		public double OffsetY
		{
			get
			{
				return WrappedItem.OffsetY;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.OffsetY) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.OffsetY = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(OffsetY));
			}
		}

		public override Model3D Content
		{
			get
			{
				var pt = WrappedItem.Point();

				var xAxis = WrappedItem.XAxis().ToGeometry3D(pt);
				var yAxis = WrappedItem.YAxis().ToGeometry3D(pt);
				var point = pt.ToGeometry3D();

				var xAxisContent = new GeometryModel3D(xAxis, new DiffuseMaterial(Brushes.Red));
				var yAxisContent = new GeometryModel3D(yAxis, new DiffuseMaterial(Brushes.Green));
				var pointContent = new GeometryModel3D(point, new DiffuseMaterial(Brushes.Gray));

				var group = new Model3DGroup();
				group.Children.Add(xAxisContent);
				group.Children.Add(yAxisContent);
				group.Children.Add(pointContent);

				return group;
			}
		}

		#endregion

	}
}
