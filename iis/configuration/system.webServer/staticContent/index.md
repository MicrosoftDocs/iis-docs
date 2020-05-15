---
title: "Static Content &lt;staticContent&gt;"
author: rick-anderson
description: "Overview The &lt;staticContent&gt; element configures several settings related to processing requests for static files in Internet Information Services (IIS)..."
ms.date: 09/26/2016
ms.assetid: a4c07bfc-71cf-4dc5-8d32-65af94d0a766
msc.legacyurl: /configreference/system.webserver/staticcontent
msc.type: config
---
# Static Content &lt;staticContent&gt;

<a id="001"></a>

## Overview

The `<staticContent>` element configures several settings related to processing requests for static files in Internet Information Services (IIS) 7.

The `<staticContent>` element contains the following three attributes that specify whether IIS 7 should apply a document footer to static files:

- The **enableDocFooter** attribute specifies whether document footers are enabled.
- The defaultDocFooter attribute contains either: 

    - A text string that IIS 7 will use for the document footer if the **isDocFooterFileName** attribute is set to **false**
    - The fully-qualified path to a file that contains the text that IIS 7 will use for the document footer if the **isDocFooterFileName** attribute is set to **true**.
- As noted above, the **isDocFooterFileName** attribute specifies whether the **defaultDocFooter** attribute contains a text string that IIS 7 will use for the document footer or the fully qualified path to a file that contains the text that IIS 7 will use for the document footer.

> [!NOTE]
> By default, the **isDocFooterFileName** attribute is set to **false** and locked globally. To use files for document footers, you would need to either set the **isDocFooterFileName** attribute to **true** at the global-level, or unlock the attribute. To learn more about locking and unlocking attributes, see the [How to Use Locking in IIS 7.0 Configuration](https://docs.microsoft.com/iis/get-started/planning-for-security/how-to-use-locking-in-iis-configuration) walkthrough.

<a id="002"></a>

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<staticContent>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<staticContent>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<staticContent>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<staticContent>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<staticContent>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<staticContent>` element replaces the following IIS 6.0 metabase properties: <ul> <li><strong>DefaultDocFooter</strong> <li><strong>EnableDocFooter</strong> </li></li></ul> |

<a id="003"></a>

## Setup

The `<staticContent>` element is included in the default installation of IIS 7.

<a id="004"></a>

## How To

There is no user interface for configuring the `<staticContent>` element for IIS 7. For examples of how to configure the `<staticContent>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>

## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `defaultDocFooter` | Optional string attribute. <br><br>Specifies either the default footer text for every Web page on a site, or the path of a file that contains the default footer text. How IIS 7 uses this property depends on the value of the **isDocFooterFileName** attribute. <br><br>**Note:** The custom footer will only be sent if the **enableDocFooter** attribute is set to **true**. |
| `enableDocFooter` | Optional Boolean attribute. <br><br>Specifies whether the text indicated by the **defaultDocFooter** attribute will appear on every static page on a Web site. <br><br>The default value is `false`. |
| `isDocFooterFileName` | Optional Boolean attribute. <br><br>Specifies whether the string in the **defaultDocFooter** attribute contains a path of a file that contains the default footer text for every static Web page on a site. <br><br>The default value is `false`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`clientCache`](clientcache.md) | Optional element.<br><br>Specifies settings for caching static content that is sent to the client. |
| [`mimeMap`](mimemap.md) | Optional element.<br><br>Specifies a list of the file name extensions for MIME mappings. |

### Configuration Sample

The following configuration sample enables a document footer for static content, and adds a simple copyright notice as the footer text.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>

## Sample Code

The following code samples enable a document footer for static content, and add a simple copyright notice as the footer text.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

### C\#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]
