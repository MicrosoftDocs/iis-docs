---
title: ChunkDownloadedEventArgs.DownloadResult Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: DownloadResult Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.DownloadResult
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkdownloadedeventargs.downloadresult(v=VS.95)
ms:contentKeyID: 46307753
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.DownloadResult
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_DownloadResult
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_DownloadResult
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.DownloadResult
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_DownloadResult
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_DownloadResult
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChunkDownloadedEventArgs.DownloadResult Property

Gets the download result.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property DownloadResult As ChunkResult.ChunkResultState
    Get
    Private Set
'Usage

Dim instance As ChunkDownloadedEventArgs
Dim value As ChunkResult.ChunkResultState

value = instance.DownloadResult
```

``` csharp
public ChunkResult.ChunkResultState DownloadResult { get; private set; }
```

``` c++
public:
property ChunkResult.ChunkResultState DownloadResult {
    ChunkResult.ChunkResultState get ();
    private: void set (ChunkResult.ChunkResultState value);
}
```

``` fsharp
member DownloadResult : ChunkResult.ChunkResultState with get, private set
```

``` jscript
function get DownloadResult () : ChunkResult.ChunkResultState
private function set DownloadResult (value : ChunkResult.ChunkResultState)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkResultState](chunkresult-chunkresultstate-enumeration-microsoft-web-media-smoothstreaming_1.md)  
A ChunkResultState object that represents the download result.

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[ChunkDownloadedEventArgs Class](chunkdownloadedeventargs-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

