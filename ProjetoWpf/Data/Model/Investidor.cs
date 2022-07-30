using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.Data.Model
{
    public class Investidor : BaseModel
    {
        private int _idInvestidor;

        public int IdInvestidor
        {
            get { return _idInvestidor; }
            set { _idInvestidor = value; OnPropertyChanged("IdInvestidor"); }
        }
        private string _nomeCompleto;

        public string NomeCompleto
        {
            get { return _nomeCompleto; }
            set { _nomeCompleto = value; OnPropertyChanged("NomeCompleto"); }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged("Email"); }
        }

        private string _contato;

        public string Contato
        {
            get { return _contato; }
            set { _contato = value; OnPropertyChanged("Contato"); }
        }

        private int? _idCorretora;

        public int? IdCorretora
        {
            get { return _idCorretora; }
            set { _idCorretora = value; OnPropertyChanged("IdCorretora"); }
        }



    }
}
