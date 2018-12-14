---
title: IPlaylistRequestInfo::SetSessionData Method
TOCTitle: IPlaylistRequestInfo::SetSessionData Method
ms:assetid: 7a728484-e952-4d7d-ab4d-ea854bd359e0
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146276(v=VS.90)
ms:contentKeyID: 19132347
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistRequestInfo::SetSessionData Method

The **SetSessionData** method sets the playlist provider specific data for this session.

    HRESULT
    SetSessionData (
            [in] BSTR                       bstrVarValue
    );

## Arguments

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>bstrVarValue</p></td>
<td><p>The value to assign to the session variable.</p></td>
</tr>
</tbody>
</table>


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

