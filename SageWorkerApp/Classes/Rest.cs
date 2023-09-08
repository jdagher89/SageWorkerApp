using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageWorkerApp.Classes
{
    public class Rest
    {
        private readonly ILogger<Worker> logger;
        private readonly IConfiguration configuration;
        public Rest(IConfiguration _configuration,ILogger<Worker> _logger)
        {
            logger = _logger;
            configuration = _configuration;
        }
        public async Task<List<OxeboTaskResponse>> GetOxeboTasks()
        {
            var resList = new List<OxeboTaskResponse>();
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, configuration.GetValue<string>("params:oxeboURL") + "/task/list?logicId=650");
                request.Headers.Add("Authorization", configuration.GetValue<string>("params:oxeboAPIKey"));
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var res = await response.Content.ReadAsStringAsync();
                 resList = JsonConvert.DeserializeObject<List<OxeboTaskResponse>>(res);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }
            return resList;
        }
    }
}
