using GalaSoft.MvvmLight.Command;
using MathematicsVisualiser.ViewModel.Operations;
using System.Windows;

namespace MathematicsVisualiser.ViewModel.Mathematics.Wrapper
{
	class Vector2DWrapper : GenericWrapper<Vector>
	{

		public Vector2DWrapper(BaseOperationViewModel parentOperation) : base("Vector 2D", parentOperation)
		{

		}

		protected override void InitializeCommands()
		{
			Commands.Add(new CommandWrapper("Normalize", new RelayCommand(NormalizeCommandExecute)));
		}

		private void NormalizeCommandExecute()
		{
			var t = WrappedItem;
			t.Normalize();
			WrappedItem = t;

			ParentOperation.CalulateResult(this);
			RaisePropertyChanged();
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

	}
}
