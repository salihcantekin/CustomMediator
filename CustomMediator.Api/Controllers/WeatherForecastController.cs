using CustomMediator.Api.Command;
using CustomMediator.Api.Query;
using CustomMediator.Library.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMediator.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator mediator;

        public WeatherForecastController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public Task<int> Get()
        {
            return mediator.Send(new UpdateNameCommand("Mahmut"));
        }
    }
}
