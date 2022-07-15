using Service.Interface;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Presentation;

class Program
{
    public static void Main(string[] args)
    { 
      ServiceCollection services = new ServiceCollection();
        Configuracoes(services);

        var serviceProvider = services.BuildServiceProvider();
        var inicioProgram = serviceProvider.GetService<IGerenciadorTelas>();
        inicioProgram.Menu();
        




    }

    public static void Configuracoes(IServiceCollection services)
    {
        services
            .AddScoped<IGerenciadorServicos, GerenciadorServicos>()
            .AddScoped<IGerenciadorTelas, GerenciadorTelas>()
            .AddScoped<ITaxCalculator, TaxCalculator>();

    }
}
      




