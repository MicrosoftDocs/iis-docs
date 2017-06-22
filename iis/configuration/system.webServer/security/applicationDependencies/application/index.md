Applications for Application Dependencies &lt;application&gt;
====================
<a id="001"></a>
## Overview

The `<application>` element of the [&lt;applicationDependencies&gt;](index.md) element specifies an application that has dependencies on one or more CGI or ISAPI extension restrictions. Specifically, the **groupID** attribute of the `<application>` element specifies the primary application dependency, and the element may contain one or more [&lt;add&gt;](add.md) elements that specify additional dependencies.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<application>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<application>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<application>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<application>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<application>` element of the `<applicationDependencies>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<applicationDependencies>` element replaces the IIS 6.0 **ApplicationDependencies** attribute of the **IIsWebService** metabase object. |

<a id="003"></a>
## Setup

The `<application>` element of the `<applicationDependencies>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for configuring the `<applicationDependencies>` element for IIS 7. For examples of how to configure the `<applicationDependencies>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `groupID` | Optional string attribute. Specifies the **groupID** of the application that has a dependency on an extension restriction. See the following Default Configuration section for the complete list of default values. |
| `Name` | Required string attribute. Specifies the unique name of the application that has a dependency on an extension restriction. See the following Default Configuration section for the complete list of default values. |

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element. Adds additional **groupIDs** to the parent application. |
| `clear` | Optional element. Removes all references to additional **groupIDs** from the add collection. |

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