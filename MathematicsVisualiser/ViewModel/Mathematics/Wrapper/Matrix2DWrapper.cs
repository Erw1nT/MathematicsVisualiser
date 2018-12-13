using MathematicsVisualiser.ViewModel.Operations;
using System.Windows.Media;

namespace MathematicsVisualiser.ViewModel.Mathematics.Wrapper
{
	class Matrix2DWrapper : GenericWrapper<Matrix>
	{

		public Matrix2DWrapper(BaseOperationViewModel parentOperation) : base("Matrix 2D", parentOperation)
		{
		}

		protected override void InitializeCommands()
		{
		}

		public double M11
		{
			get
			{
				return WrappedItem.M11;
			}
			set
			{
				var currentItem = WrappedItem;
				currentItem.M11 = value;
				WrappedItem = currentItem;

				RaisePropertyChanged(() => M11);
				ParentOperation.CalulateResult(this);
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
				var currentItem = WrappedItem;
				currentItem.M12 = value;
				WrappedItem = currentItem;

				RaisePropertyChanged(() => M12);
				ParentOperation.CalulateResult(this);
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
				var currentItem = WrappedItem;
				currentItem.M21 = value;
				WrappedItem = currentItem;

				RaisePropertyChanged(() => M21);
				ParentOperation.CalulateResult(this);
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
				var currentItem = WrappedItem;
				currentItem.M22 = value;
				WrappedItem = currentItem;

				RaisePropertyChanged(() => M22);
				ParentOperation.CalulateResult(this);
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
				var currentItem = WrappedItem;
				currentItem.OffsetX = value;
				WrappedItem = currentItem;

				RaisePropertyChanged(() => OffsetX);
				ParentOperation.CalulateResult(this);
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
				var currentItem = WrappedItem;
				currentItem.OffsetY = value;
				WrappedItem = currentItem;

				RaisePropertyChanged(() => OffsetY);
				ParentOperation.CalulateResult(this);
			}
		}

		#region Overrides of BaseMathematicsViewModel



		#endregion
	}
}
