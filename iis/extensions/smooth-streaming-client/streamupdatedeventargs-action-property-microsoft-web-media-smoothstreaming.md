---
title: StreamUpdatedEventArgs.Action Property (Microsoft.Web.Media.SmoothStreaming) (2)
TOCTitle: Action Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.Action
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streamupdatedeventargs.action(v=VS.90)
ms:contentKeyID: 31469227
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.Action
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.get_Action
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.set_Action
dev_langs:
- csharp
- jscript
- vb
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

# Action Property

Gets or sets [StreamUpdatedEventArgs..::..StreamUpdatedAction](streamupdatedeventargs-streamupdatedaction-enumeration-microsoft-web-media-smoothstreaming_1.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Action As StreamUpdatedEventArgs..::..StreamUpdatedAction
'Usage

  Dim instance As StreamUpdatedEventArgs
Dim value As StreamUpdatedEventArgs..::..StreamUpdatedAction

value = instance.Action
```

```csharp
  public StreamUpdatedEventArgs..::..StreamUpdatedAction Action { get; private set; }
```

```cpp
  public:
property StreamUpdatedEventArgs..::..StreamUpdatedAction Action {
    StreamUpdatedEventArgs..::..StreamUpdatedAction get ();
    private: void set (StreamUpdatedEventArgs..::..StreamUpdatedAction value);
}
```

```jscript
  function get Action () : StreamUpdatedEventArgs..::..StreamUpdatedAction
private function set Action (value : StreamUpdatedEventArgs..::..StreamUpdatedAction)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction](streamupdatedeventargs-streamupdatedaction-enumeration-microsoft-web-media-smoothstreaming_1.md)  
A [StreamUpdatedEventArgs..::..StreamUpdatedAction](streamupdatedeventargs-streamupdatedaction-enumeration-microsoft-web-media-smoothstreaming_1.md) object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StreamUpdatedEventArgs Class](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
