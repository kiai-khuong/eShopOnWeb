## 2025-05-14 - [PublicApi Performance & EF Tracking]
**Learning:** Found artificial `Task.Delay(1000)` calls in multiple PublicApi endpoints which were significantly increasing response times. Also identified that some read-only queries were missing `.AsNoTracking()`, leading to unnecessary memory overhead. Converting synchronous Identity manager calls to `.ToListAsync(ct)` further improves scalability.
**Action:** Remove synthetic delays in endpoints, apply `.AsNoTracking()` to read-only specifications, and ensure Identity manager operations are fully asynchronous.
