---
title: StreamInfo.ToString Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ToString Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.StreamInfo.ToString
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.tostring(v=VS.90)
ms:contentKeyID: 28440981
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ToString
dev_langs:
- csharp
- jscript
- vb
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

# ToString Method

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

```jscript
  public override function ToString() : String
```

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A string that contains the stream information.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
