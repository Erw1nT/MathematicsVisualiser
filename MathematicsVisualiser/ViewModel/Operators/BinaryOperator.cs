namespace MathematicsVisualiser.ViewModel.Operators
{
	public class BinaryOperator
	{

		private BinaryOperator(string symbol, OperatorPosition position)
		{
			Symbol = symbol;
			Position = position;
		}

		public static BinaryOperator GetSuperscriptOperator(string symbol)
		{
			var newOperator = new BinaryOperator(symbol, OperatorPosition.Superscript);
			return newOperator;
		}

		public static BinaryOperator GetCenteredOperator(string symbol)
		{
			var newOperator = new BinaryOperator(symbol, OperatorPosition.Center);
			return newOperator;
		}

		public static BinaryOperator GetSubscriptOperator(string symbol)
		{
			var newOperator = new BinaryOperator(symbol, OperatorPosition.Subscript);
			return newOperator;
		}

		public string Symbol
		{
			get;
		}

		public OperatorPosition Position
		{
			get;
		}

	}
}
