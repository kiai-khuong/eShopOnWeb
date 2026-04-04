# Bolt's Performance Journal

## 2025-05-15 - [Optimize PublicApi and Specifications]
**Learning:** Artificial `Task.Delay` calls in endpoints (e.g., RoleList, UserList, CatalogItemListPaged) significantly increase integration test duration and real-world latency. Removing these and switching to async EF Core methods like `ToListAsync(ct)` improves scalability. Additionally, using `AsNoTracking()` in specifications for read-only queries reduces memory overhead.
**Action:** Always check for artificial delays and ensure read-only specifications use `AsNoTracking()` to minimize EF Core overhead.
