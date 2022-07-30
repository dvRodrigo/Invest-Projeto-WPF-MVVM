using ProjetoWpf.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.ViewModels
{
    public class PrincipalViewModel
    {
        #region Properties
        public MeuCadastroCommand TelaMeuCadastro { get; set; }
        public CorretoraCommand TelaCorretora { get; set; }
        #endregion
        public PrincipalViewModel()
        {
            TelaMeuCadastro = new MeuCadastroCommand();
            TelaCorretora = new CorretoraCommand();
        }
    }
}
