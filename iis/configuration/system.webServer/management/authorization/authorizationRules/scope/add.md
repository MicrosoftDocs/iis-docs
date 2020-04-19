---
title: "Adding Management Authorization Rules Scope &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;scope&gt; element adds an IIS Manager user, a Windows user, or a Windows group to the collection of users who are..."
ms.date: 09/26/2016
ms.assetid: 86eea860-b481-457c-bde8-09e59c6eb858
msc.legacyurl: /configreference/system.webserver/management/authorization/authorizationrules/scope/add
msc.type: config
---
Adding Management Authorization Rules Scope &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<scope>` element adds an IIS Manager user, a Windows user, or a Windows group to the collection of users who are authorized to connect to a site or an application by using IIS Manager when the default authorization provider, *ConfigurationAuthorizationProvider*, is enabled in Internet Information Services (IIS) 7.

> [!NOTE]
> The *ConfigurationAuthorizationProvider* uses the IIS Administration.config file to store IIS Manager authorization settings for IIS Manager; however, other authorization providers may use alternate storage locations.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<scope>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The default installation of IIS 7 and later does not include the **Management Service** role service. To install this role service, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Management Tools**, and then select **Management Service**. Click **Next**.  
    [![](add/_static/image2.png)](add/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **Web Management Tools**, and then select **IIS Management Service**.  
    [![](add/_static/image4.png)](add/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **Management Service**, and then click **Next**.  
    [![](add/_static/image6.png)](add/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **Web Management Tool**.
4. Select **IIS Management Service**, and then click **OK**.   
    [![](add/_static/image8.png)](add/_static/image7.png)
 
<a id="004"></a>
## How To

### How to authorize an IIS Manager user for a site or application

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
2. In the **Connections** pane, go to the connection, site, application, or directory for which you want to authorize an IIS Manager user.
3. In the **Home** pane, double-click **IIS Manager Permissions**.  
    [![](add/_static/image10.png)](add/_static/image9.png)
4. On the **IIS Manager Permissions** page, click **Allow User...** in the **Actions** pane.  
    [![](add/_static/image12.png)](add/_static/image11.png)
5. In the **Allow User** dialog box, choose **IIS Manager**, then click **Select...**  
    [![](add/_static/image14.png)](add/_static/image13.png)
6. In the **Users** dialog box, highlight the user account that you want to allow, and then click **OK**.  
    [![](add/_static/image16.png)](add/_static/image15.png)
7. In the **Allow User** dialog box, click **OK**.  
    [![](add/_static/image18.png)](add/_static/image17.png)

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `name` | Required string attribute.<br><br>Specifies the name of an IIS Manager user, a Windows user, or a Windows group that is authorized to connect to the site or application by using IIS Manager. |
| `isRole` | Optional Boolean attribute.<br><br>Specifies whether the entry is a Windows group. When **true**, the entry is a Windows group and any Windows users that belong to that group can connect to the site or application by using IIS Manager.<br><br>The default value is `false`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample shows how to authorize an IIS Manager user named Contoso, a Windows group named Test Group, and a Windows user named Contoso2 to connect to the Default Web Site by using IIS Manager.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples check to see if a `<scope>` element has already been added to the `<authorizationRules>` element for the Default Web Site; if not, a `<scope>` element is added the `<authorizationRules>` element. Next, an `<add>` element is added to the `<scope>` element that authorizes a user account named ContosoUser.

### AppCmd.exe

> [!NOTE]
> You cannot configure `<system.webServer/management/authorization>` settings using AppCmd.exe.

### C#

[!code-csharp[Main](add/samples/sample2.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample3.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample4.js)]

### VBScript

[!code-vb[Main](add/samples/sample5.vb)]
