using Ardalis.Specification;
using Microsoft.eShopWeb.ApplicationCore.Entities;

namespace Microsoft.eShopWeb.ApplicationCore.Specifications;

public class CatalogFilterSpecification : Specification<CatalogItem>
{
    public CatalogFilterSpecification(int? brandId, int? typeId)
    {
        // PERFORMANCE: Use AsNoTracking for read-only UI display queries to improve memory efficiency.
        Query.Where(i => (!brandId.HasValue || i.CatalogBrandId == brandId) &&
            (!typeId.HasValue || i.CatalogTypeId == typeId))
            .AsNoTracking();
    }
}
