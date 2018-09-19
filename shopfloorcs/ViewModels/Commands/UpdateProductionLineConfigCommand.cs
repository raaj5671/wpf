﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace shopfloorcs.ViewModels.Commands
{
    public class UpdateProductionLineConfigCommand : ICommand
    {
        public ProductionLineConfigViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public UpdateProductionLineConfigCommand(ProductionLineConfigViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.updateProductionLineConfig();
        }
    }
}
