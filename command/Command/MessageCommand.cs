using System;
using System.Windows.Input;

//Single use command
//Relay or delegate command

namespace command.Command
{
    public class MessageCommand:ICommand
    {
        private Action _execute { get; set; }

        public MessageCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }

        public event EventHandler CanExecuteChanged;
    }
}
