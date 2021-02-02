---
title: TerminateExtension function
ms.date: 06/16/2017
api_name:
  - TerminateExtension
api_location:
  - aspnet_isapi.dll
  - unknown
api_type:
  - IIS
topic_type:
  - apiref
---
# TerminateExtension function

The **TerminateExtension** function unloads the ISAPI DLL. This optional entry-point function is called by IIS immediately before unloading the DLL from its process.

```cpp
BOOL WINAPI TerminateExtension(
    DWORD dwFlags
);
```

## Parameters

`dwFlags`\
A DWORD that specifies whether IIS should unload the extension.

| Value | Meaning |
|---|---|
| HSE_TERM_ADVISORY_UNLOAD | Indicates that the server wants to unload the extension. The extension can return `false` if the server should not unload the extension; or return `true` otherwise. |
| HSE_TERM_MUST_UNLOAD | Indicates that the server is about to unload the extension. The extension cannot refuse. |

## Return Value

Return `true` if dwFlags included HSE\_TERM\_ADVISORY\_UNLOAD and the extension can be unloaded; otherwise, `false`.

If `dwFlags` included HSE\_TERM\_ MUST\_UNLOAD, then the extension will be unloaded by the server, and a return value will be ignored.

## Remarks

Because **TerminateExtension** is never called by IIS until all outstanding requests have been processed, it is not necessary to include code to wait for outstanding requests within **TerminateExtension**.

**TerminateExtension** provides a place to put code that cleans up threads or deallocates resources that are allocated by the [GetExtensionVersion function](getextensionversion.md) function.

## Requirements

**Client:** Requires Windows XP Professional, Windows 2000 Professional, or Windows NT Workstation 4.0.

**Server:** Requires Windows Server 2003, Windows 2000 Server, or Windows NT Server 4.0.

**Product:** [IIS](/previous-versions/iis/6.0-sdk/ms525568(v=vs.90))

**Header:** Declared in httpext.h.
