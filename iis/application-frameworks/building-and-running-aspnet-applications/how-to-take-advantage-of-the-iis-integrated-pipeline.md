---
title: "How to Take Advantage of the IIS 7.0 Integrated Pipeline | Microsoft Docs"
author: leanserver
description: "IIS 6.0 and previous versions allowed the development of .NET application components via the ASP.NET platform. ASP.NET integrated with IIS via an ISAPI exten..."
ms.author: iiscontent
manager: soshir
ms.date: 12/05/2007
ms.topic: article
ms.assetid: 54ba9206-c845-457a-a800-b989641bb654
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/building-and-running-aspnet-applications/how-to-take-advantage-of-the-iis-integrated-pipeline
msc.type: authoredcontent
---
How to Take Advantage of the IIS 7.0 Integrated Pipeline
====================
by [Mike Volodarsky](https://github.com/leanserver)

## Introduction

IIS 6.0 and previous versions allowed the development of .NET application components via the ASP.NET platform. ASP.NET integrated with IIS via an ISAPI extension, and exposed its own application and request processing model. This effectively exposed two separate server pipelines, one for native ISAPI filters and extension components, and another for managed application components. ASP.NET components would execute entirely inside the ASP.NET ISAPI extension bubble and only for requests mapped to ASP.NET in the IIS script map configuration.

IIS 7.0 and above integrates the ASP.NET runtime with the core web server, providing a unified request processing pipeline that is exposed to both native and managed components known as modules. The many benefits of integration include:

- Allowing services provided by both native and managed modules to apply to all requests, regardless of handler. For example, managed Forms Authentication can be used for all content, including ASP pages, CGIs, and static files.
- Empowering ASP.NET components to provide functionality that was previously unavailable to them due to their placement in the server pipeline. For example, a managed module providing request rewriting functionality can rewrite the request prior to any server processing, including authentication.
- A single place to implement, configure, monitor and support server features such as single module and handler mapping configuration, single custom errors configuration, single url authorization configuration.

This article examines how the ASP.NET applications can take advantage of the integrated mode in IIS 7.0 and above, and illustrates the following tasks:

- Enabling/disabling modules on a per-application level.
- Adding managed application modules to the server, and enabling them to apply to all request types.
- Adding managed handlers.

Learn more about building IIS 7.0 and above modules in [Developing IIS 7.0 and Above Modules and Handlers with the .NET Framework](../../develop/runtime-extensibility/developing-iis-modules-and-handlers-with-the-net-framework.md).

See also the blog, [http://www.mvolo.com/](http://www.mvolo.com/), for more tips on taking advantage of Integrated mode and developing IIS modules that leverage the ASP.NET integration in IIS 7.0 and above. There, download a number of such modules including [Redirecting requests to your application with the HttpRedirection module](http://mvolo.com/blogs/serverside/pages/Redirect-requests-to-your-application-with-the-HttpRedirection-module.aspx), [Nice looking directory listings for your IIS website with DirectoryListingModule](http://mvolo.com/blogs/serverside/archive/2007/01/21/Get-nice-looking-directory-listings-for-your-IIS-website-with-DirectoryListingModule.aspx), [Displaying pretty file icons in your ASP.NET applications with IconHandler](http://mvolo.com/blogs/serverside/archive/2007/01/11/Display-pretty-file-icons-in-your-ASP.NET-applications-with-IconHandler.aspx), and [Stopping hot-linking with IIS and ASP.NET](http://mvolo.com/blogs/serverside/archive/2006/11/10/Stopping-hot_2D00_linking-with-IIS-and-ASP.NET.aspx).

## Prerequisites

To follow the steps in this document, the following IIS 7.0 and above features must be installed.

### ASP.NET

Install ASP.NET via the Windows Vista Control Panel. Select "Programs and Features" - "Turn on or off Windows features". Then open "Internet Information Services" - "World Wide Web Services" - "Application Development Features" and check "ASP.NET".

If you have a Windows Server® 2008 build, open "Server Manager" - "Roles" and select "Web Server (IIS)". Click "Add role services". Under "Application Development," check "ASP.NET".

### Classic ASP

We want to show how ASP.NET modules now work with all content and not just ASP.NET pages, so install classic ASP via the Windows Vista Control Panel. Select "Programs" - "Turn on or off Windows features". Then open "Internet Information Services" - "World Wide Web Services" - "Application Development Features" and check "ASP".

If you have a Windows Server 2008 build, open "Server Manager" - "Roles" and select "Web Server (IIS)". Click "Add role services". Under "Application Development," check "ASP".

## Adding Forms Authentication to Your Application

As part of this task, we enable the ASP.NET Forms-based Authentication for the application. In the next task, we enable the Forms Authentication module to run for all requests to your application, regardless of content type.

First, configure forms authentication as you would for a normal ASP.NET application.

### Creating a Sample Page

To illustrate the feature, we add a default.aspx page to the web root directory. Open notepad (to make sure you have access to the wwwroot directory below, you must run as administrator--right click on Programs\Accessories\Notepad icon, and click "Run as administrator"), and create the following file: `%systemdrive%\inetpub\wwwroot\default.aspx`. Paste the following lines into it:


[!code-aspx[Main](how-to-take-advantage-of-the-iis-integrated-pipeline/samples/sample1.aspx)]


All default.aspx does is display the current time and the name of the logged in user. We use this page later to show forms authentication in action.

### Configuring Forms Authentication and Access Control Rules

Now, to protect default.aspx with forms authentication. Create a web.config file in the `%systemdrive%\inetpub\wwwroot` directory and add the configuration shown below:


[!code-xml[Main](how-to-take-advantage-of-the-iis-integrated-pipeline/samples/sample2.xml)]


This configuration sets the ASP.NET authentication mode to use forms-based authentication, and adds authorization settings to control access to the application. These setting deny access to anonymous users (?) and only allow authenticated users (\*).

### Creating a Membership Provider

**Step 1:** We must provide an authentication store against which the user credentials will be verified. To illustrate the deep integration between ASP.NET and IIS 7.0 and above, we use our own XML-based Membership provider (you can also use the default SQL Server Membership Provider if SQL Server is installed).

Add the following entry right after the initial &lt;configuration&gt;/&lt;system.web&gt; configuration element in the web.config file:


[!code-xml[Main](how-to-take-advantage-of-the-iis-integrated-pipeline/samples/sample3.xml)]


**Step 2:** After the configuration entry is added, you must save the Membership provider code provided in Appendix as **XmlMembershipProvider.cs in your `%systemdrive%\inetpub\wwwroot\App\_Code` directory**. If this directory does not exist, you must create it.

> [!NOTE]
> If using Notepad, be sure to set Save As: All Files to prevent the file from being saved as XmlMembershipProvider.cs.txt.

**Step 3:** All that remains is the actual credential store. Save the xml snippet below as MembershipUsers.xml file in the `%systemdrive%\inetpub\wwwroot\App\_Data` directory.

> [!NOTE]
> If using Notepad, be sure to set Save As: All Files to prevent the file from being saved as MembershipUsers.xml.txt.


[!code-xml[Main](how-to-take-advantage-of-the-iis-integrated-pipeline/samples/sample4.xml)]


If the App\_Data directory does not exist, you must create it.

> [!NOTE]
> Due to security changes in Windows Server 2003 and Windows Vista SP1, you can no longer use the IIS Administration tool to create Membership user accounts for non-GACed Membership providers.

After completing this task, go to the IIS Administration tool and add or delete users for your application. Start "INETMGR" from the "Run…" menu. Open the "+" signs in the tree view on the left until the "Default Web Site" displays. Select "Default Web Site" and then move to the right and click the "Security" category. The remaining features show ".NET Users". Click ".NET Users" and add one or more user accounts of your choice.

Look in MembershipUsers.xml to find the newly created users.

### Creating a Login Page

In order to use forms authentication, we must to create a login page. Open notepad (To make sure you have access to the wwwroot directory below, you need to run as administrator by right clicking on Programs\Accessories\Notepad icon, and clicking "Run as administrator"), and create the login.aspx file in the `%systemdrive%\inetpub\wwwroot` directory. Note - be sure to set Save As: All Files to prevent the file from being saved as login.aspx.txt. Paste the following lines into it:


[!code-aspx[Main](how-to-take-advantage-of-the-iis-integrated-pipeline/samples/sample5.aspx)]


This is the login page to which you are redirected when your authorization rules deny access to a particular resource.

### Testing

Open an Internet Explorer Window and request http://localhost/default.aspx. You see that you are redirected to login.aspx, because initially your were not authenticated, and we withheld access to unauthenticated users earlier. If you successfully log in with one of the username/password pairs specified in MembershipUsers.xml, you get redirected back to default.aspx page originally requested. This page then shows the current time and the user identity with which you authenticated.

At this point, we have successfully deployed a custom authentication solution using Forms Authentication, Login controls, and Membership. This functionality is not new in IIS 7.0 or above – it has been available since ASP.NET 2.0 on previous IIS releases.

However, the problem is that only content handled by ASP.NET is protected.

If you close and re-open the browser window, and request http://localhost/iisstart.htm, you are not prompted for credentials. ASP.NET does not participate in a request for a static file like iisstart.htm. Therefore, it cannot protect it with forms authentication. You see the same behavior with classic ASP pages, CGI programs, PHP or Perl scripts. Forms authentication is an ASP.NET feature, and simply is not available during requests to those resources.


## Enabling Forms Authentication for the Entire Application

In this task, we eliminate the limitation of ASP.NET on previous releases, and enable the ASP.NET Forms Authentication and Url Authorization functionality for the entire application.

In order to take advantage of ASP.NET integration, our application must be configured to run in Integrated mode. The ASP.NET integration mode is configurable per application pool, enabling ASP.NET applications in different modes to be hosted side by side on the same server. The default application pool in which our application lives already uses Integrated mode by default, so we do not need to do anything here.

So, why did we fail to experience the benefits of Integrated mode when we tried to access the static page earlier? The answer lies in the default settings for all ASP.NET modules shipped with IIS 7.0 and above.

### Taking Advantage of the Integrated Pipeline

The default configuration for all managed modules shipped with IIS 7.0 and above, including the Forms Authentication and URL Authorization modules, uses a precondition so that these modules only apply to content that an (ASP.NET) handler manages. This is done for backwards compatibility reasons.

By removing the precondition, we make the desired managed module execute for all requests to the application, regardless of content. This is necessary in order to protect our static files, and any other application content with Forms-based authentication.

To do this, open the application's web.config file located in the `%systemdrive%\inetpub\wwwroot` directory, and paste the following lines immediately below the first &lt;configuration&gt; element:


[!code-xml[Main](how-to-take-advantage-of-the-iis-integrated-pipeline/samples/sample6.xml)]


This configuration re-adds the module elements without the precondition, enabling them to execute for all requests to the application.

### Testing

Close all instances of Internet Explorer so that the credentials entered before are no longer cached. Open Internet Explorer, and make a request to the application at the following URL:


[!code-console[Main](how-to-take-advantage-of-the-iis-integrated-pipeline/samples/sample7.cmd)]


You are redirected to the login.aspx page in order to log in.

Log in with a username/password pair used previously. When you successfully log in, you are redirected back to the original resource, which displays the IIS welcome page.

> [!NOTE]
> Even though you requested a static file, the managed forms authentication module and the URL authorization module provided their services in order to protect your resource.

To illustrate this even further, we add a classic ASP page and protect it with Forms Authentication.

Open notepad (to make sure you have access to the wwwroot directory below, you must run as administrator--right click on Programs\Accessories\Notepad icon, and click "Run as administrator"), and create a **page.asp** file in your `%systemdrive%\inetpub\wwwroot` directory.

> [!NOTE]
> If using Notepad, be sure to set Save As: All Files to prevent the file from being saved as page.asp.txt. Paste the lines below into it:


[!code-aspx[Main](how-to-take-advantage-of-the-iis-integrated-pipeline/samples/sample8.aspx)]


Close all Internet Explorer instances again-- otherwise, your credentials are still cached and request http://localhost/page.asp. You are again redirected to the login page, and after successful authentication, display the ASP page.

Congratulations – you have successfully added managed services to the server, enabling them for all requests to the server regardless of handler!


## Summary

This walkthrough demonstrated how the ASP.NET Integrated mode can be leveraged to make powerful ASP.NET features available to not just ASP.NET pages, but to the entire application.

More importantly, you can now build new managed modules using the familiar ASP.NET 2.0 APIs that have the ability to execute for all application content, and provided an enhanced set of request processing services to your application.

Feel free to check out the blog, [http://www.mvolo.com/](http://www.mvolo.com/), for more tips on taking advantage of Integrated mode and developing IIS modules that leverage the ASP.NET integration in IIS 7 and above. There, you can also download a number of such modules including [Redirecting requests to your application with the HttpRedirection module](http://mvolo.com/blogs/serverside/pages/Redirect-requests-to-your-application-with-the-HttpRedirection-module.aspx), [Nice looking directory listings for your IIS website with DirectoryListingModule](http://mvolo.com/blogs/serverside/archive/2007/01/21/Get-nice-looking-directory-listings-for-your-IIS-website-with-DirectoryListingModule.aspx), [Displaying pretty file icons in your ASP.NET applications with IconHandler](http://mvolo.com/blogs/serverside/archive/2007/01/11/Display-pretty-file-icons-in-your-ASP.NET-applications-with-IconHandler.aspx), and [Stopping hot-linking with IIS and ASP.NET](http://mvolo.com/blogs/serverside/archive/2006/11/10/Stopping-hot_2D00_linking-with-IIS-and-ASP.NET.aspx).


## Appendix

This Membership provider is based on the sample XML membership provider found in this [MSDN article](https://msdn.microsoft.com/en-us/library/aa479031.aspx).

To use this Membership provider, save the code as **XmlMembershipProvider.cs** in your `%systemdrive%\inetpub\wwwroot\App\_Code` directory. If this directory doesn't exist you will have to create it. Note - be sure to set Save As: All Files if using Notepad to prevent the file from being saved as XmlMembershipProvider.cs.txt.

> [!NOTE]
> This membership provider sample is for the purposes of this demo only. It does not conform to the best practices and security requirements for a production Membership provider, including storing passwords securely and auditing user actions. Do not use this membership provider in your application!

[!code-csharp[Main](how-to-take-advantage-of-the-iis-integrated-pipeline/samples/sample9.cs)]