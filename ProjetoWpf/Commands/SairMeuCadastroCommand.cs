using ProjetoWpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProjetoWpf.Commands
{
    public class SairMeuCadastroCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var telaMeuCadastro = Application.Current.Windows.OfType<Window>()
                                     .First(x => x is WinMeuCadastro);

            telaMeuCadastro.Close();
        }
    }
}
