---
title: "Scheme &lt;scheme&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;scheme&gt; element of the &lt;httpCompression&gt; element specifies the following settings for the GNU zip (Gzip) and Deflate compression sc..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 4cd6ddb8-81bf-42da-8545-b673cb23c0e1
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/httpcompression/scheme
msc.type: config
---
Scheme &lt;scheme&gt;
====================
<a id="001"></a>
## Overview

The `<scheme>` element of the `<httpCompression>` element specifies the following settings for the GNU zip (Gzip) and Deflate compression schemes in Internet Information Services (IIS) 7:

- The **name** and **dll** attributes respectively specify the name and provider DLL of a compression scheme. IIS 7 supports both Gzip and Deflate compression, and both compression schemes are currently implemented in %*windir*%\system32\inetsrv\gzip.dll.
- The **doStaticCompression** attribute specifies whether static compression is enabled for the compression scheme that is specified by the **name** attribute. Setting **doStaticCompression** to **true** specifies that static content will be compressed when requested by a client. If static compression is enabled, each request for static content that contains the "Accept-Encoding: gzip" or "Accept-Encoding: deflate" header causes the content to be compressed, so long as the compression scheme specified in the header is enabled in IIS. If the request does not contain this header, or the header specifies a compression scheme that is not enabled in IIS, the content is not compressed.   
  
 If IIS determines that the response should be compressed, IIS checks the compression directory specified by the     **directory** attribute of the     [&lt;httpCompression&gt;](index.md) element. If a fresh, compressed version of the static file is found in the directory, it is sent to the client browser. If a fresh, compressed version of the file is not found, and on-demand compression is enabled with     **dynamicCompressionBeforeCache** attribute of the     [&lt;urlCompression&gt;](../urlcompression.md) element, IIS sends the requested file in uncompressed form, and adds that file to the background compression queue.
- The **doDynamicCompression** attribute specifies whether dynamic compression is enabled for the compression scheme that is specified by the **name** attribute. Setting **doDynamicCompression** to **true** specifies that dynamic content will be compressed when requested by a client. If dynamic compression is enabled, each request for dynamic content that contains the "Accept-Encoding: gzip" or "Accept-Encoding: deflate" header causes the content to be compressed, so long as the compression scheme specified in the header is enabled in IIS. If the request does not contain this header, or the header specifies a compression scheme that is not enabled in IIS, the content is not compressed.  
  
    > [!NOTE]
    > Because dynamic content is by definition always changing, IIS does not cache compressed versions of dynamic content. Dynamic compression consumes considerable CPU time and memory resources, and should only be used on servers that have slow network connections and CPU time to spare.
- The **dynamicCompressionLevel** and **staticCompressionLevel** attributes specify the compression levels for the compression schemes when IIS is respectively compressing dynamic or static content. Lower compression levels produce slightly larger compressed files, but with lower overall impact on CPU and memory resources. Higher compression levels generally result in smaller compressed files, but with higher CPU and memory usage.

> [!NOTE]
> By default, only the Gzip compression scheme is available in IIS 7. To enable the Deflate compression scheme programmatically, see the [Code Samples](#006) section of this document.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<scheme>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<scheme>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<scheme>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<scheme>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<scheme>` element of the `<httpCompression>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<scheme>` element replaces the following IIS 6.0 metabase properties: <ul> <li><strong>HcCompressionDll</strong></li> <li><strong>HcDoDynamicCompression</strong></li> <li><strong>HcDoStaticCompression</strong></li> <li><strong>HcDynamicCompressionLevel</strong></li> </ul> |

<a id="003"></a>
## Setup

HTTP compression is usually available on the default installation of IIS 7 and later. However, only static compression is installed by default. To install static or dynamic compression, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Performance**, and then select **Static Content Compression** and/or **Dynamic Content Compression**. Click **Next**.  
    [![](scheme/_static/image2.png)](scheme/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Performance Features**, and then select **Dynamic Content Compression** and/or **Static Content Compression**.  
    [![](scheme/_static/image4.png)](scheme/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **Dynamic** **Content Compression** if you want to install dynamic compression and **Static Content Compression** if you want to install static compression, and then click **Next**.  
    [![](scheme/_static/image6.png)](scheme/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, then **Performance Features**.
4. Select **Http Compression Dynamic** if you want to install dynamic compression and **Static Content Compression** if you want to install static compression.   
    [![](scheme/_static/image8.png)](scheme/_static/image7.png)
5. Click **OK**.
 
<a id="004"></a>
## How To

There is no user interface for setting the compression scheme for IIS 7. For examples of how to set the compression scheme programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `dll` | Required string attribute.<br><br>Specifies the fully qualified file system path and file name of the compression DLL associated with the compression scheme. The World Wide Web Publishing Service (WWW service) must be restarted before any changes to this attribute take effect. |
| `doDynamicCompression` | Optional Boolean attribute.<br><br>Specifies whether responses to requests for dynamic content, such as scripts in Active Server Pages (ASP) and ISAPI extensions, are compressed. If this value is changed at the individual compression scheme level, the WWW service must be restarted before the change takes effect. <br><br>The default value is `true`. |
| `doStaticCompression` | Optional Boolean attribute.<br><br>Specifies whether IIS compresses responses to requests for static content. Because this attribute cannot be inherited, it must be set to true at both the global level ([&lt;httpCompression&gt;](index.md)) and the individual scheme level if the **name** attribute is set to **Gzip**. If this value is changed at the individual compression scheme level, the WWW service must be restarted before the change takes effect.<br><br>**Note:** The static compression store needs to be located in a disk partition or remote share formatted with NTFS. If the file store is not NTFS, static compression is disabled. For security reasons, no compressed responses will be served from a FAT cache store.<br><br>The default value is `true`. |
| `dynamicCompressionLevel` | Optional uint attribute.<br><br>Specifies the compression level for the compression scheme when dynamic content is being compressed. The levels range from 0 (lowest compression level and lowest CPU usage) to 10 (highest compression level and highest CPU usage). The WWW service must be restarted before any changes to this attribute take effect.<br><br>**Note:** Because dynamic compression consumes considerable CPU time and memory resources, use it only on servers that have slow network connections and CPU time to spare. Compressed static responses can be cached and, therefore, do not affect CPU resources as dynamic responses do.<br><br>The default value is `0`. |
| `name` | Required string attribute.<br><br>Specifies the name of the compression scheme. For example, **Gzip** or **Deflate**. |
| `staticCompressionLevel` | Optional uint attribute.<br><br>Specifies the compression level for the compression scheme when static content is being compressed. The levels range from 0 (lowest compression level and lowest CPU usage) to 10 (highest compression level and highest CPU usage). 0 means that compression is disabled. The WWW service must be restarted before any changes to this attribute take effect.<br><br>The default value is `7`. |

### Child Elements

| Element | Description |
| --- | --- |
| `remove` | Optional element.<br><br>Removes a reference to an HTTP compression scheme from the HTTP compression scheme collection. |
| `clear` | Optional element.<br><br>Removes all references to HTTP compression schemes from the HTTP compression scheme collection. |

### Configuration Sample

The following default `<httpCompression>` element is configured in the ApplicationHost.config file in IIS 7. This configuration section inherits the default configuration settings unless you use the `<clear>` element.

[!code-xml[Main](scheme/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples add the deflate compression scheme to IIS 7.

### AppCmd.exe

[!code-console[Main](scheme/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](scheme/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](scheme/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](scheme/samples/sample5.js)]

### VBScript

[!code-vb[Main](scheme/samples/sample6.vb)]
