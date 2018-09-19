using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using shopfloorcs.Models;

namespace shopfloorcs.ViewModels.Commands
{
    public class CustomCommand<T> : ICommand
    {
        private readonly Action<T> _action;
        private readonly Predicate<T> _canExecute;
        private Action updateProductionLineConfig;
        private Action<ProductionLineConfig> update;

        public event EventHandler CanExecuteChanged;

        public CustomCommand(Action<T> action, Predicate<T> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        //public CustomCommand(Action updateProductionLineConfig, Action<ProductionLineConfig> update)
        //{
        //    this.updateProductionLineConfig = updateProductionLineConfig;
        //    this.update = update;
        //}

        public bool CanExecute(object parameter)
        {
            return _canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            _action((T)parameter);
        }
    }
}
