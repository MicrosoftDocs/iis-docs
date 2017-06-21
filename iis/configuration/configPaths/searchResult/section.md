Configuration Path Search Result Sections <section>
====================
<a id="001"></a>
## Overview

The `<section>` element of the `<searchResult>` element contains a collection of section names returned by the configuration search. For example, "system.webServer/security/authentication/windowsAuthentication."

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<section>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<section>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<section>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<section>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<section>` element of the `<searchResult>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<section>` element of the `<searchResult>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for the `<CONFIGPATHS>` element for IIS 7. For examples of how to access the `<CONFIGPATHS>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `name` | Required string attribute. Specifies the name of the section returned by the configuration search. |

### Child Elements

None.

### Configuration Sample

> [!NOTE]
> The `<configPaths>` element is generated dynamically. Because of this, you cannot add a `<configPaths>` element to your configuration files. For examples of how to access the `<configPaths>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="006"></a>
## Sample Code

The following code examples use the `<configPaths>` element to search the Default Web Site configuration namespace for every `<system.webServer/defaultDocument>` element, and then output the path and location for each element to the console.

### AppCmd.exe

> [!NOTE]
> You cannot query `<configPaths>` settings using AppCmd.exe.

### C#

[!code-csharp[Main](section/samples/sample1.cs)]

### VB.NET

[!code-vb[Main](section/samples/sample2.vb)]

### JavaScript

[!code-javascript[Main](section/samples/sample3.js)]

### VBScript

[!code-vb[Main](section/samples/sample4.vb)]