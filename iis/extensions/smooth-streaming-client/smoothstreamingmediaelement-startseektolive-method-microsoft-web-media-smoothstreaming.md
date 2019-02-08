---
title: SmoothStreamingMediaElement.StartSeekToLive Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StartSeekToLive Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.StartSeekToLive
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.startseektolive(v=VS.90)
ms:contentKeyID: 23961070
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.StartSeekToLive
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.StartSeekToLive
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StartSeekToLive Method

Starts a seek to a live media stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Function StartSeekToLive As Boolean
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim returnValue As Boolean

returnValue = instance.StartSeekToLive()
```

``` csharp
  public bool StartSeekToLive()
```

``` c++
  public:
bool StartSeekToLive()
```

``` jscript
  public function StartSeekToLive() : boolean
```

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the seek operation succeeded; otherwise, false.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

