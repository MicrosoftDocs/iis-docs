---
title: ProtectionHeader.SystemID Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SystemID Property
description: Describes the ProtectionHeader.SystemID property and provides the field's namespace, assembly, syntax, and version information.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.SystemID
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.protectionheader.systemid(v=VS.90)
ms:contentKeyID: 31469272
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.get_SystemID
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.set_SystemID
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.SystemID
dev_langs:
- csharp
- jscript
- vb
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

# SystemID Property

Gets or sets the GUID that identifies the protection system.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property SystemID As Guid
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

```jscript
  function get SystemID () : Guid
internal function set SystemID (value : Guid)
```

### Property Value

Type: [System.Guid](https://msdn.microsoft.com/library/cey1zx63)  
A GUID object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ProtectionHeader Class](protectionheader-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
