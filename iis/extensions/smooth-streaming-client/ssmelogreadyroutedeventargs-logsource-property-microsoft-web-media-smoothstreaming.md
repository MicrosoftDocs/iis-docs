---
title: SSMELogReadyRoutedEventArgs.LogSource Property (Microsoft.Web.Media.SmoothStreaming)
description: Describes the LogSource property and provides the property's namespace, assembly, syntasx, property value, version information, and permissions.
TOCTitle: LogSource Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.LogSource
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ssmelogreadyroutedeventargs.logsource(v=VS.90)
ms:contentKeyID: 31469284
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_LogSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.LogSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_LogSource
dev_langs:
- csharp
- jscript
- vb
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

# LogSource Property

Gets a value that indicates why the log was generated.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property LogSource As LogSource
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

```jscript
  function get LogSource () : LogSource
private function set LogSource (value : LogSource)
```

### Property Value

Type: [System.Windows.Media.LogSource](https://msdn.microsoft.com/library/dd491072)  
A string that contains the log source.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SSMELogReadyRoutedEventArgs Class](ssmelogreadyroutedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
