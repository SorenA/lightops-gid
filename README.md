# LightOps.Gid

Gid management package for .NET Standard.

![Nuget](https://img.shields.io/nuget/v/LightOps.Gid)

| Branch | CI |
| --- | --- |
| main | ![Build Status](https://dev.azure.com/sorendev/LightOps%20Packages/_apis/build/status/LightOps.Gid?branchName=main) |
| develop | ![Build Status](https://dev.azure.com/sorendev/LightOps%20Packages/_apis/build/status/LightOps.Gid?branchName=develop) |

## Concepts

The package defines the following concepts.

### Gid parser - `IGidParser` and implementation `GidParser`

Parses and validates gid.

## Attaching the component

Register during startup through the `AddGid` extension on `IDependencyInjectionRootComponent`.

```csharp
// Add root component
services.AddLightOpsDependencyInjection(root =>
{
    // Add component
    root.AddGid(component =>
    {
        // Configure component
        // ...
    });

    // Register other components
    // ...
});
```

Overrides may be registered in the component configurator action, see `IGidComponent` for documentation.

### Required component dependencies

- `LightOps.DependencyInjection` - 0.1.x
