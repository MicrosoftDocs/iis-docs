---
title: Manifest.AvailableStreams Property
TOCTitle: AvailableStreams Property
ms:assetid: cb531c1a-55e3-43d9-851f-3839dd53b3a6
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822834(v=VS.90)
ms:contentKeyID: 50079588
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# Manifest.AvailableStreams Property

**Applies to:** Windows Store apps only

Gets the available streams.

## Syntax

``` csharp
public IVectorView<IManifestStream> AvailableStreams { get; }
```

``` c++
public:
virtual property IVectorView<IManifestStream^>^ AvailableStreams {
IVectorView<IManifestStream^>^ get () sealed;
}
```

``` jscript
final function get AvailableStreams () : IVectorView<IManifestStream>
```

## Property Value

Type: IVectorView(IManifestStream)

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

