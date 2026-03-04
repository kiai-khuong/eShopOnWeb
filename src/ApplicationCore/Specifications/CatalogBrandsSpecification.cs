using Ardalis.Specification;
using Microsoft.eShopWeb.ApplicationCore.Entities;

namespace Microsoft.eShopWeb.ApplicationCore.Specifications;

public class CatalogBrandsSpecification : Specification<CatalogBrand>
{
    public CatalogBrandsSpecification()
    {
        // Optimization: Read-only query for filter dropdowns, no need to track changes
        Query.AsNoTracking();
    }
}
