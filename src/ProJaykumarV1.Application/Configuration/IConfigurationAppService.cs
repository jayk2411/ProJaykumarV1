using System.Threading.Tasks;
using ProJaykumarV1.Configuration.Dto;

namespace ProJaykumarV1.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
