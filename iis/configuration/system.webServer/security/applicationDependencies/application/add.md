---
title: "Adding Applications for Application Dependencies &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;application&gt; element adds additional dependencies to the parent application. Compatibility Version Notes IIS 1..."
ms.date: 09/26/2016
ms.assetid: 2e7bdef4-8df9-4e9b-94dc-bf3e7a7fbed2
msc.legacyurl: /configreference/system.webserver/security/applicationdependencies/application/add
msc.type: config
---
Adding Applications for Application Dependencies &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the [&lt;application&gt;](index.md) element adds additional dependencies to the parent application.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<application>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<applicationDependencies>` element replaces the IIS 6.0 **ApplicationDependencies** attribute of the **IIsWebService** metabase object. |

<a id="003"></a>
## Setup

The `<add>` element of the `<application>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for configuring the `<applicationDependencies>` element for IIS 7. For examples of how to configure the `<applicationDependencies>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `groupID` | Required string attribute.<br><br>Specifies additional **groupIDs** associated with the parent application. |

### Child Elements

None.

### Configuration Sample

The following configuration sample illustrates the application dependencies in the `<applicationDependencies>` element for the Default Web Site and the related entries in the `<isapiCgiRestriction>` after you install Active Server Pages (ASP) and a custom application on IIS 7:

- The Active Server Pages application has a dependency on the &quot;ASP&quot; ISAPI/CGI restriction group.
- The custom application has a dependency on the &quot;MyCustomGroup&quot; ISAPI/CGI restriction group, and an additional dependency on the ASP ISAPI/CGI restriction group.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following configuration sample illustrates the application dependencies in the `<applicationDependencies>` element for the Default Web Site. The custom application has a dependency on the &quot;MyCustomGroup&quot; ISAPI/CGI restriction group, and an additional dependency on the ASP ISAPI/CGI restriction group.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]
