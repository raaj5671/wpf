using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace shopfloorcs.ViewModels.Commands
{
    public class RegisterCommand : ICommand
    {
        public UserViewModel uservm { get; set; }
        public event EventHandler CanExecuteChanged;

        public RegisterCommand(UserViewModel vm)
        {
            uservm = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //TODO
        }
    }
}
