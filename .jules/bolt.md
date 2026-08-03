# Bolt's Performance Journal

This journal tracks critical performance learnings, bottlenecks, and optimizations within the eShopOnWeb repository.

## 2025-03-05 - [Initial Profiling and Bottlenecks]
**Learning:** Found several unnecessary artificial `Task.Delay(1000)` calls in FastEndpoints under `PublicApi`, specifically in `UserListEndpoint`, `CatalogItemListPagedEndpoint`, and `RoleListEndpoint`. In addition, `UserListEndpoint` and `RoleListEndpoint` fetch users synchronously using `.ToList()` on Identity queries when modern EF Core async extensions are fully supported.
**Action:** Remove the artificial 1-second delay from these three endpoints and migrate synchronous `.ToList()` calls to `ToListAsync()` to make them async.

## 2025-03-05 - [FastEndpoints Performance Wins]
**Learning:** Removing artificial 1-second delays and migrating synchronous identity queries (`.ToList()`) to async EF Core extension methods (`ToListAsync()`) in PublicApi endpoints dramatically improves API performance and throughput, while reducing thread pool starvation.
**Action:** The integration test suite execution duration for `PublicApiIntegrationTests` dropped from **16 seconds** down to **5 seconds** (a ~68% runtime reduction), with all 113 solution tests passing cleanly.
