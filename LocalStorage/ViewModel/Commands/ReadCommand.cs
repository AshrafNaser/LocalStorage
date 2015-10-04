using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LocalStorage.ViewModel.Commands
{
   public class ReadCommand : ICommand
    {
        public MainViewModel MainViewModel { get; set; }
        public ReadCommand( MainViewModel mainViewModel)
        {
            this.MainViewModel = mainViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (parameter != null)
            {
                var s = parameter as string;
                s = s.Trim();
                if (string.IsNullOrEmpty(s))
                {
                    return true;
                }
                return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            this.MainViewModel.ReadMethod(parameter as string);
        }
    }
}
