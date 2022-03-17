using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MachinaTrader.Data.MongoDB
{
    public class WalletTransactionAdapter
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public Guid Id { get; set; }

        public double Amount { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime Date { get; set; }
    }
}
