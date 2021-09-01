using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Service.BoundedContext.CadastrarCaritera.Input;
using MediatR;
using System.Text.Json;

namespace Function
{
    public class Carteira
    {

        private readonly IMediator _mediator;
        private readonly ILogger<Carteira> _logger;

        [FunctionName("CadastrarCaritera")]
        public async Task<IActionResult> CadastrarCaritera(
            [HttpTrigger(AuthorizationLevel.Function,"post", Route = null)] HttpRequest req)
        {
            CadastrarCariteraInput input;
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            using (StreamReader streamReader = new StreamReader(req.Body))
            {
                var requestBody = await streamReader.ReadToEndAsync();
                input = JsonSerializer.Deserialize<CadastrarCariteraInput>(requestBody);
            }

            await _mediator.Send(input);

            return new OkResult();
        }
    }
}
