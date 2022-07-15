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

        public void CadastrarUsuario()
        {
            
            Console.WriteLine("Insira seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o valor da sua renda anual bruta: [Formato: 10.000,00]");
            double rendaAnual = Convert.ToDouble(Console.ReadLine());

            var impostoRenda = _impostoRenda.TaxCalculation(rendaAnual);

            Usuario usuario = new Usuario(nome, rendaAnual, impostoRenda);

            ListaUsuarios.Add(usuario);


        }

        public void PrintarLista()
        {
            foreach (Usuario n in ListaUsuarios)
            {
                Console.WriteLine(n.Nome);
                Console.WriteLine(n.RendaAnual);
                Console.WriteLine(n.ImpostoRenda);
                Console.WriteLine(n.RendaAnual);
            }
        }

        public void BuscarUsuario()
        {

        }


    }
}