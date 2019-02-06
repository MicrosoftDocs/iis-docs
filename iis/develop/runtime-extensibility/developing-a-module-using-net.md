---
title: "Developing a Module Using .NET"
author: leanserver
description: "IIS 7.0 and above allows for extending the server by modules which are developed in two ways: Using managed code, and the ASP.NET server extensibility APIs U..."
ms.date: 11/24/2007
ms.assetid: d3c8271b-f860-43ca-b01a-85bfc35667f5
msc.legacyurl: /learn/develop/runtime-extensibility/developing-a-module-using-net
msc.type: authoredcontent
---
Developing a Module Using .NET
====================
by [Mike Volodarsky](https://github.com/leanserver)

## Introduction

IIS 7.0 and above allows for extending the server by modules which are developed in two ways:

- Using managed code, and the ASP.NET server extensibility APIs
- Using native code, and the IIS native server extensibility APIs

In the past, ASP.NET modules were limited in functionality, as the ASP.NET request processing pipeline was separate from the main server request pipeline.

In IIS, managed modules become virtually as powerful as native modules with the Integrated Pipeline architecture. Most important, the services that managed modules provide can now be applied to all requests to the server, not just to requests to ASP.NET content like ASPX pages. Managed modules are configured and managed in a consistent manner with native modules, and can execute in the same processing stages and orderings as native modules. Finally, managed modules can perform a wider set of operations to manipulate request processing via several added and enhanced ASP.NET APIs.

This article illustrates extending the server with a managed module in order to add the ability to perform basic authentication against an arbitrary credential store, such as the provider-based credential infrastructure in the ASP.NET 2.0 Membership system.

This allows replacing the built in basic authentication support in IIS, which is tied to the Windows credential store, with one that supports arbitrary credential stores, or any of the existing Membership providers shipped with ASP.NET 2.0 like SQL Server, SQL Express, or Active Directory.

This article examines the following tasks:

- Developing a managed module using ASP.NET APIs
- Deploying a managed module on the server

To learn more about the basics of developing IIS modules and handlers, see [Developing IIS7 modules and handlers with the .NET framework](http://mvolo.com/redirect-requests-to-your-application-with-the-httpredirection-module/).

You can also find lots of resources and tips on writing IIS modules on the blog, [http://www.mvolo.com/](http://www.mvolo.com/), as well as download existing IIS modules for your applications. For some examples, see [Redirecting requests to your application with the HttpRedirection module](http://mvolo.com/blogs/serverside/pages/Redirect-requests-to-your-application-with-the-HttpRedirection-module.aspx), [Nice looking directory listings for your IIS website with DirectoryListingModule](http://mvolo.com/get-nice-looking-directory-listings-for-your-iis-website-with-directorylistingmodule/), and [Displaying pretty file icons in your ASP.NET applications with IconHandler](http://mvolo.com/display-pretty-file-icons-in-your-aspnet-applications-with-iconhandler/).

> [!NOTE]
> The code provided in this article is written in C#.

## Prerequisites

To follow the steps in this document, you must have the following IIS features installed:

### ASP.NET

Install ASP.NET via the Windows Vista Control Panel. Select "Programs" - "Turn on or off Windows features". Then open "Internet Information Services" - "World Wide Web Services" - "Application Development Features" and check "ASP.NET".

If you have a Windows Server® 2008 build, open "Server Manager" - "Roles" and select "Web Server (IIS)". Click "Add role services". Under "Application Development" check "ASP.NET".

### Background Information on Basic Authentication

Basic authentication is an authentication scheme defined in the HTTP.1 protocol ([RFC 2617](http://www.faqs.org/rfcs/rfc2617.html)). It uses a standard challenge-based mechanism that works as follows at a high level:

- Browser makes request to a URL with no credentials
- If the server requires authentication for that URL, it responds with a 401 Access Denied message, and includes a header that indicates that the basic authentication scheme is supported
- Browser receives the response, and if configured, will prompt the user for a username/password that it will include in plain text inside a request header for the next request to the URL
- Server receives the username / password inside a header, and uses them for authentication

> [!NOTE]
> While a detailed discussion of this authentication protocol is outside the scope of this article, its worth mentioning that the basic authentication scheme requires SSL to be secure, as it sends the username/password in plain text.

IIS includes support for basic authentication against the Windows accounts stored in the local account store or Active Directory for domain accounts. We want to enable our user to authenticate using basic authentication, but to validate credentials using ASP.NET 2.0 [Membership](https://www.asp.net/QUICKSTART/aspnet/doc/security/default.aspx) service instead. This gives the freedom to store user information in a variety of existing Membership providers, such as SQL server, without being tied to Windows accounts.

## Task 1: Developing a Module using .NET

In this task, we examine the development of an authentication module that supports the HTTP.1 basic authentication scheme. This module was developed using the standard ASP.NET module pattern available since ASP.NET v1.0. This same pattern is used to build ASP.NET modules that extend the IIS server. In fact, existing ASP.NET modules written for previous versions of IIS can be used on IIS, and take advantage of better ASP.NET integration to provide more power to the web applications which use them.

> [!NOTE]
> The full code for the module is provided in Appendix A.

A managed module is a .NET class that implements the **System.Web.IHttpModule** interface. The primary function of this class is to register for one or more events that occur within IIS request processing pipeline, and then perform some useful work when IIS invokes the module's event handlers for those events.

Lets create a new source file named "BasicAuthenticationModule.cs", and create the module class (the complete source code is provided in Appendix A):


[!code-csharp[Main](developing-a-module-using-net/samples/sample1.cs)]


The primary function of the **Init** method is wiring the module's event handler methods to the appropriate request pipeline events. The module's class provides the event handle methods, and they implement the desired functionality provided by the module. This is discussed further in detail.

The **Dispose** method is used to clean up any module state when the module instance is discarded. It is typically not implemented unless the module uses specific resources that require to be released.

### Init()

After creating the class, the next step is to implement the **Init** method. The only requirement is to register the module for one or more request pipeline events. Wire up module methods, which follow the System.EventHandler delegate signature, to the desired pipeline events exposed on the provided System.Web.HttpApplication instance:


[!code-csharp[Main](developing-a-module-using-net/samples/sample2.cs)]


The **AuthenticateUser** method is invoked on every request during the **AuthenticateRequest** event. We utilize it to authenticate the user based on the credential information present in the request.

The **IssueAuthenticationChallenge** method is invoked on every request during the **EndRequest** event. It is responsible for issuing a basic authentication challenge back to the client whenever the authorization module rejects a request, and authentication is needed.

### AuthenticateUser()

Implement the **AuthenticateUser** method. This method does the following:

- Extract the basic credentials if present from the incoming request headers. To see the implementation of this step, see the **ExtractBasicAuthenticationCredentials** utility method.
- Attempts to validate the provided credentials via Membership (using the default membership provider configured). To see the implementation of this step, see the **ValidateCredentials** utility method.
- Creates a user principal identifying the user if the authentication is successful, and associates it with the request.

At the end of this processing, if the module was successfully able to obtain and validate the user credentials, it will produce an authenticated user principal that other modules and application code later use in access control decisions. For example, the URL authorization module examines the user in the next pipeline event in order to enforce the authorization rules configured by the application.

### IssueAuthenticationChallenge()

Implement the **IssueAuthenticationChallenge** method. This method does the following:

- Check the response status code to determine whether this request was rejected.
- If so, issue a basic authentication challenge header to the response to trigger the client to authenticate.

## Utility Methods

Implement the utility methods that the module uses, including:

- **ExtractBasicAuthenticationCredentials**. This method extracts the basic authentication credentials from the Authorize request header, as specified in the basic authentication scheme.
- **ValidateCredentials**. This method attempts to validate user credentials by using Membership. The Membership API abstracts the underlying credential store, and allows the credential store implementations to be configured by adding / removing Membership providers through configuration.

> [!NOTE]
> In this sample, the Membership validation is commented out, and instead the module simply checks whether the username and password are both equal to the string "test". This is done for clarity, and is not intended for production deployments. You are invited to enable Membership-based credential validation by simply un-commenting the Membership code inside ValidateCredentials, and configuring a Membership provider for your application. See Appendix C for more information.

## Task 2: Deploy the module to the application

After creating the module in the first task, we next add it to the application.

### Deploy to Application

First, deploy the module to the application. Here, you have several options:

- Copy the source file containing the module into the **/App\_Code** directory of the application. This does not require compiling the module - ASP.NET automatically compiles and loads the module type when the application starts up. Simply save this source code as BasicAuthenticationModule.cs inside the /App\_Code directory of your application. Do this if you do not feel comfortable with the other steps.
- Compile the module into an assembly, and drop this assembly in the **/BIN** directory of the application. This is the most typical option if you only want this module to be available to this application, and you do not want to ship the source of the module with your application. Compile the module source file by running the following from a command line prompt:  
  
	`<PATH\_TO\_FX\_SDK>csc.exe /out:BasicAuthenticationModule.dll /target:library BasicAuthenticationModule.cs`

    Where &lt;PATH\_TO\_FX\_SDK&gt; is the path to the .NET Framework SDK that contains the CSC.EXE compiler.
- Compile the module into a strongly named assembly, and register this assembly in the GAC. This is a good option if you want multiple applications on your machine to use this module. To learn more about building strongly named assemblies, see this [MSDN article](https://msdn.microsoft.com/en-us/library/xwb8f617%28VS.80%29.aspx) .

Before making configuration changes in the application's web.config file, we must unlock some of the configuration sections that are locked at the server level by default. Run the following from an Elevated command prompt (Start &gt; Right click on Cmd.exe and choose "Run as Administrator"):


[!code-console[Main](developing-a-module-using-net/samples/sample3.cmd)]


After running these commands, you will be able to define these configuration sections in your application's web.config file.

Configure your module to run in the application. Start by creating a new web.config file, which will contain the configuration necessary to enable and use the new module. Start by adding the text below and saving it to the root of your application (`%systemdrive%\inetpub\wwwroot\web.config` if using the root application in the Default Web Site).


[!code-xml[Main](developing-a-module-using-net/samples/sample4.xml)]


Before enabling the new basic authentication module, disable all the other IIS authentication modules. By default, only Windows authentication and anonymous authentication are enabled. Because we do not want the browser to attempt authenticating with your Windows credentials or allow anonymous users, we disable both the Windows Authentication module and the Anonymous authentication module.

Now enable the module by adding it to the list of modules loaded by our application. Open web.config once again and add the entry inside to the `<modules>` tag


[!code-xml[Main](developing-a-module-using-net/samples/sample5.xml)]


You can also deploy the module by using either the IIS Administration Tool, or the APPCMD.EXE command line tool.

The final contents of the application's web.config file after these changes are provided in Appendix B.

Congratulations, you have finished configuring the custom basic authentication module.

Let's try it! Open Internet Explorer, and make a request to the application at the following URL:

[**`http://localhost/`**](http://localhost/)

You should see the basic authentication login dialog. Enter "test" in the "User name:" field and "test" in the "Password:" field to get access. Note that if you copy HTML, JPG, or any other content to your application, they too will be protected by your new BasicAuthenticationModule.

## Summary

In this article, you learned how to develop and deploy a custom managed module for an application, and enable that module to provide services for all requests to the application.

You also witnessed the power of developing server components in managed code. This allowed developing a basic authentication service that is decoupled from the Windows credential storage.

If you are adventurous, configure this module to leverage the power of the ASP.NET 2.0 Membership application services to support pluggable credential stores. See Appendix C for more information.

Find many resources and tips on writing IIS modules in the blog, [http://www.mvolo.com/](http://www.mvolo.com/), as well as download existing IIS modules for your applications. For some examples, see [Redirecting requests to your application with the HttpRedirection module](http://mvolo.com/redirect-requests-to-your-application-with-the-httpredirection-module/), [Nice looking directory listings for your IIS website with DirectoryListingModule](http://mvolo.com/get-nice-looking-directory-listings-for-your-iis-website-with-directorylistingmodule/), and [Displaying pretty file icons in your ASP.NET applications with IconHandler](http://mvolo.com/display-pretty-file-icons-in-your-aspnet-applications-with-iconhandler/).

## Appendix A: Basic Authentication Module Source Code

Save this source code as BasicAuthenticationModule.cs inside the /App\_Code directory to quickly deploy it to your application.

> [!NOTE]
> If you are using Notepad, make sure to set Save As: All Files to avoid saving the file as BasicAuthenticationModule.cs.txt.


[!code-csharp[Main](developing-a-module-using-net/samples/sample6.cs)]


## Appendix B: Web.config for Basic Auth Module

Save this configuration as web.config file in the root of your application:


[!code-xml[Main](developing-a-module-using-net/samples/sample7.xml)]


## Appendix C: Configuring Membership

The ASP.NET 2.0 Membership service enables applications to quickly implement credential validation and user management required by most authentication and access control schemes. Membership isolates the application code from the actual credential store implementation, and provides a number of options for integrating with existing credential stores.

To take advantage of Membership for this module sample, uncomment a call to Membership.ValidateUser inside the ValidateCredentials method, and configure a Membership provider for your application. You can learn more about configuring Membership in this [MSDN article](https://msdn.microsoft.com/en-us/library/6e9y4s5t%28VS.80%29.aspx).