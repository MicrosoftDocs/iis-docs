---
title: IPlaylistRequestInfo::Format Property
TOCTitle: IPlaylistRequestInfo::Format Property
ms:assetid: b965b958-102b-4f00-930e-d87fd4f0d5e0
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146288(v=VS.90)
ms:contentKeyID: 19132359
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistRequestInfo::Format Property

The **Format** property gets the format in which playlist is requested.

    HRESULT Format( [out,retval] BSTR *pbstrPlaylistFormat );

## Arguments

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>bstrPlaylistFormat</p></td>
<td><p>The returned format of the <a href="iplaylistrequestinfo-interface.md">IPlaylistRequestInfo Interface</a> instance.</p></td>
</tr>
</tbody>
</table>


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Remarks


> [!NOTE]
> <P>ASX is the only format supported at this time.</P>



## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

