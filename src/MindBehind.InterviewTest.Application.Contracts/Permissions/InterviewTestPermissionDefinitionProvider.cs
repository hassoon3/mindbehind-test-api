using MindBehind.InterviewTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MindBehind.InterviewTest.Permissions
{
    public class InterviewTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(InterviewTestPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(InterviewTestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<InterviewTestResource>(name);
        }
    }
}
