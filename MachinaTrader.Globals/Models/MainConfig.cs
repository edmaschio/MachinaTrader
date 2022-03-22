using System.Collections.Generic;
using MachinaTrader.Globals.Structure.Models;

namespace MachinaTrader.Globals.Models
{
    public class MainConfig
    {
        public SystemOptions SystemOptions = new();
        public TradeOptions TradeOptions = new();
        public TelegramNotificationOptions TelegramOptions = new();
        public List<ExchangeOptions> ExchangeOptions = new() { };
        public DisplayOptions DisplayOptions = new();
    }

    public class SystemOptions
    {
        public string Database { get; set; } = "MongoDB";
        public MongoDbOptions MongoDbOptions = new();

        // Frontend stuff
        public int WebPort { get; set; } = 5000;
        public string RsaPrivateKey { get; set; } = "";
        public string DefaultUserName { get; set; } = "admin";
        public string DefaultUserEmail { get; set; } = "admin@localhost";
        public string DefaultUserPassword { get; set; } = "admin";
        public string Theme { get; set; } = "light";
        public string ThemeHighlightColor { get; set; } = "orange";
    }

    public class MongoDbOptions
    {
        public string Host { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 27017;
        public string Username { get; set; } = null;
        public string Password { get; set; } = null;
    }

}
