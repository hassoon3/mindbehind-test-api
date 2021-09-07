using MindBehind.InterviewTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MindBehind.InterviewTest
{
    [DependsOn(
        typeof(InterviewTestEntityFrameworkCoreTestModule)
        )]
    public class InterviewTestDomainTestModule : AbpModule
    {

    }
}