using Volo.Abp.Settings;

namespace MindBehind.InterviewTest.Settings
{
    public class InterviewTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(InterviewTestSettings.MySetting1));
        }
    }
}
