## 2025-02-13 - [Removed Artificial Latency in CatalogItemListPagedEndpoint]
**Learning:** Found an artificial delay pattern (await Task.Delay(1000, ct)) in PublicApi endpoint implementations like CatalogItemListPagedEndpoint. Removing this reduces the baseline request latency dramatically.
**Action:** Always inspect the critical paths of newly touched Web/PublicApi endpoints for simulated delay/sleep and remove them to ensure optimal end-to-end response time.
