---
title: ClipInformation Constructor (Boolean, Uri) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipInformation Constructor (Boolean, Uri)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ClipInformation.#ctor(System.Boolean,System.Uri)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipinformation.clipinformation(v=VS.95)
ms:contentKeyID: 46307644
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- "cpp"
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ClipInformation Constructor (Boolean, Uri)

Initializes a new instance of the [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    isSmoothStreamingSource As Boolean, _
    clipUri As Uri _
)
'Usage

Dim isSmoothStreamingSource As Boolean
Dim clipUri As Uri

Dim instance As New ClipInformation(isSmoothStreamingSource, _
    clipUri)
```

```csharp
public ClipInformation(
    bool isSmoothStreamingSource,
    Uri clipUri
)
```

```cpp
public:
ClipInformation(
    bool isSmoothStreamingSource, 
    Uri^ clipUri
)
```

``` fsharp
new : 
        isSmoothStreamingSource:bool * 
        clipUri:Uri -> ClipInformation
```

```jscript
public function ClipInformation(
    isSmoothStreamingSource : boolean, 
    clipUri : Uri
)
```

### Parameters

  - isSmoothStreamingSource  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
    A Boolean value that indicates whether the clip source is Smooth Streaming media.

<!-- end list -->

  - clipUri  
    Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))  
    A [Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\)) object that contains the clip source.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[ClipInformation Overload](clipinformation-constructor-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

