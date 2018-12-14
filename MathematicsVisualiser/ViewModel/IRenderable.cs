using System.Windows.Media.Media3D;

namespace MathematicsVisualiser.ViewModel
{
	public interface IRenderable
	{
		Model3D Content { get; }
	}
}
