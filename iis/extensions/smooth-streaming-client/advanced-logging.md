---
title: Advanced Logging
TOCTitle: Advanced Logging
ms:assetid: 4f6af850-b519-45b8-b2df-47c34bc2ed70
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ff728114(v=VS.95)
ms:contentKeyID: 46359322
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- csharp
---

# Advanced Logging

To monitor and test a Silverlight Smooth Streaming client, you can use [IIS Advanced Logging](http://go.microsoft.com/fwlink/?linkid=230674). IIS Advanced Logging provides rich, flexible data collection and real-time logging capabilities. You can log HTTP request and response headers, IIS server variables, and client-side fields in order to track end-user engagement for each IIS application.

## Advanced Logging

The Smooth Streaming client can use data about its interaction with media content as the basis of analytic reporting. IIS Advanced Logging accepts client logs sent by standard HTTP POST messages. The data is formatted as XML text for both transport and logging. You can use the logs for troubleshooting or research on usage.

### Prerequisites

To use IIS Advanced Logging, you have to install the feature and configure IIS to use it. After the feature is installed, in IIS Manager, double-click the **Advanced Logging** icon, and then click **Enable Advanced Logging** in the **Actions** pane. (For more information, see [Advanced Logging for IIS 7 - Client Logging](http://go.microsoft.com/fwlink/?linkid=230676).) You can download [Smooth Streaming HD sample content](http://go.microsoft.com/fwlink/?linkid=251075) to test the Smooth Streaming client.

### Advanced Logging Initialization

To use IIS Advanced Logging, create a reference to the [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md) assembly as shown in the following example:

``` csharp
using Microsoft.Web.Media.Diagnostics;
```

You can initialize client logging when the Silverlight page loads as shown in the following example. The [ApplicationLogUrls](advancedloggingplugin-applicationlogurls-property-microsoft-web-media-diagnostics_1.md) property can contain several URLs; if it does, logging data will be sent to each of the URLs.

``` csharp
    void MainPage_Loaded(object sender, RoutedEventArgs e)
    {
        // Initialize IIS Advanced Logging.
        AdvancedLoggingPlugin log = new AdvancedLoggingPlugin();
        log.ApplicationLogUrls = new List<string>() {"http://<serverName>/newLog.log"};
        log.TimerInterval = TimeSpan.FromSeconds(30);
        log.SmoothStreamingMediaElement = SmoothPlayer;
    }
```

The collected statistics are sent in XML format as the body of standard HTTP POST messages.

The following additional configuration options are available for logging:

  - **Client manifest configuration**. Clients can read the LogUrl element in a client-side manifest to determine the URL where the log information should be sent. The URLs specified in initialization parameters are added to the list obtained from the manifest. The following example shows the pertinent syntax of the LogUrl element in the client manifest.
    
        <SmoothStreamingMedia
          MajorVersion="1"
          MinorVersion="0"
          Duration="6537916781">
          <LogUrl>http://logserver/iislogging.log</LogUrl>
          <StreamIndex
            Type="video"
            Subtype="WVC1"
            Chunks="327"
            Url="QualityLevels({bitrate})/Fragments(video={start time})">

  - **Initialization parameters**. The log URL can also be set using a param element named initparams. You can specify multiple LogUrl servers, separated by semicolons, in the object element of the Web page that calls the Silverlight XAP file. The following example shows the syntax:
    
        <object data="data:application/x-silverlight-2," type="application/x-silverlight-2" 
                width="100%" height="100%">
            <param name="source" value="SampleClient.xap"/>
            <param name="onerror" value="onSilverlightError" />
            <param name="initparams" 
                value='autoplay=true,autoload=true,enablecaptions=true,muted=false,
                displaytimecode=true,playlist=<playList><playListItems><playListItem title="test"
                description="test" mediaSource="http://server/contentdir/content.ism/manifest"
                adaptiveStreaming="True" thumbSource="" frameRate="24.0" width="512" height="384>
            </playListItem></playListItems></playList>,logUrls=http://server/contentdir/newLog.log' />
            <a href="http://go2.microsoft.com/fwlink/?LinkID=124807" style="text-decoration: none;">
            <img src="http://go2.microsoft.com/fwlink/?LinkId=108181" 
                alt="Get Microsoft Silverlight" style="border-style: none"/>
            </a>
        </object>

### Configuring the Log Definition

For IIS Advanced Logging to use client logging, you have to configure fields in the log definition. You can use the **Advanced Logging** user interface in IIS Manager to define the log, but an easier way to configure the log is to use the AddClientConfig.js script. You can download the script from the IIS.net Web site: [ClientConfig\_2.zip](http://go.microsoft.com/fwlink/?linkid=251073).

The download file contains the fields.xml file, which is an XML file that defines logging fields. Run the script a shown in the following command. The baseFileName parameter specifies the name of your log definition file. If you do not specify a baseFileName value, IIS Advanced Logging uses the default log definition name of %COMPUTERNAME%-Client.

    AddClientConfig.js [/f:<fields.xml>] [/b:<baseFileName>]

The content of the fields.xml file is as follows. Change the value of the applicationUri element to your domain and application's XAP file. After you define the log, be sure to enable the definition in IIS Manager.

    <?xml version="1.0" encoding="utf-8"?>
    <XML>
      <applicationUri>http://www.contoso.com/AdaptiveStreamingStatsTracker.xap</applicationUri>
      <audioBandwidthAvg>932844</audioBandwidthAvg>
      <audioBandwidthMax>27343198</audioBandwidthMax>
      <audioBandwidthMin>46528</audioBandwidthMin>
      <audioBitrates>160016</audioBitrates>
      <audioBufferChunks>0</audioBufferChunks>
      <audioBufferChunksAvg>10</audioBufferChunksAvg>
      <audioBufferChunksMax>11</audioBufferChunksMax>
      <audioBufferSize>0</audioBufferSize>
      <audioBufferSizeAvg>401160</audioBufferSizeAvg>
      <audioBufferSizeMax>458553</audioBufferSizeMax>
      <audioBufferTime>0</audioBufferTime>
      <audioBufferTimeAvg>199669058</audioBufferTimeAvg>
      <audioBufferTimeMax>221692517</audioBufferTimeMax>
      <audioChunks>250</audioChunks>
      <audioCodec>Wma</audioCodec>
      <audioDownloadedDuration>4986427210</audioDownloadedDuration>
      <audioDownloadedSize>10058537</audioDownloadedSize>
      <audioDownloadErrors>0</audioDownloadErrors>
      <audioPlaybackBitrateDurations>4353451247</audioPlaybackBitrateDurations>
      <audioPlaybackBitrates>160016</audioPlaybackBitrates>
      <audioResponseTimeAvg>42</audioResponseTimeAvg>
      <audioResponseTimeMax>881</audioResponseTimeMax>
      <audioResponseTimeMin>1</audioResponseTimeMin>
      <audioSwitches>0</audioSwitches>
      <bandwidthAvg>4721028</bandwidthAvg>
      <bandwidthMax>104207158</bandwidthMax>
      <bandwidthMin>46528</bandwidthMin>
      <browserName>Microsoft Internet Explorer</browserName>
      <browserPlatform>Win32</browserPlatform>
      <browserVersion>4.0</browserVersion>
      <c-buffercount>5</c-buffercount>
      <c-bytes>177010217</c-bytes>
      <clientStartTime>2009-03-19 21:48:18Z</clientStartTime>
      <c-os>Win32NT</c-os>
      <c-osversion>6.0.6001.65536</c-osversion>
      <c-playerId>0a786fb9-ea8b-4851-aa2f-63e2192401ed</c-playerId>
      <c-playerState>EndOfStream</c-playerState>
      <c-playerVersion>2.0.40115.0</c-playerVersion>
      <c-starttime>793</c-starttime>
      <cs-url>http://www.contoso.com/smooth/Big_Buck_Bunny.ism/manifest</cs-url>
      <date>2009-03-19</date>
      <displayHeight>831</displayHeight>
      <displayIsFullScreen>False</displayIsFullScreen>
      <displayWidth>1676</displayWidth>
      <droppedFramesPerSec>0</droppedFramesPerSec>
      <hasDRM>False</hasDRM>
      <isLive>False</isLive>
      <logReason>playerStateChange: Playing-EndOfStream</logReason>
      <manifestRequests>1</manifestRequests>
      <playbackEndTime>2009-03-19 21:59:40Z</playbackEndTime>
      <playbackStartTime>2009-03-19 21:48:19Z</playbackStartTime>
      <renderedFramesPerSec>24</renderedFramesPerSec>
      <requestHeadersEnabled>False</requestHeadersEnabled>
      <seeks>2</seeks>
      <smoothStreamingVersion>2.0</smoothStreamingVersion>
      <startupTimeMs>125.5251</startupTimeMs>
      <time>21:59:40</time>
      <videoBandwidthAvg>6250217</videoBandwidthAvg>
      <videoBandwidthMax>104207158</videoBandwidthMax>
      <videoBandwidthMin>549495</videoBandwidthMin>
      <videoBitrates>336000;636000;936000;1436000;1936000;2936000</videoBitrates>
      <videoBufferChunks>2</videoBufferChunks>
      <videoBufferChunksAvg>10</videoBufferChunksAvg>
      <videoBufferChunksMax>11</videoBufferChunksMax>
      <videoBufferSize>264564</videoBufferSize>
      <videoBufferSizeAvg>6560685</videoBufferSizeAvg>
      <videoBufferSizeMax>8300593</videoBufferSizeMax>
      <videoBufferTime>10833334</videoBufferTime>
      <videoBufferTimeAvg>203326340</videoBufferTimeAvg>
      <videoBufferTimeMax>219583333</videoBufferTimeMax>
      <videoChunks>262</videoChunks>
      <videoCodec>WVC1</videoCodec>
      <videoDownloadedDuration>5223750001</videoDownloadedDuration>
      <videoDownloadedSize>166951680</videoDownloadedSize>
      <videoDownloadErrors>0</videoDownloadErrors>
      <videoPlaybackBitrateDurations>20000000;20000000;20000000;20000000;420000000;760000000;
    93333334;20000000;20000000;20000000;20000000;1840000000;669583334;20000000;207916667;20000000;
    93333334</videoPlaybackBitrateDurations>
      <videoPlaybackBitrates>336000;636000;936000;1436000;2936000;1936000;2936000;336000;
    636000;936000;1436000;2936000;1936000;336000;2936000;336000;2936000</videoPlaybackBitrates>
      <videoResponseTimeAvg>101</videoResponseTimeAvg>
      <videoResponseTimeMax>636</videoResponseTimeMax>
      <videoResponseTimeMin>6</videoResponseTimeMin>
      <videoSwitches>16</videoSwitches>
      <x-duration>11</x-duration>
    </XML>

## See Also

#### Other Resources

[Advanced Logging for IIS 7 - Client Logging](http://go.microsoft.com/fwlink/?linkid=230676)

