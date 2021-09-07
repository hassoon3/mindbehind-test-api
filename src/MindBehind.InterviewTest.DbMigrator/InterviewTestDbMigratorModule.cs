using MindBehind.InterviewTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MindBehind.InterviewTest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(InterviewTestEntityFrameworkCoreModule),
        typeof(InterviewTestApplicationContractsModule)
        )]
    public class InterviewTestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
