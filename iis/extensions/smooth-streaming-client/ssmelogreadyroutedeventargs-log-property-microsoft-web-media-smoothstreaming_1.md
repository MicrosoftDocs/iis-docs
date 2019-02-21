---
title: SSMELogReadyRoutedEventArgs.Log Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Log Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.Log
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.ssmelogreadyroutedeventargs.log(v=VS.95)
ms:contentKeyID: 46307863
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_Log
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.Log
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_Log
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_Log
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.Log
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_Log
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SSMELogReadyRoutedEventArgs.Log Property

Gets or sets an XML string in the Windows Media Log format that contains the fields listed in the LogFields section.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Log As String
    Get
    Private Set
'Usage

Dim instance As SSMELogReadyRoutedEventArgs
Dim value As String

value = instance.Log
```

```csharp
public string Log { get; private set; }
```

```cpp
public:
property String^ Log {
    String^ get ();
    private: void set (String^ value);
}
```

``` fsharp
member Log : string with get, private set
```

```jscript
function get Log () : String
private function set Log (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
A string that contains XML data.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SSMELogReadyRoutedEventArgs Class](ssmelogreadyroutedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

