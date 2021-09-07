using Volo.Abp.Settings;

namespace MindBehind.InterviewTest.Settings
{
    public class InterviewTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            context.Add(new SettingDefinition(InterviewTestSettings.CommentExternalApiBaseUrl, "https://my-json-server.typicode.com"));
            context.Add(new SettingDefinition(InterviewTestSettings.CommentExternalApiResourcePath, "typicode/demo/comments"));
        }
    }
}
