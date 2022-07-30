using ProjetoWpf.Commands;
using ProjetoWpf.Data.Gerenciadores;
using ProjetoWpf.Helper;
using ProjetoWpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ProjetoWpf.ViewModels
{
    public class LogarViewModel : BaseViewModel
    {
        #region Propriedades
        private string _usuario;

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; OnPropertyChanged("Usuario"); }
        }
        private GerenciadorUsuario _gerenciador;
        #endregion

        #region Commands
        public LogarCommand Logar { get; set; }
        public ChamarTrocarSenhaCommand ChamarTelaTrocarSenha { get; set; }
        #endregion
        public LogarViewModel() : base()
        {
            Logar = new LogarCommand(this);
            ChamarTelaTrocarSenha = new ChamarTrocarSenhaCommand();
            _gerenciador = new GerenciadorUsuario(_context);
        }

        public void RealizarLogin(string usuario, string senha)
        {
            if (_gerenciador.ValidarAcesso(usuario,senha))
            {
                Helpers.UsuarioAtual = _gerenciador.ObterUsuarioByLogin(usuario);
                var telaPrincipal = new WinPrincipal();
                telaPrincipal.Show();
                Helper.Helpers.FecharTelaLogin();
            }
            else
            {
                MessageBox.Show("Dados Incorretos!","!!!",MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }
    }
}
