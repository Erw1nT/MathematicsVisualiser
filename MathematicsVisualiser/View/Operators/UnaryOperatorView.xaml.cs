using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace MathematicsVisualiser.View.Operators
{
	/// <summary>
	/// Interaction logic for UnaryOperatorView.xaml
	/// </summary>
	public partial class UnaryOperatorView : UserControl
	{

		public UnaryOperatorView()
		{
			InitializeComponent();
		}

		//TODO: Wieso zur Hölle geht das überhaupt nicht>
		

		public static readonly DependencyProperty OperandProperty =
			DependencyProperty.Register("Operand",
			typeof(object),
			typeof(UnaryOperatorView));

		public object Operand
		{
			get
			{
				return GetValue(OperandProperty);
			}
			set
			{
				SetValue(OperandProperty, value);
			}
		}

	}
}
