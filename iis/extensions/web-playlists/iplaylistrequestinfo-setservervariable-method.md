---
title: IPlaylistRequestInfo::SetServerVariable Method
TOCTitle: IPlaylistRequestInfo::SetServerVariable Method
ms:assetid: 80ff059b-a0fa-4339-a4fd-5100f60381d9
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146279(v=VS.90)
ms:contentKeyID: 19132350
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistRequestInfo::SetServerVariable Method

The **SetServerVariable** method sets a single server variable in a collection of server variables associated with the request.

    HRESULT
    SetServerVariable(
            [in] BSTR                       bstrVarName,
            [in] BSTR                       bstrVarValue
    );

## Arguments

|||
|--- |--- |
|*bstrVarName*|The name of the server variable to set.|
|*bstrVarValue*|The value to assign to the server variable.|


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

