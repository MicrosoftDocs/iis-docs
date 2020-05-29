---
title: IPlaylistProvider::Initialize Method
TOCTitle: IPlaylistProvider::Initialize Method
ms:assetid: 21faac8a-b6eb-4fd9-a0cd-daf331119e05
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146259(v=VS.90)
ms:contentKeyID: 19132330
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistProvider::Initialize Method

The **Initialize** method is called once after a playlist provider is instantiated.

```cpp
HRESULT
Initialize(
);
```

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Notes for Implementers

This method may be implemented to customize the initialization behavior of a custom playlist provider.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
