## 2026-06-08 - [PublicApi Performance Boost]
**Learning:** Removing artificial `Task.Delay` calls and converting synchronous `.ToList()` to `ToListAsync()` on Identity `IQueryable` properties significantly reduces response times and test duration (from 16s to 6s in PublicApiIntegrationTests).
**Action:** Always check for simulated latency in endpoints and ensure Identity Manager queries are fully asynchronous using `Microsoft.EntityFrameworkCore`.

## 2026-06-08 - [SDK Version Mismatch Workaround]
**Learning:** The environment lacks the .NET 9.0 SDK targeted by the project. Running tests requires temporarily updating `global.json` to an available version (e.g., 10.0.103) and using `DOTNET_ROLL_FORWARD=Major`.
**Action:** Temporarily modify `global.json` for local verification but ensure it is reverted before submission to avoid breaking CI/CD pipelines with unsupported SDK versions.
