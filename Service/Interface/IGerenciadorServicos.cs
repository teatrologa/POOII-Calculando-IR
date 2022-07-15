using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IGerenciadorServicos
    {
        public void SalvarUsuario(Usuario usuario);
        public void BuscarUsuario();
        public void PrintarLista();


    }
}
