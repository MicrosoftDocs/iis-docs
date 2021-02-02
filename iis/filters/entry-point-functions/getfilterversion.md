---
title: GetFilterVersion function
ms.date: 06/16/2017
api_name:
  - GetFilterVersion
api_location:
  - aspnet_filter.dll
  - unknown
api_type:
  - IIS
topic_type:
  - apiref
---
# GetFilterVersion function

The **GetFilterVersion** function is the first entry-point function called by IIS on your ISAPI filter, and must be present for the filter to work properly. IIS passes a pointer to a [HTTP\_FILTER\_VERSION Structure](/previous-versions/iis/6.0-sdk/ms525822(v=vs.90)), which can be used to supply important filter configuration information to IIS. The most important information passed to IIS is the bitmask that contains flags that specify which notification events your filter can process, and a flag that indicates the overall processing priority for your filter.

```cpp
BOOL WINAPI GetFilterVersion(
    PHTTP_FILTER_VERSION pVer
);
```

## Parameters

`pVer`\

Points to the [HTTP\_FILTER\_VERSION Structure](/previous-versions/iis/6.0-sdk/ms525822(v=vs.90)) that contains both the version information for the server and members with which the filter can indicate filter version number, notifications, and priority desired. There is also a space for the filter application to provide a descriptive text.

## Return Values

This function must return `TRUE` for your filter to remain loaded and working properly. If this function returns `FALSE`, IIS will not send the filter any notifications. If your filter returns `FALSE`, and you do not want IIS to log an error event for failure to load the filter, you must use the Win32 API function `SetLastError()`, passing `S_OK` as the argument. If you do want IIS to log an error, you should use `SetLastError()` to select an appropriate error code. This error will be logged by IIS.

## Remarks

Due to performance considerations, it is important to register only for those notifications that are necessary for your filter's purposes.

## Requirements

**Client:** Requires Windows XP Professional, Windows 2000 Professional, or Windows NT Workstation 4.0.

**Server:** Requires Windows Server 2003, Windows 2000 Server, or Windows NT Server 4.0.

**Product:** [IIS](/previous-versions/iis/6.0-sdk/ms525568(v=vs.90))

**Header:** Declared in httpfilt.h.
