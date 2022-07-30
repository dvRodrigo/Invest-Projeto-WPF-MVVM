using ProjetoWpf.Commands;
using ProjetoWpf.Data.Gerenciadores;
using ProjetoWpf.Data.Model;
using ProjetoWpf.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.ViewModels
{
    public class MeuCadastroViewModel : BaseViewModel
    {
        #region Commands
        public SairMeuCadastroCommand SairMeuCadastroCommand { get; set; }
        public AddMeuCadastro AddMeuCadastroCommand { get; set; }
        #endregion

        #region Properties
        private Investidor _investidorAtual;

        public Investidor InvestidorAtual
        {
            get { return _investidorAtual; }
            set { _investidorAtual = value; OnPropertyChanged("InvestidorAtual"); }
        }

        private List<Corretora> _corretorasCadastradas;

        public List<Corretora> CorretorasCadastradas
        {
            get { return _corretorasCadastradas; }
            set { _corretorasCadastradas = value; OnPropertyChanged("CorretorasCadastradas"); }
        }

        private GerenciadorInvestidor _gerenciadorInvestidor { get; set; }

        #endregion


        public MeuCadastroViewModel() : base()
        {
            this.SairMeuCadastroCommand = new SairMeuCadastroCommand();
            this.AddMeuCadastroCommand = new AddMeuCadastro(this);         
            this._gerenciadorInvestidor = new GerenciadorInvestidor(_context);
            this.InvestidorAtual = _gerenciadorInvestidor.ObterInvestidor(Helpers.UsuarioAtual.IdInvestidor);

        }

        public void EnviarRegistro()
        {
            _gerenciadorInvestidor.SalvarOuAtualizar(this.InvestidorAtual);
            if (Helpers.UsuarioAtual.IdInvestidor is null)
            {
                _gerenciadorInvestidor.ConectarInvestidorAoLogin(Helpers.UsuarioAtual.Id, this.InvestidorAtual.IdInvestidor);
                Helpers.UsuarioAtual.IdInvestidor = this.InvestidorAtual.IdInvestidor;
            }
           
        }
    }
}
