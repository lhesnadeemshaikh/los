using PHH.ReverseLOS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PHH.ReverseLOS.Permissions
{
    public class ReverseLOSPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ReverseLOSPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ReverseLOSPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ReverseLOSResource>(name);
        }
    }
}
