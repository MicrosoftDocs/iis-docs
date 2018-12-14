---
title: ManifestType Enumeration (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ManifestType Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ManifestType
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.manifesttype(v=VS.95)
ms:contentKeyID: 46307941
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestType
- Microsoft.Web.Media.SmoothStreaming.ManifestType.Composite
- Microsoft.Web.Media.SmoothStreaming.ManifestType.Segmented
- Microsoft.Web.Media.SmoothStreaming.ManifestType.Standard
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ManifestType
- Microsoft.Web.Media.SmoothStreaming.ManifestType.Composite
- Microsoft.Web.Media.SmoothStreaming.ManifestType.Segmented
- Microsoft.Web.Media.SmoothStreaming.ManifestType.Standard
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ManifestType Enumeration

The manifest type.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Enumeration ManifestType
'Usage

Dim instance As ManifestType
```

``` csharp
public enum ManifestType
```

``` c++
public enum class ManifestType
```

``` fsharp
type ManifestType
```

``` jscript
public enum ManifestType
```

## Members

<table>
<thead>
<tr class="header">
<th></th>
<th>Member name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td></td>
<td>Standard</td>
<td>The manifest is a standard manifest.</td>
</tr>
<tr class="even">
<td></td>
<td>Segmented</td>
<td>The manifest is a segmented (Live-to-VOD) manifest.</td>
</tr>
<tr class="odd">
<td></td>
<td>Composite</td>
<td>The manifest is a composite manifest. A composite manifest combines clips from one or more client manifests.</td>
</tr>
</tbody>
</table>


## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

