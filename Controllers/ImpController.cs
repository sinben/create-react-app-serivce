using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imp_service.Models;
using imp_service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace imp_service.Controllers
{
    [ApiController]
  
    public class ImpController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ImpController> _logger;
         private readonly ImpService _service;

        public ImpController(ILogger<ImpController> logger)
        {
            _logger = logger;
            _service = new ImpService();
        }
        [Route("/imps")]
        [HttpGet]
        public IEnumerable<Imp> Get()
        {
            return _service.GetImps();

        }
    }
}
