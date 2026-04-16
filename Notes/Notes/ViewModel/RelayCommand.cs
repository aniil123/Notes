using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notes.ViewModel
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public void Execute(object parameter)
            => _execute(parameter);

        public bool CanExecute(object parameter)
            => _canExecute == null || _canExecute(parameter);

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
    }
}
