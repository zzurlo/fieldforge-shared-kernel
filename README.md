# FieldForge Shared Kernel

This repository contains shared DTOs, enums, and interfaces used across the FieldForge application ecosystem.

## Installation

### C# Package

Install the NuGet package in your .NET project:

```bash
dotnet add package FieldForge.Shared --version 1.0.0
```

Or using the Package Manager Console:

```powershell
Install-Package FieldForge.Shared -Version 1.0.0
```

### TypeScript Definitions

Install the npm package in your TypeScript project:

```bash
npm install @fieldforge/shared
```

## Usage

### C# Namespaces

```csharp
using FieldForge.Shared.Models;     // DTOs and enums
using FieldForge.Shared.Interfaces; // Service interfaces
```

Available types:
- `ServiceOrderDto`, `ServiceOrderStatus`
- `CustomerDto`
- `InvoiceDto`, `InvoiceStatus`
- `INotificationService`

### TypeScript Imports

```typescript
import { ServiceOrderDto, ServiceOrderStatus } from '@fieldforge/shared/lib/models/ServiceOrder';
import { CustomerDto } from '@fieldforge/shared/lib/models/Customer';
import { InvoiceDto, InvoiceStatus } from '@fieldforge/shared/lib/models/Invoice';
```

## Development

The repository contains both C# and TypeScript sources:
- C# sources are under `src/FieldForge.Shared/`
- TypeScript definitions are under `ts/models/`

## License

MIT