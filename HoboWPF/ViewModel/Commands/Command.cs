using System.Windows.Input;

namespace HoboWPF.ViewModel.Commands
{
    class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly Action action;

        public Command(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            action();
        }
    }
}
