using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using ProDiegoV1.Authorization.Users;
using ProDiegoV1.Editions;

namespace ProDiegoV1.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
