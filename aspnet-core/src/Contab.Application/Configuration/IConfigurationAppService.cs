using System.Threading.Tasks;
using Contab.Configuration.Dto;

namespace Contab.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
