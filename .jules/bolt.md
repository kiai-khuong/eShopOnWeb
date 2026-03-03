## 2025-05-15 - [Optimization of Catalog Listing]
**Learning:** In eShopOnWeb, read-only queries in the catalog were using default Entity Framework tracking and an extremely inefficient string-based calculation for `TotalPages`.
**Action:** Always use `.AsNoTracking()` for specifications that fetch read-only data for UI display. Use standard arithmetic or `Math.Ceiling` instead of string-based parsing for calculations.

## 2025-05-15 - [SDK Version Mismatch]
**Learning:** The project targets .NET 9.0, but the current environment only has 8.0 and 10.0. This prevents `dotnet test` from running unless `DOTNET_ROLL_FORWARD=Major` is used or `global.json` is temporarily adjusted.
**Action:** Use `DOTNET_ROLL_FORWARD=Major` for tests if the required SDK is missing, and ensure `global.json` is reverted before submission.
