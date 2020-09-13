using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Contab.Configuration.Dto;

namespace Contab.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ContabAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
