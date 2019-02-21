---
title: StreamInfo.ToString Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ToString Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.StreamInfo.ToString
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.tostring(v=VS.95)
ms:contentKeyID: 46307708
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ToString
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ToString
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StreamInfo.ToString Method

Writes the [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) item to a string.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Overrides Function ToString As String
'Usage

Dim instance As StreamInfo
Dim returnValue As String

returnValue = instance.ToString()
```

```csharp
public override string ToString()
```

```cpp
public:
virtual String^ ToString() override
```

``` fsharp
abstract ToString : unit -> string 
override ToString : unit -> string 
```

```jscript
public override function ToString() : String
```

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
A string that contains the stream information.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

