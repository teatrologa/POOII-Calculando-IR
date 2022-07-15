using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Service
{
    public class GerenciadorServicos : IGerenciadorServicos
    {
        public List<Usuario> ListaUsuarios = new List<Usuario>();

        public readonly ITaxCalculator _impostoRenda;
        public GerenciadorServicos(ITaxCalculator impostoRenda)
        {
            _impostoRenda = impostoRenda;
        }

        public void SalvarUsuario(Usuario usuario)
        {

            ListaUsuarios.Add(usuario);

        }

        public void PrintarLista()
        {
            Console.Clear();
            foreach (Usuario n in ListaUsuarios)
            {
                Console.WriteLine(n.Nome);
                Console.WriteLine(n.RendaAnual);
                Console.WriteLine(n.ImpostoRenda);
            }
        }

        public void BuscarUsuario()
        {

        }


    }
}