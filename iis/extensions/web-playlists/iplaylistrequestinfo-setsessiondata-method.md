---
title: IPlaylistRequestInfo::SetSessionData Method
description: Describes the IPlaylistRequestInfo::SetSessionData method and details its arguments, return value, and requirements.
TOCTitle: IPlaylistRequestInfo::SetSessionData Method
ms:assetid: 7a728484-e952-4d7d-ab4d-ea854bd359e0
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146276(v=VS.90)
ms:contentKeyID: 19132347
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistRequestInfo::SetSessionData Method

The **SetSessionData** method sets the playlist provider specific data for this session.

```cpp
HRESULT
SetSessionData (
        [in] BSTR                       bstrVarValue
);
```

## Arguments

|Argument|Description|
|--- |--- |
|*bstrVarValue*|The value to assign to the session variable.|

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
