using ProjetoWpf.ViewModels;
using ProjetoWpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjetoWpf.Commands
{
    public class ChamarTrocarSenhaCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public ChamarTrocarSenhaCommand()
        {

        }
        public void Execute(object parameter)
        {
            var telaTrocarSenha = new WinTrocarSenha();
            telaTrocarSenha.Show();
        }
    }
}
