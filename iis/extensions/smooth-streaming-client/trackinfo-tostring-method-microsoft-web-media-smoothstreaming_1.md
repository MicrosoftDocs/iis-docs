---
title: TrackInfo.ToString Method  (Microsoft.Web.Media.SmoothStreaming)
description: Describes the TrackInfo.ToString method and details its syntax, return value, and Silverlight information.
TOCTitle: ToString Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.TrackInfo.ToString
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.trackinfo.tostring(v=VS.95)
ms:contentKeyID: 46307712
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.ToString
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.ToString
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TrackInfo.ToString Method

Writes a [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) object to string.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Overrides Function ToString As String
'Usage

Dim instance As TrackInfo
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
A string that contains the [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) object as a string.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
