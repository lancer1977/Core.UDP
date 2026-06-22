# Core.UDP

UDP networking utilities for .NET applications.

## Tags

- dotnet
- core
- core-udp
- docs
- obs
- devops

## 🚀 Key Features

- `IUdpListener` interface for UDP abstraction
- `ObservableJsonUdpListener` - Reactive UDP listener with JSON deserialization
- `SocketTransmitter` for UDP data transmission
- Extension methods for common UDP operations

## 🛠 Technology Stack

- C# / .NET 10.0
- System.Reactive (Rx extensions)
- PolyhydraGames.Core.Models, Core.Interfaces, Extensions

## 📦 NuGet Package

**Package:** `PolyhydraSoftware.Core.UDP`

Published automatically via GitHub Actions on main branch commits.

- **Feed:** NuGet.org (public)
- **CI Pipeline:** `.github/workflows/ci.yml`
- **Versioning:** Build-number based (`1.0.0.{rev}`)

### Local Pack

```bash
cd Models
dotnet pack -c Release --output ./artifacts
```

## 🚦 Getting Started

```bash
dotnet build
dotnet test
```

## 🧪 Test Coverage

The test suite includes behavioral tests for:

- **SocketTransmitter**: Payload serialization shape verification
- **ObservableJsonUdpListener**: JSON deserialization, subscription lifecycle
- **Listener Lifecycle**: Start/Stop behavior (note: Stop() throws if called before Start())

Tests run via `dotnet test` in the Tests project.

## 📖 Documentation

- [Validation](./docs/validation.md)
- [Feature Index](./docs/features/README.md)
- [Core Capabilities](./docs/features/core-capabilities.md)
