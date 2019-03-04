---
title: ClipInformation Constructor (Boolean, Uri, Uri, Duration) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipInformation Constructor (Boolean, Uri, Uri, Duration)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ClipInformation.#ctor(System.Boolean,System.Uri,System.Uri,System.Windows.Duration)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipinformation.clipinformation(v=VS.95)
ms:contentKeyID: 46307658
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- cpp
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
ROBOTS: INDEX,FOLLOW
---

# ClipInformation Constructor (Boolean, Uri, Uri, Duration)

Initializes a new instance of the [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    isSmoothStreamingSource As Boolean, _
    clipUri As Uri, _
    clickThroughUri As Uri, _
    duration As Duration _
)
'Usage

Dim isSmoothStreamingSource As Boolean
Dim clipUri As Uri
Dim clickThroughUri As Uri
Dim duration As Duration

Dim instance As New ClipInformation(isSmoothStreamingSource, _
    clipUri, clickThroughUri, duration)
```

```csharp
public ClipInformation(
    bool isSmoothStreamingSource,
    Uri clipUri,
    Uri clickThroughUri,
    Duration duration
)
```

```cpp
public:
ClipInformation(
    bool isSmoothStreamingSource, 
    Uri^ clipUri, 
    Uri^ clickThroughUri, 
    Duration duration
)
```

``` fsharp
new : 
        isSmoothStreamingSource:bool * 
        clipUri:Uri * 
        clickThroughUri:Uri * 
        duration:Duration -> ClipInformation
```

```jscript
public function ClipInformation(
    isSmoothStreamingSource : boolean, 
    clipUri : Uri, 
    clickThroughUri : Uri, 
    duration : Duration
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

<!-- end list -->

  - clickThroughUri  
    Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))  
    A [Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\)) object that contains the Uri to additional information.

<!-- end list -->

  - duration  
    Type: [System.Windows.Duration](https://msdn.microsoft.com/library/ms602372\(v=vs.95\))  
    A [TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\)) object that contains the duration of the clip in ticks.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[ClipInformation Overload](clipinformation-constructor-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

