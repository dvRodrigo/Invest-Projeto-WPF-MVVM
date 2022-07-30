using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.LinqToSql.LINQ.Gerenciador
{
    public class GerenciadorBaseLinq
    {
        public DataBaseDataContext Context { get; }
        public GerenciadorBaseLinq(DataBaseDataContext context)
        {
            this.Context = context;           
        }    
    }
}
