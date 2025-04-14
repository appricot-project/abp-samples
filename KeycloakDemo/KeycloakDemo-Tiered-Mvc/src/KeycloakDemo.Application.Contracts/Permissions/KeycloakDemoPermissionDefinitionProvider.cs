using KeycloakDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace KeycloakDemo.Permissions;

public class KeycloakDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(KeycloakDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        myGroup.AddPermission(KeycloakDemoPermissions.Test, L("Permission:Test"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<KeycloakDemoResource>(name);
    }
}
