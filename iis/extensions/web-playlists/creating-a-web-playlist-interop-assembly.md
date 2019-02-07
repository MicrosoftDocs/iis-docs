---
title: Creating a Web Playlist Interop Assembly
TOCTitle: Creating a Web Playlist Interop Assembly
ms:assetid: c3b169e8-b444-4c9f-b6b3-25f568c14c08
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146291(v=VS.90)
ms:contentKeyID: 19132362
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Creating a Web Playlist Interop Assembly

Before you can compile a managed Playlist provider, you must have an assembly that contains the interfaces which your provider will implement. This document describes how to create a type library from the IDL provided in the IIS Web Playlists SDK and then describes how to import the type library into a managed assembly.

This document assumes that you have downloaded and unzipped the IIS Web Playlists SDK.

## Create a Type Library

To create a type library, open up an SDK command prompt and type the following:

midl /I \<Playlist SDK path\> PlaylistProvider.idl /tlb PlaylistProvider.tlb /win32

midl /I \<Playlist SDK path\> PlaylistProvider.idl /tlb PlaylistProvider.tlb /x64

where \<Playlist SDK path\> is the path to the Playlist provider SDK.

For instance, if you have installed the Playlist provider in C:\\inc\\playlist you would type:

midl /I c:\\inc\\playlist PlaylistProvider.idl /tlb PlaylistProvider.tlb /win32

midl /I c:\\inc\\playlist PlaylistProvider.idl /tlb PlaylistProvider.tlb /x64

This will create a type library file that will be used in the next section. The types in the type library will be imported into a managed assembly.

## Import Types into an Assembly

To use the type library created in the previous section, type the following at the SDK command prompt:

tlbimp /out:\<output assembly\> /namespace:\<provider namespace\> \<type library path\>

where \<output assembly\> is the path to the assembly you want to produce, \<provider namespace\> is the managed namespace you want the types to be imported into, and \<type library path\> is the path of the type library you want to import.

For example, if you want to import the types from c:\\inc\\playlist\\PlaylistProvider.tlb into the Microsoft.Web.Media.Playlist.Provider namespace in an assembly located at c:\\asm\\playlist\\ SampleProvider.dll, you would type the following:

tlbimp /out:c:\\asm\\playlist\\sampleprovider.dll /namespace:Microsoft.Web.Media.Playlist.Provider c:\\inc\\playlist\\playlistprovider.tlb

You may also substitute the playlistprovider.tlb with the released playlisthandler.dll if you have it. To do so, type the following:

tlbimp /out:c:\\asm\\playlist\\sampleprovider.dll /namespace:Microsoft.Web.Media.Playlist.Provider c:\\inc\\playlist\\playlistprovider.dll

## See Also

#### Concepts

[Writing a Managed Web Playlist Provider](writing-a-managed-web-playlist-provider.md)

[Installing a Custom Web Playlist Provider](installing-a-custom-web-playlist-provider.md)

[Creating a Managed Playlist Provider](creating-a-managed-playlist-provider.md)

[IIS Web Playlists SDK Programming Guide](iis-web-playlists-sdk-programming-guide.md)

