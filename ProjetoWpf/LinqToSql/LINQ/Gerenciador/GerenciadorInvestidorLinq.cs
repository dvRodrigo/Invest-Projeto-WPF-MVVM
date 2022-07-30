using ProjetoWpf.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.LinqToSql.LINQ.Gerenciador
{
    public class GerenciadorInvestidorLinq : GerenciadorBaseLinq
    {
        public GerenciadorInvestidorLinq(DataBaseDataContext context) : base(context)
        {

        }

        public void SalvarOuAtualizar(Investidores investidor)
        {
            if (investidor.PK_Investidor == 0)
            {
                Context.Investidores.InsertOnSubmit(investidor);
                Context.SubmitChanges();
            }
            else
            {
                var inv = Context.Investidores.First(x => x.PK_Investidor == investidor.PK_Investidor);
                inv.NomeCompleto = investidor.NomeCompleto;
                inv.Email = investidor.Email;
                inv.Contato = investidor.Contato;
                inv.FK_Corretora = investidor.FK_Corretora;
                Context.SubmitChanges();
            }
        }
        public void ConectarInvestidorAoLogin(int idLogin, int idInvestidor)
        {
            var usuario = Context.Usuarios.First(x => x.PK_Usuario == idLogin);
            usuario.FK_Investidor = idInvestidor;
            Context.SubmitChanges();        
        }

        public Investidores ObterInvestidor (int idInvestidor)
        {
            return Context.Investidores.First(x => x.PK_Investidor == idInvestidor);
        }
    }
}
