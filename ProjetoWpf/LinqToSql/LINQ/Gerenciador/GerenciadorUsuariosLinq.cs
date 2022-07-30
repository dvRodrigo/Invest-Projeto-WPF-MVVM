using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetoWpf.LinqToSql.LINQ.Gerenciador
{
   public class GerenciadorUsuariosLinq : GerenciadorBaseLinq
    {
        public GerenciadorUsuariosLinq(DataBaseDataContext context) : base(context)
        {
            
        }

        public bool ValidarAcesso(string usuario, string senha)
        {
            return Context.Usuarios.Any(x => x.Login == usuario && x.Senha == senha);
        }
        public bool ValidarUsuario(string usuario)
        {
            return Context.Usuarios.Any(x => x.Login == usuario);
        }

        public void AtualizarSenha(string usuario,string senha)
        {
            var registro = Context.Usuarios.FirstOrDefault(x => x.Login == usuario);
            registro.Senha = senha;
            Context.SubmitChanges();
        }

        public Usuarios ObterUsuarioByLogin(string usuario)
        {
            return Context.Usuarios.First(x => x.Login == usuario);
        }
    }
}
