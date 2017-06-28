---
title: "Adding Security Authorization &lt;add&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;authorization&gt; collection defines an authorization rule that will either allow or deny access to specified use..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/security/authorization/add
msc.type: config
---
Adding Security Authorization &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<authorization>` collection defines an authorization rule that will either allow or deny access to specified users, groups, anonymous users, or all users.

The **accessType** attribute specifies either of two types of authorization rules:

- Allow rules let you define the user accounts or user groups that can access a site, an application, or all the sites on a server.
- Deny rules let you define the user accounts or user groups that cannot access a site, an application, or all the sites on a server.

Authorization rules can further be targeted for a list of HTTP verbs and either specific users or groups.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<authorization>` collection was introduced in IIS 7.0. |
| IIS 6.0 | The `<authorization>` collection replaces the IIS 6.0 **AzEnable**, **AzStoreName**, **AzScopeName**, and **AzImpersonationLevel** metabase properties. |

<a id="003"></a>
## Setup

To support and configure authorization for sites and applications on your Web server, you must install the URL authorization module. To do so, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**. - In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**. - In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**. - On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Security**, and then select **URL Authorization**. Click **Next**.  
    [![](add/_static/image2.png)](add/_static/image1.png) . - On the **Select features** page, click **Next**. - On the **Confirm installation selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**. - In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**. - Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Security**, and then select **URL Authorization**.  
    [![](add/_static/image4.png)](add/_static/image3.png)- Click **OK**.
- Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**. - In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**. - In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**. - On the **Select Role Services** page of the **Add Role Services Wizard**, select **URL Authorization**, and then click **Next**.  
    [![](add/_static/image6.png)](add/_static/image5.png)- On the **Confirm Installation Selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**. - In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**. - Expand **Internet Information Services**, then select **URL Authorization**, and then click **OK**.  
    [![](add/_static/image8.png)](add/_static/image7.png)
 
<a id="004"></a>
## How To

### How to add an authorization rule

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
2. In the **Connections** pane, expand the server name, expand **Sites**, and then navigate to the site or application on which you want to configure authorization.
3. In the **Home** pane, double-click **Authorization Rules**.  
    [![](add/_static/image10.png)](add/_static/image9.png)
4. To add a new authorization rule, in the **Actions** pane click **Add Allow Rule...** or **Add Deny Rule...**
5. Apply the authorization settings needed for your site or application, and then click **OK**. For example:

    - Example #1: Adding an Allow rule for all users for specific HTTP verbs:  
        [![](add/_static/image12.png)](add/_static/image11.png)
    - Example #2: Adding a Deny rule for a specific user for all HTTP verbs:  
        [![](add/_static/image14.png)](add/_static/image13.png)

    > [!NOTE]
    >  To edit or delete an existing rule, select the rule in the     **Authorization rules** pane, and then click     **Edit...** or     **Remove** in the     **Actions** pane. If you click     **Edit...** , a dialog box appears that allows you to edit the rule; this dialog box is similar to the     **Add Allow Authorization Rule** and     **Add Deny Authorization Rule** dialog boxes.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `accessType` | Required Enum attribute. <br><br>The **accessType** attribute can be one of the following possible values. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>Allow</code></th> <td>Specifies a rule that allows authorization.<br><br>The numeric value is <code>0</code>. </td></tr> <tr> <th><code>Deny</code></th> <td>Specifies a rule that denies authorization.<br><br>The numeric value is <code>1</code>. </td></tr></tbody></table> |
| `roles` | Optional string attribute. <br><br>Specifies roles for an authorization rule. |
| `users` | Optional string attribute. <br><br>Specifies users for an authorization rule. Multiple users can be added in a comma-separated list. In addition, the following special identifiers have been defined. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>*</code></th> <td>Specifies that the rule will apply to all users.</td></tr> <tr> <th><code>?</code></th> <td>Specifies that the rule will apply to anonymous users.</td></tr></tbody></table> |
| `verbs` | Optional string attribute. <br><br>Specifies the HTTP verbs for an authorization rule.<br><br>If this value is left blank or is not specified, the rule will apply to all HTTP verbs. |

### Child Elements

None.

### Configuration Sample

The following configuration example, when included in a Web.config file, removes the default IIS authorization settings, which allows all users access to Web site or application content. It then configures an authorization rule that allows only users with administrator privileges to access the content.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples add an allow authorization rule that allows users in the administrators group to access a Web site named Contoso.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

> [!NOTE]
> You can optionally set the **commit** parameter to `apphost` when using AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file instead of a Web.config file.

### C#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]