---
title: IPlaylistRequestInfo::Path Property
TOCTitle: IPlaylistRequestInfo::Path Property
ms:assetid: 45b48164-8ac8-4a1d-bd18-e09941f2a1be
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146266(v=VS.90)
ms:contentKeyID: 19132337
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistRequestInfo::Path Property

The **Path** property gets the physical path of the requested playlist file.

    RESULT Path( [out, retval] BSTR* pbstrPath);

## Arguments

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>pbstrName</p></td>
<td><p>The physical path of the <a href="iplaylistrequestinfo-interface.md">IPlaylistRequestInfo Interface</a> instance.</p></td>
</tr>
</tbody>
</table>


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Remarks


> [!NOTE]
> <P>A physical playlist file is not required to implement a playlist provider.</P>



## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

