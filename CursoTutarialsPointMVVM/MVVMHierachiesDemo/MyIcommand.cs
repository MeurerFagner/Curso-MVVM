using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMHierachiesDemo
{
    public class MyIcommand : ICommand
    {
        Action _TargetExecuteMethod;
        Func<bool> _TargetCanExecuteMethod;

        public MyIcommand(Action executeMethod)
        {
            _TargetExecuteMethod = executeMethod;
        }

        public MyIcommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            _TargetExecuteMethod = executeMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged = delegate { };

        public bool CanExecute(object parameter)
        {
            if (_TargetCanExecuteMethod != null)
                return _TargetCanExecuteMethod();

            if (_TargetExecuteMethod != null)
                return true;

            return false;
        }


        public void Execute(object parameter)
        {
            _TargetExecuteMethod?.Invoke();
        }
    }
}
