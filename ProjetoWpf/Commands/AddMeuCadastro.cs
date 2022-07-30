using ProjetoWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjetoWpf.Commands
{
    public class AddMeuCadastro : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MeuCadastroViewModel _vm;
        public AddMeuCadastro(MeuCadastroViewModel viewModel)
        {
            _vm = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _vm.EnviarRegistro();
        }
    }
}
