---
title: ProtectionHeader.SystemID Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SystemID Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.SystemID
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.protectionheader.systemid(v=VS.95)
ms:contentKeyID: 46307780
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.get_SystemID
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.set_SystemID
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.SystemID
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.get_SystemID
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.set_SystemID
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.SystemID
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ProtectionHeader.SystemID Property

Gets or sets the [System.GUID](https://msdn.microsoft.com/library/cey1zx63\(v=vs.95\)) that identifies the protection system.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property SystemID As Guid
    Get
    Friend Set
'Usage

Dim instance As ProtectionHeader
Dim value As Guid

value = instance.SystemID
```

```csharp
public Guid SystemID { get; internal set; }
```

```cpp
public:
property Guid SystemID {
    Guid get ();
    internal: void set (Guid value);
}
```

``` fsharp
member SystemID : Guid with get, internal set
```

```jscript
function get SystemID () : Guid
internal function set SystemID (value : Guid)
```

### Property Value

Type: [System.Guid](https://msdn.microsoft.com/library/cey1zx63\(v=vs.95\))  
A [System.GUID](https://msdn.microsoft.com/library/cey1zx63\(v=vs.95\)) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[ProtectionHeader Class](protectionheader-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
