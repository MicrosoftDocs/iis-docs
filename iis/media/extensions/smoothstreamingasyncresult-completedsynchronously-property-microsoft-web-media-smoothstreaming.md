---
title: SmoothStreamingAsyncResult.CompletedSynchronously Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CompletedSynchronously Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.CompletedSynchronously
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingasyncresult.completedsynchronously(v=VS.95)
ms:contentKeyID: 46307794
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.CompletedSynchronously
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.get_CompletedSynchronously
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.set_CompletedSynchronously
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.CompletedSynchronously
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.get_CompletedSynchronously
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.set_CompletedSynchronously
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingAsyncResult.CompletedSynchronously Property

Indicates whether the operation completed synchronously on the same thread.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property CompletedSynchronously As Boolean
    Get
    Private Set
'Usage

Dim instance As SmoothStreamingAsyncResult
Dim value As Boolean

value = instance.CompletedSynchronously
```

``` csharp
public bool CompletedSynchronously { get; private set; }
```

``` c++
public:
virtual property bool CompletedSynchronously {
    bool get () sealed;
    private: void set (bool value) sealed;
}
```

``` fsharp
abstract CompletedSynchronously : bool with get, private set
override CompletedSynchronously : bool with get, private set
```

``` jscript
final function get CompletedSynchronously () : boolean
private final function set CompletedSynchronously (value : boolean)
```

#### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.95\))  
true if the operation completed synchronously on the same thread; otherwise, false.

#### Implements

[IAsyncResult.CompletedSynchronously](https://msdn.microsoft.com/en-us/library/eyx2c824\(v=vs.95\))  

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[SmoothStreamingAsyncResult Class](smoothstreamingasyncresult-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

