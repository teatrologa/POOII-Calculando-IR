using Domain;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class GerenciadorTelas : IGerenciadorTelas
    {
       
        public readonly ITaxCalculator _impostoRenda;
        public readonly IGerenciadorServicos _gerenciadorServicos;
       
        public GerenciadorTelas(ITaxCalculator impostoRenda, IGerenciadorServicos gerenciadorServicos)
        {
            _impostoRenda = impostoRenda;
            _gerenciadorServicos = gerenciadorServicos;
        }

        public void CadastarUsuario()
        {
            Console.Clear();
            Console.WriteLine(Telas.InputTela.usuarioNomeInput);
            string nome = Console.ReadLine();

            Console.WriteLine(Telas.InputTela.usuarioRendaAnualInput);
            double rendaAnual = Convert.ToDouble(Console.ReadLine());

            var impostoRenda = _impostoRenda.TaxCalculation(rendaAnual);

            Usuario usuario = new Usuario(nome, rendaAnual, impostoRenda);

            _gerenciadorServicos.SalvarUsuario(usuario);
            
            PrintarUsuario(usuario);
        }

        public void PrintarUsuario(Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine(Telas.UsuarioTela.usuarioCabeçalho);
            Console.WriteLine(Telas.UsuarioTela.usuarioNomeTela + usuario.Nome);
            Console.WriteLine(Telas.UsuarioTela.usuarioRendaAnualTela + usuario.RendaAnual.ToString("C"));
            Console.WriteLine(Telas.UsuarioTela.usuarioImpostoTela + usuario.ImpostoRenda.ToString("C"));
        }


        public void Menu()
        {
            Console.WriteLine(Telas.MenuTela.MenuPrincipal);
            int input = Convert.ToInt32(Console.ReadLine());
            

            switch (input)
            {
                case 1:
                    CadastarUsuario();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Em implementação!");
                    Menu();
                    return;
                case 3:
                    break;
            }

        }

       


    }
}
