using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionAppdemo1
{
    public class Function2
    {
        [FunctionName("Function2")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"Hiii.... C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
