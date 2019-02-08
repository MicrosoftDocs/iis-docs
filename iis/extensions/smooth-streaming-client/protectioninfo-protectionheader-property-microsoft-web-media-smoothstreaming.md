---
title: ProtectionInfo.ProtectionHeader Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ProtectionHeader Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ProtectionInfo.ProtectionHeader
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.protectioninfo.protectionheader(v=VS.90)
ms:contentKeyID: 31469196
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ProtectionInfo.get_ProtectionHeader
- Microsoft.Web.Media.SmoothStreaming.ProtectionInfo.ProtectionHeader
- Microsoft.Web.Media.SmoothStreaming.ProtectionInfo.set_ProtectionHeader
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ProtectionInfo.get_ProtectionHeader
- Microsoft.Web.Media.SmoothStreaming.ProtectionInfo.set_ProtectionHeader
- Microsoft.Web.Media.SmoothStreaming.ProtectionInfo.ProtectionHeader
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ProtectionHeader Property

Gets or sets the headers for the [ProtectionInfo](protectioninfo-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Property ProtectionHeader As ProtectionHeader
'Usage

  Dim instance As ProtectionInfo
Dim value As ProtectionHeader

value = instance.ProtectionHeader
```

``` csharp
  public ProtectionHeader ProtectionHeader { get; internal set; }
```

``` c++
  public:
property ProtectionHeader^ ProtectionHeader {
    ProtectionHeader^ get ();
    internal: void set (ProtectionHeader^ value);
}
```

``` jscript
  function get ProtectionHeader () : ProtectionHeader
internal function set ProtectionHeader (value : ProtectionHeader)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .ProtectionHeader](protectionheader-class-microsoft-web-media-smoothstreaming_1.md)  
A [ProtectionInfo](protectioninfo-class-microsoft-web-media-smoothstreaming_1.md) digital rights management object.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ProtectionInfo Class](protectioninfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

