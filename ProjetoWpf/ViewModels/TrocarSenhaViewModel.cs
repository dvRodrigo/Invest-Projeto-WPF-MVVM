using ProjetoWpf.Commands;
using ProjetoWpf.Data.Gerenciadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetoWpf.ViewModels
{
    public class TrocarSenhaViewModel : BaseViewModel
    {
        #region Propriedades
        private GerenciadorUsuario _gerenciador { get; set; }
        private string _usuario;

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; OnPropertyChanged("Usuario"); }
        }
        #endregion

        #region Commands
        public TrocarSenhaCommand TrocarSenha { get; set; }
        #endregion

        public TrocarSenhaViewModel() : base()
        {
            _gerenciador = new GerenciadorUsuario(_context);
            TrocarSenha = new TrocarSenhaCommand(this);
        }

        public void RealizarTrocaDeSenha(string senha, string confirSenha)
        {
            if (_gerenciador.ValidarUsuario(this.Usuario))
            {
                if (senha == confirSenha)
                {
                    _gerenciador.AtualizarSenha(this.Usuario, senha);
                    Helper.Helpers.FecharUltimaTela();
                }
                else
                {
                    MessageBox.Show("Senhas Divergentes");
                }
            }
            else
            {
                MessageBox.Show("Usuario não existe");
            }
        }
    }
}
