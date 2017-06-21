Adding Handlers <add>
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<handlers>` collection adds a handler to the list of HTTP handlers for Internet Information Services (IIS) 7.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<handlers>` collection was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<add>` element of the `<handlers>` collection is included in the default installation of IIS 7.

<a id="004"></a>
## How To

### How create a handler mapping for an ASP.NET handler in an IIS 7 application running in Integrated mode

1. Open **Internet Information Services (IIS) Manager**: 

    - If you are using Windows Server 2012 or Windows Server 2012 R2: 

        - On the taskbar, click **Server Manager**, click **Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows 8 or Windows 8.1: 

        - Hold down the **Windows** key, press the letter **X**, and then click **Control Panel**.
        - Click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
    - If you are using Windows Server 2008 or Windows Server 2008 R2: 

        - On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows Vista or Windows 7: 

        - On the taskbar, click **Start**, and then click **Control Panel**.
        - Double-click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, click the server connection that you want to add the native module to.
3. In the **Home** pane, double-click **Handler Mappings**.  
    [![](add/_static/image2.png)](add/_static/image1.png)
4. On the **Actions** pane, click **Add Managed Handler...**
5. In the **Add Managed Handler** dialog box, specify the following:

    - **Request Path**. The file name or file name extension to map.
    - **Type**. The type (class) name of the managed handler. If the handler is defined in the app\_code or bin folders of the application, its type name will appear in the drop-down list.
    - **Name**. A descriptive name.
  
    [![](add/_static/image4.png)](add/_static/image3.png)
6. Click **OK** to close the **Add Managed Handler** dialog box.

### How to create a FastCGI handler mapping

1. Open **Internet Information Services (IIS) Manager**: 

    - If you are using Windows Server 2012 or Windows Server 2012 R2: 

        - On the taskbar, click **Server Manager**, click **Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows 8 or Windows 8.1: 

        - Hold down the **Windows** key, press the letter **X**, and then click **Control Panel**.
        - Click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
    - If you are using Windows Server 2008 or Windows Server 2008 R2: 

        - On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows Vista or Windows 7: 

        - On the taskbar, click **Start**, and then click **Control Panel**.
        - Double-click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, click the server name for which you want to configure FastCGI handler mappings.
3. In the **Home** pane, double-click **Handler Mappings**.  
    [![](add/_static/image6.png)](add/_static/image5.png)
4. In the **Actions** pane, click **Add Module Mapping...**  
  
    > [!NOTE]
    > For the next steps to work, you must have already installed binaries that will execute the file path or file name extension that you specify. This example uses a PHP implementation available from the Microsoft Web site.
5. Type the file name extension, such as.php in the **Request path** box, click **FastCGIModule** in the **Module** drop-down list, type the path to the scripting engine (in this example, PHP-CGI.exe) in the **Executable** box, and then click **OK**.  
    [![](add/_static/image8.png)](add/_static/image7.png)
6. On the **Add Module Mapping** dialog box, click **Yes**.  
    [![](add/_static/image10.png)](add/_static/image9.png)

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `allowPathInfo` | Optional Boolean attribute. Specifies whether the handler processes full path information in a URI, such as contoso/marketing/imageGallery.aspx. If the value is **true**, the handler processes the full path, contoso/marketing/imageGallery. If the value is **false**, the handler processes only the last section of the path, /imageGallery. The default value is `false`. |
| `modules` | Optional string attribute. Specifies the name of the module or modules to which you want to map the file name or file name with extension. If you specify more than one value, separate the values with a comma (,). The default value is `ManagedPipelineHandler`. |
| `name` | Required string attribute. Specifies the unique name of the handler mapping. |
| `path` | Required string attribute. Specifies the file name or the file name extension for which the handler mapping applies. |
| `preCondition` | Optional string attribute. Specifies conditions under which the handler will run. The **preCondition** attribute can be one or more of the following possible values. If you specify more than one value, separate the values with a comma (,). | Value | Description | | --- | --- | | `bitness32` | Specify the **bitness32** value when the handler is a 32-bit .dll file, and IIS should load the handler only for worker processes that run in WOW64 mode (32-bit simulation) on a 64-bit operating system. | | `bitness64` | Specify the **bitness64** value when the handler is a 64-bit .dll file, and IIS should load the handler only for worker processes that run in 64-bit mode. | | `integratedMode` | Specify the **integratedMode** value when the handler should respond only to requests in application pools that are configured to use the integrated request-processing pipeline. | | `ISAPIMode` | Specify the **ISAPIMode** value when the handler should respond only to requests in application pools that are configured to use Classic mode. | | `runtimeVersionv1.1` | Specify the **runtimeVersionv1.1** value when the handler should respond only to requests in application pools that are configured to use .NET Framework version 1.1. | | `runtimeVersionv2.0` | Specify the **runtimeVersionv2.0** value when the handler should respond only to requests in application pools that are configured to use .NET Framework version 2.0. | |
| `requireAccess` | Optional enum attribute. Specifies the type of access that a handler requires to the resource. The **requireAccess** attribute can be one or more of the following possible values. If you specify more than one value, separate the values with a comma (,). The default value is `Script`. | Value | Description | | --- | --- | | **Execute** | Specifies that the handler requires rights to run executables. The numeric value is `4`. | | **None** | Specifies that the handler does not have access requirements. The numeric value is `0`. | | **Read** | Specifies that the handler requires read permissions. The numeric value is `1`. | | **Script** | Specifies that the handler requires rights to run scripts. The numeric value is `3`. | | **Write** | Specifies that the handler requires write permissions. The numeric value is `2`. | |
| `resourceType` | Optional string attribute. Specifies the type of resource to which the handler mapping applies. The **resourceType** attribute can be one of the following possible values. The default value is `Unspecified`. | Value | Description | | --- | --- | | `Directory` | Specifies that the handler mapping applies to requests only for physical folders on disk. The numeric value is `1`. | | `Either` | Specifies that the handler mapping applies to requests for physical files or folders on disk. The numeric value is `2`. | | `File` | Specifies that the handler mapping applies to requests only for physical files on disk. The numeric value is `0`. | | `Unspecified` | Specifies that the mapping type is not specified. The handler mapping applies to requests regardless of whether the request maps to a physical file or folder on disk. Use this setting when you map a handler to a file name or file name extension that does not exist on disk, such as MyHandler.axd. The numeric value is `3`. | |
| `responseBufferLimit` | Optional uint attribute. Specifies the maximum size, in bytes, of the response buffer for a request handler. The default value is `4194304` bytes. |
| `scriptProcessor` | Optional string attribute. Specifies the physical path of the ISAPI extension .dll file or Common Gateway Interface (CGI) .exe file that processes the request. The scriptProcessor attribute is required only for script map handler mappings. When you map a handler to an ISAPI extension, you must specify ISAPIModule for the modules attribute. When you map a handler to a CGI file, you must specify CGIModule for the modules attribute. |
| `type` | Optional string attribute. Specifies the namespace path of a managed handler. The type attribute is required only for managed handlers. |
| `verb` | Required string attribute. Specifies the HTTP verbs for which the handler mapping applies. |

### Child Elements

None.

### Configuration Sample

The following example contains two `<add>` elements that define handler mappings. The first `<add>` element defines a SampleHandler handler for a Web application running in IIS 7 Integrated mode. If you add the handler assembly to the app\_code directory for the Web application, you do not need to include the assembly name in the value for the **type** attribute. The second `<add>` element defines a mapping for PHP requests that use the FastCGI module.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples add a FastCGI mapping for a PHP module, then add a handler on the Contoso Web site that will process PHP requests.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

> [!NOTE]
> This second example shows how to add a new ASP.NET handler mapping named SampleHandler.new for a specific URL to a Web application.

[!code-console[Main](add/samples/sample3.cmd)]

### C#

[!code-csharp[Main](add/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample6.js)]

### VBScript

[!code-vb[Main](add/samples/sample7.vb)]