using NPOI.SS.Formula.Functions;
using ProjetoWpf.ViewModels;
using ProjetoWpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjetoWpf.Commands
{
    public class LogarCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private LogarViewModel _vm;
        public LogarCommand(LogarViewModel view)
        {
            _vm = view;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string senha = (parameter as PasswordBox).Password;
            _vm.RealizarLogin(_vm.Usuario, senha);           
        }

    }
}
