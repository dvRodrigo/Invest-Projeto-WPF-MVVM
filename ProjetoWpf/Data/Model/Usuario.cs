using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.Data.Model
{
    public class Usuario : BaseModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("Id"); }
        }

        private string _login;

        public string Login
        {
            get { return _login; }
            set { _login = value; OnPropertyChanged("Login"); }
        }

        private string _senha;

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; OnPropertyChanged("Senha"); }
        }

        private int? _idInvestidor;

        public int? IdInvestidor
        {
            get { return _idInvestidor; }
            set { _idInvestidor = value; OnPropertyChanged("IdInvestidor"); }
        }

    }
}
