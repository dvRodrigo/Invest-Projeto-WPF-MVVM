using ProjetoWpf.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetoWpf.Helper
{
    public static class Helpers
    {
        public static Usuario UsuarioAtual { get; set; }
        public static void FecharTelaLogin()
        {
            var telaLogin = Application.Current.Windows.OfType<Window>().First();
            telaLogin.Close();
        }

        public static void FecharUltimaTela()
        {
            var telaLogin = Application.Current.Windows.OfType<Window>().Last();
            telaLogin.Close();
        }
    }
}
