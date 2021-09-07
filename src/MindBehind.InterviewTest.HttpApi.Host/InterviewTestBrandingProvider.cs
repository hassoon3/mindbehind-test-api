using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MindBehind.InterviewTest
{
    [Dependency(ReplaceServices = true)]
    public class InterviewTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "InterviewTest";
    }
}
