---
title: IPlaylistRequestInfo::GetServerVariable Method
TOCTitle: IPlaylistRequestInfo::GetServerVariable Method
ms:assetid: 9e53ad6b-1eae-451a-8ed9-9236a37049f8
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146282(v=VS.90)
ms:contentKeyID: 19132353
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistRequestInfo::GetServerVariable Method

The **GetServerVariable** method returns a single server variable from a collection of server variables associated with the request.

    HRESULT
    GetServerVariable(
            [in] BSTR                       bstrVarName,
            [out, retval] BSTR              *pbstrVarValue
    );

## Arguments

|||
|--- |--- |
|*bstrVarName*|The name of the server variable requested.|
|*pbstrVarValue*|The requested server variable.|


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

