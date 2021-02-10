---
title: LoadManagedRuntimeEx function
ms.date: 02/03/2021
api_name:
  - LoadManagedRuntimeEx
api_location:
  - "webengine4.dll"
api_type:
  - "DLLExport"
topic_type:
  - "apiref"
---
# LoadManagedRuntimeEx function

Loads a specified version of the common language runtime (CLR) into a process.

## Syntax

```cpp
HRESULT __stdcall
LoadManagedRuntimeEx(
        _In_ PCWSTR pwszRuntimeVersion,
        _In_ PCWSTR pszClrConfigFile,
        __deref_out IUnknown ** ppManagedRuntimeHost)
```

### Parameters

`pwszRuntimeVersion`\
[in] A string that describes the version of the CLR you want to load. A version number in the .NET Framework consists of four parts separated by periods: *major.minor.build.revision*. The string must start with the character "v" followed by the first three parts of the version number (for example, "v4.0.30319").

`pszClrConfigFile`\
[in] The name of a host configuration file that specifies the version of the CLR to load. If the file name does not include a fully qualified path, the file is assumed to be in the same directory as the executable that is making the call.

`ppManagedRuntimeHost`\
[out] An interface pointer to the version of the runtime that was loaded.

## Requirements

|Type|Description|
|----------|-----------------|
|Client|-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />|
|Server|-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />|
|Product|-   IIS 7.5, IIS 8.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)]|
|Assembly|webengine4.dll|

## See also

- [ASP.NET performance: Managed runtime loader](https://devblogs.microsoft.com/aspnet/asp-net-performance-managed-runtime-loader/)
- [CorBindToRuntimeHost Function](/dotnet/framework/unmanaged-api/hosting/corbindtoruntimehost-function)
