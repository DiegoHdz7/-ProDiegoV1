using Abp.Application.Services;
using ProDiegoV1.MultiTenancy.Dto;

namespace ProDiegoV1.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

