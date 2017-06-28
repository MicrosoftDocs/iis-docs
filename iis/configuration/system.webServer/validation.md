---
title: "Validation &lt;validation&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;validation&gt; element configures Internet Information Services (IIS) 7 to detect whether an ASP.NET application that is set up to run in Cl..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/validation
msc.type: config
---
Validation &lt;validation&gt;
====================
<a id="001"></a>
## Overview

The `<validation>` element configures Internet Information Services (IIS) 7 to detect whether an ASP.NET application that is set up to run in Classic .NET mode needs to be changed in order to function correctly in Integrated mode.

IIS generates a migration error message if the **validateIntegratedModeConfiguration** attribute is set to **true** and one of the following is also true:

- Your application defines an `<httpModules>` section in its Web.config file. 

    In IIS 7 Integrated mode, ASP.NET modules are specified with native modules in a unified [&lt;modules&gt;](modules/index.md) section under [&lt;system.webServer&gt;](index.md).
- Your application defines an `<httpHandlers>` section in its Web.config file. 

    In IIS 7 Integrated mode, the ASP.NET handler mappings are specified in a unified [&lt;handlers&gt;](handlers/index.md) section inside [&lt;system.webServer&gt;](index.md). The [&lt;handlers&gt;](handlers/index.md) section replaces both the ASP.NET `<httpHandlers>` and IIS script-processor-mapping configurations, which were both required to set up an ASP.NET 1.0 handler mapping.
- Your application's Web.config file specifies `<identity impersonate="true" />`. 

    In IIS 7 Integrated mode, client impersonation is not available in some early request processing stages. Therefore, IIS will generate the migration error message. If your ASP.NET Web application impersonates client credentials (most common with intranet scenarios), you may want to set the **validateIntegratedModeConfiguration** attribute to **false**.

> [!NOTE]
> If you migrate your configuration manually, or you do not migrate your configuration but you want IIS to remain in Integrated mode (which is not advised), you can disable migration error messages by setting the **validateIntegratedModeConfiguration** attribute to **false**. Because IIS will no longer provide warnings for unsupported configurations when **validateIntegratedModeConfiguration** is **false**, ensure that your application works correctly in Integrated mode before you make this setting.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<validation>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<validation>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<validation>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<validation>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<validation>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<validation>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for adding validation for IIS 7. For examples of how to add validation programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `validateIntegratedModeConfiguration` | Optional Boolean attribute.<br><br>Specifies whether configuration validation is enabled when it runs in Integrated mode. The `<system.Web/httpHandlers>` and `<system.Web/httpModules>` sections as well as impersonation are checked during this process.<br><br>The default value is `true`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample enables validation. > [!NOTE]
 > This excerpt is from a Web.config file, so this configuration sample can be used at any folder level within a Web site.

[!code-xml[Main](validation/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples enable validation for the Default Web Site.

### AppCmd.exe

[!code-console[Main](validation/samples/sample2.cmd)]

### C#

[!code-csharp[Main](validation/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](validation/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](validation/samples/sample5.js)]

### VBScript

[!code-vb[Main](validation/samples/sample6.vb)]