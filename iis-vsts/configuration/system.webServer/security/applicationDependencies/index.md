---
title: "Application Dependencies &lt;applicationDependencies&gt;"
author: rick-anderson
description: "Overview The &lt;applicationDependencies&gt; element of the &lt;security&gt; element works in tandem with the &lt;isapiCgiRestriction&gt; element to define w..."
ms.date: 09/26/2016
ms.assetid: ea6151ab-b619-40b0-9fd4-56f5ad6ffc60
msc.legacyurl: /configreference/system.webserver/security/applicationdependencies
msc.type: config
---
Application Dependencies &lt;applicationDependencies&gt;
====================
<a id="001"></a>
## Overview

The `<applicationDependencies>` element of the [&lt;security&gt;](../index.md) element works in tandem with the [&lt;isapiCgiRestriction&gt;](../isapicgirestriction/index.md) element to define which applications have dependencies on one or more CGI or ISAPI extension restrictions. If an application is contained in this element , the application has dependencies on an item (or multiple items) in the [&lt;isapiCgiRestriction&gt;](../isapicgirestriction/index.md) element.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<applicationDependencies>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<applicationDependencies>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<applicationDependencies>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<applicationDependencies>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<applicationDependencies>` element of the `<security>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<applicationDependencies>` element replaces the IIS 6.0 **ApplicationDependencies** attribute of the **IIsWebService** metabase object. |

<a id="003"></a>
## Setup

The `<applicationDependencies>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for configuring the `<applicationDependencies>` element for IIS 7. For examples of how to configure the `<applicationDependencies>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`application`](application/index.md) | Optional element.<br><br>Specifies an application that has dependencies on a CGI or ISAPI extension restriction. |
| `clear` | Optional element.<br><br>Removes all references to applications from the **applicationDependencies** collection. |

### Configuration Sample

The following configuration sample illustrates the application dependencies in the `<applicationDependencies>` element for the Default Web Site and the related entries in the `<isapiCgiRestriction>` after you install Active Server Pages (ASP) and a custom application on IIS 7:

- The Active Server Pages application has a dependency on the &quot;ASP&quot; ISAPI/CGI restriction group.
- The custom application has a dependency on the &quot;MyCustomGroup&quot; ISAPI/CGI restriction group, and an additional dependency on the ASP ISAPI/CGI restriction group.


[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following configuration sample illustrates the application dependencies in the `<applicationDependencies>` element for the Default Web Site. The custom application has a dependency on the &quot;MyCustomGroup&quot; ISAPI/CGI restriction group, and an additional dependency on the ASP ISAPI/CGI restriction group.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]