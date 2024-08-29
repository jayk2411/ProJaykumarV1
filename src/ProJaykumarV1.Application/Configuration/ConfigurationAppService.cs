using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ProJaykumarV1.Configuration.Dto;

namespace ProJaykumarV1.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProJaykumarV1AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
