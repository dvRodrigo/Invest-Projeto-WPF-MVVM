using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.Data.Model
{
    public class Corretora : BaseModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("Id"); }
        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; OnPropertyChanged("Nome"); }
        }
        private string _cnpj;

        public string CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; OnPropertyChanged("CNPJ"); }
        }

        public Corretora()
        {
        }

        public Corretora(Corretora build)
        {
            Id = build.Id;
            Nome = build.Nome;
            CNPJ = build.CNPJ;
        }
        
    }
}
