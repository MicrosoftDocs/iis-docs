---
title: IPlaylistProvider Interface
description: Describes the IPlaylistProvider interface and lists its members with links to corresponding documentation.
TOCTitle: IPlaylistProvider Interface
ms:assetid: b4baeec6-a0f6-4a22-9278-0611b29818e9
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146285(v=VS.90)
ms:contentKeyID: 19132356
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistProvider Interface

The **IPlaylistProvider** interface is the root interface of a playlist provider.

## Members

|Member|Description|
|--- |--- |
|[IPlaylistProvider::Initialize Method](iplaylistprovider-initialize-method.md)|Called once after a playlist provider is instantiated.|
|[IPlaylistProvider::Shutdown Method](iplaylistprovider-shutdown-method.md)|Called before a playlist provider is released.|
|[IPlaylistProvider::GetPlaylistInfo Method](iplaylistprovider-getplaylistinfo-method.md)|Gets an [IPlaylistInfo Interface](iplaylistinfo-interface.md) object for the given request.|

## Notes for Implementers

Implementers may use this interface to control initialization and shut down of a custom playlist provider.
