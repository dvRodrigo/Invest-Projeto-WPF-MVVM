using ProjetoWpf.Commands;
using ProjetoWpf.Data.Gerenciadores;
using ProjetoWpf.Data.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.ViewModels
{
    public class CorretoraViewModel : BaseViewModel
    {
        #region Properties
        private Corretora _corretoraAtual;

        public Corretora CorretoraAtual
        {
            get { return _corretoraAtual; }
            set { _corretoraAtual = value; OnPropertyChanged("CorretoraAtual"); }
        }

        private ObservableCollection<Corretora> _corretorasCadastradas;

        public ObservableCollection<Corretora> CorretorasCadastradas
        {
            get { return _corretorasCadastradas; }
            set { _corretorasCadastradas = value; OnPropertyChanged("CorretorasCadastradas"); }
        }

        private GerenciadorCorretora _gerenciador { get; set; }

        #endregion

        #region Commands
        public SairCorretoraCommand SairTelaCorretora { get; set; }
        public AddCorretoraCommand AddCorretora { get; set; }
        public EditarCorretoraCommand EditCorretora { get; set; }
        public ExcluirCorretoraCommand DeletarCorretora { get; set; }
        #endregion
        public CorretoraViewModel() : base()
        {
            _gerenciador = new GerenciadorCorretora(_context);
            SairTelaCorretora = new SairCorretoraCommand();
            AddCorretora = new AddCorretoraCommand(this);
            EditCorretora = new EditarCorretoraCommand(this);
            DeletarCorretora = new ExcluirCorretoraCommand(this);
            CorretoraAtual = new Corretora();
            CorretorasCadastradas = _gerenciador.CarregarCorretoras();
        }

        public void EnviarCorretora()
        {
            VerificarLista();
            _gerenciador.SalvarOuAtualizar(this.CorretoraAtual);
            this.CorretorasCadastradas.Add(this.CorretoraAtual);
            this.CorretoraAtual = new Corretora();
        }

        public void ExcluirCorretora(Corretora corretora)
        {
            _gerenciador.Deletar(corretora.Id);
            this.CorretorasCadastradas.Remove(corretora);

        }
        void VerificarLista()
        {
            if (this.CorretorasCadastradas.Any(x => x.Id == this.CorretoraAtual.Id))
            {
                var remover = this.CorretorasCadastradas.First(x => x.Id == this.CorretoraAtual.Id);
                this.CorretorasCadastradas.Remove(remover);
            }
        }
    }
}
