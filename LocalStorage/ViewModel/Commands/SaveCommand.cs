using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LocalStorage.ViewModel.Commands
{
    public class SaveCommand : ICommand
    {
        public MainViewModel MainViewModel { get; set; }
        public SaveCommand( MainViewModel mainViewModel)
        {
            this.MainViewModel = mainViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (parameter != null)
            {
                var S = parameter as string;
                S = S.Trim();
                if (string.IsNullOrEmpty(S))
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            this.MainViewModel.SaveMethod(parameter as string);
        }
    }
}
