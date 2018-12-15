using System;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using MathematicsVisualiser.ViewModel.Operands.Helper;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	class Matrix3DWrapper : GenericWrapper<Matrix3D>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Matrix3DWrapper() : base("Matrix 3D")
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

		public double M13
		{
			get
			{
				return WrappedItem.M13;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M13) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M13 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M13));
			}
		}

		public double M14
		{
			get
			{
				return WrappedItem.M14;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M14) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M14 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M14));
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

		public double M23
		{
			get
			{
				return WrappedItem.M23;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M23) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M23 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M23));
			}
		}

		public double M24
		{
			get
			{
				return WrappedItem.M24;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M24) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M24 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M24));
			}
		}

		public double M31
		{
			get
			{
				return WrappedItem.M31;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M31) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M31 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M31));
			}
		}

		public double M32
		{
			get
			{
				return WrappedItem.M32;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M32) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M32 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M32));
			}
		}

		public double M33
		{
			get
			{
				return WrappedItem.M33;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M33) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M33 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M33));
			}
		}

		public double M34
		{
			get
			{
				return WrappedItem.M34;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M34) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M34 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M34));
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

		public double OffsetZ
		{
			get
			{
				return WrappedItem.OffsetZ;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.OffsetZ) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.OffsetZ = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(OffsetZ));
			}
		}

		public double M44
		{
			get
			{
				return WrappedItem.M44;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.M44) < 0.01)
				{
					return;
				}

				var m = WrappedItem;
				m.M44 = value;
				WrappedItem = m;

				RaisePropertyChanged(nameof(M44));
			}
		}

		public override Model3D Content
		{
			get
			{

				var pt = WrappedItem.Point();

				var xAxis = WrappedItem.XAxis().ToGeometry3D(pt);
				var yAxis = WrappedItem.YAxis().ToGeometry3D(pt);
				var zAxis = WrappedItem.ZAxis().ToGeometry3D(pt);
				var point = pt.ToGeometry3D();

				var xAxisContent = new GeometryModel3D(xAxis, new DiffuseMaterial(Brushes.Red));
				var yAxisContent = new GeometryModel3D(yAxis, new DiffuseMaterial(Brushes.Green));
				var zAxisContent = new GeometryModel3D(zAxis, new DiffuseMaterial(Brushes.Blue));
				var pointContent = new GeometryModel3D(point, new DiffuseMaterial(Brushes.Gray));

				var group = new Model3DGroup();
				group.Children.Add(xAxisContent);
				group.Children.Add(yAxisContent);
				group.Children.Add(zAxisContent);
				group.Children.Add(pointContent);

				return group;
			}
		}

		#endregion
	}
}
