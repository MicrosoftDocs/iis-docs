---
title: ManifestTrack.CustomAttributeNames Property
TOCTitle: CustomAttributeNames Property
ms:assetid: 8bbb3af0-0f18-47db-9687-7cd50f3e6012
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822775(v=VS.90)
ms:contentKeyID: 50079530
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestTrack.CustomAttributeNames Property

**Applies to:** Windows Store apps only

Gets the track level custom attributes names.

## Syntax

``` csharp
public IVectorView<string> CustomAttributeNames { get; }
```

``` c++
public:
virtual property IVectorView<String^>^ CustomAttributeNames {
IVectorView<String^>^ get () sealed;
}
```

``` jscript
final function get CustomAttributeNames () : IVectorView<String>
```

## Property Value

The track level custom attributes names.

## Requirements

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><strong>Minimum supported client</strong></p></td>
<td><p>Windows 8</p></td>
</tr>
<tr class="even">
<td><p><strong>Minimum supported server</strong></p></td>
<td><p>Not Supported</p></td>
</tr>
<tr class="odd">
<td><p><strong>Metadata</strong></p></td>
<td><p>Microsoft.Media.AdaptiveStreaming.winmd</p></td>
</tr>
</tbody>
</table>

