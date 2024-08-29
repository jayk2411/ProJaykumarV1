using System.Threading.Tasks;
using Abp.Application.Services;
using ProJaykumarV1.Sessions.Dto;

namespace ProJaykumarV1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
