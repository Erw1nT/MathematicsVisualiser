using System;
using System.Windows;
using MathematicsVisualiser.ViewModel.Operands;

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

		#endregion
	}
}
