---
title: SSMELogReadyRoutedEventArgs.LogSource Property (Microsoft.Web.Media.SmoothStreaming)
description: SSMELogReadyRoutedEventArgs.LogSource Property gets a value that indicates why a log is generated.
TOCTitle: LogSource Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.LogSource
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ssmelogreadyroutedeventargs.logsource(v=VS.95)
ms:contentKeyID: 46307864
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_LogSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.LogSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_LogSource
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_LogSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.LogSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_LogSource
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SSMELogReadyRoutedEventArgs.LogSource Property

Gets a value that indicates why the log was generated.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property LogSource As LogSource
    Get
    Private Set
'Usage

Dim instance As SSMELogReadyRoutedEventArgs
Dim value As LogSource

value = instance.LogSource
```

```csharp
public LogSource LogSource { get; private set; }
```

```cpp
public:
property LogSource LogSource {
    LogSource get ();
    private: void set (LogSource value);
}
```

``` fsharp
member LogSource : LogSource with get, private set
```

```jscript
function get LogSource () : LogSource
private function set LogSource (value : LogSource)
```

### Property Value

Type: [System.Windows.Media.LogSource](https://msdn.microsoft.com/library/dd491072\(v=vs.95\))  
A string that contains the log source.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SSMELogReadyRoutedEventArgs Class](ssmelogreadyroutedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
