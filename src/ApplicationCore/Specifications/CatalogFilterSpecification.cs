using Ardalis.Specification;
using Microsoft.eShopWeb.ApplicationCore.Entities;

namespace Microsoft.eShopWeb.ApplicationCore.Specifications;

public class CatalogFilterSpecification : Specification<CatalogItem>
{
    public CatalogFilterSpecification(int? brandId, int? typeId)
    {
        // Optimization: AsNoTracking improves performance for read-only queries by bypassing change tracking.
        Query.Where(i => (!brandId.HasValue || i.CatalogBrandId == brandId) &&
            (!typeId.HasValue || i.CatalogTypeId == typeId))
            .AsNoTracking();
    }
}
