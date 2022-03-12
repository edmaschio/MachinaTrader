using LiteDB;

namespace AspNetCore.Identity.LiteDB.Data
{
    public class LiteDbContext : ILiteDbContext
    {
        public LiteDatabase LiteDatabase { get; set; }

        public LiteDbContext(string fileName)
        {
            var conn = new ConnectionString { Filename = fileName, Upgrade = true };
            LiteDatabase = new LiteDatabase(conn);
        }
    }
}
