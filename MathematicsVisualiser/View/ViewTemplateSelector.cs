using System.Windows;
using System.Windows.Controls;
using MathematicsVisualiser.ViewModel.Operations;

namespace MathematicsVisualiser.View
{
	/// <inheritdoc />
	/// <summary>
	/// This class is used do determine which type (unary, bonary or ternary)  the selected operation is of.
	/// As checking for generics is not possible in XAML it is done by this DataTemplateSelector.
	/// </summary>
	class ViewTemplateSelector : DataTemplateSelector
	{

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			DataTemplate template = null;

			if (item == null)
			{
				return null;
			}

			if (!(container is FrameworkElement element))
			{
				return null;
			}

			var typeOf = item.GetType();
			var unaryType = typeof(UnaryOperation<,>);
			var binaryType = typeof(BinaryOperation<,,>);
			var ternaryType = typeof(TernaryOperation<,,,>);

			//Order is important:
			//as the ternary operation is derived from the binary and therefore the unary operation
			//all of these if-blocks would be correct
			//that's why the ternary is first, then theres binary and unary

			if (typeOf.IsOfGenericType(ternaryType))
			{
				template = element.FindResource("TernaryOperationTemplate") as DataTemplate;
			}
			else if (typeOf.IsOfGenericType(binaryType))
			{
				template = element.FindResource("BinaryOperationTemplate") as DataTemplate;
			}
			else if (typeOf.IsOfGenericType(unaryType))
			{
				template = element.FindResource("UnaryOperationTemplate") as DataTemplate;
			}
			else
			{
				throw new System.Exception(nameof(item));
			}

			return template;
		}

	}
}