---
title: "Configuring Step 4: Configure Application Security | Microsoft Docs"
author: rmcmurray
description: "In this phase of building your ASP.NET website, you configure the security settings that are available in IIS."
ms.author: aspnetcontent
manager: wpickett
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/application-frameworks/scenario-build-an-aspnet-website-on-iis/configuring-step-4-configure-application-security
msc.type: authoredcontent
---
Configuring Step 4: Configure Application Security
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In this phase of building your ASP.NET website, you configure the security settings that are available in IIS. The following sections discuss common security settings for ASP.NET applications:

- [4.1. Isolate Web Applications](#41)
- [4.2. .NET Trust Levels](#42)
- [4.3. .NET Authentication](#43)
- [4.4. Machine Key Settings](#44)
- [4.5. TLS/SSL Communication](#45)

<a id="41"></a>
## 4.1. Isolate Web Applications

 Implement the following recommendations to isolate websites and web applications on your server.

- Use one application pool per website or web application.
- Limit access to site folders and files to the application pool identity.
- Set up a separate ASP.NET temp folder per site and only give access to the application pool identity.
- Make sure to set an ACL (access control list) on each site root to allow only access to the application pool identity.

If you have more than one application per application pool, consider creating enough application pools and moving some of the applications to the new pools.

### To create an application pool

1. Open IIS Manager.
2. In the **Connections** pane, click **Application Pools**.
3. In the **Actions** pane, click **Add Application Pool**.
4. In the **Name** box, type a unique name for the application pool.
5. Select the **.NET Framework version** and **Managed pipeline mode**.
6. Click **OK**.

### To move an application to another application pool

1. Open IIS Manager.
2. In the **Connections** page, select the website or web application you want to move.
3. In the **Actions** pane, click **Basic Settings**.
4. On the **Edit Site** dialog, click **Select** to open the **Select Application Pool** dialog, and then select the application pool from the **Application pool** menu.
5. Click **OK** to close the **Select Application Pool** dialog, and click **OK** to close the **Edit Site** menu.

### To add an application pool identity to a folder or file ACL

1. Open Windows Explorer and navigate to the folder or file.
2. Right click the folder or file, and then click **Properties**.
3. Select the **Security** tab, and then click **Edit**.
4. Click **Add**, click **Locations**, and select your server as the location to search.
5. In the **Enter the object names to select** box, type **IIS APPPOOL\applicationPoolName**, where *applicationPoolName* is the application pool identity.
6. Click **OK**, click **OK**, and click **OK** again to close the dialogs.

<a id="42"></a>
## 4.2. .NET Trust Levels

This section describes how to set application trust level by using either IIS Manager UI or the command line.

### To set a trust level by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **.NET Trust Levels**.
3. On the **.NET Trust Levels** page, select a trust level from the **Trust level** drop-down list, and then click **Apply** in the **Actions** pane.

### To set a trust level by using the command line

To set a trust level, use the following syntax:

`appcmd set config /commit:WEBROOT /section:trust /level:Full|High|Medium|Low|Minimal`

The level attribute uses one of five values that correspond to preconfigured CAS policy files. For example, to set a trust level of `Full`, type the following at the command prompt, and then press ENTER:

`appcmd set config /commit:WEBROOT /section:trust /level:Full`

> [!NOTE]
> When you use Appcmd.exe to configure the trust element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

<a id="43"></a>
## 4.3. .NET Authentication

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you made design decisions about what authentication mode was right for your application. The following sections decide how to configure authentication for your ASP.NET application:

1. [ASP.NET Forms Authentication](#431)
2. [ASP.NET Impersonation Authentication](#432)

<a id="431"></a>
### ASP.NET Forms Authentication

This section describes how to configure ASP.NET forms authentication by using either the IIS Manager UI or the command line.

#### To configure forms authentication by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Authentication**.
3. On the **Authentication** page, select **Forms Authentication**.
4. In the **Actions** pane, click **Enable** to use Forms authentication with the default settings.
5. In the **Actions** pane, click **Edit**.
6. In the **Edit Forms Authentication Settings** dialog box, in the **Login URL** text box, type the name of the page where clients log in.
7. In the **Authentication cookie time-out (in minutes)** text box, type the number of minutes you want to use for the time-out value.
8. From the **Mode** list, select the cookie mode you want to use.
9. In the **Name** text box, type the name of the cookie.
10. From the **Protection mode** list, select the protection mode you want to use.
11. Select the **Requires SSL** check box.
12. Select the **Extend cookie expiration on every request** check box, and then click **OK**.

#### To configure forms authentication by using the command line

To enable forms authentication, use the following syntax:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /mode:None|Windows|Passport|Forms`

By default, IIS 8 sets the `mode` attribute to `Windows`, which disables Forms authentication. If you set the attribute to `Forms`, you enable Forms authentication. For example, to enable Forms authentication, type the following at the command prompt, and then press ENTER:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /mode:Forms`

> [!NOTE]
> When you use Appcmd.exe to configure the authentication element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

To specify the login URL for Forms authentication, use the following syntax:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.loginURL:string`

The variable `forms.loginURL:string` is the name of the page where clients login. The default value is Login.aspx. For example, to specify the login URL for Forms authentication, type the following at the command prompt, and then press ENTER:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.loginURL:login.aspx`

> [!NOTE]
> When you use Appcmd.exe to configure the authentication element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

To specify the authentication time-out for Forms authentication, use the following syntax:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.timeout:TimeSpan`

The variable `forms.timeout:TimeSpan` is the time in minutes when the cookie used for authentication expires. The default value is 30 minutes. For example, to specify the authentication time-out for Forms authentication, type the following at the command prompt, and then press ENTER:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.timeout:30`

> [!NOTE]
> When you use Appcmd.exe to configure the authentication element at the global level in IIS 8, you must specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

To configure the cookie name for Forms authentication, use the following syntax:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.name:string`

The variable `forms.name:string` is the name of the cookie used for Forms authentication. The default value is .ASPXAUTH. For example, to configure the cookie name for Forms authentication, type the following at the command prompt, and then press ENTER:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.name:.ASPXUTH`

To configure the cookie mode for Forms authentication, use the following syntax:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.cookieless:UseUri|UseCookies|AutoDetect|UseDeviceProfile`

The default value for `forms.cookieless` is `UseDeviceProfile`. For example, to configure the cookie mode for Forms authentication to use the setting Use Device Profile, type the following at the command prompt, and then press ENTER:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.cookieless:UseDeviceProfile`

To configure the cookie protection mode for Forms authentication, use the following syntax:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.protection:All|None|Encryption|Validation`

The default value for `forms.protection` is `All`. For example, to configure the cookie protection mode for Forms authentication to use the setting Encryption and Validation, type the following at the command prompt, and then press ENTER:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.protection:All`

To require SSL for an authentication cookie, use the following syntax:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.requireSSL:true|false`

The default value for `forms.requireSSL` is `false`. If you set this attribute to `true`, you require SSL. For example, to require SSL for an authentication cookie, type the following at the command prompt, and then press ENTER:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.requireSSL:true`

To cache frequently requested content, use the following syntax:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.slidingExpiration:true|false`

The default value for `forms.slidingExpiration` is `true`. For example, to cache frequently requested content, type the following at the command prompt, and then press ENTER:

`appcmd set config /commit:WEBROOT /section:system.web/authentication /forms.slidingExpiration:true`

<a id="432"></a>
### ASP.NET Impersonation Authentication

#### To configure Impersonation Authentication by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Authentication**.
3. On the **Authentication** page, select **ASP.NET Impersonation**.
4. In the **Actions** pane, click **Enable** to use ASP.NET Impersonation authentication with the default settings.
5. Optionally, in the **Actions** pane, click **Edit** to set the security principal.
6. In the **Edit ASP.NET Impersonation Settings** dialog box, select either **Specific user** or **Authenticated user**. Whichever you decide, IIS uses this identity for the security context of the ASP.NET application. By default, IIS 8 is set to impersonate the authenticated user.
7. Click **OK** to finish or proceed to the next optional steps to change the identity to impersonate.
8. Optionally, click **Set** to change the **Specific user** identity.
9. In the **Set Credentials** dialog box, enter the name of an existing user account in **User name,** the password associated with that user account in **Password**, and then the exact same value in **Confirm password** for a new account IIS should use for anonymous access.
10. Click **OK** to close the **Set Credentials** dialog box.
11. Click **OK** to close the **Edit ASP.NET Impersonation Settings** dialog box.

#### To configure Impersonation Authentication by using the command line

To enable or disable ASP.NET Impersonation, use the following syntax:

`appcmd set config /commit:WEBROOT /section:identity /impersonate:true|false`

By default, IIS sets the `impersonate` attribute to `false`, which disables ASP.NET Impersonation authentication. If you set the attribute to `true`, you enable ASP.NET Impersonation authentication. For example, to enable ASP.NET Impersonation authentication, type the following at the command prompt, and then press ENTER:

`appcmd set config /commit:WEBROOT /section:identity /impersonate:true`

Optionally, you can set the account for IIS to impersonate, using the following syntax:

`appcmd set config /commit:WEBROOT /section:identity /userName:string /password:string`

The variable `userName:string` is the account IIS uses to impersonate and the variable `password:string` is the password. For example, to use an account named **Moe** for IIS to impersonate, type the following at the command prompt, and then press ENTER:

`appcmd set config /commit:WEBROOT /section:identity /userName: Moe /password:pass@word1`

> [!NOTE]
> When you use Appcmd.exe to configure the identity element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

<a id="44"></a>
## 4.4. Machine Key Settings

This section describes how to generate machine keys for your ASP.NET application by using the IIS Manager UI.

### To generate machine keys by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Machine Key**.
3. On the **Machine Key** page, select a validation method from the **Validation method** list. The default validation method is **SHA1**.
4. Choose an encryption method from the **Encryption method** list. The default encryption method is **Auto**.
5. Optionally, configure settings for validation and decryption keys.
6. In the **Actions** pane, click **Generate Keys**, and then click **Apply**.

<a id="45"></a>
## 4.5. TLS/SSL Communication

 This section describes how to configure TLS/SSL security for your application.

After obtaining a server certificate from a certification authority (CA), work through the procedures in the following sections:

1. [SSL Binding](#451)
2. [Require SSL for Your Site](#452)
3. [Client Certificates](#453)

<a id="451"></a>
### SSL Binding

This section describes how to add an SSL binding to your site by using either the IIS Manager UI or the command line.

#### To add an SSL binding to a site by using the UI

1. Open IIS Manager.
2. In the **Connections** pane, expand the **Sites** node in the tree, and then click to select the site for which you want to add a binding.
3. In the **Actions** pane, click **Bindings**.
4. In the **Site Bindings** dialog box, click **Add**.
5. In the **Add Site Binding** dialog box, in the **Type** list, select **https**.
6. From the **IP address** list, select **All Unassigned** (unless there is a specific IP address you want to use).
7. In the **Port** box, type the number of the port (the default is 443).
8. In the **Host name** box, type the name of the host computer.
9. If you want multiple secure websites to be served using the same IP address, select the **Require Server Name Indication** check box.
10. From the **SSL certificate** list, select the certificate for your website. If your certificate doesn't appear in the list, click **Select** and search for the certificate using the **Select Certificate** dialog box.
11. Click **OK**.

#### To add an SSL binding to a site by using the command line

To add a binding to a site, use the following syntax:

`appcmd set site /site.name:string /+bindings.[protocol='string', bindingInformation='string']`

The variable `site.name:string` is name of the site to which you want to add a binding. The variable `protocol='string'` is the protocol that you want to use, and the variable `bindingInformation='string'` is the combination of IP address, port, and host header.

For example, to configure a site named **contoso** to have an HTTPS binding for all IP addresses, on port 443, without a host header, type the following at the command prompt, and then press ENTER:

`appcmd set site /site.name:contoso /+bindings.[protocol='https', bindingInformation='*:443:']`

<a id="452"></a>
### Require SSL for Your Site

This section describes how to require SSL for your website by using the IIS Manager UI or the command line.

#### To require SSL using the UI

1. Open IIS Manager and navigate to the level you want to manage. Make sure that you are at the site, application, or directory level; **SSL Settings** are not available at the server level. (> [!NOTE]
> If you want to configure SSL at the file level, navigate to the file in **Content View** and then click **Switch to Features View** in the **Actions** pane.)
2. In **Features View**, double-click **SSL Settings**.
3. On the **SSL Settings** page, select **Require SSL**.
4. In the **Actions** pane, click **Apply**.

#### To require SSL using the command line

To require SSL, use the following syntax:

`appcmd set config "site|URL" /section:access /sslFlags:Ssl /commit:APPHOST`

The variable `site|URL` is the site, application, virtual directory, or file where you want IIS 8 to require SSL. For example, to require SSL for the Default Web Site, type the following at the command prompt, and then press ENTER:

`appcmd set config "Default Web Site" /section:access /sslFlags:Ssl /commit:APPHOST`

To require SSL for the file iisstart.htm on the Default Web Site, type the following at the command prompt, and then press ENTER:

`appcmd set config "http://localhost/iisstart.htm" /section:access /sslFlags:Ssl /commit:APPHOST`

<a id="453"></a>
### Client Certificates

#### To specify client certificates by using the UI

1. Open IIS Manager and navigate to the level you want to manage. Make sure that you are at the site, application, or directory level; **SSL Settings** are not available at the server level. (> [!NOTE]
> If you want to configure SSL at the file level, navigate to the file in **Content View** and then click **Switch to Features View** in the **Actions** pane.)
2. In **Features View**, double-click **SSL Settings**.
3. On the **SSL Settings** page, optionally select **Require SSL**. You do not need SSL to **Ignore** or **Accept** client certificates.
4. On the **SSL Settings** page, in the **Client certificates** area, use one of the following procedures:

    - Select **Ignore** if you do not want to accept a client certificate even if a client presents one.
    - Select **Accept** to accept client certificates.
    - Select **Require** to require client certificates. To use **Require Client Certificates**, you must enable **Require SSL**.
5. In the **Actions** pane, click **Apply**.

#### To specify client certificates by using the command line

To specify whether to use client certificates, use the following syntax:

`appcmd set config "site|URL" /section:access /sslFlags:Ssl|SslNegotiateCert|SslRequireCert /commit:APPHOST`

The variable `site|URL` is the site, application, virtual directory, or file where you want IIS to enable client certificates. For example, to accept client certificates for the Default Web Site, type the following at the command prompt, and then press ENTER:

`appcmd set config "Default Web Site" /section:access /sslFlags:SslNegotiateCert /commit:APPHOST`

To accept client certificates for the file iisstart.htm on the Default Web Site, type the following at the command prompt, and then press ENTER:

`appcmd set config "http://localhost/iisstart.htm" /section:access /sslFlags:SslNegotiateCert /commit:APPHOST`

You can specify one or more of the values for the sslFlags attribute. If you want more than one value, separate each value with a comma (,). For example, to specify a requirement for both SSL and client certificates on the Default Web Site, type the following at the command prompt, and then press ENTER:

`appcmd set config "Default Web Site" /section:access /sslFlags:Ssl,SslRequireCert /commit:APPHOST`