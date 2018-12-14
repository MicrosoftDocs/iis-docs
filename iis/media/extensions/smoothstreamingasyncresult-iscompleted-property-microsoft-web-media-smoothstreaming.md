---
title: SmoothStreamingAsyncResult.IsCompleted Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: IsCompleted Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.IsCompleted
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingasyncresult.iscompleted(v=VS.95)
ms:contentKeyID: 46307807
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.set_IsCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.IsCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.get_IsCompleted
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.get_IsCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.IsCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.set_IsCompleted
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingAsyncResult.IsCompleted Property

Gets a Boolean value that indicates whether the operation has completed.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property IsCompleted As Boolean
    Get
    Private Set
'Usage

Dim instance As SmoothStreamingAsyncResult
Dim value As Boolean

value = instance.IsCompleted
```

``` csharp
public bool IsCompleted { get; private set; }
```

``` c++
public:
virtual property bool IsCompleted {
    bool get () sealed;
    private: void set (bool value) sealed;
}
```

``` fsharp
abstract IsCompleted : bool with get, private set
override IsCompleted : bool with get, private set
```

``` jscript
final function get IsCompleted () : boolean
private final function set IsCompleted (value : boolean)
```

#### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.95\))  
true if the operation has completed; otherwise, false.

#### Implements

[IAsyncResult.IsCompleted](https://msdn.microsoft.com/en-us/library/7fz31972\(v=vs.95\))  

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[SmoothStreamingAsyncResult Class](smoothstreamingasyncresult-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

