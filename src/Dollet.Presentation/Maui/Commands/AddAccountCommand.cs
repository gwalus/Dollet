using System.Windows.Input;

namespace Dollet.Commands
{
    public class AddAccountCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {

        }
    }
}
