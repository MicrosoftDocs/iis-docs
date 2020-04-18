---
title: StreamUpdatedEventArgs.Action Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Action Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.Action
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streamupdatedeventargs.action(v=VS.95)
ms:contentKeyID: 46307876
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.Action
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.get_Action
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.set_Action
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.Action
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.get_Action
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.set_Action
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StreamUpdatedEventArgs.Action Property

Gets or sets [StreamUpdatedEventArgs.StreamUpdatedAction](streamupdatedeventargs-streamupdatedaction-enumeration-microsoft-web-media-smoothstreaming_1.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Action As StreamUpdatedEventArgs.StreamUpdatedAction
    Get
    Private Set
'Usage

Dim instance As StreamUpdatedEventArgs
Dim value As StreamUpdatedEventArgs.StreamUpdatedAction

value = instance.Action
```

```csharp
public StreamUpdatedEventArgs.StreamUpdatedAction Action { get; private set; }
```

```cpp
public:
property StreamUpdatedEventArgs.StreamUpdatedAction Action {
    StreamUpdatedEventArgs.StreamUpdatedAction get ();
    private: void set (StreamUpdatedEventArgs.StreamUpdatedAction value);
}
```

``` fsharp
member Action : StreamUpdatedEventArgs.StreamUpdatedAction with get, private set
```

```jscript
function get Action () : StreamUpdatedEventArgs.StreamUpdatedAction
private function set Action (value : StreamUpdatedEventArgs.StreamUpdatedAction)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction](streamupdatedeventargs-streamupdatedaction-enumeration-microsoft-web-media-smoothstreaming_1.md)  
A [StreamUpdatedEventArgs.StreamUpdatedAction](streamupdatedeventargs-streamupdatedaction-enumeration-microsoft-web-media-smoothstreaming_1.md) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[StreamUpdatedEventArgs Class](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
