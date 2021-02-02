---
title: TerminateFilter function
ms.date: 06/16/2017
api_name:
  - TerminateFilter
api_location:
  - aspnet_filter.dll
  - unknown
api_type:
  - IIS
topic_type:
  - apiref
---
# TerminateFilter function

The **TerminateFilter** is an entry point exposed by ISAPI filters. This function indicates to the filter that it is going to be removed from memory. When this function is called, you should make sure that the filter closes any attachments it has made to system resources.

```cpp
BOOL WINAPI TerminateFilter(
    DWORD dwFlags
);
```

## Parameters

`dwFlags`\
No values for `dwFlags` have been identified at this time.

## Return Value

The return value is currently ignored.

## Requirements

**Client:** Requires Windows XP Professional, Windows 2000 Professional, or Windows NT Workstation 4.0.

**Server:** Requires Windows Server 2003, Windows 2000 Server, or Windows NT Server 4.0.

**Product:** [IIS](/previous-versions/iis/6.0-sdk/ms525568(v=vs.90))

**Header:** Declared in httpfilt.h.
