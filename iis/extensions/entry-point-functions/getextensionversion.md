---
title: GetExtensionVersion function
ms.date: 06/16/2017
api_name:
  - GetExtensionVersion
api_location:
  - aspnet_isapi.dll
  - unknown
api_type:
  - IIS
topic_type:
  - apiref
---
# GetExtensionVersion function

The **GetExtensionVersion** function is the first entry-point function in IIS. This function allows your ISAPI extension to register its version information with IIS.

```cpp
BOOL WINAPI GetExtensionVersion(
    HSE_VERSION_INFO* pVer
);
```

## Parameters

`pVer`\
Points to an [HSE\_VERSION\_INFO](/previous-versions/iis/6.0-sdk/ms525590(v=vs.90)) data structure that your extension has populated with your extension's version information.

## Return Values

**GetExtensionVersion** must return `TRUE` for IIS to be able to use your ISAPI DLL. If this function returns `FALSE`, IIS will not use the extension.

## Remarks

IIS calls this function when the DLL is initially loaded, and the call is made in the system's security context.

## Requirements

**Client:** Requires Windows XP Professional, Windows 2000 Professional, or Windows NT Workstation 4.0.

**Server:** Requires Windows Server 2003, Windows 2000 Server, or Windows NT Server 4.0.

**Product:** [IIS](/previous-versions/iis/6.0-sdk/ms525568(v=vs.90))

**Header:** Declared in httpext.h.
