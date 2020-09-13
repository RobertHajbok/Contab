using Abp.Authorization;
using Contab.Authorization.Roles;
using Contab.Authorization.Users;

namespace Contab.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
