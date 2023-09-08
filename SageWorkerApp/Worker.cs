using SageWorkerApp.Classes;

namespace SageWorkerApp
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly Rest _RestCls;
        IConfiguration _configuration;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _logger = logger;
            _configuration = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json", true, true)
             .Build();
            _RestCls = new Rest(_configuration,_logger);
        }

        protected override async System.Threading.Tasks.Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                //if (DateTime.UtcNow.Hour == 08)
                //{
              
                //GET INVOICES FROM OXEBO
                var invoices = await _RestCls.GetOxeboTasks();
                //
                if (invoices.Any())
                {
                    // INSERT AT SAGE ACCOUNTING API

                    //

                }

                //}

                // await System.Threading.Tasks.Task.Delay(1000, stoppingToken);
            }
        }
    }
}