
using ProjetoWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjetoWpf.Commands
{
    public class TrocarSenhaCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private TrocarSenhaViewModel _vm;

        public TrocarSenhaCommand(TrocarSenhaViewModel viewModel)
        {
            _vm = viewModel;

        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var passwords = (parameter as object[]);
            string primeiraSenha = (passwords[0] as PasswordBox).Password;
            string segundaSenha = (passwords[1] as PasswordBox).Password;

            _vm.RealizarTrocaDeSenha(primeiraSenha, segundaSenha);
        }
    }
}
