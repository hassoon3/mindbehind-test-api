using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MindBehind.InterviewTest.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class InterviewTestDbContextFactory : IDesignTimeDbContextFactory<InterviewTestDbContext>
    {
        public InterviewTestDbContext CreateDbContext(string[] args)
        {
            InterviewTestEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<InterviewTestDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new InterviewTestDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MindBehind.InterviewTest.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
