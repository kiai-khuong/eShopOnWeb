## 2025-05-18 - Eliminating artificial Task.Delay in CatalogItemListPagedEndpoint
**Learning:** PublicApi endpoints contained artificial `Task.Delay(1000, ct)` calls that directly injected 1000ms latency into API requests. Removing this delay directly improves endpoint throughput and reduces test suite execution time significantly without impacting functionality.
**Action:** Always search for and eliminate hardcoded artificial delays before optimizing complex queries or caching mechanisms.
