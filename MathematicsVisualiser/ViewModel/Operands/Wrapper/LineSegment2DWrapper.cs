using System.Windows.Media;
using System.Windows.Media.Media3D;
using MathematicsVisualiser.ViewModel.Operands.Helper;

namespace MathematicsVisualiser.ViewModel.Operands.Wrapper
{
	class LineSegment2DWrapper : GenericWrapper<LineSegment2D>
	{
		public LineSegment2DWrapper(string name) : base(name)
		{
		}

		public override Model3D Content
		{
			get
			{
				var ptStart = WrappedItem.StartPoint;
				var ptEnd = WrappedItem.EndPoint;
				var v = WrappedItem.Direction;

				var startContent = new GeometryModel3D(ptStart.ToGeometry3D(), new DiffuseMaterial(Brushes.Gray));
				var endContent = new GeometryModel3D(ptEnd.ToGeometry3D(), new DiffuseMaterial(Brushes.Gray));
				var dirContent = new GeometryModel3D(v.ToGeometry3D(ptStart), new DiffuseMaterial(Brushes.Blue));

				var group = new Model3DGroup();
				group.Children.Add(startContent);
				group.Children.Add(endContent);
				group.Children.Add(dirContent);

				return group;

			}
		}
	}
}
