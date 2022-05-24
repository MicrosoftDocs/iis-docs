---
title: Writing a Managed Web Playlist Provider
TOCTitle: Writing a Managed Web Playlist Provider
description: "This article discusses interfaces included in the interop assembly; these must be implemented before writing a Web Playlist provider in managed code."
ms:assetid: 03598018-92ff-46d2-ab15-e90a21cd0af5
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146254(v=VS.90)
ms:contentKeyID: 19132325
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Writing a Managed Web Playlist Provider

You must produce an interop assembly with managed interfaces before you can write a Web Playlist provider in managed code. This procedure is discussed in the document titled "[Creating a Web Playlist Interop Assembly](creating-a-web-playlist-interop-assembly.md)."

After you have created the interop assembly, you must create the implementation for a few interfaces. These interfaces are discussed below.

## Interfaces

The interfaces included in the interop assembly are listed in the following table:

|                                      Interface                                      |                                                                                                   Description                                                                                                    |
|-------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|            [IPlaylistProvider Interface](iplaylistprovider-interface.md)            |                               Serves as the root interface for a custom Playlist provider. This interface provides access to initialization and shutdown routines for a provider.                                |
|         [IPlaylistRequestInfo Interface](iplaylistrequestinfo-interface.md)         | Enables custom providers to access HTTP request attributes. These attributes are exposed as server variables in the IIS 7 pipeline. String data may also be sent to the custom provider by using this interface. |
|                [IPlaylistInfo Interface](iplaylistinfo-interface.md)                |                  Defines an empty Playlist that contains a collection of Playlist entries in the form of an [IPlaylistEntryInfoCollection Interface](iplaylistentryinfocollection-interface.md)                  |
|           [IPlaylistEntryInfo Interface](iplaylistentryinfo-interface.md)           |                                                                                   Represents individual entries in a Playlist.                                                                                   |
| [IPlaylistEntryInfoCollection Interface](iplaylistentryinfocollection-interface.md) |                           Allows a custom provider to traverse a list of Playlist entries in the form of [IPlaylistEntryInfo Interface](iplaylistentryinfo-interface.md) info objects.                           |
|            [IPlaylistFileInfo Interface](iplaylistfileinfo-interface.md)            |                             Provides access to the properties of file-based Playlists. Implementing this interface is not required, but it is recommended for file-based providers.                              |

Each of these interfaces must be implemented before you can create a working provider, with the exception of [IPlaylistFileInfo Interface](iplaylistfileinfo-interface.md). The [IPlaylistFileInfo Interface](iplaylistfileinfo-interface.md) interface is useful for file-based providers. It allows you to access file information from the IIS pipeline and gain access to the file contents without having to implement the logic in your provider to open files and perform file operations.

## Example

The code sample below demonstrates how to add an advertisement to the beginning of a requested URL. This is an example of a managed Playlist provider:

using System;

using Microsoft.Web.Media.Playlist.Provider;

using System.Runtime.InteropServices;

namespace Microsoft.Web.Management.Media.Playlist.ProviderSample

{

public class PlaylistEntryInfo : IPlaylistEntryInfo {

public PlaylistEntryInfo(string name, bool canSeekOrSkip) {

\_name = name;

\_canSeekOrSkip = canSeekOrSkip;

}

ENTRY\_TYPE IPlaylistEntryInfo.EntryType {

get {

return ENTRY\_TYPE.EntryTypePhysicalFile;

}

}

string IPlaylistEntryInfo.Uri {

get {

return PlaylistProvider.MediaDirectory + \_name;

}

}

Object IPlaylistEntryInfo.GetProperty(

PLAYLIST\_ENTRY\_PROPERTY\_TYPE propertyName

) {

switch (propertyName) {

case PLAYLIST\_ENTRY\_PROPERTY\_TYPE.PlaylistEntryProperty\_CanSeek:

case PLAYLIST\_ENTRY\_PROPERTY\_TYPE.PlaylistEntryProperty\_CanSkipBackward:

case PLAYLIST\_ENTRY\_PROPERTY\_TYPE.PlaylistEntryProperty\_CanSkipForward:

return \_canSeekOrSkip;

default:

return null;

}

}

private string \_name;

private bool \_canSeekOrSkip;

}

public class PlaylistInfo : IPlaylistInfo, IPlaylistEntryInfoCollection

{

public PlaylistInfo(string adname, string filename) {

\_entries = new IPlaylistEntryInfo\[2\];

\_entries\[0\] = new PlaylistEntryInfo(adname, false);

\_entries\[1\] = new PlaylistEntryInfo(filename, true);

}

IPlaylistEntryInfoCollection IPlaylistInfo.Entries {

get {

return this;

}

}

uint IPlaylistEntryInfoCollection.Count {

get {

return 2;

}

}

IPlaylistEntryInfo IPlaylistEntryInfoCollection.this\[uint index\] {

get {

return \_entries\[index\];

}

}

Object IPlaylistInfo.GetProperty(PLAYLIST\_PROPERTY\_TYPE propertyName) {

if (propertyName == PLAYLIST\_PROPERTY\_TYPE.PlaylistProperty\_Title) {

return "Wrapper Playlist";

}

return null;

}

void IPlaylistInfo.EndRequestStatus(

uint urlEntryId, uint status,

int completionStatus, ulong bytesSent

) {

// No processing for EndRequest

}

private IPlaylistEntryInfo\[\] \_entries;

}

\[Guid("D5178953-96A0-4ebd-B511-024897DA2C09")\]

\[ProgId("SamplePlaylistProvider.ProviderSample")\]

\[ComVisible(true)\]

public class PlaylistProviderSample : IPlaylistProvider

{

IPlaylistInfo IPlaylistProvider.GetPlaylistInfo(IPlaylistRequestInfo requestInfo) {

String path = requestInfo.Path;

String name = path.Substring(path.LastIndexOf('/') + 1);

name = name.Substring(0, name.LastIndexOf(".")) + FileExtension;

return new PlaylistInfo(Advertisement + FileExtension, name);

}

void IPlaylistProvider.Initialize() {

//Load defaults for this provider... from config/xml etc

MediaDirectory = @"C:\\Test\\Media\\";

Advertisement = "advertisement";

FileExtension = ".flv";

}

void IPlaylistProvider.Shutdown() { }

public static String MediaDirectory;

public static String Advertisement;

public static String FileExtension;

}

}

The PlaylistProviderSample class is the main class listed in this sample. Notice that it is marked with the ComVisible, ProgId, and Guid attributes. These attributes allow the provider to be registered and used by COM. The remainder of the classes in this sample are implementations of the other interfaces needed to support the PlaylistProviderSample class.

To build this sample, you will need the interop assembly created in the document, "[Creating a Web Playlist Interop Assembly](creating-a-web-playlist-interop-assembly.md)."

You can compile this sample by saving this code sample as "playlistprovidersample.cs" and then typing the following at an SDK command prompt:

csc.exe /noconfig /nowarn:1701,1702 /errorreport:prompt /warn:4 /define:TRACE /reference:playlistprovider.dll /reference: c:\\windows\\microsoft.net\\framework\\v2.0.50727\\system.dll /debugpdbonly /filealign:512 /optimize+ /out:obj\\release\\providersample.dll /target:library playlistprovidersample.cs

This command assumes that the interop assembly, playlistprovider.dll, is in the same directory as playlistprovidersample.cs.

## See Also

### Concepts

[Creating a Web Playlist Interop Assembly](creating-a-web-playlist-interop-assembly.md)

[Installing a Custom Web Playlist Provider](installing-a-custom-web-playlist-provider.md)

[Creating a Managed Playlist Provider](creating-a-managed-playlist-provider.md)
