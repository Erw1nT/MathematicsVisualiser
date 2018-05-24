using System.Windows.Input;

namespace MathematicsVisualiser.ViewModel.Mathematics
{
	public class CommandWrapper : BaseViewModel
	{

		public CommandWrapper(string name, ICommand command) : base(name)
		{
			Command = command;
		}

		public ICommand Command
		{
			get;
		}

	}
}
