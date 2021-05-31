using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return string.Empty;
        }
        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return string.Empty;
        }

        [HttpGet("{id}/subscriptions")]
        public string GetSubscriptions(int id)
        {
            return string.Empty;
        }

        [HttpGet("{id}/subscriptions/{SubsId}")]
        public string GetSubscriptions(int id,int SubsId)
        {
            return string.Empty;
        }

        [HttpPost("{id}")]
        public void Post([FromBody] int id)
        {
            
        }
    }
}
