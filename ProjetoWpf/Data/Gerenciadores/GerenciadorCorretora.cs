using ProjetoWpf.Data.Model;
using ProjetoWpf.LinqToSql;
using ProjetoWpf.LinqToSql.LINQ.Gerenciador;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.Data.Gerenciadores
{
   
    public class GerenciadorCorretora
    {
        private GerenciadorCorretoraLinq _corretoraLinq { get; set; }
        public GerenciadorCorretora(DataBaseDataContext context)
        {
            _corretoraLinq = new GerenciadorCorretoraLinq(context);
        }

        public void SalvarOuAtualizar(Corretora build)
        {
            var data = ConverterToDataBase(build);
            _corretoraLinq.SalvarOuAtualizar(data);
            build.Id = data.PK_Corretora;
        }

        private Corretoras ConverterToDataBase(Corretora build)
        {
            return new Corretoras()
            {
                PK_Corretora = build.Id,
                Nome = build.Nome,
                CNPJ = build.CNPJ
            };
        }

        private Corretora ConverterToClass(Corretoras build)
        {
            return new Corretora()
            {
                Id = build.PK_Corretora,
                Nome = build.Nome,
                CNPJ = build.CNPJ
            };
        }

        public ObservableCollection<Corretora> CarregarCorretoras()
        {
            var corretorasCarregadas = new ObservableCollection<Corretora>();
            var listCorretoras = _corretoraLinq.CarregarCorretoras();

            listCorretoras.ForEach(x => corretorasCarregadas.Add(ConverterToClass(x)));

            return corretorasCarregadas;

        }

        public void Deletar(int idCorretora)
        {
            _corretoraLinq.Deletar(idCorretora);
        }
    }
}
