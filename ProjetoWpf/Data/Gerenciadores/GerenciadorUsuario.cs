using ProjetoWpf.Data.Model;
using ProjetoWpf.LinqToSql;
using ProjetoWpf.LinqToSql.LINQ.Gerenciador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.Data.Gerenciadores
{
    public class GerenciadorUsuario
    {
        private GerenciadorUsuariosLinq _usuarioLinq;

        public GerenciadorUsuario(DataBaseDataContext context)
        {
            _usuarioLinq = new GerenciadorUsuariosLinq(context);
        }



        public bool ValidarAcesso(string usuario, string senha)
        {
            return _usuarioLinq.ValidarAcesso(usuario, senha);
        }

        public bool ValidarUsuario(string usuario)
        {
            return _usuarioLinq.ValidarUsuario(usuario);
        }

        public void AtualizarSenha(string usuario,string senha)
        {
             _usuarioLinq.AtualizarSenha(usuario, senha);
        }

        public Usuario ObterUsuarioByLogin(string usuario)
        {
            var usuarioAtual = _usuarioLinq.ObterUsuarioByLogin(usuario);
            return ConvertToClassObj(usuarioAtual);
        } 

        private Usuario ConvertToClassObj(Usuarios usuarioBanco)
        {
            return new Usuario()
            {
                Id = usuarioBanco.PK_Usuario,
                Login = usuarioBanco.Login,
                IdInvestidor = usuarioBanco.FK_Investidor
            };
        }
    }
}
