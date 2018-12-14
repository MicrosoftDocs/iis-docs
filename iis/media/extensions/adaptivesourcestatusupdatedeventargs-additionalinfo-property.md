---
title: AdaptiveSourceStatusUpdatedEventArgs.AdditionalInfo Property
TOCTitle: AdditionalInfo Property
ms:assetid: c2b57443-1418-4d01-aaaa-d6be06f79a9c
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822826(v=VS.90)
ms:contentKeyID: 50079580
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# AdaptiveSourceStatusUpdatedEventArgs.AdditionalInfo Property

**Applies to:** Windows Store apps only

Gets the additional info.

## Syntax

``` csharp
public string AdditionalInfo { get; }
```

``` c++
public:
virtual property String^ AdditionalInfo {
String^ get () sealed;
}
```

``` jscript
final function get AdditionalInfo () : String
```

## Property Value

The additional info.

## Remarks

When the update type is 4 (BitrateChanged), additional info field will include bitrate value and update time. BitrateChanged event fires when the downloaded qualities change. This is different than the rendering time. There can be delays when the quality changes in the display because of the internal buffers. "Update Time" represents the playback time.

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

