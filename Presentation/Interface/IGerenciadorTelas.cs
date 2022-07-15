using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Interface
{
    public interface IGerenciadorTelas
    {
        public void Menu();
        public void MenuOpcoes();
        public void CadastarUsuario();
        public void TabelaImposto();
        public void PrintarUsuario(Usuario usuario);
    }
}
