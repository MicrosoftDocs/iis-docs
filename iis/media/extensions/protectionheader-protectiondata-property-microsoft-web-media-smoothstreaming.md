---
title: ProtectionHeader.ProtectionData Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ProtectionData Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.ProtectionData
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.protectionheader.protectiondata(v=VS.90)
ms:contentKeyID: 31469300
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.get_ProtectionData
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.ProtectionData
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.set_ProtectionData
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.get_ProtectionData
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.ProtectionData
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.set_ProtectionData
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ProtectionData Property

Gets or sets the protection data relevant to the [SystemID](protectionheader-systemid-property-microsoft-web-media-smoothstreaming_1.md) Property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyProtectionDataAsByte()
'Usage
DiminstanceAsProtectionHeaderDimvalueAsByte()

value = instance.ProtectionData
```

``` csharp
publicbyte[] ProtectionData { get; internalset; }
```

``` c++
public:
propertyarray<unsigned char>^ ProtectionData {
    array<unsigned char>^ get ();
    internal: voidset (array<unsigned char>^ value);
}
```

``` jscript
function getProtectionData () : byte[]
internalfunction setProtectionData (value : byte[])
```

#### Property Value

Type: array\<[System. . :: . .Byte](https://msdn.microsoft.com/en-us/library/yyb1w04y\(v=vs.90\))\> \[\] () \[\] \[\]  
A [Byte](https://msdn.microsoft.com/en-us/library/yyb1w04y\(v=vs.90\)) array.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ProtectionHeader Class](protectionheader-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

