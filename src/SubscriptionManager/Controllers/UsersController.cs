
namespace SubscriptionManager.Controllers
{
    using Common;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Model;
    using SubscriptionManager.Data;
    using SubscriptionManager.Data.Enumeration;
    using SubscriptionManager.Data.Model;
    using System;
    using System.Linq;
    using System.Text.Json;

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly ISubscriptionDbRepository _db;
        public AppSettings Config => AppSettingsHelper.Config;
        public UsersController(ILogger<UsersController> logger, ISubscriptionDbRepository dbContext)
        {
            _logger = logger;
            _db = dbContext;
        }

        [HttpGet]
        public string Get()
        {
            return JsonSerializer.Serialize(_db.GetAllUsers());
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return JsonSerializer.Serialize(_db.GetUser(id));
        }

        [HttpGet("{id}/subscriptions")]
        public string GetSubscriptions(int id)
        {
            return JsonSerializer.Serialize(_db.GetUser(id).Subscriptions);
        }

        [HttpGet("{id}/subscriptions/{SubsId}")]
        public string GetSubscriptions(int id, int SubsId)
        {
            var subscriptions = _db.GetUser(id).Subscriptions.Where(s => s.ID == SubsId);
            return JsonSerializer.Serialize(subscriptions);
        }

        [HttpPost]
        public void Post([FromBody] UserRequest req)
        {
            User user = new User
            {
                FullName = req.FullName,
                UserName = req.UserName
            };

            _db.AddUser(user);
            return;
        }
    }
}
