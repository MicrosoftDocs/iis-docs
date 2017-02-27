---
title: "Delivering Transform Manager Output to Clients | Microsoft Docs"
author: rick-anderson
description: "If you want to serve the transformed on-demand output from IIS Transform Manager 1.0 to clients, you must move or copy the transformed output files to a serv..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 03/07/2012
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/media/transform-manager/delivering-transform-manager-output-to-clients
msc.type: authoredcontent
---
Delivering Transform Manager Output to Clients
====================
by Dave Nelson

If you want to serve the transformed on-demand output from [IIS Transform Manager 1.0](https://www.iis.net/downloads/microsoft/transform-manager) to clients, you must move or copy the transformed output files to a server that's running the [IIS Smooth Streaming](https://www.iis.net/downloads/microsoft/smooth-streaming) feature in IIS Media Services 4. The Smooth Streaming feature enables a handler that processes requests for on-demand Smooth Streaming presentation manifest files (files with .ism file name extensions), which are present in the Smooth Streaming and Apple HTTP Live Streaming presentations that are created by Transform Manager.

This article describes how to deliver Transform Manager output to clients.

In this article:

- [Licensing](delivering-transform-manager-output-to-clients.md#license)
- [Staging the Transformed Output for IIS Smooth Streaming](delivering-transform-manager-output-to-clients.md#stage)
- [Installing IIS Smooth Streaming](delivering-transform-manager-output-to-clients.md#installss)
- [Serving the On-Demand Smooth Streams](delivering-transform-manager-output-to-clients.md#servess)
- [Serving the On-Demand Apple HTTP Live Streams](delivering-transform-manager-output-to-clients.md#servehls)

<a id="license"></a>

## Licensing

IIS Transform Manager is designed to work with other programs, such as programs that handle audio or video signals. It's solely your responsibility to ensure your compliance with any terms accompanying such other programs, and that you have obtained any necessary rights for your use of the programs.

<a id="stage"></a>

## Staging the Transformed Output for IIS Smooth Streaming

If you chained Transform Manager's built-in **Robocopy** task to a job template in order to copy the transformed output to a Web server, the output files should be stored in the destination that you specified on the Web server. If you didn't use the built-in **Robocopy** task, or if it failed to copy the output files to the specified destination, you can copy the output files from the watch folder's WorkQueue to the Web server by doing the following:

1. If the watch folder is disabled, select it in the **Watch Folders** page, and then click **Enable** in the **Actions** pane.
2. In the **Actions** pane, click **Explore Watch Folder**.
3. Open the WorkQueue folder, and then the Finished folder.
4. Copy the folder that contains the transformed presentation to the Web server.

> [!NOTE]
> For more information about how to use the **Robocopy** task in Transform Manager, see [Chaining the Robocopy Task to your Transformed Output](chaining-the-robocopy-task-to-your-transformed-output.md).


<a id="installss"></a>

## Installing IIS Smooth Streaming

To serve the transformed on-demand Smooth Streams and Apple HTTP Live Streams, the IIS Smooth Streaming feature in IIS Media Services 4 must be installed. To install IIS Smooth Streaming, see the IIS Media Services Readme [Installation Notes](../iis-media-services/iis-media-services-readme.md#installation).

When you install the Smooth Streaming feature, handlers that process requests for on-demand Smooth Streaming presentation manifest files (files with .ism file name extensions) might not be configured for a website if the site settings have been changed from default values. The website might not have acquired the handler for .ism files and Smooth Streaming might not work. If you have previously edited a website, after installing IIS Smooth Streaming, ensure that a handler is installed for .ism files by doing the following:

1. In IIS Manager, in the **Connections** pane, click the website or directory that you want to use for Smooth Streaming, and then double-click the **Handler Mappings** icon in the **Home** page.
2. If the **SmoothHandler** handler mapping isn't displayed on the **Handler Mappings** feature page, in the **Actions** pane, click **Revert to Parent**.

<a id="servess"></a>

## Serving the On-Demand Smooth Streams

After you've installed the IIS Smooth Streaming feature, no additional configuration steps are required to deliver on-demand Smooth Streaming presentations.

To locate the Smooth Streaming presentation files on the Web server, do the following:

1. In IIS Manager, navigate to the Smooth Streaming presentation folder in the **Connections** pane.  
    [![](delivering-transform-manager-output-to-clients/_static/image2.png)](delivering-transform-manager-output-to-clients/_static/image1.png)
2. In the **Home** page, double-click the **Smooth Streaming Presentations** icon in the **Media Services** area.  
    [![](delivering-transform-manager-output-to-clients/_static/image4.png)](delivering-transform-manager-output-to-clients/_static/image3.png)
3. Click **Content View** to view the Smooth Streaming presentation files.  
    [![](delivering-transform-manager-output-to-clients/_static/image6.png)](delivering-transform-manager-output-to-clients/_static/image5.png)

Clients can use their web browser to open Default.html and play the Smooth Streaming presentation in a Silverlight player. You must simply provide the URL of Default.html to the client.

For more information about how to manage your on-demand Smooth Streaming presentation files on the Web server, see [Managing On-Demand Presentations](../on-demand-smooth-streaming/managing-on-demand-presentations.md).

<a id="servehls"></a>

## Serving the On-Demand Apple HTTP Live Streams

After you've installed the IIS Smooth Streaming feature, You must create an HTML5 page that can be used by supported Apple mobile digital devices to play the Apple HTTP Live Streaming presentation.

The following Apple mobile digital devices/iOS mobile operating systems can be used to play the transformed Apple HTTP Live Streaming presentation:

- iPhone®, iPod touch®: iOS 3.0, iOS 3.0.1, iOS 3.1, iOS 3.1.2, iOS 3.1.3, iOS 4.0, iOS 4.1, iOS 5.0
- iPad®: iOS 3.2, iOS 4.2.1, iOS 5.0

To create the HTML5 page, do the following:

1. In IIS Manager, navigate to the Apple HTTP Live Streaming presentation folder in the **Connections** pane.  
    [![](delivering-transform-manager-output-to-clients/_static/image8.png)](delivering-transform-manager-output-to-clients/_static/image7.png)
2. In the **Home** page, double-click the **Smooth Streaming Presentations** icon in the **Media Services** area.  
    [![](delivering-transform-manager-output-to-clients/_static/image10.png)](delivering-transform-manager-output-to-clients/_static/image9.png)
3. Click **Content View** to view the Apple HTTP Live Streaming presentation files.  
    [![](delivering-transform-manager-output-to-clients/_static/image12.png)](delivering-transform-manager-output-to-clients/_static/image11.png)
4. Right-click the **Content View** window, and then click **Explore**.
5. In Notepad, create a text file with an HTM file-name extension and save it to this location. In this example, we'll save the text document as **iphone**.htm.  
    [![](delivering-transform-manager-output-to-clients/_static/image14.png)](delivering-transform-manager-output-to-clients/_static/image13.png)
6. Open the **iphone.htm** file in Notepad and add the following sample HTML:

    [!code-html[Main](delivering-transform-manager-output-to-clients/samples/sample1.html)]

 Update the manifest request     `src` URL so that clients can access the .m3u8 file on the server by replacing the file name in     `manifest.ism` with the file name of the presentation ISM file. For example: 

    [!code-html[Main](delivering-transform-manager-output-to-clients/samples/sample2.html?highlight=10)]
7. (Optional) As shown in the sample HTML, you can add additional HTML5 video attributes such as `poster`, `autoplay`, and `controls`.  
  
 The     `controls` attribute must be set for iPad devices to play the video. For more information about how to configure the HTML5     `video` element, see     **4.8.6 The video element** in the     [W3C HTML5 Specification](http://www.w3.org/TR/html5/spec.html) .
8. On an Apple device, open the Safari® Web browser and enter the URL of the iphone.htm page in the browser, and then click **GO**. The page will load with the default HTML5 video element, which contains a simple **Play** button.  
    [![](delivering-transform-manager-output-to-clients/_static/image16.png)](delivering-transform-manager-output-to-clients/_static/image15.png)
9. Click the **Play** button in the HTML5 video element. The device will open the QuickTime® player and begin loading the stream. You might need to wait a few seconds for the video to start.  
    [![](delivering-transform-manager-output-to-clients/_static/image18.png)](delivering-transform-manager-output-to-clients/_static/image17.png)

| ![Note](delivering-transform-manager-output-to-clients/_static/image1.gif) **Notes** - If the device displays a message box that says "Can't open Movie," it's likely that you're using a profile that's not supported by the device. This error message is typically seen when sending a Baseline Level 3.1 profile or Main Level 3.1 to a device that only supports Baseline Level 3.0 (older iPhone devices and iPod touch devices). - You might see an error message if you try to play the stream when there are fewer than 3 segments available in the playlist. This can happen if you don't wait for 3 times the segment length; for example, 30 seconds when the default segment length is set to 10 seconds. |
| --- |
  
  
[Discuss in IIS Forums](https://forums.iis.net/1145.aspx)