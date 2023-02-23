using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ENG4.Servive
{
    public class InfoWork : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Processo iniciado... {nameof(InfoWork)}");
            //var cat = GetCategories();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Processo finalizado {nameof(InfoWork)}.");
            return Task.CompletedTask;
        }
    }
}