using Microsoft.EntityFrameworkCore;
using WideWorldImporters.API.Models;

namespace WideWorldImporters.API.UnitTests
{
    public static class DbContextMocker
    {
        public static WideWorldImportersDbContext
            GetWideWorldImportersDbContext(string dbName)
        {
            var options = new DbContextOptionsBuilder<WideWorldImportersDbContext>().UseInMemoryDatabase(databaseName: dbName).Options;

            var dbContext = new WideWorldImportersDbContext(options);
            dbContext.Seed();
            return dbContext;
        }
    }
}
