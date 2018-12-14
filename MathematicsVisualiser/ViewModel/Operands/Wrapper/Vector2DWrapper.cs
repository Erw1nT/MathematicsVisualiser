using System;
using System.Windows;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using MathematicsVisualiser.ViewModel.Operands.Helper;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	class Vector2DWrapper : GenericWrapper<Vector>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Vector2DWrapper() : base("Vector 2D")
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

				var v = new Vector(value, WrappedItem.Y);
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

				var v = new Vector(WrappedItem.X, value);
				WrappedItem = v;
			}
		}

		public override GeometryModel3D Content
		{
			get
			{
				if (!LastCalculation.HasValue)
				{
				}

				var meshBuilder = new MeshBuilder();

				var startPoint = new Point3D(0, 0, 0);
				var endPoint = WrappedItem.ToPoint3D();
				
				meshBuilder.AddArrow(startPoint, endPoint, 0.1);

				var mat = new DiffuseMaterial(System.Windows.Media.Brushes.Orange);
				var model = new GeometryModel3D(meshBuilder.ToMesh(), mat);

				return model;
				
			}
		}

		#endregion
	}
}
