using Abp.Application.Services;
using Contab.MultiTenancy.Dto;

namespace Contab.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

