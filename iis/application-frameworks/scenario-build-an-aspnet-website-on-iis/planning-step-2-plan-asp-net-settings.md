---
title: "Planning Step 2: Plan ASP.NET Settings | Microsoft Docs"
author: rmcmurray
description: "In this phase of building your website, consider the following IIS server and website settings that support ASP.NET: Session State Settings, Pages and Contro..."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/scenario-build-an-aspnet-website-on-iis/planning-step-2-plan-asp-net-settings
msc.type: authoredcontent
---
Planning Step 2: Plan ASP.NET Settings
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In this phase of building your website, consider the following IIS server and website settings that support ASP.NET:

- [2.1. Session State Settings](#21)
- [2.2. Pages and Controls Settings](#22)
- [2.3. Application Settings](#23)
- [2.4. .NET Compilation Settings](#24)
- [2.5. .NET Globalization Settings](#25)

<a id="21"></a>
## 2.1. Session State Settings

When clients visit a site, they generally navigate from one page to another and frequently change some of the pages they visit. If you want to track pages that users browse and the changes they make during a visit to your website, configure session state.

When session state is enabled for your application, a user receives a unique session ID on their first request to a web page from your ASP.NET application. Session-state data is stored on the server in one of the following ways:

- **In-process**: Session state is stored in the worker process where the ASP.NET application runs.
- **State Server**: Session state is stored outside the worker process where the ASP.NET application runs.
- **SQL Server**: Session state is stored in a SQL Server database.

> [!NOTE]
> You can also configure custom out-of-state storage for session-state data. However, it is beyond the scope of this tutorial. Visual Studio 11 project uses custom storage to support SQL Server, SQL Compact, and SQL Azure.

Session-state data can also be stored on the client in a cookie. A cookie is a text file that contains data used for storing information about a user, such as user preferences and user authentication information.

The following sections describe your session-state storage options in more detail.

- [Store session state in process](#211)
- [Store session state by using state server](#212)
- [Store session state by using SQL server](#213)
- [Cookie mode for session state](#214)

<a id="211"></a>
### Store session state in process

The in-process session state mode stores session-state data for an ASP.NET application in the worker process where the application runs. This mode is the default for IIS 8.

The advantage of using in-process session state is that it provides the fastest access to session-state data. However, as you store more data in a session, you consume more memory, which can slow server performance.

Before you configure in-process session state, consider the effect of worker process recycling on session state data. If the worker process recycles, all session state data is lost. If your ASP.NET applications must preserve session-state data, and if speed of access to the data is not your primary objective, consider using an out-of-process session state mode for storing this data.

**Important**: The Windows state service (Aspnet\_state.exe) must be running for in-process session state to take effect. By default, this service is installed when Windows Server® 2012 is installed and is configured for manual start. It is recommended that you change the start behavior to Automatic.

By default, the session expires when the user has not requested or refreshed a page in the ASP.NET application for 20 minutes. Because Session objects consume memory on the web server, consider decreasing the time-out value to conserve resources.

Important: Use caution when you adjust the session time-out value, because information stored in a user's Session object is lost when the user is not active on the website for the length of the time-out period.

If you decide to use in-process session-state storage, decide also if you also want to use cookies. For more information about cookies, see [Cookie mode for session state](#214).

<a id="212"></a>
### Store session state by using state server

A *state server* maintains session-state date in memory that is outside the worker process. The advantage of this configuration is that session state is preserved when the application worker process recycles. Using a state server is recommended for medium-sized applications.

A state server depends on the Windows state service (Aspnet\_state.exe) and requires a machine key to verify session state across the connection.

When a state server runs on the same web server that contains the applications for which it maintains state, a web garden configuration is supported. For increased protection of session state data, consider using a web farm configuration with a separate server that stores session state and shares it among all servers in the farm. Another approach is to use SQL server to maintain out-of-process session state.

Important: The Windows state service (Aspnet\_state.exe) must be running for in-process session state to take effect. By default, this service is installed when Windows Server 2012 is installed and is configured for manual start. Change the start behavior to Automatic.

If you decide to store session state by using a state server, make the following design decisions:

- Define a connection string for the state server.
- Specify the number of seconds to wait before the connection time out.
- Decide whether to enable compression.
- Decide whether to store any session state data in a cookie. For more information about cookies, see [Cookie mode for session state](#214).

<a id="213"></a>
### Store session state by using SQL server

One type of out-of-process session state uses a SQL server to store session state data. The advantage of this configuration is that session state is preserved despite recycling of the application worker process, or if either the Windows state service or the web server goes down.

> [!NOTE]
> This setting does not support SQL Azure.

When a SQL server runs on the same web server that has the applications for which it maintains state, it supports a web garden configuration, which increases web server scalability. When the SQL server runs on another server, it supports a web farm configuration, which greatly increases scalability across a group of servers.

**Important**: The Windows state service (Aspnet\_state.exe) must be running for out-of-process session state to take effect. By default, this service is installed when Windows Server 2012 is installed and is configured for manual start. Change the start behavior to Automatic.

**Important**: Before you configure a SQL server for session state, run the InstallSqlState.sql script on the server. By default, this script is stored in %systemroot%\Microsoft.NET\Framework\V4.0.30319.

If you decide to store session state in a SQL Server database, make the following design decisions:

- Define a connection string for the database.
- Specify the number of seconds to wait before the connection time-out.
- Specify the number of seconds to wait before trying to reconnect.
- Decide whether to enable a custom database.
- Decide whether to enable compression.
- Decide whether to store any session state data in a cookie. For more information about cookies, see [Cookie mode for session state](#214).

<a id="214"></a>
### Cookie mode for session state

One way to track session state for clients that connect to a web server is to use cookies. You can configure a web server to use cookies, not to use cookies, or to select cookie behavior that depends on the browser that is used for the connection.

A session cookie associates session information with client information for the session. A session is the duration of a user's connection to a site. The cookie is passed together with all requests between a client and a web server in an HTTP header.

Using cookies to track session state is more efficient than any other method that does not use cookies, because cookies do not require any redirection. In addition, they allow users to bookmark web pages, and they retain state if a user leaves one site to visit another and then returns to the original site. The one drawback of user cookies is that users can disable cookies in their browser.

The *Use Device Profile* cookie mode causes the browser to use cookies if the browser supports cookies; otherwise, no cookies are used. If the device profile indicates support for cookies, they are used regardless of whether the user has disabled cookie support.

**Important**: When you use the Use Device Profile cookie mode, set expired session IDs be regenerated. Doing so allows a web server to expire and regenerate tokens, which gives a potential attacker less time to capture a cookie and gain access to web server content.

The *Auto-Detect* cookie mode causes the mobile device to use cookies if its profile supports cookies; otherwise, no cookies are used. For desktop browsers that are known to support cookies, ASP.NET tries to use cookies when cookie support is enabled in the browser. If cookie support is disabled, session state is stored in the URL.

**Important**: When you use the Auto-Detect cookie mode, set expired session IDs be regenerated. Doing so enables a web server to expire and regenerate tokens, which gives a potential attacker less time to capture a cookie and gain access to web server content. Consider changing the time-out value to less than the 20-minute default.

You can configure session state without using cookies. When you use a Uniform Resource Identifier (URI) to handle session state, the session ID is embedded as a query string in the URI request, and then the URI is redirected to the originally requested URL. The changed URI request is used for the duration of the session, so that no cookie is necessary.

**Important**: When you use a URI, set expired session IDs be regenerated. Doing so enables a web server to expire and regenerate tokens, which gives a potential attacker less time to capture a cookie and gain access to web server content.

Using a URI to track session state can help you avoid the disadvantages of cookies, including browser support problems and the possibility that users disable cookies. However, using a URI has the following disadvantages:

- Cannot use absolute URLs without losing session state, which means that if a user goes to another application and then returns to the previous one, the user's input no longer exists on the page.
- Does not allow users to bookmark web pages, because session state is lost.

If you decide to use cookies to store session state, make the following design decisions:

- Select a cookie mode: auto detect, use cookies, use device profile, or use URI.
- Unless you selected use URI, specify the name of the cookie.
- Unless you selected use URI, specify the number of minutes before the cookie times out.
- Unless you selected use cookies, decide whether to regenerate an expired session ID.

<a id="22"></a>
## 2.2. Pages and Controls Settings

ASP.NET pages include extra elements that ASP.NET recognizes and processes when the page runs. ASP.NET pages can also contain custom, reusable controls. These custom controls are processed on the server. This lets you use server code to set ASP.NET web page properties.

> [!NOTE]
> These settings apply only the ASP.NET Web Forms. They do not apply to ASP.NET MVC or ASP.NET Web Pages.

IIS 8 lets you configure the following ASP.NET page and user controls settings:

- Behavior settings: For example, whether the web page maintains its view state and the view state of any server controls it contains when the current page request ends.
- General settings: For example, namespaces that are included for all pages.
- Compilation settings: For example, whether pages are compiled or interpreted.
- Services: For example, whether session state is enabled.

IIS 8 provides default settings for ASP.NET pages and controls, but you can change those settings as needed. For example, you can set the master page file for a site or enable view state.

Web custom controls are compiled components that run on the server and that encapsulate user-interface and other related functionality into reusable packages. In IIS 8, you can specify the tag prefix and namespace mapping for a custom control that can be used in multiple pages in an application.

Add a custom control when you want to specify the tag prefix/namespace mapping for a custom control that is used in multiple pages in an application.

> [!NOTE]
> Adding a configuration setting adds the setting at the local level and to any child levels that inherit the setting.

If you decide to configure ASP.NET custom controls, you need the following information for each control you want to configure:

- Specify the tag prefix of the control.
- Specify the .NET namespace of the control.
- Specify the assembly the control is in.

<a id="23"></a>
## 2.3. Application Settings

Configure application settings when you want to store key/value pairs as part of your configuration in the Web.config file. Application settings provide quick and easy access to stored configuration data for your application.

To manage custom controls, you can view a list that contains all custom controls for a particular configuration level. You can sort this list by tag prefix, source or assembly, or scope (local or inherited). You can also group controls by scope to see which custom controls apply at the current configuration level and which custom controls are inherited from a parent level.

Add a custom control when you want to specify the tag prefix/namespace mapping for a custom control that is used in multiple pages in an application.

> [!NOTE]
> Adding a configuration setting adds the setting at the local level and to any child levels that inherit the setting.

If you decide to configure application settings, you need the following information for each setting you want to configure:

1. Specify a name for the setting.
2. Specify a value for the setting.

<a id="24"></a>
## 2.4. .NET Compilation Settings

For application code to service requests by users, ASP.NET must first compile the code into one or more assemblies. Assemblies are files that have the file name extension .dll. Configure .NET compilation settings in IIS 8 when you want to control how ASP.NET code is compiled.

IIS lets you configure the following .NET compilation settings:

- Batch settings, such as the maximum file size that you can batch and the maximum number of pages that you can have per batched compilation.
- Behavior settings, such as the number of times resources are dynamically compiled before the application is restarted.
- General settings, such as the default programming language that is used in dynamic compilation files.

<a id="25"></a>
## 2.5. .NET Globalization Settings

Globalization is the process of internationalizing application code, then localizing the application to other languages and cultures. The internationalization process makes it possible to translate, store, retrieve, and present application content for any locale by using the same application code base whenever possible. Locale is the combination of both language and cultural environment. This includes date formats, times, currencies, telephone numbers, and so on. Localization means adapting your application to other locales by translating and formatting content according to culture, preferably without touching the code.

You can change globalization settings for ASP.NET applications at the web server level when you want them to apply to all ASP.NET applications on the server. You can also edit ASP.NET globalization settings for sites, applications, directories, and files.

IIS lets you configure the following globalization settings:

- Culture settings, such as the UI culture or UI language.
- Encoding settings, such as encoding for response headers.

> [!NOTE]
> Editing a configuration setting changes the setting at the local level and for any child levels that inherit the setting.