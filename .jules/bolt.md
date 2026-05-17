## 2026-05-17 - Removing artificial delays and improving async data access in PublicApi
**Learning:** The PublicApi project contained several endpoints with artificial 1000ms delays and synchronous '.ToList()' calls on Identity managers. Removing these delays and converting to 'ToListAsync(ct)' significantly reduces response time and improves test suite execution speed.
**Action:** Always check for 'Task.Delay' and synchronous materialization (like '.ToList()') on IQueryable properties in API endpoints as high-impact quick wins.
