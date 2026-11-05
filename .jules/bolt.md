## 2025-05-18 - Eliminating Simulated Latency in Catalog Endpoints
**Learning:** PublicApi endpoints contain artificial `Task.Delay(1000, ct)` calls designed to simulate latency. Eliminating this delay in `CatalogItemListPagedEndpoint` directly removes 1000ms from response times and cuts PublicApi test suite execution time by ~5 seconds.
**Action:** When auditing APIs for performance bottlenecks, check for artificial delay simulations and eliminate them domain by domain.
