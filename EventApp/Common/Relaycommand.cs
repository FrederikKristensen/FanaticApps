using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventApp.Common
{
    class Relaycommand : ICommand
    {
        private Action _Method;

        public Relaycommand(Action method)
        {
            _Method = method;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _Method?.Invoke();
        }
    }
}
