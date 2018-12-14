---
title: IPlaylistProvider::Shutdown Method
TOCTitle: IPlaylistProvider::Shutdown Method
ms:assetid: 57ea47b7-0033-4c13-b30e-e1f3a998a325
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146271(v=VS.90)
ms:contentKeyID: 19132342
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistProvider::Shutdown Method

The **Shutdown** method is called before playlist provider is released.

    HRESULT
    Shutdown(
    );

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Remarks

This method may be implemented to customize the shutdown behavior of a custom playlist provider.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

