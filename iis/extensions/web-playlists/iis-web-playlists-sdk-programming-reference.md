---
title: IIS Web Playlists SDK Programming Reference
TOCTitle: Programming Reference
description: "The IIS Web Playlists SDK allows developers to extend the default behavior through the development of custom providers and provides a COM interface."
ms:assetid: b90dbdd2-a0e5-4675-8924-6507c1e2b66a
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146287(v=VS.90)
ms:contentKeyID: 19132358
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Web Playlists SDK Programming Reference

The IIS Web Playlists SDK allows developers to extend the default behavior through the development of custom providers. The SDK provides a COM interface that supports implementation in either .NET or native code providers.

## Interfaces

The following table represents the interfaces used to develop custom playlist programming references.

|Interface|Description|
|--- |--- |
|[IPlaylistProvider Interface](https://msdn.microsoft.com/library/dd146285)|Serves as the root interface for a custom playlist provider. This interface provides access to initialization and shutdown routines for a provider.|
|[IPlaylistRequestInfo Interface](https://msdn.microsoft.com/library/dd146293)|Represents the current playlist request. Enables custom providers to get and set server variables, the URI of the request, and playlist file information if the playlist is file-based.|
|[IPlaylistInfo Interface](https://msdn.microsoft.com/library/dd146255)|Defines an empty playlist that contains a collection of playlist entries in the form of an IPlaylistEntryInfoCollection Interface.|
|[IPlaylistEntryInfo Interface](https://msdn.microsoft.com/library/dd146268)|Represents individual entries in a playlist.|
|[IPlaylistEntryInfoCollection Interface](https://msdn.microsoft.com/library/dd146264)|Allows a custom provider to traverse a list of playlist entries in the form of IPlaylistEntryInfo Interface info objects.|
|[IPlaylistFileInfo Interface](https://msdn.microsoft.com/library/dd146277)|Provides access to properties of file-based playlists.|

## See Also

### Concepts

[IIS Web Playlists](iis-web-playlists.md)
