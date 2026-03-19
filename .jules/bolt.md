## 2025-05-14 - Artificial Delays in PublicApi

**Learning:** Several PublicApi endpoints (CatalogItemListPaged, RoleList, UserList) contained artificial `Task.Delay(1000)` calls, significantly increasing latency. Additionally, using synchronous `.ToList()` on Identity managers in async methods can block threads and cause compiler warnings (CS1998) if the only `await` was the removed delay.

**Action:** When optimizing PublicApi endpoints, always check for and remove demonstration-only delays. Ensure Identity manager queries use `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` to maintain full asynchronicity and avoid warnings.

## 2025-05-14 - SDK Version Compatibility in global.json

**Learning:** The .NET CLI may fail to resolve the SDK even with `rollForward` if the specific version in `global.json` is missing. This happens even when newer SDKs are installed.

**Action:** Temporarily update `global.json` to an installed SDK version (e.g., 10.0.103) to run `dotnet` commands, but ensure it is reverted before submission to maintain project standards.
