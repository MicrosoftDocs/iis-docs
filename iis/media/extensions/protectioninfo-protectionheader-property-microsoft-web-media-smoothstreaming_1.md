---
title: ProtectionInfo.ProtectionHeader Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ProtectionHeader Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ProtectionInfo.ProtectionHeader
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.protectioninfo.protectionheader(v=VS.95)
ms:contentKeyID: 46307787
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ProtectionInfo.get_ProtectionHeader
- Microsoft.Web.Media.SmoothStreaming.ProtectionInfo.ProtectionHeader
- Microsoft.Web.Media.SmoothStreaming.ProtectionInfo.set_ProtectionHeader
dev_langs:
- CSharp
- JScript
- VB
- FSharp
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

# ProtectionInfo.ProtectionHeader Property

Gets or sets the headers for the [ProtectionInfo](protectioninfo-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property ProtectionHeader As ProtectionHeader
    Get
    Friend Set
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

``` fsharp
member ProtectionHeader : ProtectionHeader with get, internal set
```

``` jscript
function get ProtectionHeader () : ProtectionHeader
internal function set ProtectionHeader (value : ProtectionHeader)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ProtectionHeader](protectionheader-class-microsoft-web-media-smoothstreaming_1.md)  
A [ProtectionInfo](protectioninfo-class-microsoft-web-media-smoothstreaming_1.md) digital rights management object.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[ProtectionInfo Class](protectioninfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

