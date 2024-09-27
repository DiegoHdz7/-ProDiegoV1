using System.Threading.Tasks;
using ProDiegoV1.Configuration.Dto;

namespace ProDiegoV1.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
