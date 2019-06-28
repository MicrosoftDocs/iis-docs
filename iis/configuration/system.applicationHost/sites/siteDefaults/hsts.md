---
title: "Default HSTS settings for a Web Site &lt;hsts&gt;"
author: bangbingsyb
description: "Overview The &lt;hsts&gt; element of the &lt;siteDefaults&gt; element configures HSTS settings for a website"
ms.author: bangbingsyb
msc.type: config
---
# Default HSTS Settings for a Web Site &lt;hsts&gt;

<a id="001"></a>
## Overview

The `<hsts>` element of the `<siteDefaults>` element contains attributes that allow you to configure default HTTP Strict Transport Security (HSTS) settings for a site on IIS 10.0 version 1709 and later.

> [!NOTE]
> If the `<hsts>` element is configured in both the `<siteDefaults>` section and in the `<site>` section for a specific site, the configuration in the `<site>` section is used for that site.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 version 1709 | The `<hsts>` element of the `<siteDefaults>` element was introduced in IIS 10.0 version 1709. |
| IIS 10.0 | N/A |
| IIS 8.5 | N/A |
| IIS 8.0 | N/A |
| IIS 7.5 | N/A |
| IIS 7.0 | N/A |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<hsts>` element of the `<siteDefaults>` element is included in the default installation of IIS 10.0 version 1709 and later.

<a id="004"></a>
## How To

There is no user interface that lets you configure the `<hsts>` element of the `<siteDefaults>` element for IIS 10.0 version 1709. For examples of how to configure the `<hsts>` element of the `<siteDefaults>` element programmatically, see the [Sample Code](#006) section of this document.

## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `enabled` | Optional Boolean attribute. <br><br> Specifies whether HSTS is enabled (**true**) or disabled (**false**) for a site. If HSTS is enabled, the **Strict-Transport-Security** HTTP response header is added when IIS replies an HTTPS request to the web site. <br><br> The default value is `false`. |
| `max-age` | Optional uint attribute. <br><br> Specifies the **max-age** directive in the **Strict-Transport-Security** HTTP response header field value. <br><br>The default value is `0`. |
| `includeSubDomains` | Optional Boolean attribute. <br><br> Specifies whether the **includeSubDomains** directive is included in the **Strict-Transport-Security** HTTP response header field value. <br><br> **Note:** Enable this attribute only if all subdomains indeed offer HTTP-based service over TLS/SSL. <br><br> The default value is `false`. |
| `preload` | Optional Boolean attribute. <br><br> Specifies whether the **preload** directive is included in the **Strict-Transport-Security** HTTP response header field value. <br><br> **Note:** Enable this attribute only if the domain of the site has been submitted for inclusion in the HSTS preload list. <br><br>The default value is `false`. |
| `redirectHttpToHttps` | Optional Boolean attribute.<br><br> Specifies whether HTTP to HTTPS redirection is enabled (**true**) or disabled (**false**) for a site. <br><br> **Note:** Enabling **redirectHttpToHttps** enforces the site-level HTTP to HTTPS redirection. When IIS redirects an HTTP request, it replaces the URI scheme with "https" and ignores the port component. Make sure that the redirection destination provides HTTP-based service over TLS/SSL on standard port 443.  <br><br> The default value is `false`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample specifies the default `<hsts>` options for IIS 10.0 version 1709 and later.

[!code-xml[Main](hsts/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples configure the default `<hsts>` options for IIS 10.0 version 1709 and later.

### AppCmd.exe

[!code-console[Main](hsts/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the applicationHost.config file.

### C\#

[!code-csharp[Main](hsts/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](hsts/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](hsts/samples/sample5.js)]

### VBScript

[!code-vb[Main](hsts/samples/sample6.vb)]

### IISAdministration PowerShell Cmdlets

[!code-powershell[Main](hsts/samples/sample7.ps1)]
