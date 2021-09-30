using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptaBot.Server.Data
{
    public class MongoSettings
    {
        public const string JsonOption = "MongoDb";
        public string ConnectionString { get; set; }
        public string DBName { get; set; }
        public string Collection { get; set; }
    }
}
