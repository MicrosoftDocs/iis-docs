Adding Module Providers &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<moduleProviders>` element adds a module to the list of module providers for IIS Manager. Each module provider entry contains the managed-code registration information for a module, which enables the module as a feature in IIS Manager.

> [!NOTE]
> The settings in the `<moduleProviders>` element can only be configured in the Administration.config file.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<moduleProviders>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<add>` element of the `<moduleProviders>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for adding modules to the `<moduleProviders>` element for IIS 7. For examples of how to add modules to the `<moduleProviders>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `name` | Required string attribute. Specifies the unique name of a managed module on the Web server. |
| `type` | Required string attribute. Specifies the managed type of a managed module. |

### Child Elements

None.

### Configuration Sample

The following sample configuration excerpt from the Administration.config file adds a managed module provider named ContosoProvider to the end of the `<moduleProviders>` collection. The **name** property defines the name ContosoProvider for the module, and the **type** property defines the managed type for the module.

> [!NOTE]
> This sample configuration excerpt has been shortened for easier reading.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

> [!NOTE]
> The examples in this document illustrate using a managed-code assembly that has been stored in the .NET Global Assembly Cache (GAC). Before using the code in these examples to deploy your own assemblies, you need to retrieve the assembly information from the GAC. To do so, use the following steps:

- In Windows Explorer, open your C:\Windows\assembly path, where C: is your operating system drive.
- Locate your assembly.
- Right-click the assembly and click **Properties**.
- Copy the **Culture** value; for example: **Neutral**.
- Copy the **Version** number; for example: **1.0.0.0**.
- Copy the **Public Key Token** value; for example: **426f62526f636b73**.
- Click **Cancel**.

The following code examples add a managed module provider named ContosoProvider to the Administration.config file. The **name** property defines the name ContosoProvider for the module, and the **type** property defines the managed type for the module.

### AppCmd.exe

> [!NOTE]
> You cannot configure `<moduleProviders>` settings using AppCmd.exe.

### C#

[!code-csharp[Main](add/samples/sample2.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample3.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample4.js)]

### VBScript

[!code-vb[Main](add/samples/sample5.vb)]