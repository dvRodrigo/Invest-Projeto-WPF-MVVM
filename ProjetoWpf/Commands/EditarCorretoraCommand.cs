using ProjetoWpf.Data.Model;
using ProjetoWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjetoWpf.Commands
{
    public class EditarCorretoraCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private CorretoraViewModel _vm;
        public EditarCorretoraCommand(CorretoraViewModel vm)
        {
            _vm = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {             
           _vm.CorretoraAtual = new Corretora((Corretora)parameter);
        }
    }
}
