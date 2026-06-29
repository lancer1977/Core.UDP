# Validation

This repo's native validation path is the `Core.UDP.sln` test run. The
`PolyhydraSoftware.Core.UDP.sln` file is retained for legacy packaging context
and currently has no restoreable projects.

## Commands

```bash
dotnet restore Core.UDP.sln
dotnet build Core.UDP.sln --configuration Release --no-restore
dotnet test Core.UDP.sln --configuration Release --no-restore --no-build --verbosity normal
```

For a one-command local check, run:

```bash
dotnet test Core.UDP.sln --configuration Release
```

## 2026-06-29 Baseline

- `dotnet test Core.UDP.sln --configuration Release`
- Result: passed, 14 tests.

## Dependency Follow-up

Run this before dependency work:

```bash
dotnet list Core.UDP.sln package --outdated
```

Dependency updates are tracked separately from the validation repair so package
churn does not hide transport behavior changes.
