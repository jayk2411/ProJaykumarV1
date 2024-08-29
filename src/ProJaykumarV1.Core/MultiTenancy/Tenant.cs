using Abp.MultiTenancy;
using ProJaykumarV1.Authorization.Users;

namespace ProJaykumarV1.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
