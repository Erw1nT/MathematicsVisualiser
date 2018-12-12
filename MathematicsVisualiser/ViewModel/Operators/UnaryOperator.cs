namespace MathematicsVisualiser.ViewModel.Operators
{
	public class UnaryOperator
	{

		private UnaryOperator(string symbolFront, string symbolBack, string symbolHat, OperatorPosition position)
		{
			SymbolFront = symbolFront;
			SymbolBack = symbolBack;
			SymbolHat = symbolHat;
			Position = position;
		}

		public static UnaryOperator GetSurroundingOperator(string symbol)
		{
			var newOperator = new UnaryOperator(symbol, symbol, null, OperatorPosition.Surrounding);
			return newOperator;
		}

		public static UnaryOperator GetPrefixOperator(string symbol, OperatorPosition position)
		{
			if (position == OperatorPosition.Above || position == OperatorPosition.Surrounding)
			{
				throw new System.Exception(nameof(position));
			}

			var newOperator = new UnaryOperator(symbol, null, null, position);
			return newOperator;
		}

		public static UnaryOperator GetPostfixOperator(string symbol, OperatorPosition position)
		{
			if (position == OperatorPosition.Above || position == OperatorPosition.Surrounding)
			{
				throw new System.Exception(nameof(position));
			}

			var newOperator = new UnaryOperator(null, symbol, null, position);
			return newOperator;
		}

		public static UnaryOperator GetHatOperator(string symbol)
		{
			var newOperator = new UnaryOperator(null, null, symbol, OperatorPosition.Above);
			return newOperator;
		}

		public string SymbolFront
		{
			get;
		}

		public string SymbolBack
		{
			get;
		}

		public string SymbolHat
		{
			get;
		}

		public OperatorPosition Position
		{
			get;
		}

	}
}
