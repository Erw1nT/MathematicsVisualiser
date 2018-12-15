using System;
using System.Windows;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using MathematicsVisualiser.ViewModel.Operands.Helper;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	class Vector3DWrapper : GenericWrapper<Vector3D>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Vector3DWrapper() : base("Vector 3D")
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

				var v = new Vector3D(value, WrappedItem.Y, WrappedItem.Z);
				WrappedItem = v;
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

				var v = new Vector3D(WrappedItem.X, value, WrappedItem.Z);
				WrappedItem = v;
			}
		}

		public double Z
		{
			get
			{
				return WrappedItem.Z;
			}
			set
			{
				if (Math.Abs(value - WrappedItem.Z) < 0.01)
				{
					return;
				}

				var v = new Vector3D(WrappedItem.X, WrappedItem.Y, value);
				WrappedItem = v;
			}
		}

		public override Model3D Content
		{
			get
			{
				if (LastCalculation.HasValue && LastCalculation.Value.Key == WrappedItem)
				{
					return LastCalculation.Value.Value;
				}

				var mat = new DiffuseMaterial(System.Windows.Media.Brushes.Orange);
				var model = new GeometryModel3D(WrappedItem.ToGeometry3D(), mat);

				if (!LastCalculation.HasValue)
				{
					LastCalculation = new System.Collections.Generic.KeyValuePair<Vector3D, GeometryModel3D>(WrappedItem, model);
				}

				return model;
			}
		}

		#endregion
	}
}
