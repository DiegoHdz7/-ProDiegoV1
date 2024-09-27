using Abp.Authorization;
using ProDiegoV1.Authorization.Roles;
using ProDiegoV1.Authorization.Users;

namespace ProDiegoV1.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
