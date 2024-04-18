using Microsoft.EntityFrameworkCore;
using PubHubWebServer.Data;

namespace TestProject1
{
    public static class ContextGenerator
    {
        private const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-PubHubDB;Trusted_Connection=True;MultipleActiveResultSets=true";

        public static PubHubDBContext Generator()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PubHubDBContext>()
                .UseSqlServer(ConnectionString)
                .Options;
            return new PubHubDBContext(optionsBuilder);

        }


    }
}
