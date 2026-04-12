## 2026-04-12 - Removing artificial delays in PublicApi
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial `Task.Delay(1000, ct)` calls, likely to simulate latency. These delays cumulatively added ~11 seconds to the execution time of `PublicApiIntegrationTests`.
**Action:** Always check for and remove artificial delays in API endpoints to improve response times and test suite performance. Removing these, along with converting synchronous `.ToList()` to `.ToListAsync(ct)`, reduced test duration by ~70%.

## 2026-04-12 - .NET SDK mismatch in environment
**Learning:** The project targets .NET 9.0 via `global.json`, but the environment only has .NET 8.0 and .NET 10.0. This prevents `dotnet test` from running out of the box.
**Action:** To run tests locally, temporarily update `global.json` to an installed version (e.g., '10.0.103') and use `DOTNET_ROLL_FORWARD=Major`. CRITICAL: Ensure `global.json` is reverted before final submission to avoid breaking the project configuration for others.
