---
title: StreamUpdatedListEventArgs Constructor (Exception, Object) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamUpdatedListEventArgs Constructor (Exception, Object)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.#ctor(System.Exception,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streamupdatedlisteventargs.streamupdatedlisteventargs(v=VS.90)
ms:contentKeyID: 31469161
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StreamUpdatedListEventArgs Constructor (Exception, Object)

Initializes a new instance of the [StreamUpdatedListEventArgs](streamupdatedlisteventargs-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Sub New ( _
    error As Exception, _
    userState As Object _
)
'Usage

  Dim error As Exception
Dim userState As Object

Dim instance As New StreamUpdatedListEventArgs(error, userState)
```

``` csharp
  public StreamUpdatedListEventArgs(
    Exception error,
    Object userState
)
```

``` c++
  public:
StreamUpdatedListEventArgs(
    Exception^ error, 
    Object^ userState
)
```

``` jscript
  public function StreamUpdatedListEventArgs(
    error : Exception, 
    userState : Object
)
```

#### Parameters

  - error  
    Type: [System. . :: . .Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.90\))  
    A \[T:System.Exception,System.Object\] object.  

<!-- end list -->

  - userState  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    Use defined state [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\)).  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[StreamUpdatedListEventArgs Class](streamupdatedlisteventargs-class-microsoft-web-media-smoothstreaming_1.md)

[StreamUpdatedListEventArgs Overload](streamupdatedlisteventargs-constructor-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

