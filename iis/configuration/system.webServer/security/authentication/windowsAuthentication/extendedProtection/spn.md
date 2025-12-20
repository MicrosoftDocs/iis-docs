---
title: "Service Principal Name &lt;spn&gt;"
author: rick-anderson
description: "Overview The &lt;spn&gt; element adds a Service Principal Name (SPN) to the collection of SPNs. Each SPN specifies a unique endpoint for client activity usin..."
ms.date: 09/26/2016
ms.assetid: 055f0622-955d-49c8-989a-897bb9c7e22e
msc.legacyurl: /configreference/system.webserver/security/authentication/windowsauthentication/extendedprotection/spn
msc.type: config
ms.custom: sfi-image-nochange
---
# Service Principal Name &lt;spn&gt;

<a id="001"></a>
## Overview

The `<spn>` element adds a Service Principal Name (SPN) to the collection of SPNs. Each SPN specifies a unique endpoint for client activity using the extended protection features for Windows authentication.

Extended protection enhances the existing Windows authentication functionality in order to mitigate authentication relay or "man in the middle" attacks. This mitigation is accomplished by using security information that is implemented through two security mechanisms:

- Channel-binding information that is specified through a Channel Binding Token (CBT), which is primarily used for SSL connections.
- Service-binding information that is specified through a Service Principal Name (SPN), which is primarily used for connections that do not use SSL, or when a connection is established through a scenario that provides SSL-offloading, such as a proxy server or load-balancer.

The `<extendedProtection>` element may contain a collection of `<spn>` elements, each of which contains a unique SPN for the service binding information. Each SPN represents a unique endpoint in the connection path, which may be a Fully Qualified Domain Name (FQDN) or NetBIOS name of the destination server or a proxy server. For example, if a client is connecting to a destination server through a proxy server, the SPN collection on the destination server would need to contain the SPN for the proxy server. Each SPN in the collection must be prefixed with "HTTP," so the resulting SPN for "www.contoso.com" would be "HTTP/www.contoso.com."

There are two attributes of the `<extendedProtection>` element that configure the channel-binding and additional behavior for IIS extended protection:

- The **tokenChecking** attribute configures the behavior for checking for channel-binding tokens. The possible values for this attribute are: 

    | Name | Description |
    | --- | --- |
    | `None` | This value specifies that IIS will not perform channel-binding token checking. This setting emulates the behavior that existed before extended protection. <br><br> The numerical value is `0`. |
    | `Allow` | This value specifies that channel-binding token checking is enabled, but not required. This setting allows secure communication with clients that support extended protection, but still supports clients that are not capable of using extended protection. <br><br> The numerical value is `1`. |
    | `Require` | This value specifies that channel-binding token checking is required. This setting does not provide support for clients that do not support extended protection. <br><br> The numerical value is `2`. |
- The **flags** attribute configures additional behavior for extended protection. The possible flags are: 

    | Name | Description |
    | --- | --- |
    | `None` | This flag specifies that no additional behavior is enabled for extended protection. (For example, no proxy server is being used and SPN checking is enabled and requires FQDNs.) <br><br> The numerical value is `0`. |
    | `Proxy` | This flag specifies that part of the communication path will be through a proxy, or that the client is connecting directly to the destination server over HTTP. <br><br> The numerical value is `1`. |
    | `NoServiceNameCheck` | This flag specifies that SPN checking is disabled; this flag should not be used in scenarios where only SPNs are being checked. <br><br> The numerical value is `2`. |
    | `AllowDotlessSpn` | This flag specifies that SPNs are not required to be FQDNs. Setting this flag allows NetBIOS-based SPNs. **Note:** Setting this flag is not a secure scenario; non-FQDN-based names are vulnerable to name resolution poisoning attacks. <br><br> The numerical value is `4`. |
    | `ProxyCohosting` | This flag specifies that the entire client-to-server communication path will use HTTP only; no part of the communication path will use SSL, and SPN checking will be used. **Note:** When you specify this flag, you must also specify the `Proxy` flag. <br><br> The numerical value is `32`. |

### Extended Protection Scenarios

Consider the following example scenarios:

- In each of the following scenarios, you could also specify the `AllowDotlessSpn` flag if your networking environment supports NetBIOS-based SPNs; however, NetBIOS-based SPNs are not secure.
- For each of the following scenarios where SPN checking will be used and channel-binding token checking will not be used, you should not specify the `NoServiceNameCheck` flag.

| Scenario | Flags | Description |
| --- | --- | --- |
| Client connects directly to destination server using HTTP | `Proxy`, `ProxyCohosting` | SPN checking will be used and channel-binding token checking will not be used. |
| Client connects directly to destination server using SSL | `None` | Channel-binding token checking is used and SPN checking is not used. |
| Client connects to destination server through a proxy server using HTTP for the entire path | `Proxy`, `ProxyCohosting` | SPN checking will be used and channel-binding token checking will not be used. |
| Client connects to destination server through a proxy server using SSL for the entire path | `Proxy` | SPN checking will be used and channel-binding token checking will not be used. |
| Client connects to proxy server using SSL and proxy server connects to the destination server using HTTP (SSL off-loading) | `Proxy` | SPN checking will be used and channel-binding token checking will not be used. |

### Additional Information

More information about Extended Protection is available in the following topic:

> [Integrated Windows Authentication with Extended Protection](/previous-versions/visualstudio/visual-studio-2008/dd639324(v=vs.90))
> 
> [Service Principal Names](/windows/win32/ad/service-principal-names)

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<spn>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<spn>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<spn>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<spn>` element of the `<extendedProtection>` element was introduced in IIS 7.5. |
| IIS 7.0 | N/A |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The default installation of IIS 7 and later does not include the Windows authentication role service. To use Windows authentication on IIS, you must install the role service, disable Anonymous authentication for your Web site or application, and then enable Windows authentication for the site or application.

> [!NOTE]
> After you install the role service, IIS 7 commits the following configuration settings to the ApplicationHost.config file.

[!code-xml[Main](spn/samples/sample1.xml)]

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Security**, and then select **Windows Authentication**. Click **Next**.  
    [![Screenshot shows Web Server and Security pane expanded with Windows Authentication selected.](spn/_static/image2.png)](spn/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Security**, and then select **Windows Authentication**.  
    [![Screenshot of World Wide Web Services and Security node expanded. Windows Authentication is highlighted.](spn/_static/image4.png)](spn/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 or Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, select **Windows Authentication**, and then click **Next**.   
    [![Screenshot displays Select Role Services page of Add Role Services Wizard with Security pane expanded and Windows Authentication selected.](spn/_static/image6.png)](spn/_static/image5.png)
5. On the **Confirm Installation Selections** page, click **Install**.
6. On the **Results** page, click **Close**.

### Windows Vista or Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, then **World Wide Web Services**, then **Security**.
4. Select **Windows Authentication**, and then click **OK**.   
    [![Screenshot of World Wide Web Services and Security pane expanded with Windows Authentication highlighted.](spn/_static/image8.png)](spn/_static/image7.png)
 
<a id="004"></a>
## How To

### How to enable Extended Protection for Windows authentication

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
2. In the **Connections** pane, expand the server name, expand **Sites**, and then the site, application, or Web service for which you want to enable Extended Protection for Windows authentication.
3. Scroll to the **Security** section in the **Home** pane, and then double-click **Authentication**.
4. In the **Authentication** pane, select **Windows Authentication**.
5. Click **Enable** in the **Actions** pane.  
    [![Screenshot shows Authentication pane with Windows Authentication selected. Enable option is displayed in Actions pane.](spn/_static/image10.png)](spn/_static/image9.png)
6. Click **Advanced Settings** in the **Actions** pane.
7. When the **Advanced Settings** dialog box appears, select one of the following options in the **Extended Protection** drop-down menu: 

    - Select **Accept** if you want to enable extended protection while providing down-level support for clients that do not support extended protection.
    - Select **Required** if you want to enable extended protection without providing down-level support.  
        [![Screenshot of Advanced Settings dialog box showing Accept option is selected from Extended Protection drop down menu.](spn/_static/image12.png)](spn/_static/image11.png)
8. Click OK to close the **Advanced Settings** dialog box.

<a id="005"></a>
## Configuration

The `<spn>` element of the `<extendedProtection>` element is configurable at the site, application, or virtual directory level in the ApplicationHost.config file.

### Attributes

| Attribute | Description |
| --- | --- |
| `name` | Optional string attribute.<br><br>Specifies a unique SPN.<br><br>There is no default value. |

### Child Elements

None.

### Configuration Sample

The following sample displays a `<extendedProtection>` element that demonstrates enabling Windows authentication with extended protection for the Default Web Site, and adds two SPN entries to the collection of SPNs.

[!code-xml[Main](spn/samples/sample2.xml)]

<a id="006"></a>
## Sample Code

The following examples demonstrate configuring Windows authentication with extended protection for the Default Web Site, and adds two SPN entries to the collection of SPNs.

### AppCmd.exe

[!code-console[Main](spn/samples/sample3.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](spn/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](spn/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](spn/samples/sample6.js)]

### VBScript

[!code-vb[Main](spn/samples/sample7.vb)]
