using Abp.Application.Services;
using ProJaykumarV1.MultiTenancy.Dto;

namespace ProJaykumarV1.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

