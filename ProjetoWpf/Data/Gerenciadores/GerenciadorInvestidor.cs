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
   public class GerenciadorInvestidor
    {
        private GerenciadorInvestidorLinq _investidorLinq;
        public GerenciadorInvestidor(DataBaseDataContext context)
        {
            _investidorLinq = new GerenciadorInvestidorLinq(context);
        }

        public void SalvarOuAtualizar(Investidor build)
        {
            var data = ConverterToDataBase(build);
            _investidorLinq.SalvarOuAtualizar(data);
            build.IdInvestidor = data.PK_Investidor;
        }

        private Investidores ConverterToDataBase(Investidor build)
        {
            int? corretora = null;
            if (build.IdCorretora != 0)
            {
                corretora = build.IdCorretora;
            }
            return new Investidores()
            {
                PK_Investidor = build.IdInvestidor,
                NomeCompleto = build.NomeCompleto,
                Email = build.Email,
                Contato = build.Contato,
                FK_Corretora = corretora
            };
        }

        public void ConectarInvestidorAoLogin(int idLogin, int idInvestidor)
        {
            _investidorLinq.ConectarInvestidorAoLogin(idLogin, idInvestidor);
        }

        public Investidor ObterInvestidor(int? idInvestidor)
        {
            if (idInvestidor is null)
            {
                return new Investidor();
            }
            else
            {
                return ConverterToClassObj(_investidorLinq.ObterInvestidor((int)idInvestidor));
            }
            
        }

        public Investidor ConverterToClassObj(Investidores inv)
        {
            return new Investidor()
            {
                IdInvestidor = inv.PK_Investidor,
                NomeCompleto = inv.NomeCompleto,
                Email = inv.Email,
                Contato = inv.Contato,
                IdCorretora = inv.FK_Corretora
            };
        }
    }
}
