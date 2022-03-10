using LiteDB;

namespace AspNetCore.Identity.LiteDB.Data
{
    public class LiteDbContext : ILiteDbContext
    {
        public LiteDatabase LiteDatabase { get; set; }

        public LiteDbContext(string fileName)
        {
            var conn = new ConnectionString { Filename = fileName, Mode = FileMode.Exclusive };
            LiteDatabase = new LiteDatabase(conn);
        }
    }
}
