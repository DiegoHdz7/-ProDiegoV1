using System.Threading.Tasks;
using Abp.Application.Services;
using ProDiegoV1.Sessions.Dto;

namespace ProDiegoV1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
