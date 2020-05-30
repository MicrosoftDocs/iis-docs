---
title: "IIS Media Services Readme"
author: rick-anderson
description: "Applies To: IIS Media Services 4 (IIS Media Services 4.1 and IIS Media Services 4.0), IIS Media Services 3 Last Updated: June 27, 2012 IIS Media Services int..."
ms.date: 06/23/2011
ms.assetid: 618ec076-9347-4dc0-b7b7-4f73cc069ac5
msc.legacyurl: /learn/media/iis-media-services/iis-media-services-readme
msc.type: authoredcontent
---
# IIS Media Services Readme

by Dave Nelson

Applies To: IIS Media Services 4 (IIS Media Services 4.1 and IIS Media Services 4.0), IIS Media Services 3

Last Updated: June 27, 2012

[IIS Media Services](https://go.microsoft.com/?linkid=9735225) integrates with [Internet Information Services (IIS) 7](https://go.microsoft.com/?linkid=9735226) to provide a secure, scalable, and easy-to-manage HTTP-based media delivery platform for managing rich and dynamic websites, applications, and services.

IIS Media Services contains the following extensions for IIS 7:

- [Live Smooth Streaming](https://go.microsoft.com/?linkid=9735230). Enables HTTP adaptive streaming of live media broadcasts to Smooth Streaming-compatible clients (including Microsoft Silverlight) and to Apple&reg; mobile digital devices.
- [Smooth Streaming](https://go.microsoft.com/?linkid=9735229). Enables HTTP adaptive streaming of media files to Smooth Streaming-compatible clients and to Apple devices through integration with [IIS Transform Manager](https://go.microsoft.com/?linkid=9735234).
- [Bit Rate Throttling](https://go.microsoft.com/?linkid=9735227). Provides enhanced progressive downloading that can substantially reduce bandwidth costs.
- [Web Playlists](https://go.microsoft.com/?linkid=9735228). Enables server-side control of content and advertising, ensuring that you can protect, personalize, and monetize your media assets.

<a id="whatsnew"></a>

## What's New

IIS Media Services 4.1 contains the following new features:

- Performance enhancements for the IIS Smooth Streaming and IIS Live Smooth Streaming extensions.
- Support for managing Live Smooth Streaming publishing points programatically by using [IIS Smooth Streaming Management REST Services](https://go.microsoft.com/?linkid=9787827).

<a id="installation"></a>

## Installation Notes

This section describes the installation requirements for IIS Media Services.

<a id="requirements"></a>

### Requirements

The following prerequisites must be fulfilled to install IIS Media Services:

- You must use IIS 7 running on one of the following operating systems: 

    - Windows Server 2008 R2
    - Windows Server 2008
    - Windows 7
    - Windows Vista with SP1
- To manage IIS Media Services features using the IIS Manager user interface, the **IIS Management Console** for IIS must be installed.
- To use the optional ASP.NET session state persistence feature in IIS Web Playlists, **ASP.NET** for IIS must be installed.
- You must be an administrator on the computer. This can be accomplished by logging on to the computer using either the Administrator account or an account with administrative privileges.

> [!IMPORTANT]
> Microsoft Silverlight includes support for cross-domain connectivity, which allows an application to access resources from locations other than the site of origin. This is an important feature for enabling Silverlight applications to consume existing services on the web. The security policy system in the Silverlight runtime requires that a Silverlight policy file named ClientAccessPolicy.xml be downloaded from a target domain before a network connection is allowed access to a network resource under that target domain. If you expect to deliver Smooth Streams across domain boundaries to Silverlight-based clients, you must host the ClientAccessPolicy.xml file in your Smooth Streaming web server root to allow Silverlight applications to access the Smooth Streams. For more information about how to create a ClientAccessPolicy.xml file, see [Network Security Access Restrictions in Silverlight](https://go.microsoft.com/?linkid=9749724).

<a id="install"></a>

### Downloading and Installing

IIS Media Services 4.1 can be installed by using either Microsoft Web Platform Installer (Web PI) or Windows Installer. IIS Media Services 4.0 must be installed using Windows Installer. IIS Media Services 4.1 and 4.0 are available in the following languages:

- Chinese (Simplified)
- Chinese (Traditional)
- English
- French
- German
- Italian
- Japanese
- Korean
- Russian
- Spanish

**Install IIS Media Services 4.1 Using Web PI**

1. Go to the [Web Platform Installer webpage](https://go.microsoft.com/?linkid=9735231) and click **Download It Now** to download and run Web PI.
2. At the bottom of the **Web Platform Installer** dialog box, click **Options**.
3. In the **Change Options** dialog box, select your preferred language for software installations, and then click **OK**.
4. At the top of the **Web Platform Installer** dialog box, click **Products** in the **Spotlight** – **Products** – **Applications** row of options.
5. In the Contents pane, click either **All** or **Server**.
6. In the list of products that is displayed, click the **Add** button for **IIS Media Services 4.1**, and then click **Install**.

**Install IIS Media Services 4 Using Windows Installer**

Separate downloadable installation packages are available for each release of IIS Media Services 4. Click one of the following links to download the Windows Installer (.msi) file for your edition of Windows:

- [IIS Media Services 4.1 (32-bit)](https://go.microsoft.com/?linkid=9787829)
- [IIS Media Services 4.1 (64-bit)](https://go.microsoft.com/?linkid=9787830)
- [IIS Media Services 4.0 (32-bit)](https://go.microsoft.com/?linkid=9735235)
- [IIS Media Services 4.0 (64-bit)](https://go.microsoft.com/?linkid=9735236)

Follow the instructions on the **Download details** page to install the software.

<a id="upgrade"></a>

### Upgrading from a Previous Version of IIS Media Services

If a previous version of IIS Media Services is installed on your computer, and you use Web PI to install a more recent version, Web PI will automatically update the software to the new version.

If you use a Windows Installer file to install the software, Setup will update the previous version to the new version. However, if you mark an installed feature as unavailable on the **Custom Setup** page in the Setup Wizard, Setup will uninstall the feature.

<a id="uninstall"></a>

### Uninstalling

To remove IIS Media Services features, in **Control Panel** &gt; **Programs** &gt; **Programs and Features**, under **Uninstall or change a program**, click **IIS Media Services**, and then click **Change**.

To remove all of the IIS Media Services features, in **Control Panel** &gt; **Programs** &gt; **Programs and Features**, under **Uninstall or change a program**, click **IIS Media Services**, and then click **Uninstall**.

<a id="issues"></a>

## Known Issues

This section describes the known issues for IIS Media Services features.

<a id="issues_lss"></a>

### Live Smooth Streaming

This section describes the known issues for IIS Live Smooth Streaming.

#### Encoding and delivering Apple HTTP Live Streaming content

Applies To: IIS Media Services 4

To stream content to an Apple mobile digital device, you must have access to a Live Smooth Streaming-capable encoder, such as [Microsoft&reg; Expression&reg; Encoder 4 Pro](https://go.microsoft.com/fwlink/?LinkID=149601), that supports encoding content using H.264 video with AAC low complexity (AAC-LC) audio codecs.

**Supported encoding profiles**

The following video and audio formats are supported by the Apple HTTP Live Streaming feature in IIS Live Smooth Streaming 4:

- **Video**. H.264 Baseline Profile Level 3.0 (iPhone&reg;/iPod&reg;/iPod touch&reg;), Main Profile Level 3.1 (iPad&trade;)
- **Audio**. AAC-LC up to 48 kHz, stereo audio

For more information about the supported encoding profiles for Apple mobile digital devices, see [Recommended Encoding Settings for HTTP Live Streaming Media](https://go.microsoft.com/?linkid=9736231) on the Apple Developer website.

**Supported Apple devices**

The following Apple mobile digital devices/iOS mobile operating systems are supported by the Apple HTTP Live Streaming feature:

- iPhone, iPod touch: iOS 3.0, iOS 3.0.1, iOS 3.1, iOS 3.1.2, iOS 3.1.3, iOS 4.0, iOS 4.1, iOS 5.0
- iPad: iOS 3.2, iOS 4.2.1, iOS 5.0

> [!NOTE]
>  
> - The encoded live stream received by the publishing point must contain both audio and video.
> - Apple recommends that you not use B-frames when encoding streams for iPhone and iPod devices.
> - Although the iPhone 3GS can play content that is at a level higher than Baseline 3.0, it's not recommended if you plan to target older iPhone devices and iPod touch devices.
> - You shouldn't use AAC-LC audio at bitrates higher than 64 Kbps when targeting iPhone/iPod devices.

**About Expression Encoder 4**

[Microsoft Expression Encoder 4 Pro](https://go.microsoft.com/fwlink/?LinkID=149601) must be used to encode to Smooth Streaming format with H.264/AAC-LC codecs. If you purchased Expression Studio 3 from a store, and it's installed on your computer, you can download a trial version of Expression Studio 4 Ultimate or Expression Studio 4 Web Professional, and the full version of Expression Studio 4 (which includes Expression Encoder 4 Pro) will automatically be enabled.

Expression Encoder 4 Pro includes presets for iPhone and iPad devices for both cellular and WiFi networks. The **H.264 IIS Smooth Streaming iPhone WiFi** preset uses settings recommended by Apple for delivering content to an iPhone device over a WiFi network. The profile uses H.264 Baseline, Level 3.0 at 3 different bitrates: 700 Kbps, 400 Kbps, and 200 Kbps. It's a 1-pass CBR encode with no B-frames. For more information about how to encode and deliver live Smooth Streams to Apple mobile digital devices, see [Apple HTTP Live Streaming with IIS Media Services](https://go.microsoft.com/?linkid=9736234).

#### Specifying the maximum bitrate for MPEG-2 TS live streams

Applies To: IIS Media Services 4

The maximum recommended bitrate for delivery to Apple iPhone and iPad devices is 1,600 kilobits per second (Kbps). If your Smooth Streaming encoder creates bitrates in the stream that are higher than this value, you can configure a **Maximum bit rate** setting for the Live Smooth Streaming feature in IIS Manager and specify the highest bitrate in the stream that will be converted to MPEG-2 TS segments. For more information about how to set the maximum bitrate value, see [Add/Edit Publishing Point Dialog Box](https://go.microsoft.com/?linkid=9749725).

In IIS Media Services 4.0, the default **Maximum bit rate** value is set to **3,000** Kbps because Microsoft Expression Encoder 4 reports its encoded audio bitrate incorrectly. Because the audio track is typically encoded with the video tracks in the stream, lowering the maximum bitrate value might cause some or all of the video tracks to not be converted to MPEG-2 TS segments, making them unavailable for playback on the Apple device. This issue was corrected in [Microsoft Expression Encoder 4 Service Pack 1 (SP1)](https://go.microsoft.com/?linkid=9735239). Install the latest Service Pack onto your encoding computer that is running Expression Encoder 4, and then change the **Maximum bit rate** value in the Live Smooth Streaming feature to **1,600** Kbps.

In IIS Media Services 4.1, the default **Maximum bit rate** value is set to **1,600** Kbps. Be sure to install the [Expression Encoder 4 SP1](https://go.microsoft.com/?linkid=9735239) so that the bitrates are filtered correctly.

#### Delivering Apple HTTP Live Streams through CDNs

Applies To: IIS Media Services 4

If your Live Smooth Streaming presentations will be delivered through a Content Delivery Network (CDN) or from an edge cache, you must ensure that the src tag for the video is constructed correctly in your HTML 5 page so that Apple iPhone and iPad devices can play the streams.

As an example, for Live Smooth Streams delivered directly from a Smooth Streaming origin server, the following src URL is typically used:

src="*PublishingPointName*.isml/manifest(format=m3u8-aapl)"

For streams delivered through a CDN or from an edge cache, you must add the extension **.m3u8** to the end of the src URL:

src="*PublishingPointName*.isml/manifest(format=m3u8-aapl).m3u8"

For more information about how to create an HTML 5 page that can be used by iPhone and iPad devices to play Live Smooth Streaming presentations, see [Creating an HTML 5 page for use in Safari](https://go.microsoft.com/?linkid=9749855).

#### Adding website handler mappings for live streams

Applies To: IIS Media Services 4, IIS Media Services 3

When you install the Live Smooth Streaming feature, handlers that process requests for publishing point definition files (files with .isml file name extensions) might not be configured for a website if the site settings have been changed from default values. The website might not have acquired the handler for .isml files and Live Smooth Streaming might not work. If you have previously edited a website, after installing IIS Live Smooth Streaming, ensure that a handler is installed for .isml files by doing the following:

1. In the **Connections** pane, click the website or directory that you want to use for Live Smooth Streaming, and then double-click **Handler Mappings** in the Home page.
2. If the **LiveStreamingHandler** handler mapping isn't displayed on the **Handler Mappings** feature page, in the **Actions** pane, click **Revert to Inherited**.

#### Distributing live streams using Application Request Routing

Applies To: IIS Media Services 4, IIS Media Services 3

If you use [Application Request Routing (ARR)](https://go.microsoft.com/?linkid=9735242) for disk-based caching of live Smooth Streams or as an edge cache in CDN/ECN environments, and ARR forwards a request for live streams from a publishing point on a remote Live Smooth Streaming server to a publishing point on the local Live Smooth Streaming server, the request might fail if the ASP.NET session state is enabled on the local website or directory that contains the publishing point. The ASP.NET session state should be disabled to ensure proper distribution of live streams. To do this, do the following:

1. In IIS Manager, in the **Connections** pane, click the website or directory that contains the publishing point.
2. In the website or directory **Home** page, in the **ASP.NET** category, double-click the **Session State** icon.
3. In the **Session State** feature page, in the **Session State Mode Settings** area, select **Not enabled**.

> [!NOTE]
>  
> 
> Turning off ASP.NET session state disables it for all local website or directory features and applications that are using it. If you are also the Web Playlists feature in IIS Media Services on the local website or directory and you configured Web Playlists to use ASP.NET session state persistence to store user session variables, be sure to change the **Session persistence type** in Web Playlists to **InMemory** to store user session data in the web server worker process memory. For more information about how to change the session-persistence type, see [Edit Feature Settings Dialog Box](https://go.microsoft.com/?linkid=9749726).

#### Archiving segmented presentations

Applies To: IIS Media Services 4, IIS Media Services 3

Archiving live streams to multiple on-demand Smooth Streaming presentations (or segments) might not work correctly if you specify a segment length of less than 5 minutes. To ensure archiving of segmented presentations works correctly, enter a value of **5** or greater in the **Segment length** box.

#### Viewing publishing point status

Applies To: IIS Media Services 4, IIS Media Services 3

You can view the status of a publishing point's connection to a live source, such as an encoder or a publishing point on another Live Smooth Streaming server, in the **State** column on the **Live Smooth Streaming Publishing Points page**. When you start a publishing point, the **State** changes to **Starting**, which means that it's enabled. When the live source begins delivering live streams to the publishing point, the **State** changes to **Started**; however, the state change isn't visible unless you refresh website or directory that contains the publishing point.

<a id="issues_ss"></a>

### Smooth Streaming

This section describes the known issues for IIS Smooth Streaming.

#### Adding website handler mappings for on-demand Smooth Streams

Applies To: IIS Media Services 4, IIS Media Services 3

When you install the Smooth Streaming feature, handlers that process requests for on-demand Smooth Streaming presentation manifest files (files with .ism file name extensions) might not be configured for a website if the site settings have been changed from default values. The website might not have acquired the handler for .ism files and Smooth Streaming might not work. If you have previously edited a website, after installing IIS Smooth Streaming, ensure that a handler is installed for .ism files by doing the following:

1. In IIS Manager, in the **Connections** pane, click the website or directory that you want to use for Smooth Streaming, and then double-click **Handler Mappings** in the **Home** page.
2. If the **SmoothHandler** handler mapping isn't displayed on the **Handler Mappings** feature page, in the **Actions** pane, click **Revert to Inherited**.

#### Configuring the SmoothHandler handler mapping to process HTTP Head requests

Applies To: IIS Media Services 3

The default installation of the Smooth Streaming feature adds the **SmoothHandler** handler mapping to the **handlers** collection and registers the handler to process the HTTP requests GET and HEAD for on-demand Smooth Streaming presentation manifest (.ism) files. However, a configuration error in the string that specifies the HTTP verbs for which the handler mapping applies causes the following issues:

- Clients that send HTTP HEAD requests for .ism files receive a **404** response.
- Players created by using the [Smooth Streaming Client](https://go.microsoft.com/?linkid=9735237) might not be able to play Smooth Streams referenced in a [Smooth Streaming presentation composite manifest file](https://go.microsoft.com/?linkid=9735238) (a file with a .csm file name extension).

These issues occur because the string that specifies the HTTP verbs contains a space when all spaces must be trimmed from the string. You can update the string in IIS Manager or by running an Appcmd.exe command at a command prompt to edit the configuration file (applicationHost.config) directly, as described in the following procedures.

> [!NOTE]
>  
> 
> If you perform the procedure in this section by using IIS Manager, you must be a server administrator or an IIS Manager user who has been granted permission to the web server in IIS Manager. If you perform the procedure in this section by using Appcmd.exe, you must have Write permissions to applicationHost.config.

##### To configure request restrictions for the SmoothHandler handler mapping in IIS Manager

1. In IIS Manager, navigate to the web server level. For information about navigating to locations in the UI, see [Navigation in IIS Manager (IIS 7)](https://go.microsoft.com/?linkid=9735240).
2. In **Features View**, double-click **Handler Mappings**.  
    [![](iis-media-services-readme/_static/image2.jpg)](iis-media-services-readme/_static/image1.jpg)
3. On the **Handler Mappings** page, right-click **SmoothHandler**, and then click **Edit**.  
    [![](iis-media-services-readme/_static/image4.jpg)](iis-media-services-readme/_static/image3.jpg)
4. In the **Edit Module Mapping** dialog box, click **Request Restrictions**.  
    [![](iis-media-services-readme/_static/image6.jpg)](iis-media-services-readme/_static/image5.jpg)
5. In the **Request Restrictions** dialog box, on the **Verbs** tab, select the option **One of the following verbs**, and then type the following in the corresponding box: **GET,HEAD**  
    [![](iis-media-services-readme/_static/image8.jpg)](iis-media-services-readme/_static/image7.jpg)

##### To configure request restrictions for the SmoothHandler handler mapping in the Command Prompt window

- To specify that the **SmoothHandler** handler respond only to requests for HTTP verbs GET and HEAD, type the following at the command prompt, and then press ENTER: 

    **appcmd set config /section:handlers /[name=' SmoothHandler '].verb:GET,HEAD**

#### Preventing static file download of Smooth Streaming presentation files

Applies To: IIS Media Services 4, IIS Media Services 3

Smooth Streaming is designed to deliver video fragments in an HTTP response from media source files stored in a fragmented MPEG-4 (MP4) media container format (with .ismv file name extensions). The .ismv source files allow for easy management of the video source content on the web server, but they're not designed to be downloaded by clients. We recommend that you use the Request Filtering feature in IIS 7 to deny access to the .ismv file name extension. For more information about how to configure request filtering, see [Request Filtering](https://go.microsoft.com/?linkid=9735241).

<a id="issues_brt"></a>

### Bit Rate Throttling

This section describes the known issues for IIS Bit Rate Throttling.

#### Media files that aren't throttled

Applies To: IIS Media Services 4, IIS Media Services 3

Most pre-defined media format files are throttled correctly. However, some non-standard files might have differences in the file header that cause Bit Rate Throttling to not detect the encoded bitrate. When this occurs, the file is downloaded to clients with no throttling applied.

<a id="issues_wp"></a>

### Web Playlists

This section describes the known issues for IIS Web Playlists.

#### Adding the ASP.NET Session State Persistence Option

Applies To: IIS Media Services 4, IIS Media Services 3

If you are installing IIS Media Services for the first time, or if you are upgrading a previous version of IIS Media Services, and the optional ASP.NET session state persistence feature for Web Playlists wasn't previously installed, you can add this feature by doing the following:

1. Verify that **ASP.NET** for IIS is installed.
2. If you used Web PI to install IIS Media Services, download and run the Windows Installer file for your edition of Windows. (See **Install Using Windows Installer** for more information.)  
  
   -or-  
  
   If you used a Windows Installer file to install IIS Media Services, in **Control Panel** > **Programs** > **Programs and Features**, under **Uninstall or change a program**, click **IIS Media Services**, and then click **Change**.
3. In **IIS Media Services Setup**, on the **Change, repair, or remove installation** page, click **Change**.
4. In **IIS Media Services Setup**, on the **Custom Setup** page, mark the **Session Helper** feature under **Web Playlists** for installation.

#### Using special characters in XSLT output format names

Applies To: IIS Media Services 4, IIS Media Services 3

When you use XSL Transformation (XSLT) style sheets in Web Playlists to specify alternate output formats in the Web Playlists response to clients, you must specify an output format name. The output format name is attached to the query string in the playlist URL returned to clients. For example, http://*ServerName*/*PlaylistName*.isx?format=*FormatName*, where *FormatName* is any name that you use to identify the output format. The query string is the part of the URL after the question mark (?) character (format=*FormatName*).

Web Playlists encodes the URLs returned to clients according to Internet standards described in [RFC 1738: Uniform Resource Locators (URL)](https://go.microsoft.com/?linkid=9735243). Special characters (such as a space, brackets (&lt; and &gt;), ampersand (&amp;), and so on) that you include in the output format name in the query strings returned to clients aren't encoded and some clients might not be able to parse the URL by using escape characters and view the transformed output. To ensure that all clients can view the transformed output, we recommend that you don't use special characters in XSLT output format names. If you want to use a space in your output format name, use the hyphen (-) character instead, as most web browsers recognize the hyphen as a space separator.

<a id="support"></a>

## Product Support

You can obtain support for IIS Media Services by using the following resources:

**Self Support**

- [Knowledge Base](https://go.microsoft.com/?linkid=9735244)
- [Forum](https://go.microsoft.com/?linkid=9735245)

**Microsoft Support**

To obtain support from Microsoft, go to [Microsoft Support](https://go.microsoft.com/?linkid=9735246).

<a id="resources"></a>

## For More Information

To keep up-to-date with the latest IIS Media Services feature news and developments, go to the [IIS Media Services home page](https://go.microsoft.com/?linkid=9735247) on IIS.net.
