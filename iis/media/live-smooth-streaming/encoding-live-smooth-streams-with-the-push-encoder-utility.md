---
title: "Encoding Live Smooth Streams with the Push Encoder Utility | Microsoft Docs"
author: rmcmurray
description: "Live Smooth Streaming encoders generate multiple streams, each containing MPEG-4 (MP4) fragments encoded at different bit rates. As in the encoded output for..."
ms.author: iiscontent
manager: soshir
ms.date: 08/24/2012
ms.topic: article
ms.assetid: 0e8ac833-fe5a-43e3-80af-4f8674e6c276
ms.technology: iis-media
ms.prod: iis
msc.legacyurl: /learn/media/live-smooth-streaming/encoding-live-smooth-streams-with-the-push-encoder-utility
msc.type: authoredcontent
---
Encoding Live Smooth Streams with the Push Encoder Utility
====================
by [Robert McMurray](https://github.com/rmcmurray)

Live Smooth Streaming encoders generate multiple streams, each containing MPEG-4 (MP4) fragments encoded at different bit rates. As in the encoded output for on-demand Smooth Streaming presentations, there can be multiple video and audio streams, depending on the encoder configuration. However, instead of storing the fragments sequentially in MP4-container files, the encoder delivers them directly to Live Smooth Streaming publishing points on Web servers. The metadata encoded in the Live Smooth Streaming output also differs from that encoded in on-demand Smooth Streaming files in that additional information is included in the encoded output to support Live Smooth Streaming features such as DVR-style client interaction, archiving by publishing points, and so on. Live Smooth Streaming encoders also do not output server client manifest files as on-demand Smooth Streaming encoders do. Instead, the Live Smooth Streaming publishing point on the server generates a manifest for clients, based on information provided to it by the encoder.

When a Live Smooth Streaming publishing point receives a request for media, it retrieves virtual fragments from the most appropriate stream in the live broadcast for the conditions at any given time in order to deliver the best content possible to the client.

To encode media to the Live Smooth Streaming presentation format in production environments, you can use Microsoft® Expression® Encoder 4 ([https://www.microsoft.com/expression/products/EncoderPro\_Overview.aspx](https://www.microsoft.com/expression/products/EncoderPro_Overview.aspx)) or a third-party encoding solution that contains a Live Smooth Streaming encoding profile. For more information, you should refer to your selected encoding solution's documentation for assistance. To help you determine which encoding solution is best-suited for your Live Smooth Streaming configuration, see the list of our encoding partners ([https://www.iis.net/media/partners](https://www.iis.net/media)).

If you do not have an encoder that can deliver live streams in the required format, you can use a Push Encoder test utility in test environments. The Push Encoder cannot accept input from a live source. Instead, it sources from on-demand Smooth Streaming presentation files and simulates the output that is required by Live Smooth Streaming publishing points. You can create the required input on-demand Smooth Streaming source files for the Push Encoder by using a Smooth Streaming-capable encoder. Again, see the list of our encoding partners ([https://www.iis.net/media/partners](https://www.iis.net/media)) to find companies that provide such an encoder. We also provide several on-demand Smooth Streaming presentations for testing purposes that you can download (see IIS Smooth Streaming HD Sample Content).

## Deploying the Push Encoder utility

The Push Encoder sources from on-demand Smooth Streaming presentation files and simulates the output that is required by Live Smooth Streaming publishing points. Before you proceed, make sure that the following prerequisite conditions are fulfilled:

- You have a Web server with an on-demand IIS Smooth Streaming presentation available as the content source. For more information, see Smooth Streaming for IIS 7 - Getting Started ([https://www.iis.net/learn/media/on-demand-smooth-streaming/getting-started-with-iis-smooth-streaming](../on-demand-smooth-streaming/getting-started-with-iis-smooth-streaming.md)).
- You have a Live Smooth Streaming publishing point configured on a Web server. For more information, see Live Smooth Streaming for IIS 7 - Getting Started ([https://www.iis.net/learn/media/live-smooth-streaming/getting-started-with-iis-live-smooth-streaming](getting-started-with-iis-live-smooth-streaming.md)).

To deploy the Push Encoder, do the following:

1. Go to the IIS Smooth Streaming Format SDK – Beta 2 download page and then download and run the Windows Installer (.msi) file for your edition of Windows: 

    - SSFSDK\_32.msi. For 32-bit editions of the operating system.
    - SSFSDK\_64.msi. For 64-bit editions of the operating system.
2. By default, the Push Encoder utility is installed to `%SystemDrive%\Program Files\Microsoft SDKs\IIS Smooth Streaming Format SDK\v1.0\Tools\`. After the installation finishes, locate the Push Encoder application (PushEncoder.exe) in this directory and copy it to the Web server that contains the on-demand Smooth Streaming presentation (for example, to `C:\inetpub\wwwroot`).

## Simulating an encoded Live Smooth Streaming presentation

The Push Encoder sources from files in an on-demand Smooth Streaming presentation and pushes the resulting simulated output to a Live Smooth Streaming publishing point on a Web server (this is known as a push-encoder configuration). Before you proceed, make sure that the following prerequisite conditions are fulfilled:

- The Live Smooth Streaming publishing point is configured and started on the Web server. For more information, see Live Smooth Streaming for IIS 7 - Getting Started.
- A Silverlight player template is updated so that clients can access the simulated Live Smooth Streaming presentation. For more information, see Serving the Live Stream to Clients.

To simulate Live Smooth Streaming encoded output, do the following:

1. On the Web server that contains an on-demand Smooth Streaming presentation, open a Command Prompt window and navigate to the directory where you installed the Push Encoder.
2. At the command prompt, type a command that uses the following syntax to begin encoding simulated Live Smooth Streaming output from the Smooth Streaming presentation: pushencoder &lt;full-url-of-publishing-point&gt; &lt;relative-url-of-ism-file&gt;  
  
 Where &lt;full-url-of-publishing-point&gt; is the fully qualified URL of the Live Smooth Streaming publishing point definition (.isml) file and &lt;relative-url-of-ism-file&gt; is the URL of the server manifest that describes all of the available bit rates in the Smooth Streaming presentation, relative to PushEncoder.exe.  
  
 As the Push Encoder pushes the streams to the publishing point, you can observe the push activity in the Command Prompt window.  
 The following table contains example commands that show how to specify different types of publishing point and source URLs, and how to specify basic encoding options:  

    | **Command** | **Description** |
    | --- | --- |
    | **pushencoder http://iismedia7/LiveSmoothStream.isml BigBuckBunny.ism** | The Push Encoder is sourcing the on-demand streams referenced in BigBuckBunny.ism and pushing them to the publishing point LiveSmoothStream.isml. The utility is located in the same directory as the server manifest (.ism) file. |
    | **pushencoder http://iismedia7/LiveSmoothStream.isml "Big Buck Bunny.ism"** | Same as above, except that the command wraps **Big Buck Bunny.ism** in quotation marks because there are spaces in the file name. |
    | **pushencoder http://iismedia7/LiveSmoothStream.isml BigBuckBunny\BigBuckBunny.ism** | The Push Encoder is sourcing the on-demand Smooth Streaming presentation files referenced in BigBuckBunny\BigBuckBunny.ism and pushing them to the Live Smooth Streaming publishing point LiveSmoothStream.isml. The utility is not located in the same directory as the .ism file and references it using the appropriate relative path. |
    | **pushencoder http://*UserName*:*Password*@iismedia7/LiveSmoothStream.isml BigBuckBunny.ism** | The Live Smooth Streaming publishing point requires authentication credentials (user name and password) before the Push Encoder can push streams to it. This example command shows how to insert the required credentials. |
    | **Pushencoder /create http://*UserName*:*Password*@iismedia7/BBB.isml BigBuckBunny.ism** | The **/create** option creates a publishing point on the Web Server before pushing live streams to it. In the example, a publishing point named **BBB.isml** is created on the default Web site. This option requires that the Web server on which the publishing point is created be WebDAV-enabled. Because WebDAV publishing is used to create the publishing point, you must also supply the appropriate user name and password in the command. For more information, see [Enabling WebDAV publishing on the Web server](#To_enable_WebDAV). **Note:** You must update the media reference in the Silverlight player template file so that clients can access the Live Smooth Streaming presentation from the new publishing point. For more information, see [Serving the Live Stream to Clients](getting-started-with-iis-live-smooth-streaming.md#client). |
    | **pushencoder /loop http://iismedia7/LiveSmoothStream.isml BigBuckBunny.ism** | The **/loop** option specifies that when the Push Encoder reaches the end of the presentation, it should return to the beginning of the presentation and continue the live streaming output. Use this option to simulate live streams that run indefinitely. |

## Using the advanced options

The Push Encoder utility contains the following options for testing advanced live Smooth Streaming scenarios. At the command prompt, type a command that uses the following syntax to begin encoding simulated Live Smooth Streaming output from a single Smooth Streaming video (.ismv) file in an on-demand Smooth Streaming presentation: pushencoder [options]&lt;full-url-of-publishing-point&gt; &lt;relative-url-of-ismv-file&gt; &lt;relative-url-of-ism-file&gt;  
  
Where &lt;full-url-of-publishing-point&gt; is the fully qualified URL of the Live Smooth Streaming publishing point definition (.isml) file, &lt;relative-url-of-ismv-file&gt; is the URL (relative to PushEncoder.exe) of the bit rate in the presentation that you want to encode, and &lt;relative-url-of-ism-file&gt; is the URL of the server manifest (relative to PushEncoder.exe) that describes all of the available bit rates in the Smooth Streaming presentation.

The following advanced [options] are available:

- **/liveArchive** Specifies that the on-demand source is from an archived Live Smooth Streaming presentation. This option must be used when sourcing an ISMV file from a previously archived Live Smooth Streaming presentation.
- **/realtime[:start]** Specifies that a specific time (formatted as /realtime[:?]) or the system tick time (formatted as /realtime) be used in place of 0 as the start time.
- **/id:&lt;id&gt;** Specifies the value to use in place of the standard process ID (PID) as the unique stream ID.
- **/noEOS** Specifies that an end-of-stream (EOS) signal is not sent when the stream ends. This is a useful option for testing encoder-failover scenarios.
- **/noSparseEOS** Specifies that an EOS signal is not sent when a sparse track, such as an advertisement, ends. This is a useful option for testing encoder-failover scenarios.
- **/noHeader** Specifies that ftyp and moov boxes are not included in the encoded output.
- **/streammanifest:&lt;file&gt;** Specifies the stream manifest file to use during encoding.
- **/headers:&lt;header1, header2, …&gt;** Specifies the HTTP request headers to include in the encoded output. To add multiple request headers to the output, enter them as a comma-delimited list.
- **/rate:&lt;rate&gt;** Specifies the rate at which the Smooth Stream fragments are pushed relative to the local system clock (which is considered to have a value of 1.0) in order to simulate different encoder clock speeds. For example, to specify that the encoder is outputting fragments at 99.9% of the system clock rate, enter the option as /rate:0.999. You can also use rate values larger than 1.0 to indicate faster encoder output. This option is useful for simulating encoder clock drift, which can cause buffer overflow or underflow on the client.
- **/skip:start,end** Specifies a range of fragments (inclusive) in the stream to skip during encoding.

<a id="To_enable_WebDAV"></a>
## Enabling WebDAV publishing on the Web server

WebDAV Publishing (Web Distributed Authoring and Versioning) enables you to publish files to and from a Web server by using the HTTP protocol. Because WebDAV uses HTTP, it works through most firewalls without modification. To configure WebDAV, do the following:

1. Install and configure the WebDAV Extension for IIS 7 on the Web server. For more information, see Installing and Configuring WebDAV on IIS 7 ([https://go.microsoft.com/fwlink/?LinkId=165796](https://go.microsoft.com/fwlink/?LinkId=165796)).
2. On the Web server, in Server Manager, install one of the following Security role services for the Web Server (IIS) role that matches the authentication method that you plan to use for WebDAV publishing: 

    - Basic Authentication
    - Windows Authentication
    - Digest Authentication

    For more information about installing role services in Server Manager, see Installing Components with Server Manager ([https://go.microsoft.com/fwlink/?LinkId=165797](https://go.microsoft.com/fwlink/?LinkId=165797)).

    > [!NOTE]
    > Anonymous authentication is not supported for publishing your encoded media files to a WebDAV-enabled server running IIS 7. For an overview of the authentication methods that you can use for WebDAV publishing, see Publish a video ([https://go.microsoft.com/fwlink/?LinkId=165798](https://go.microsoft.com/fwlink/?LinkId=165798)).
3. On the Web server, in IIS Manager, click the Web site or directory in the **Connections** pane that you plan to use for delivering your Smooth Streaming presentation.  
    [![](encoding-live-smooth-streams-with-the-push-encoder-utility/_static/image2.png)](encoding-live-smooth-streams-with-the-push-encoder-utility/_static/image1.png)
4. On the Home page, double-click the **Authentication** icon, and then enable and configure the **Security** role service that you installed.  
    [![](encoding-live-smooth-streams-with-the-push-encoder-utility/_static/image4.png)](encoding-live-smooth-streams-with-the-push-encoder-utility/_static/image3.png)  
  
 For more information, see Configuring Authentication in IIS 7 ([https://go.microsoft.com/fwlink/?LinkId=165799](https://go.microsoft.com/fwlink/?LinkId=165799)).