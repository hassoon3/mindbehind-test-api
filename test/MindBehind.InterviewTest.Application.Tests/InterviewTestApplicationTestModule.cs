using Volo.Abp.Modularity;

namespace MindBehind.InterviewTest
{
    [DependsOn(
        typeof(InterviewTestApplicationModule),
        typeof(InterviewTestDomainTestModule)
        )]
    public class InterviewTestApplicationTestModule : AbpModule
    {

    }
}