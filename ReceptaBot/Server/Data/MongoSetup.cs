using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ReceptaBot.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptaBot.Server.Data
{
    public class MongoSetup
    {
        private readonly IConfiguration _config;
        private readonly IOptions<MongoSettings> _configuration;


        public MongoSetup(IOptions<MongoSettings> configuration, 
                           IConfiguration config)
        {
            _config = config;
            _configuration = configuration;
            var connectionString = _configuration.Value.ConnectionString;
             var settings = MongoClientSettings.FromConnectionString(connectionString);
             //var settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
             var client = new MongoClient(settings);
            var database = client.GetDatabase("ReceptaBotDb");
            var collection = database.GetCollection<Recipe>("RecipeCollection");
        }


    }
}
