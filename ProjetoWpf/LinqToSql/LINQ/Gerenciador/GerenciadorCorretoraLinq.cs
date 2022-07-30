using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.LinqToSql.LINQ.Gerenciador
{
    public class GerenciadorCorretoraLinq : GerenciadorBaseLinq
    {
        public GerenciadorCorretoraLinq(DataBaseDataContext context) : base(context)
        {
        }

        public void SalvarOuAtualizar(Corretoras data)
        {
            if (data.PK_Corretora == 0)
            {
                Context.Corretoras.InsertOnSubmit(data);
                Context.SubmitChanges();
            }
            else
            {
                var corretora = Context.Corretoras.Single(x => x.PK_Corretora == data.PK_Corretora);
                corretora.Nome = data.Nome;
                corretora.CNPJ = data.CNPJ;
                Context.SubmitChanges();
            }
            
        }

        public void Deletar(int idCorretora)
        {
            var registro = Context.Corretoras.First(x => x.PK_Corretora == idCorretora);
            Context.Corretoras.DeleteOnSubmit(registro);
            Context.SubmitChanges();
        }

        public List<Corretoras> CarregarCorretoras()
        {
            return Context.Corretoras.ToList();
        }
    }
}
