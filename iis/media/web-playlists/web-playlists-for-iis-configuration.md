---
title: "Web Playlists for IIS 7 - Configuration"
author: rick-anderson
description: "Web Playlists for Internet Information Services (IIS) provides the ability to control media delivery to clients and limit a client’s ability to seek or skip..."
ms.date: 02/27/2008
ms.assetid: a3856239-50c7-449f-b536-67d1cadc4b80
msc.legacyurl: /learn/media/web-playlists/web-playlists-for-iis-configuration
msc.type: authoredcontent
---
# Web Playlists for IIS 7 - Configuration

by [Vishal Sood](https://twitter.com/vishalsood)

Web Playlists for Internet Information Services (IIS) provides the ability to control media delivery to clients and limit a client's ability to seek or skip individual entries in the playlist. This article provides information about the settings possible through the Web Playlists configuration files.

<a id="prerequisites"></a>

## Prerequisites

To install the Web Playlists extension for IIS 7 and above, see the **Installation Notes** section in the [IIS Media Services Readme](../iis-media-services/iis-media-services-readme.md).

<a id="configuration"></a>

## Configuration

### Handler Attributes

Before creating a playlist, be aware of the following playlist handler attributes. These attributes are defined in the playlist handler schema and can be set through the applicationHost.config file.

| **Rule Attribute** | **Required** | **Type** | **Permissible Values** | **Default Value** | **Description** |
| --- | --- | --- | --- | --- | --- |
| **enabled** | No | Bool | True/False | True | Determines if Web Playlists is enabled on the node. |
| **queryStringDelimiter** | No | String | Any value permitted by HTTP as a valid query string delimiter | ; | Determines the correct query string delimiter in the URL. This is needed as the most common delimiter (&amp;) is not XML friendly. |
| **allowAbsolutePaths** | No | Bool | True/False | False | Specifies whether absolute paths and UNC paths are allowed as media entries in the playlist. It is recommended that you keep the default value (False) unless only administrators can create playlists. When this value is set to True, Web Playlists can be used to download any file from the Web server by specifying the absolute path. This also depends on the credentials assigned to the application pool. |
| **defaultSessionProvider** | No | String | A valid string corresponding to a name in the sessionProviders collection | InMemory | Specifies the session persistence provider that is used to store the playlist session information. There are two available with the default installation: InMemory and ASP.NET. |
| **maximumPlaylistDepth** | No | Uint | Any unsigned integer from 1 to 1024 | 5 | Determines the default depth of the playlist. |
| **allowClientCache** | No | Bool | True/False | False | Determines if clients can cache the content. This sets the pragma:no-cache in the response. |

### Other Schema Elements

| **Element** | **Description** |
| --- | --- |
| **winHttpSetTimeouts** | Sets the timeout options for the HTTPD requests in a playlist. |
| **sessionProviders** | Selects the session persistence provider for the playlist. The default options are InMemory and ASP.NET. |
| **sessionOptions** | Sets timeouts for a particular session. |
| **accessOptions** | Sets impersonation settings for a particular path that can then be used inside a playlist. |
| **playlistProviders** | Web Playlists provides a mechanism to write custom providers.This element stores the configuration for the available providers. |
| **outputFormats** | A collection to specify an output format extension to web Playlists. This allows you to specify format name, XSLT path and the content type related to the format |

<a id="schema"></a>

## Schema

The playlist handler schema is a part of the media section group and playlist configuration section under System.webServer. The playlist handler uses the following playlist schema that is contained in the IISMedia\_schema file that ships with the feature.

[!code-xml[Main](web-playlists-for-iis-configuration/samples/sample1.xml)]

<a id="scenarios"></a>

## Configuration Scenarios

### Shared Hosting

A server is shared by multiple sites. Each site has its own administrator and there is a super administrator for the server. In this case, the super administrator must ensure that site administrators have freedom within their site homes and at the same time do not have access to another site's content and other aspects. The super administrator also needs to protect essential server resources from being accessed by any of the sites. The site administrators or their users could have access to creating new playlists.

*Set allowAbsolutePaths=false.*

> [!IMPORTANT]
> This is the most important step. If this is not done, any lower level site administrator can add any file on the server to his/her playlist and that, in turn, would be downloaded for them. This can be a security issue. By default, this setting is set to False in the handler config.

All other settings could have the default values.

1. In the **Actions** pane, click **Edit Feature Settings**.

    [![](web-playlists-for-iis-configuration/_static/image2.bmp)](web-playlists-for-iis-configuration/_static/image1.bmp)
2. In the **Edit Feature Settings** dialog box, clear the **Allow absolute/UNC paths** check box.

    [![](web-playlists-for-iis-configuration/_static/image4.bmp)](web-playlists-for-iis-configuration/_static/image3.bmp)

### Enterprise

A server is used for an enterprise. Enterprise users cannot create playlists, only the super administrator for the server can. The content to be used in the playlist is scattered across local/remote locations on the enterprise network.

*Set allowAbsolutePaths=true.*

This is needed, as otherwise Web Playlists fails when it tries to access local paths (for example, `C:\mydir`) or remote UNC paths (for example, [`file:///\\myServer\media`]`(file://myserver/media)`). Because the super administrator is the only one who can create playlists, the risk of making this setting true is minimal. By default, this setting is set to False in the playlist handler configuration.

All other settings could have the default values *.*

Refer to screen shots in the previous scenario.

### Persisting Session State

A server farm is front-ended with a load balancer. This means that there is no guarantee that all requests will arrive at the same server. Also, as the session is stored in the IIS worker process memory by default, if the worker process were to recycle for some reason, the session information would be lost. These scenarios imply that session state persistence is needed.

*Set persistenceType=ASP.NET.*

This will use ASP.NET session state persistence to store the session data.

**Prerequisites**

- This scenario requires that ASP.NET be installed and ASP.NET session state management be configured. This can be configured in IIS Manager.

**Limitations**

- As this persistence requires ASP.NET, it does not work with Server Core installations of Windows Server 2008.
- Using ASP.NET session state persistence requires IIS to run in integrated mode for that application pool.
- AllowSkipAfterMinPercent should be set to 0. Client-side logic is needed to enforce skip/seek behavior for rogue clients.

> [!NOTE]
> ASP.NET session state persistence can be configured in IIS Manager by configuring settings on the **Session State** feature page. A detailed discussion is beyond the scope of this article. Web Playlists supports all variations of ASP.NET session state persistence.

[![](web-playlists-for-iis-configuration/_static/image6.bmp)](web-playlists-for-iis-configuration/_static/image5.bmp)

## More Information

- ASP.NET State Management Overview ([https://support.microsoft.com/kb/307598](https://support.microsoft.com/kb/307598))
