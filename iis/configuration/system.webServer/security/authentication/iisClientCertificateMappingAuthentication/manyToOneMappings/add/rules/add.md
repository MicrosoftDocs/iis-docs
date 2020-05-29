---
title: "Adding Many-To-One Mappings Rules &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;rules&gt; element specifies the rule attributes that client certificates must match to be authenticated. There ar..."
ms.date: 09/26/2016
ms.assetid: a2b0156b-7d6b-4e31-9014-a170547b1d2b
msc.legacyurl: /configreference/system.webserver/security/authentication/iisclientcertificatemappingauthentication/manytoonemappings/add/rules/add
msc.type: config
---
# Adding Many-To-One Mappings Rules &lt;add&gt;

<a id="001"></a>
## Overview

The `<add>` element of the `<rules>` element specifies the rule attributes that client certificates must match to be authenticated.

There are two fields from client certificates that can be used as criteria for many-to-one rules:

- **Issuer** - This field specifies information about the certification authority (CA) that issued the client certificate.
- **Subject** - This field specifies information about the entity to whom the client certificate was issued.

Each of these fields can contain common LDAP sub fields; for example:

- CN = commonName (for example, &quot;Nancy Davolio&quot;)
- OU = organizationalUnitName (for example, &quot;Sales&quot;)
- O = organizationName (for example, &quot;Contoso&quot;)
- L = localityName (for example, &quot;Redmond&quot;)
- S = stateOrProvinceName (for example, &quot;WA&quot;)
- C = countryName (for example, &quot;US&quot;)

To create a mapping, you create a rule based on a field/subfield pair for a specific value. For example, you could create a rule that matched the issuer's O subfield with Contoso to allow access to all clients with certificates that were issued by the Contoso CA. This effectively eliminates client connections from any clients that are not part of the Contoso organization.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<rules>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<manyToOneMappings>` element replaces the IIS 6.0 **IIsCertMapper** metabase object. |

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
| `certificateField` | Required enum attribute.<br><br>The **certificateField** attribute can be one of the following possible values. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>Issuer</code></th> <td>Specifies the issuer of the certificate.<br><br>The numeric value is <code>2</code>. </td></tr> <tr> <th><code>Subject</code></th> <td>Specifies the subject of the certificate.<br><br>The numeric value is <code>1</code>. </td></tr></tbody></table> |
| `certificateSubField` | Required string attribute.<br><br>Specifies any of the standard fields on the certificate. |
| `compareCaseSensitive` | Optional Boolean attribute.<br><br>Specifies whether to compare values using case sensitive evaluations.<br><br>The default value is `true`. |
| `matchCriteria` | Required string attribute.<br><br>Specifies the data that should be compared to determine a matching certificate. |

### Child Elements

None.

### Configuration Sample

The following configuration sample performs the following actions for the Default Web Site:

- Enables IIS Client Certificate Mapping authentication using many-to-one certificate mapping.
- Creates a many-to-one certificate mapping rule for a user account based on the organization field in the subject of the client certificate matching Contoso.
- Configures the site to require SSL and to negotiate client certificates.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples perform the following actions for the Default Web Site:

- Enable IIS Client Certificate Mapping authentication using many-to-one certificate mapping.
- Create a many-to-one certificate mapping rule for a user account based on the organization field in the subject of the client certificate matching Contoso.
- Configure the site to require SSL and to negotiate client certificates.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]
