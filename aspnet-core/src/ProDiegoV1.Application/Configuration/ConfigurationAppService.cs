using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ProDiegoV1.Configuration.Dto;

namespace ProDiegoV1.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProDiegoV1AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
