using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MindBehind.InterviewTest.Data;
using Volo.Abp.DependencyInjection;

namespace MindBehind.InterviewTest.EntityFrameworkCore
{
    public class EntityFrameworkCoreInterviewTestDbSchemaMigrator
        : IInterviewTestDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreInterviewTestDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the InterviewTestDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<InterviewTestDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
