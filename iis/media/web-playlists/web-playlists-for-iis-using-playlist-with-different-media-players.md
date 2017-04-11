---
title: "Web Playlists for IIS 7 - Using Playlist With Different Media Players | Microsoft Docs"
author: rick-anderson
description: "This article describes how various clients can interact with Web Playlists to display the playlist content. Web Playlists works with the clients mentioned in..."
ms.author: iiscontent
manager: soshir
ms.date: 02/27/2008
ms.topic: article
ms.assetid: 
ms.technology: iis-media
ms.prod: iis
msc.legacyurl: /learn/media/web-playlists/web-playlists-for-iis-using-playlist-with-different-media-players
msc.type: authoredcontent
---
Web Playlists for IIS 7 - Using Playlist With Different Media Players
====================
by [Vishal Sood](https://twitter.com/vishalsood)

This article describes how various clients can interact with Web Playlists to display the playlist content. Web Playlists works with the clients mentioned in this article; however, any client that supports ASX natively or through extensions can use this feature.

<a id="Prerequisites"></a>

## Prerequisites

To install the Web Playlists extension for IIS 7 and above, see the **Installation Notes** section in the [IIS Media Services Readme](../iis-media-services/iis-media-services-readme.md).

<a id="Windows"></a>

## Windows Media Player

Follow the steps below to consume an ISX (Web Playlist) file in Windows Media Player 11 (WMP)

1. Open Windows Media Player 11.
2. Click File. Select Open URL.

    [![](web-playlists-for-iis-using-playlist-with-different-media-players/_static/image2.jpg)](web-playlists-for-iis-using-playlist-with-different-media-players/_static/image1.jpg)
3. Type in the URL to the .isx file and click OK.

    [![](web-playlists-for-iis-using-playlist-with-different-media-players/_static/image4.jpg)](web-playlists-for-iis-using-playlist-with-different-media-players/_static/image3.jpg)

<a id="Silverlight"></a>

## Silverlight

Silverlight has an out-of-the-box Media Element that can play ASX files. This fits very well with the Web Playlists handler, as it sends out an ASX response when an .isx URL is requested. Thus, for us to be able to play back Web Playlists in Silverlight, we must use the Media Element.

### Media Element

MediaElement is the object in the Silverlight rendering engine that knows how to play back audio and video content.

Adding media to a page is as simple as adding a [MediaElement](https://msdn.microsoft.com/en-us/library/bb980132.aspx) to your markup and providing a Uniform Resource Identifier (URI) to the media to play. The following example creates a MediaElement and sets its [Source](https://msdn.microsoft.com/en-us/library/bb979939.aspx) property to the URI of a video file. The MediaElement begins playing when the page loads.

[!code-xml[Main](web-playlists-for-iis-using-playlist-with-different-media-players/samples/sample1.xml)]

The MediaElement object can play Windows Media Video (WMV), Windows Media Audio (WMA), and MP3 files. For a detailed list of the formats and protocols supported, see [Supported Media Formats and Protocols](https://msdn.microsoft.com/en-us/library/bb980063.aspx).

### Using PARAM Tags in Silverlight

To the play the playlist in a Silverlight MediaElement, simply point the Source of the MediaElement to the ISX file location. This plays the playlist entries in the order specified. In case you want to control the appearance of next / previous buttons, or control the seek bar on the client site, you must access the PARAM tags associated with the MediaElement. By default, Silverlight just ignores these PARAM tags. The PARAM tags of interest in our case are CANSKIPFORWARD, CANSKIPBACK and CANSEEK along with the attribute CLIENTSKIP for the entry. CLIENTSKIP is handled by Silverlight by disabling seek on the media element.

Any of these PARAM tags can easily be accessed from a Silverlight app by using **Attributes**. Here is a simple piece of code that tells how to read an attribute:


[!code-javascript[Main](web-playlists-for-iis-using-playlist-with-different-media-players/samples/sample2.js)]
 

After you have read the attributes CANSKIPFORWARD, CANSKIPBACKWARD and CANSEEK, you can easily control the UI experience by appropriately enabling / disabling the controls.By default, Silverlight does not have implemented the concept of skipping to the next entry in the playlist. One way to overcome this limitation is to seek to the end of the current entry and let the next entry play automatically.

### Silverlight Reference

- MediaElement - [https://msdn.microsoft.com/en-us/library/bb980141.aspx](https://msdn.microsoft.com/en-us/library/bb980141.aspx)
- Attributes - [https://msdn.microsoft.com/en-us/library/bb979671.aspx](https://msdn.microsoft.com/en-us/library/bb979671.aspx)

<a id="Flash"></a>

## Flash Player

The Web Playlist .isx file, when accessed on the client side, generates an ASX file. To play a Web Playlist file in Flash, we need to add the capability for Flash to parse ASX files. ASX files are simply XML files. The way to add this capability to Flash player is to write an Action Script (.AS) which can load the ASX response from the web request and then parse the response to get the relevant entries and PARAM tags. Then, tie them back to the controls in the UI element where the media will play.

Below are a few classes that help in parsing the ASX response sent by the Web Playlists module when a get request is made for an .ISX Playlist file. This is just a sample and suggests one way of doing the same.


[!code-console[Main](web-playlists-for-iis-using-playlist-with-different-media-players/samples/sample3.cmd)]


The **Playlist** class above helps parse an ASX file to get the playlist entries and the **PlaylistEntry** class helps parse each entry to get appropriate PARAM tags to be used to set the player controls in the UI accordingly. The code above makes use of XML parsing abilities provided by the Flash SDK. The Playlist class parses the ASX to store all entries in an array and then PlaylistEntry goes through the array to parse the appropriate data for each entry.

The classes above should be used together with NetConnection, NetStream and Video classes provided by Flash. Below is a sample piece of code that shows how these could be used. The actual implementation is left to the reader.


[!code-console[Main](web-playlists-for-iis-using-playlist-with-different-media-players/samples/sample4.cmd)]


[Discuss in IIS Forums](https://forums.iis.net/1145.aspx)