using Domain;
using Domain.Interface;
using Presentation.Interface;
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
        public readonly IValidacao _validacao;


        public GerenciadorTelas(ITaxCalculator impostoRenda, IGerenciadorServicos gerenciadorServicos, IValidacao validacao)
        {
            _impostoRenda = impostoRenda;
            _gerenciadorServicos = gerenciadorServicos;
            _validacao = validacao;
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

            if (usuario.ImpostoRenda > 0)
            {
                Console.WriteLine(Telas.UsuarioTela.usuarioImpostoTela + usuario.ImpostoRenda.ToString("C"));
                Console.WriteLine(Telas.UsuarioTela.tracejado1);
            }
            else { 
                Console.WriteLine(Telas.UsuarioTela.usuarioImpostoIsentoTela);
                Console.WriteLine(Telas.UsuarioTela.tracejado2);
            }
            

            TabelaImposto();

        }

        public void TabelaImposto()
        {
            Console.WriteLine(Telas.InfoTela.tabelaImposto);
            Console.WriteLine(Telas.InfoTela.explicacaoCalculoImposto);
            Console.WriteLine(Telas.InfoTela.calculoImposto);

        }


        public void Menu()
        {
            Console.Clear();
            Console.WriteLine(Telas.MenuTela.MenuPrincipal);
            var input = int.Parse(Console.ReadLine());

            switch (input)
                {
                    case 1:
                        CadastarUsuario();
                        MenuOpcoes();
                        break;
                    case 2:
                        Console.Clear();
                        TabelaImposto();
                        MenuOpcoes();
                        break;
                    case 3:
                        break;
                }
            

        }

        public void MenuOpcoes()
        {
            Console.WriteLine(Telas.MenuTela.MenuOpcoes);
            var input = int.Parse(Console.ReadLine());

            switch(input)
            {
                case 1:
                    Menu();
                    break;
                case 2:
                    break;

            }
        }

        

       


    }
}
