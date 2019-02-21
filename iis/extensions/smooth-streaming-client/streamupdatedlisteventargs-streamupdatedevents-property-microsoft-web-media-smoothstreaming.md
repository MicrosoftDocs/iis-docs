---
title: StreamUpdatedListEventArgs.StreamUpdatedEvents Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamUpdatedEvents Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.StreamUpdatedEvents
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streamupdatedlisteventargs.streamupdatedevents(v=VS.90)
ms:contentKeyID: 31469292
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.get_StreamUpdatedEvents
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.StreamUpdatedEvents
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.get_StreamUpdatedEvents
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.StreamUpdatedEvents
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# StreamUpdatedEvents Property

Gets the list of stream updated events.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property StreamUpdatedEvents As IList(Of StreamUpdatedEventArgs)
'Usage

  Dim instance As StreamUpdatedListEventArgs
Dim value As IList(Of StreamUpdatedEventArgs)

value = instance.StreamUpdatedEvents
```

```csharp
  public IList<StreamUpdatedEventArgs> StreamUpdatedEvents { get; }
```

```cpp
  public:
property IList<StreamUpdatedEventArgs^>^ StreamUpdatedEvents {
    IList<StreamUpdatedEventArgs^>^ get ();
}
```

```jscript
  function get StreamUpdatedEvents () : IList<StreamUpdatedEventArgs>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\< (Of \< ( \<'[StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
An IList of [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md) objects.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StreamUpdatedListEventArgs Class](streamupdatedlisteventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

