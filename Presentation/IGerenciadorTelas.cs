using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IGerenciadorTelas
    {
        public void Menu();
        public void CadastarUsuario();

        public void PrintarUsuario(Usuario usuario);
    }
}
