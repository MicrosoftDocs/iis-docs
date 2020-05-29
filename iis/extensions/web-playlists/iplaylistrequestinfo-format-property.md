---
title: IPlaylistRequestInfo::Format Property
TOCTitle: IPlaylistRequestInfo::Format Property
ms:assetid: b965b958-102b-4f00-930e-d87fd4f0d5e0
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146288(v=VS.90)
ms:contentKeyID: 19132359
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistRequestInfo::Format Property

The **Format** property gets the format in which playlist is requested.

```cpp
HRESULT Format( [out,retval] BSTR *pbstrPlaylistFormat );
```

## Arguments

|||
|--- |--- |
|*bstrPlaylistFormat*|The returned format of the [IPlaylistRequestInfo Interface](https://msdn.microsoft.com/library/dd146293) instance.|

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Remarks

> [!Note]  
> ASX is the only format supported at this time.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
