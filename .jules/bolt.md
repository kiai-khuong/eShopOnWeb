## 2025-05-14 - Artificial Latency in PublicApi Endpoints
**Learning:** Several endpoints in the PublicApi (`CatalogItemListPagedEndpoint`, `UserListEndpoint`, `RoleListEndpoint`) contain explicit `Task.Delay(1000)` calls, likely for demonstration or simulating load. Removing these provides an immediate 1s improvement in response time per request.
**Action:** Always check for `Task.Delay` in demonstration-style repositories when profiling for latency.

## 2025-05-14 - Optimizing Read-Only Queries with AsNoTracking
**Learning:** The project uses `Ardalis.Specification`. For read-only endpoints like catalog listings, adding `Query.AsNoTracking()` to the specification significantly reduces memory overhead and improves performance by bypassing EF Core's change tracking.
**Action:** Use `.AsNoTracking()` in specifications intended for read-only UI or API responses.

## 2025-05-14 - SDK Version Mismatch in Sandbox
**Learning:** When `global.json` specifies an SDK version not present in the environment (e.g., 9.0.0 vs 10.0.103), the .NET CLI fails even with `DOTNET_ROLL_FORWARD=Major`.
**Action:** Temporarily update `global.json` to an installed SDK version to run tests, then revert before submission.
