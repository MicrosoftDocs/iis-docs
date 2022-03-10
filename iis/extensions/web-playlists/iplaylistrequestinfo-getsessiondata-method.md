---
title: IPlaylistRequestInfo::GetSessionData Method
TOCTitle: IPlaylistRequestInfo::GetSessionData Method
ms:assetid: 806a9f3e-9390-4d67-8b9a-25a24974969e
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146278(v=VS.90)
ms:contentKeyID: 19132349
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistRequestInfo::GetSessionData Method

The **GetSessionData** method gets the playlist provider specific data saved for this session.

```cpp
HRESULT
GetSessionData (
        [out,reval] BSTR                       *pbstrVarValue
);
```

## Arguments

|Argument|Description|
|--- |--- |
|*pbstrVarValue*|The returned session data|

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
