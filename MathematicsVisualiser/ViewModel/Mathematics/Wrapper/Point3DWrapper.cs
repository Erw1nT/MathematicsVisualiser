using MathematicsVisualiser.ViewModel.Operations;
using System.Windows.Media.Media3D;

namespace MathematicsVisualiser.ViewModel.Mathematics.Wrapper
{
	class Point3DWrapper : GenericWrapper<Point3D>
	{
		public Point3DWrapper(BaseOperationViewModel parentOperation) : base("Point 3D", parentOperation)
		{
		}

		protected override void InitializeCommands()
		{
		}

		public double X
		{
			get
			{
				return WrappedItem.X;
			}
			set
			{
				var currentItem = WrappedItem;
				currentItem.X = value;
				WrappedItem = currentItem;

				RaisePropertyChanged(() => X);
				ParentOperation.CalulateResult(this);
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
				var currentItem = WrappedItem;
				currentItem.Y = value;
				WrappedItem = currentItem;

				RaisePropertyChanged(() => Y);
				ParentOperation.CalulateResult(this);
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
				var currentItem = WrappedItem;
				currentItem.Z = value;
				WrappedItem = currentItem;

				RaisePropertyChanged(() => Z);
				ParentOperation.CalulateResult(this);
			}
		}

		#region Overrides of BaseMathematicsViewModel

		#endregion
	}
}
