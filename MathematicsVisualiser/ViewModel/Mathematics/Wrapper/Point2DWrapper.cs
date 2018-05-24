using GalaSoft.MvvmLight.CommandWpf;
using MathematicsVisualiser.ViewModel.Operations;
using System.Windows;

namespace MathematicsVisualiser.ViewModel.Mathematics.Wrapper
{
	public class Point2DWrapper : GenericWrapper<Point>
	{

		#region Constants

		#endregion

		#region Attributes

		#endregion

		#region Construct

		public Point2DWrapper(BaseOperationViewModel parentOperation) : base("Point 2D", parentOperation)
		{
		}

		#endregion

		#region Methods

		protected override void InitializeCommands()
		{
			Commands.Add(new CommandWrapper("Normalize", new RelayCommand(NormalizeCommandExecute)));
		}

		private void NormalizeCommandExecute()
		{
			var t = (Vector) WrappedItem;
			t.Normalize();
			WrappedItem = (Point) t;

			ParentOperation.CalulateResult(this);
			RaisePropertyChanged();
		}

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

		#endregion

	}
}
