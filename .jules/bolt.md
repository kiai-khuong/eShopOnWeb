## 2025-05-15 - [Initial Performance Optimizations]
**Learning:** Found artificial 1s delays in several PublicApi endpoints. Also identified that read-only UI specifications can benefit from `AsNoTracking()` to reduce memory overhead and improve performance.
**Action:** Remove `Task.Delay` from PublicApi endpoints and use `Query.AsNoTracking()` in read-only Specifications.
