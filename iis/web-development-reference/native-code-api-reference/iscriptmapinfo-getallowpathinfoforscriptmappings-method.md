---
title: "IScriptMapInfo::GetAllowPathInfoForScriptMappings Method"
ms.date: "10/07/2016"
ms.assetid: decdb30f-9bb2-36e0-1b66-2baf79b4b1cd
---
# IScriptMapInfo::GetAllowPathInfoForScriptMappings Method

Retrieves a value that indicates whether a script map handler has the `allowPathInfo` attribute set to `true`.

## Syntax

```cpp
virtual BOOL GetAllowPathInfoForScriptMappings(
   VOID
) const = 0;
```

### Parameters

This method takes no parameters.

## Return Value

`true` if the `allowPathInfo` attribute for the script map is set to `true`; otherwise, `false`.

## Remarks

Developers can use the `GetAllowPathInfoForScriptMappings` method to retrieve a value that specifies whether an HTTP handler is configured to allow for *PathInfo* data when it processes requests. *PathInfo* refers to the additional path information that may follow the file name and extension in a Uniform Resource Identifier (URI). For example, if you request the URI `http://localhost/test.dll/myinfo`, the *PathInfo* portion of that URI is /myinfo.

To configure which HTTP handlers will allow for *PathInfo* information to be used, set the `allowPathInfo` attribute to `true` for an HTTP handler in the ApplicationHost.config file. For example, the configuration section for Internet Server API (ISAPI) DLLs in your ApplicationHost.config file may resemble the following example:

```
<add name="ISAPI-dll"
    path="*.dll"
    verb="*"
    modules="IsapiModule"
    resourceType="File"
    requireAccess="Execute"
    allowPathInfo="true" />
```

This example enables the *PathInfo* data for ISAPI DLLs. Likewise, set the `allowPathInfo` attribute to `false` to disable *PathInfo* data.

## Example

The following code example demonstrates how to use the `GetAllowPathInfoForScriptMappings` method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetAllowPathInfoForScriptMappings` method to retrieve a value that indicates whether *PathInfo* data is enabled for the script map. The module returns the result to a Web client and then exits.

<!-- TODO: review snippet reference  [!CODE [IScriptMapInfoGetAllowPathInfoForScriptMappings#1](IScriptMapInfoGetAllowPathInfoForScriptMappings#1)]  -->

Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).

You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.

## Requirements

|Type|Description|
|----------|-----------------|
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|
|Header|Httpserv.h|

## See also

- [IScriptMapInfo Interface](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md)