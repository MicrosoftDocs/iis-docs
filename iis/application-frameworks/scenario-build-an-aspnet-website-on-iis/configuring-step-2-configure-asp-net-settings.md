---
title: "Configuring Step 2: Configure ASP.NET Settings"
author: rmcmurray
description: "In this phase of building your website, you configure the IIS server and website settings that support ASP.NET."
ms.date: 04/14/2013
ms.assetid: 2e778eb8-a1f8-4a3d-aa13-cfa2ca6fca92
msc.legacyurl: /learn/application-frameworks/scenario-build-an-aspnet-website-on-iis/configuring-step-2-configure-asp-net-settings
msc.type: authoredcontent
---
Configuring Step 2: Configure ASP.NET Settings
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

<a id="21"></a>
## 2.1. Session State Settings

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you decided to use one of the following session-state-storage options:

- **In-process**: Session state is stored in the worker process where the ASP.NET application runs.
- **State Server**: Session state is stored outside the worker process where the ASP.NET application runs.
- **SQL Server**: Session state is stored in a SQL Server database.

You might have also chosen to store session data on the client computer in a cookie. You can even combine the use of cookies with one of the other storage methods. For example, you could store authentication data in a cookie while storing other session-state data in a SQL Server database.

The following sections describe how to configure session state based on the planning decisions you have made:

- [Store Session State in Process](#211)
- [Store Session State by using State Server](#212)
- [Store Session State by using SQL Server](#213)
- [Cookie Mode for Session State](#214)

<a id="211"></a>
### Store Session State in Process

 This section describes how to configure in-process session state by using either the IIS Manager UI or the command line.

#### To enable in-process session state by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Session State**.
3. On the **Session State** page, in the **Session State Mode Settings** area, click **In process**.
4. (Optional) Configure cookie settings in the **Cookie Settings** area on the **Session State** page. 

    For more information about cookie settings, see [Cookie Mode for Session State](#214).
5. In the **Time-out** field, enter a time-out value in the format hh:mm:ss. For example, enter 00:15:00 for 15 minutes.
6. (Optional) Check the **Use hosting identity for impersonation** check box to use Windows authentication and the host process identity (either ASP.NET or a Windows service identity) for remote connections.
7. Click **Apply** in the **Actions** pane.

#### To enable in-process session state by using the command line

To enable in-process session state, use the following syntax:

`appcmd set config /commit:WEBROOT /section:sessionState /mode:InProc`

The variable `mode:InProc` enables in-process session state. By default, in-process session state is enabled.

> [!NOTE]
> When you use Appcmd.exe to configure the `<sessionState>` element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

To specify the default time that a session object is maintained after the last request associated with the object is made, use the following syntax:

`appcmd set config /section:asp /timeout:timeSpan`

The variable `timeSpan` represents the maximum time (hh:mm:ss) that a session object is maintained after the last request associated with the object is made. The default value is 00:20:00.

<a id="212"></a>
### Store Session State by using State Server

This section describes how to configure a state server for session-state storage by using either the IIS Manager UI or the command line.

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you made the following design decisions:

- Define a connection string for the state server.
- Specify the number of seconds to wait before the connection time-out.
- Decide whether to enable compression.
- Decide whether to store any session state data in a cookie.

#### To configure a state server to maintain session state by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Session State**.
3. On the **Session State** page, in the **Session State Mode Settings** area, click **State Server.**
4. Type a connection string in the **Connection string** text box, or click **Create** to create a connection string.
5. Type a time-out value in the **Time-out (in seconds)** text box. The default time-out value is 10 seconds.
6. (Optional) Configure cookie settings in the **Cookie Settings** area on the **Session State** page. For more information about cookie settings, see [Cookie Mode for Session State](#214).
7. (Optional) Select the **Use hosting identity for impersonation** check box to use Windows authentication and the host process identity (either ASP.NET or a Windows service identity) for connections to the database.
8. Click **Apply** in the **Actions** pane.

#### To configure a state server to maintain session state by using the command line

To configure a state server to maintain session state, use the following syntax:

`appcmd set config /commit:WEBROOT /section:sessionState /mode:StateServer /stateConnectionString:string /stateNetworkTimeout:timeSpan /useHostingIdentity:true|false`

The variable `mode:StateServer` sets the session state mode to store session data in a state server. By default, the variable `string` defines the connection string that the state server uses. The default setting is `tcpip=loopback:42424`. The variable `timeSpan` sets the time, in seconds, that the connection to the state server is maintained. The default is 10 seconds. The variable `useHostingIdentity:true|false` enables or disables the use of Windows authentication and the host process identity (either ASP.NET or a Windows service identity) for connections to the database. The default value is `true`.

> [!NOTE]
> When you use Appcmd.exe to configure the `<sessionState>` element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

<a id="213"></a>
### Store Session State by using SQL Server

This section describes how to configure a SQL Server database for session-state storage using either the IIS Manager UI or the command line.

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you made the following design decisions:

- Define a connection string for the database.
- Specify the number of seconds to wait before the connection time-out.
- Specify the number of seconds to wait before trying to reconnect.
- Decide whether to enable a custom database.
- Decide whether to enable compression.
- Decide whether to store any session state data in a cookie.

#### To configure a SQL server to maintain session state by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Session State**.
3. On the **Session State** page, in the **Session State Mode Settings** area, click **SQL Server**.
4. Type a connection string in the **Connection string** text box, or click **Create** to create a connection string. If the SQL server is on the server you are managing, select **LocalSqlServer** in the **Connection string** text box.
5. Type a time-out value in the **Time-out** text box.
6. (Optional) Check the **Enable custom database** check box to use a custom database for storing session state data.
7. (Optional) Configure cookie settings in the **Cookie Settings** area on the **Session State** page. For more information about cookie settings, see [Cookie Mode for Session State](#214).
8. (Optional) Check the **Use hosting identity for impersonation** check box to use Windows authentication and the host process identity (either ASP.NET or a Windows service identity) for remote connections to the SQL database.
9. Click **Apply** in the **Actions** pane.

#### To configure a SQL server to maintain session state by using the command line

To configure a state server to maintain session state, use the following syntax:

`appcmd set config /commit:WEBROOT /section:sessionState /mode:SqlServer /sqlConnectionString:string /sqlCommandTimeout:timeSpan /useHostingIdentity:true|false`

The variable `mode:SqlServer` sets the session state mode to store session data in a SQL server database. By default, the variable `string` defines the connection string that the SQL server uses. The default setting is LocalSqlServer. The variable `timeSpan` sets the time, in seconds, that the connection to the SQL server is maintained. The default is 30 seconds. The variable `useHostingIdentity:true|false` enables or disables the use of Windows authentication and the host process identity (either ASP.NET or a Windows service identity) for connections to the database. The default value is `true`.

> [!NOTE]
> When you use Appcmd.exe to configure the `<sessionState>` element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

<a id="214"></a>
### Cookie Mode for Session State

This section describes how to configure a SQL Server database for session-state storage by using either the IIS Manager UI or the command line.

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you made the following design decisions:

- Select a cookie mode: auto detect, use cookies, use device profile, or use URI.
- Unless you selected use URI, specify the name of the cookie.
- Unless you selected use URI, specify the number of minutes before the cookie times out.
- Unless you selected use cookies, decide whether to regenerate an expired session ID.

#### To configure Use Cookies mode for session state by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Session State**.
3. On the **Session State** page, in the **Cookie Settings** area, select **Use Cookies** from the **Mode** drop-down list.
4. Type a cookie name in the **Name** text box, or use the default cookie name, ASP.NET\_SessionId.
5. Type a time-out value in the **Time-out** text box, or use 20 minutes, the default time-out value.
6. Click **Apply** in the **Actions** pane.

#### To configure Use Cookies mode for session state by using the command line

To configure use cookies mode for session state, use the following syntax:

`appcmd set config /commit:WEBROOT /section:sessionState /cookieless:UseCookies /cookieName:string /timeout:timeSpan`

The variable `cookieless:UseCookies` configures IIS 8 to use cookies mode for session state. This is the default value. The variable `string` is the name of the cookie. The default value is `ASP.NET_SessionId`. The variable `timeSpan` sets the time, in minutes, after which the cookie times out. The default is 20 minutes. For example, to set a cookie-mode cookie for session state (called MyCookie and that expires after 40 minutes), type the following at the command prompt, and then press Enter:

`appcmd set config /commit:WEBROOT /section:sessionState /cookieless:UseCookies /cookieName:MyCookie /timeout:40`

> [!NOTE]
> When you use Appcmd.exe to configure the `<sessionState>` element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

To configure use device profile cookie mode for session state, use the following syntax:

`appcmd set config /commit:WEBROOT /section:sessionState /cookieless:UseDeviceProfile /cookieName:string /timeout:timeSpan /regenerateExpiredSessionId:true|false`

The variable `cookieless:UseDeviceProfile` configures IIS 8 to use device-profile cookie mode for session state. The variable `string` is the name of the cookie. The default value is `ASP.NET_SessionId`. The variable `timeSpan` sets the time, in minutes, after which the cookie times out. The default is 20 minutes. The variable `regenerateExpiredSessionId:true|false` enables or disables the regeneration of expired session IDs.

> [!NOTE]
> When you use Appcmd.exe to configure the `<sessionState>` element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

To configure auto-detect cookie mode for session state, use the following syntax:

`appcmd set config /commit:WEBROOT /section:sessionState /cookieless:AutoDetect /cookieName:string /timeout:timeSpan /regenerateExpiredSessionId:true|false`

The variable `cookieless:AutoDetect` configures IIS 8 to use auto-detect cookie mode for session state. The variable `string` is the name of the cookie. The default value is `ASP.NET_SessionId`. The variable `timeSpan` sets the time, in minutes, after which the cookie times out. The default is 20 minutes. The variable `regenerateExpiredSessionId:true|false` enables or disables the regeneration of expired session IDs.

> [!NOTE]
> When you use Appcmd.exe to configure the `<sessionState>` element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

To configure URI cookie mode for session state, use the following syntax:

`appcmd set config /commit:WEBROOT /section:sessionState /cookieless:UseUri /regenerateExpiredSessionId:true|false`

The variable `cookieless:UseUri` configures IIS 8 to use URI cookie mode for session state. The variable `regenerateExpiredSessionId:true|false` enables or disables the regeneration of expired session IDs.

> [!NOTE]
> When you use Appcmd.exe to configure the `<sessionState>` element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

<a id="22"></a>
## 2.2. Pages and Controls Settings

This section describes how to configure ASP.NET pages and control settings by using either the IIS Manager UI or the command line.

> [!NOTE]
> These settings apply only to ASP.NET Web Forms. They do not apply to ASP.NET MVC or ASP.NET Web Pages.

### Edit Pages and Controls

 You can edit the settings of existing pages and controls, and the changes are reflected into the Web.config file.

#### To edit settings for pages and controls by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Pages and Controls**.
3. On the **Pages and Controls** page, edit settings as necessary.
4. When finished, click **Apply** in the **Actions** pane.

#### To edit settings for pages and controls by using the command line

To enable or disable page output buffering, use the following syntax:

`appcmd set config /commit:WEBROOT /section:pages /buffer:true|false`

The variable `buffer:true` enables buffering of page output. The default is `true`.

### Add a Custom Control

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you made the following design decisions for each custom control you want to add:

- Specify the tag prefix of the control.
- Specify the .NET namespace of the control.
- Specify the assembly the control is in.

#### To add a custom control by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Pages and Controls**.
3. In the **Actions** pane, click **Register Controls**.
4. In the **Actions** pane, click **Add Custom Control**.
5. In the **Add Custom Control** dialog box, type a tag prefix in the **Tag prefix** text box.
6. In the **Namespace** text box, type the namespace to which the custom control belongs. This is the same namespace that was specified in the application code.
7. In the **Assembly** text box, type the name of the source or assembly for the custom control, and then click **OK**.

#### To add a custom control by using the command line

To add a custom control, use the following syntax:

`appcmd set config /commit:WEBROOT /section:system.web/pages /+"controls.[assembly='string', namespace='string', src='string', tagName='string', tagPrefix='string']"`

The variable `assembly='string'` is the name of the assembly that contains the COM control implementation and requires that the `namespace` attribute is also set. The variable `namespace='string'` is the namespace that is associated with the tag prefix and requires that the `assembly` attribute is also set, if the COM control is not located in the application code directory. The variable `src='string'` is the name of the file that contains the user control and requires that the `tagName` attribute is also set. The variable `tagName='string'` is the name of the control to use in the page and requires that the `src` attribute is also set. The variable `tagPrefix='string'` is the tag prefix that is being mapped to a source file or namespace and assembly. This attribute requires one of the following combinations of other attributes:

- `namespace` to define a COM control, if the control is in the application code directory.
- `namespace` and `assembly` to define a COM control.
- `tagName` and `src` to define a user control.

For example, to add a custom control that uses the specified source for a user control, type the following at the command prompt, and then press Enter:

`appcmd set config /commit:WEBROOT /section:system.web/pages /+"controls.[tagPrefix='MyTag', tagName='MyControl', src='controls/MyControl.asx']"`

> [!NOTE]
> When you use Appcmd.exe to configure the `<controls>` element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

<a id="23"></a>
## 2.3. Application Settings

This section describes how to configure application settings by using either the IIS Manager UI or the command line.

In [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md), you made the following design decisions for each application setting you want to configure:

1. Specify a name for the setting.
2. Specify a value for the setting.

### To create an application setting by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **Application Settings**.
3. In the **Actions** pane, click **Add**.
4. In the **Add Application Setting** dialog box, type a name for the application setting in the **Name** text box.
5. In the **Add Application Setting** dialog box, type a value for the application setting in the **Value** text box, and then click **OK**.

#### To create an application setting by using the command line

To add an application setting, use the following syntax:

`appcmd set config /commit:MACHINE /section:appSettings /+"[key='string', value='string']"`

The variable `key=string` is the name of the application setting and the variable `value=string` is the value for the application setting. For example, to add an application setting for the name of your application, type the following at the command prompt, and then press Enter:

`appcmd set config /commit:MACHINE /section:appSettings /+"[key='Application Name', value='MyApplication']"`

<a id="24"></a>
## 2.4. .NET Compilation Settings

Edit .NET compilation settings in IIS 8 when you want to control how ASP.NET code is compiled. This section describes how to edit the compilation settings for you ASP.NET application.

### To configure .NET compilation settings by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **.NET Compilation**.
3. On the **.NET Compilation** page, edit settings as necessary.
4. When finished, click **Apply** in the **Actions** pane.

### To configure .NET compilation settings by using the command line

To enable or disable batch compilation for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /batch:true|false`

The variable `batch:true` enables batch compilation, and the variable `batch:false` disables batch compilation. The default value is `true`.

To change the maximum file size (in KB) of the batch compilation, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /maxBatchGeneratedFileSize:int`

The variable `int` is the maximum file size (in KB). The default value is 1000.

To specify the maximum number of pages per batched compilation for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /maxBatchSize:int`

The variable `int` is the maximum number of pages per batched compilation.

To define the time-out period, in seconds, for batch compilation for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /batchTimeout:timeSpan`

The variable `timeSpan` is the time-out in seconds for batch compilation.

To specify compilation of retail or debug binaries for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /debug:true|false`

The variable `debug:true` enables compilation of debug binaries and the variable `debug:false` enables compilation of retail binaries. The default value is `false`.

To specify the number of times resources can be dynamically recompiled before an application restarts for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /numRecompilesBeforeAppRestart:int`

The variable `int` is the number of times resources are dynamically recompiled before the application is restarted. The default is 15.

To enable or disable URL line pragma for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /urlLinePragmas:true|false`

The variable `urlLinePragmas:true` enables URL line pragma and the variable `urlLinePragmas:false` disables URL line pragma. The default value is `false`.

To enable or disable Visual Basic explicit compilation for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /explicit:true|false`

The variable `explicit:true` enables Visual Basic explicit compilation and the variable `explicit:false` disables explicit compilation. The default value is `false`.

To enable or disable Visual Basic strict compilation for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /strict:true|false`

The variable `strict:true` enables Visual Basic strict compilation and the variable `strict:false` disables strict compilation. The default value is `false`.

To add an ASP.NET compilation processing directive for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /+"assemblies.[assembly='string']"`

The variable `string` is the ASP.NET compilation processing directive.

To remove an ASP.NET compilation processing directive for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /-"assemblies.[assembly='string']"`

The variable `string` is the ASP.NET compilation processing directive.

To remove an ASP.NET compilation processing directive for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /-"assemblies.[assembly='string']"`

The variable `string` is the ASP.NET compilation processing directive.

To change the default programming language that is used in dynamic compilation files for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /defaultLanguage:string`

The variable `string` is the default programming language. The default value is vb. For example, to change the default programming language that is used in dynamic compilation files from Visual Basic to C#, type the following at the command prompt, and then press Enter:

`appcmd set config /commit:WEBROOT /section:compilation /defaultLanguage:c#`

To specify the directory to use for temporary file storage during compilation for a site, use the following syntax:

`appcmd set config /commit:WEBROOT /section:compilation /tempDirectory:`*string*

The variable `string` is the directory path.

> [!NOTE]
> When you use Appcmd.exe to configure the `<compilation>` element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

<a id="25"></a>
## 2.5. .NET Globalization Settings

This section describes how to edit the globalization settings for you ASP.NET application by using either the IIS Manager UI or the command line.

### To edit .NET globalization settings by using the UI

1. Open IIS Manager and navigate to the level you want to manage.
2. In **Features View**, double-click **.NET Globalization**.
3. On the **.NET Globalization** page, in the property sheet, click to select the global setting you want to edit, and select a value from the drop-down list.
4. In the **Actions** pane, click **Apply**.

### To edit .NET globalization settings by using the command line

To edit the default culture for processing Web requests, use the following syntax:

`appcmd set config /commit:WEBROOT /section:globalization /culture:string`

The variable *string* is the default culture for processing web requests. For example, to change the default culture for processing Web requests to US English, type the following at the command prompt, and then press Enter:

`appcmd set config /commit:WEBROOT /section:globalization /culture:en-us`

> [!NOTE]
> When you use Appcmd.exe to configure the `<globalization>` element at the global level in IIS 8, specify `/commit:WEBROOT` in the command so that configuration changes are made to the root Web.config file instead of ApplicationHost.config.

To enable or disable client-based culture, use the following syntax:

`appcmd set config /commit:WEBROOT /section:globalization /enableClientBasedCulture:true|false`

The variable `enableClientBasedCulture:true` enables client-based culture and the variable `enableClientBasedCulture:false` disables client-based culture. The default is `false`.

To edit the default culture for processing locale-dependent resource searches, use the following syntax:

`appcmd set config /commit:WEBROOT /section:globalization /uiCulture:string`

The variable `string` is the default culture for processing locale-dependent resource searches.

To edit the default culture for processing locale-dependent resource searches, use the following syntax:

`appcmd set config /commit:WEBROOT /section:globalization /uiCulture:string`

The variable `string` is the default culture for processing locale-dependent resource searches.

To change the default encoding when parsing .aspx, .asmx, and .asax files, use the following syntax:

`appcmd set config /commit:WEBROOT /section:globalization /fileEncoding:string`

The variable `string` is the default encoding to be used when parsing .aspx, .asmx, and .asax files.

To change the header encoding for responses, use the following syntax:

`appcmd set config /commit:WEBROOT /section:globalization /responseHeaderEncoding:string`

The variable `string` is the header encoding used for responses. The default is utf-8.

To edit the content encoding for responses, use the following syntax:

`appcmd set config /commit:WEBROOT /section:globalization /responseEncoding:string`

The variable `string` is the content encoding used for responses. The default is utf-8.