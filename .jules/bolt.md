## 2025-05-14 - [Artificial Delays in PublicApi Endpoints]
**Learning:** Found 1000ms artificial delays (`Task.Delay(1000)`) in multiple PublicApi endpoints (`CatalogItemListPagedEndpoint`, `UserListEndpoint`, `RoleListEndpoint`). These were likely added for demo purposes or to simulate latency. Additionally, Identity endpoints were using synchronous `.ToList()` instead of asynchronous materialization.
**Action:** Always check PublicApi endpoints for hardcoded delays and ensure database materialization is asynchronous (`ToListAsync`) and uses the `Microsoft.EntityFrameworkCore` namespace.

## 2025-05-14 - [.NET SDK Versioning and Roll-Forward]
**Learning:** The project targets .NET 9.0, but the environment only has SDK 10.0 and 8.0. The .NET CLI may fail to locate the SDK even with `DOTNET_ROLL_FORWARD=Major` if `global.json` specifies a missing version without broad roll-forward rules.
**Action:** Temporarily update `global.json` to an installed SDK version (e.g., 10.0.103) to enable builds and tests, but ensure it's reverted before submission. Use `DOTNET_ROLL_FORWARD=Major` for all `dotnet` commands.
