using System.Threading.Tasks;
using Abp.Application.Services;
using Contab.Sessions.Dto;

namespace Contab.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
