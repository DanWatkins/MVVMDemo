using System;
using System.Windows.Input;

namespace HierarchiesDemo
{
    public class MyCommand<T> : ICommand
    {
        private Action<T> _executeMethod;
        private Func<T, bool> _canExecuteMethod;

        public event EventHandler CanExecuteChanged;

        public MyCommand(Action<T> executeMethod)
        {
            _executeMethod = executeMethod;
        }

        public MyCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
        {
            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecuteMethod != null)
                return _canExecuteMethod((T)parameter);

            return _executeMethod != null;
        }

        public void Execute(object parameter)
        {
            _executeMethod?.Invoke((T)parameter);
        }
    }
}