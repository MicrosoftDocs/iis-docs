Adding One-To-One Mappings &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<oneToOneMappings>` element specifies a unique mapping between an individual client certificate and an individual user account.

> [!NOTE]
> One-to-one certificate mappings differ from [many-to-one](../../../../../system.webserver/security/authentication/iisclientcertificatemappingauthentication/manytoonemappings.md) certificate mappings, which can map multiple certificates to a single user account.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<oneToOneMappings>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<oneToOneMappings>` element replaces the IIS 6.0 **IIsCertMapper** metabase object. |

<a id="003"></a>
## Setup

The `<iisClientCertificateMappingAuthentication>` element is not available on the default installation of IIS 7 and later. To install it, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Security**, and then select **IIS Client Certificate Mapping Authentication**. Click **Next**.  
    [![](add/_static/image2.png)](add/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Security**, and then select **IIS Client Certificate Mapping Authentication**.  
    [![](add/_static/image4.png)](add/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **IIS Client Certificate Mapping Authentication**, and then click **Next**.  
    [![](add/_static/image6.png)](add/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then select **IIS Client Certificate Mapping Authentication**, and then click **OK**.  
    [![](add/_static/image8.png)](add/_static/image7.png)
 
<a id="004"></a>
## How To

There is no user interface for configuring IIS Client Certificate Mapping authentication for IIS 7. For examples of how to configure IIS Client Certificate Mapping authentication programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `certificate` | Required string attribute. Specifies the base64-encoded public certificate from a client certificate. IIS will compare this certificate with the copy of the certificate sent over the internet by a Web client. The two data strings must be identical for the mapping to proceed. If a client gets another certificate, it will not match the original, even if the copy contains all the same user information as the original. If there are line breaks in the base64-encoded string of the client certificate in this attribute, you must remove them. Line breaks can interfere with the server's ability to compare the server's certificate with the certificate sent by the browser. |
| `enabled` | Optional Boolean attribute. Specifies whether the one-to-one mapping is enabled. The default value is `true`. |
| `password` | Optional string attribute. Specifies the password of the account used to authenticate clients. <br><br>**Note:** To avoid storing unencrypted password strings in configuration files, always use AppCmd.exe to enter passwords. If you use these management tools, the password strings will be encrypted automatically before they are written to the XML configuration files. This provides better password security than storing unencrypted passwords. |
| `username` | Optional string attribute. Specifies the user name of the account used to authenticate clients. |

### Child Elements

None.

### Configuration Sample

The following configuration sample enables IIS Client Certificate Mapping authentication using one-to-one certificate mapping for the Default Web Site, creates a singe one-to-one certificate mapping for a user account, and configures the site to require SSL and to negotiate client certificates.

[!code-xml[Main](add/samples/sample1.xml)]

### How to retrieve Base-64 encoded string from a client certificate

> [!NOTE]
> To retrieve a Base-64 encoded certificate data for all of the samples in this topic, you can export a certificate using the following steps:

1. Click **Start**, then **Run**.
2. Enter MMC, and then click **OK**.
3. When the Microsoft Management Console opens, click **File**, then **Add/Remove Snap-ins**.
4. In the **Add or Remove Snap-ins** dialog box: 

    - Highlight **Certificates** in the list of available snap-ins, then click **Add**.
    - Choose to manage certificates for **My user account**, then click **Finish**.
    - Click **OK** to close the dialog box.
5. In the Microsoft Management Console: 

    - Expand **Certificates - Current User**, then **Personal**, then **Certificates**.
    - In the list of certificates, right-click the certificate that you want to export, then click **All Tasks**, and then click **Export**.
6. When the **Certificate Export Wizard** opens: 

    - Click **Next**.
    - Choose **No, do not export the private key**, then click **Next**.
    - Choose **Base-64 encoded X.509 9 (.CER)** for the export format, then click **Next**.
    - Choose to save the certificate to your desktop as **MyCertificate.cer**, then click **Next**.
    - Click **Finish**; you should see a dialog box that says the export was successful.
7. Close the Microsoft Management Console.
8. Open the **MyCertificate.cer** file that you exported using Windows Notepad: 

    - Remove "-----BEGIN CERTIFICATE-----" from the start of the text.
    - Remove "-----END CERTIFICATE-----" from the end of the text.
    - Concatenate all the lines into a single line of text - this is the Base-64 encoded certificate data that you will use for all of the samples in this topic.
 
<a id="006"></a>
## Sample Code

The following code samples enable IIS Client Certificate Mapping authentication using one-to-one certificate mapping for the Default Web Site, create a single one-to-one certificate mapping for a user account, and configure the site to require SSL and to negotiate client certificates.

> [!NOTE]
> To retrieve the Base-64 encoded certificate data for the code samples listed below, you can export a certificate using the steps listed in the [Configuration Details](#005) section of this document.

### AppCmd.exe

> [!NOTE]
> Because of characters in certificate strings that cannot be parsed by AppCmd.exe, you should not use AppCmd.exe to configure IIS one-to-one certificate mappings.

### C#

[!code-csharp[Main](add/samples/sample2.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample3.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample4.js)]

### VBScript

[!code-vb[Main](add/samples/sample5.vb)]