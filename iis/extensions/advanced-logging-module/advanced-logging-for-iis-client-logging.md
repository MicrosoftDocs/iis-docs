---
title: "Advanced Logging for IIS - Client Logging | Microsoft Docs"
author: rick-anderson
description: "IIS Advanced Logging can accept information about client-consumption of media and other content. Clients (for example, Microsoft Silverlight) can send useful..."
ms.author: iiscontent
manager: soshir
ms.date: 03/19/2009
ms.topic: article
ms.assetid: 39459850-55e5-4abd-94ea-c01507907f6f
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/advanced-logging-module/advanced-logging-for-iis-client-logging
msc.type: authoredcontent
---
Advanced Logging for IIS - Client Logging
====================
by [Vishal Sood](https://twitter.com/vishalsood)

IIS Advanced Logging can accept information about client-consumption of media and other content. Clients (for example, Microsoft Silverlight) can send useful data about their interaction with media content. This information forms the basis of analytic reporting, which can help businesses improve their content placement and return on investment (ROI).

IIS Advanced Logging accepts client logs by using standard HTTP POST messages and XML formatting, enabling most clients to use this capability.

<a id="requirements"></a>

## Requirements

For client logging to be useful, a client must send messages to IIS Advanced Logging via HTTP POST in the expected XML format. Clients that can do this include:

- Applications based on Microsoft Silverlight 3 or later. Silverlight includes metrics that you can use to post messages in the required XML format to the web server that has IIS Advanced Logging installed.
- The IIS Smooth Streaming sample client.

<a id="enable"></a>

## Enabling Client Logging

Client logging in IIS Advanced Logging is disabled by default. To enable this feature, do the following:

1. In IIS Manager, on the **Home** page for the server where you would like to receive client logs, double-click the **Advanced Logging** icon.  
    [![](advanced-logging-for-iis-client-logging/_static/image2.jpg)](advanced-logging-for-iis-client-logging/_static/image1.jpg)
2. In the **Actions** pane, click **Enable Client Logging**.  
    [![](advanced-logging-for-iis-client-logging/_static/image4.jpg)](advanced-logging-for-iis-client-logging/_static/image3.jpg)

<a id="sample"></a>

## Using the Sample Logging Client

IIS Smooth Streaming is an adaptive streaming platform from Microsoft that enables bitrate switching to accommodate a client's changing resource conditions (network throughput and CPU). For IIS Advanced Logging, we can use a Sample Logging Client for IIS Smooth Streaming, which provides rich data collection capabilities. This section describes how to set up the Sample Logging Client and configure IIS Advanced Logging to log the client-side analytical data.

### Setting up the Sample Logging Client

To set up the Sample Logging Client for IIS Smooth Streaming, do the following:

1. [Download the Sample Logging Client for IIS Smooth Streaming](https://go.microsoft.com/?linkid=9657323).
2. When you're prompted to extract the sample, click **Yes**.
3. When you're prompted to accept the License Agreement, click **Yes**.
4. When you're asked to specify a location in which to place the extracted files, enter a directory path (for example, **C:\LoggingSampleClient**). If prompted to create the directory, click **Yes** (this prompt will appear only if the directory doesn't exist).

When you navigate to the directory to which you extracted the sample, you'll see a file named SampleClient.xap. This is the Sample Logging Client. See the [Smooth Streaming documentation](../../media/on-demand-smooth-streaming/getting-started-with-iis-smooth-streaming.md) to see how a similar sample client is deployed and used. You can replace the .xap file in existing content with this file (rename if necessary or update the html that references it).

### Configuring the Sample Logging Client

The only configuration possible with the Sample Logging Client is to specify a log URL, which determines where the client will send HTTP POST messages containing the collected statistics. This section reviews two configuration options for logging Smooth Streaming client statistics.

#### Client-side manifest

Clients read the **LogUrl** element in a client-side manifest to determine the URL where the HTTP POST should be sent. Multiple **LogUrl** elements mean that the HTTP POST is sent to all the URLs in the list. The URLs specified in the [Initialization parameters](advanced-logging-for-iis-client-logging.md#parameters) section of this article are added to the list obtained from the manifest.

The syntax for adding LogUrls to the manifest is:


[!code-xml[Main](advanced-logging-for-iis-client-logging/samples/sample1.xml)]

<a id="parameters"></a>

#### Initialization parameters

The Log URL can also be set using the PARAM tag **initparams** while instantiating the client. The syntax is as follows (you can specify multiple LogUrls via a semi-colon separated list):

> [!NOTE]
> The values for the LogUrls in the initparams must be complete HTTP URLs. Use of relative URLs isn't permitted.


[!code-html[Main](advanced-logging-for-iis-client-logging/samples/sample2.html)]


### Configuring the Log Definition

For IIS Advanced Logging to take advantage of client logging capabilities, related fields and the log definition must be configured in the configuration store. While it's possible to use the Advanced Logging user interface in IIS Manager to do this, an easier way to configure the log definition is to use the script AddClientConfig.js. Click [here](advanced-logging-for-iis-client-logging/_static/advanced-logging-for-iis---client-logging-582-clientconfig_21.zip) to download the script in a compressed (zipped) folder (ClientConfig\_2.zip).

The script syntax is:


[!code-console[Main](advanced-logging-for-iis-client-logging/samples/sample3.cmd)]


where fields.xml is the XML file included in the zipped folder and baseFileName is the name you want to give to your log definition. If you don't specify a baseFileName, IIS Advanced Logging will use the default log definition name: %COMPUTERNAME%-Client.

After running the script, restart the web server by using the IIS Reset command-line utility or by restarting the web server in IIS Manager:

1. In the **Connections** pane, click the web server name.
2. In the **Actions** pane, click **Restart**.

The web server running IIS Advanced Logging can now receive client-side logs.

### Sample Logging Client - Log Events

The Sample Logging Client for IIS Smooth Streaming will post log messages for the following events:

- **Play**. Indicates the start of a play request. IIS Advanced Logging will begin calculating statistics.
- **Seek**. The client jumps to a new location. This event doesn't invalidate the current session or create a new one. All statistics other than the following continue to be cumulative:

    - **c-starttime**. The client resets to a new location using the Seek function. This field as specified above suggests the time in the video where playback started.
    - **startupTime**. Seeking may may cause the client buffer to be filled again, so we reset this value.
    - **x-duration**. The duration is reset to **0** when **c-starttime** changes.
- **Stop**. Client progressive download and playback stopped. However, the session (**c-playerid** GUID) isn't invalidated. Restarting playback will start from 0 offset again and at that point the following fields will continue to be cumulative:

    - **c-starttime**. Resets to **0**.
    - **startupTime**. Calculated again.
    - **x-duration**. Resets to **0**.
- **Pause**. This is similar to **Stop**, except that playback (when resumed) continues from the location where it was paused. In this case, all fields except the following continue to be cumulative:

    - **startupTime**. Calculated again
- **Periodic**. A snapshot of log data that is posted at 30-second intervals. The 30-second interval is calculated from a previous periodic log or from another log created from any of the other events above. You shouldn't misinterpret that this event occurs every 30 seconds. When another event occurs and a log is sent, the next periodic log is sent after 30 seconds has elapsed. This ensures that you don't log two events in a 30-second window unless two events occur during that interval.

### Sample Logging Client – Log Fields

IIS Advanced Logging can record client data for the following logging fields.

| **Field** | **Details** |
| --- | --- |
| **date** | The date the log was generated. |
| **time** | The time the log was generated. |
| **cs-url** | The manifest URL for the content item. |
| **c-playerId** | A unique GUID generated for each Smooth Streaming content, or a playlist if the content is part of one. |
| **c-buffercount** | Number of times rebuffering is required. This is how many times we underflow basically **.** This is calculated at the frame level. |
| **c-playerVersion** | Silverlight version |
| **c-bytes** | Number of bytes received by the client from the server. The value doesn't include any overhead that is added by the network stack. However, HTTP may introduce some overhead. Therefore, the same content streamed by using different protocols may result in different values. If c-bytes and sc-bytes(server-side) aren't identical, packet loss occurred. |
| **audiocodec** | Audio codec |
| **videocodec** | Video codec |
| **c-starttime** | The point where the client began watching the stream (in seconds, no fraction). For true live streaming, we need to calculate time offset using wallclock time. |
| **x-duration** | Duration (in seconds) of the data rendered by the client from c-starttime. |
| **c-os** | Operating system of the client computer. |
| **c-osversion** | Operating system version of the client computer. |
| **startupTimeMs** | From play to render first frame (in milliseconds). |
| **c-playerState** | Play/stop/pause, and so on. |
| **bandwidthMax** | Maximum perceived bandwidth |
| **bandwidthMin** | Minimum perceived bandwidth |
| **bandwidthAvg** | Average perceived bandwidth |
| **droppedFramesPerSecond** | Dropped frames per second (provided by Silverlight) |
| **renderedFramesPerSecond** | Rendered frames per second (provided by Silverlight) |
| **hasDRM** | The value can be true, false, or an enum such as DRM, PlayReady, Lightweight, and so on. |
| **audioResponseTimeAvg** | Average response time to get audio chunks. This is time from request to last byte. |
| **audioResponseTimeMax** | Maximum response time to get audio chunks. This is time from request to last byte. |
| **audioResponseTimeMin** | Minimum response time to get audio chunks. This is time from request to last byte. |
| **videoResponseTimeAvg** | Average response time to get video chunks. This is time from request to last byte. |
| **videoResponseTimeMax** | Maximum response time to get video chunks. This is time from request to last byte. |
| **videoResponseTimeMin** | Minimum response time to get video chunks. This is time from request to last byte. |
| **smoothStreamingVersion** | Smooth Streaming client version |
| **audioDownloadErrors** | Total number of missing audio chunks (for example, 404s). This is a semicolon-separated list of starttime/chunk IDs. |
| **videoDownloadErrors** | Total number of missing video chunks (for example, 404s). This is a semicolon-separated list of starttime/chunk IDs |
| **audioPlaybackBitrates** | An ordered list of the audio bitrates played during playback. This is a semicolon-separated list. This list is in the order of playback. There may be duplicate entries. |
| **videoPlaybackBitrates** | An ordered list of the video bitrates played during playback. This is a semicolon-separated list. This list is in the order of playback. There may be duplicate entries. |
| **audioPlaybackBitrateDurations** | An ordered list of durations of each of the audio bitrates played during playback. This is a semicolon-separated list. This list is in the order of playback. There may be duplicate entries. |
| **videoPlaybackBitrateDurations** | An ordered list of durations of each of the video bitrates played during playback in order. This is a semicolon-separated list. This list is in the order of playback. There may be duplicate entries. |
| **audioBandwidthAvg** | Average audio bitrate for the downloaded chunks |
| **videoBandwidthAvg** | Average video bitrate for the downloaded chunks |
| **audioBufferSizeAvg** | Average audio buffer size (in seconds) during playback |
| **audioBufferSizeMax** | Maximum audio buffer size (in seconds) during playback |
| **videoBufferSizeAvg** | Average video buffer size (in seconds) during playback |
| **videoBufferSizeMax** | Maximum video buffer size (in seconds) during playback |
| **audioSwitches** | Number of audio bitrate switches |
| **videoSwitches** | Number of video bitrate switches |

### Sample Logging Client - Sample Log Message

The following is a sample log from the Sample Logging Client for IIS Smooth Streaming:

[!code-xml[Main](advanced-logging-for-iis-client-logging/samples/sample4.xml)]

<a id="summary"></a>

## Summary

In this walkthrough, we reviewed the IIS Advanced Logging feature and learned how to log client data. Client logging and real-time logging can make real-time analysis of log files possible.

You also learned how to collect meaningful information from a Smooth Streaming experience by using the IIS Smooth Streaming sample client.

<a id="references"></a>

## References

- [Getting Started with IIS Smooth Streaming](../../media/on-demand-smooth-streaming/getting-started-with-iis-smooth-streaming.md)