## 2025-05-14 - Artificial delays and sync materialization in PublicApi
**Learning:** PublicApi endpoints in eShopOnWeb often contain artificial 1000ms `Task.Delay` calls and synchronous `.ToList()` materialization on Identity managers, which significantly bloat response times and test duration.
**Action:** Always check `src/PublicApi` endpoints for `Task.Delay` and synchronous materialization on `IQueryable` (like `userManager.Users` or `roleManager.Roles`) during the PROFILE phase.
