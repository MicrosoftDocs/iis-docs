---
title: LoadManagedRuntime function
ms.date: 02/03/2021
api_name:
  - LoadManagedRuntime
api_location:
  - "webengine4.dll"
api_type:
  - "DLLExport"
topic_type:
  - "apiref"
---
# LoadManagedRuntime function

Loads a specified version of the common language runtime (CLR) into a process.

## Syntax

```cpp
HRESULT __stdcall
LoadManagedRuntime(
        _In_ PCWSTR pwszRuntimeVersion,
        __deref_out IUnknown ** ppManagedRuntimeHost)
```

### Parameters

`pwszRuntimeVersion`\
[in] A string that describes the version of the CLR you want to load. A version number in the .NET Framework consists of four parts separated by periods: *major.minor.build.revision*. The string must start with the character "v" followed by the first three parts of the version number (for example, "v4.0.30319").

`ppManagedRuntimeHost`\
[out] An interface pointer to the version of the runtime that was loaded.

## Requirements

|Type|Description|
|----------|-----------------|
|Client|-   IIS 7.5 on Windows 7|
|Server|-   IIS 7.5 on Windows Server 2008 R2|
|Product|-   IIS 7.5<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)]|
|Assembly|webengine4.dll|

## See also

- [ASP.NET performance: Managed runtime loader](https://devblogs.microsoft.com/aspnet/asp-net-performance-managed-runtime-loader/)
- [CorBindToRuntimeHost Function](/dotnet/framework/unmanaged-api/hosting/corbindtoruntimehost-function)
