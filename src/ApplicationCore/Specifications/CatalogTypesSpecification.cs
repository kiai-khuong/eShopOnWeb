using Ardalis.Specification;
using Microsoft.eShopWeb.ApplicationCore.Entities;

namespace Microsoft.eShopWeb.ApplicationCore.Specifications;

public class CatalogTypesSpecification : Specification<CatalogType>
{
    public CatalogTypesSpecification()
    {
        // Optimization: Read-only query for filter dropdowns, no need to track changes
        Query.AsNoTracking();
    }
}
