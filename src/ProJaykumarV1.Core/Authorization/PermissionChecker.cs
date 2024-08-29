using Abp.Authorization;
using ProJaykumarV1.Authorization.Roles;
using ProJaykumarV1.Authorization.Users;

namespace ProJaykumarV1.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
