---
title: "Develop a Native C\C++ Module for IIS 7.0 | Microsoft Docs"
author: leanserver
description: "IIS 7.0 and above allows for extending the server by modules which are developed in two ways: Using managed code, and the ASP.NET server extensibility APIs U..."
ms.author: iiscontent
manager: soshir
ms.date: 11/24/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-develop
ms.prod: iis
msc.legacyurl: /learn/develop/runtime-extensibility/develop-a-native-cc-module-for-iis
msc.type: authoredcontent
---
Develop a Native C\C++ Module for IIS 7.0
====================
by [Mike Volodarsky](https://github.com/leanserver)

## Introduction

IIS 7.0 and above allows for extending the server by modules which are developed in two ways:

- Using managed code, and the ASP.NET server extensibility APIs
- Using native code, and the IIS native server extensibility APIs

Unlike the previous versions of IIS, the majority of server extensibility scenarios does not require native (C++) code development, and can be accommodated using managed code and the ASP.NET APIs. Using ASP.NET to extend the server allows you to reduce dramatically development time, and to take advantage of the rich functionality of ASP.NET and the .NET Framework. To learn more about extending IIS with ASP.NET, see [Developing an IIS Module with .NET](developing-a-module-using-net.md).

IIS also provides a (C++) native core server API, which replaces ISAPI filter and extension API from previous IIS releases. If you have specific requirements that demand native code development, or would like to convert your existing native ISAPI components, take advantage of this API to build server components. The new native server API features object-oriented development with an intuitive object model, provides more control over request processing, and uses simpler design patterns to help you write robust code.

This walkthrough examines the following tasks:

- Developing a native module using the native (C++) server API
- Deploying a native module on the server

In order to compile the module, you must install the Platform SDK that contains the IIS header files. The latest Windows Vista Platform SDK is available [here](https://msdn.microsoft.com/windowsvista/downloads/products/getthebeta/default.aspx).

In order to use the Platform SDK with Visual Studio 2005, you must register the SDK. After you have installed the SDK, do this via **Start &gt; Programs &gt; Microsoft Windows SDK &gt; Visual Studio Registration &gt; Register Windows SDK Directories with Visual Studio**.

The source code for this module is available in the [Visual Studio IIS7 Native Module Sample](https://www.iis.net/downloads?tabid=34&g=6&i=1301).

## Develop a Native Module

In this task, we examine the development of a native module using the new native (C++) server API. A native module is a Windows DLL that contains the following:

- **RegisterModule** exported function. This function is responsible for creating a module factory, and registering the module for one or more server events.
- Implementation of the module class inheriting from the **CHttpModule** base class. This class provides the main functionality of your module.
- Implementation of the module factory class implementing the **IHttpModuleFactory** interface. The class is responsible for creating instances of your module.

> [!NOTE]
> In some cases, you can also implement the **IGlobalModule** interface, in order to extend some of the server functionality that is not related to request processing. This is an advanced topic and is not covered in this walkthrough.

Your native module has the following life cycle:

1. When the server worker process starts, it will load the DLL containing your module, and invoke its exported **RegisterModule** function. In this function, you:

> a. Create the module factory.   
> b. Register the module factory for the request pipeline events your module implements.


2. When a request arrives, the server:

> a. Creates an instance of your module class using the factory you provided.   
> b. Calls the appropriate event handler method on the module instance for each of the request events you registered for.   
> c. Disposes the instance of the module at the end of request processing.


Now, to build it.

The full source code for the module is available in the [Visual Studio IIS7 Native Module Sample](https://www.iis.net/downloads?tabid=34&g=6&i=1301). The steps below are the most important for developing the module, and do not include supporting code and error handling.

Implement the **RegisterModule** function that the server invokes when the module DLL is loaded. Its signature and the rest of the native API is defined in the **httpserv.h** header file, which is part of the Platform SDK (if you do not have the Platform SDK, please see the [Introduction](https://www.iis.net/overview) for information on obtaining it):

**main.cpp**:


[!code-unknown[Main](develop-a-native-cc-module-for-iis/samples/sample-127057-1.unknown)]


### The RegisterModule

There are three basic tasks we need to accomplish inside **RegisterModule:** 

#### Save the Global State

We will store the global server instance, and the module context id for later use in global variables. While this example does not use this information, many modules find it useful to save and use later during request processing. The **IHttpServer** interface provides access to many server functions, such as opening files, and accessing the cache. The module context id is used to associate the custom module state with several server objects, such as request and application.

#### Create Module Factory

We will implement our factory class, **CMyHttpModuleFactory**, later in this walkthrough. This factory is responsible for manufacturing instances of our module for each request.

#### Register the Module Factory for the Desired Request Processing Events

The registration is done through the **SetRequestNotificatons** method, which instructs the server: to create our module instance for each request using the specified factory; and, to invoke the appropriate event handlers on it for each of the specified request processing stages.

In this case, we are only interested in the RQ\_ACQUIRE\_REQUEST\_STATE stage. The complete list of the stages that comprise the request processing pipeline is defined in **httpserv.h**:


[!code-unknown[Main](develop-a-native-cc-module-for-iis/samples/sample-127057-2.unknown)]


In addition, you can subscribe to several non-deterministic events that may occur during request processing due to actions that other modules take, such as flushing the response to client:


[!code-unknown[Main](develop-a-native-cc-module-for-iis/samples/sample-127057-3.unknown)]


In order for our **RegisterModule** implementation to be accessible to the server, we must export it. Use a .DEF file that contains the EXPORTS keyword to export our RegisterModule function.

Next, implement the module factory class:

**mymodulefactory.h:** 


[!code-csharp[Main](develop-a-native-cc-module-for-iis/samples/sample4.cs)]


The module factory implements the **IHttpModuleFactory** interface, and serves to create instances of the module on each request.

The server calls the **GetHttpModule** method at the beginning of every request to obtain the instance of the module to use for this request. The implementation simply returns a new instance of our module class, **CMyHttpModule**, which we implement next. As we see shortly, this enables us to store request state easily without worrying about thread safety, because the server always create and uses a new instance of the module for each request.

More advanced factory implementations may decide to use a singleton pattern instead of creating a new instance each time, or use the provided **IModuleAllocator** interface to allocate module memory in the request pool. These advanced patterns are not discussed in this walkthrough.

The **Terminate** method is called by the server when the worker process shuts down to perform final cleanup of the module. If you initialize any global state in **RegisterModule**, implement its cleanup in this method.

### Implementing the Module Class

This class is responsible for providing the main functionality of the module during one or more server events:

**myhttpmodule.h:** 


[!code-csharp[Main](develop-a-native-cc-module-for-iis/samples/sample5.cs)]


The module class inherits from the **CHttpModule** base class, which defines an event handler method for each of the server events discussed earlier. When the request processing pipeline executes each event, it invokes the associated event handler method on each of the module instances that have registered for that event.

Each event handler method has the following signature:


[!code-unknown[Main](develop-a-native-cc-module-for-iis/samples/sample-127057-6.unknown)]


The **IHttpContext** interface provides access to the request context object, which can be used to perform request processing tasks such as inspecting the request, and manipulating the response.

The **IHttpEventProvider** interface is replaced with a more specific interface for each of the events that provide specific functionality to the module. For example, the **OnAuthenticateRequest** event handler receives the **IAuthenticationProvider** interface that allows the module to set the authenticated user.

The return of each event handler method is one of the values of the REQUEST\_NOTIFICATION\_STATUS enumeration. You must return RQ\_NOTIFICATION\_CONTINUE if the module successfully performed the task; the pipeline should continue execution.

If a failure occurred and you want to abort request processing with an error, you must set the error status and return RQ\_NOTIFICATION\_FINISH\_REQUEST. The RQ\_NOTIFICATION\_PENDING return allows you to perform work asynchronously, and to let go of the thread processing the request so it can be reused for another request. Asynchronous execution is not discussed in this article.

Our module class overrides the OnAcquireRequestState event handler method. In order to provide functionality in any of the pipeline stages, the module class must override the respective event handler method. If you register for an event in **RegisterModule**, but do not override the appropriate event handler method on your module class, your module will fail at runtime (and trigger a debug-time assertion if compiled in the debug mode). Be careful and make sure that the method signature of the overriding method is exactly equivalent to the base class method of the **CHttpModule** class you are overriding.

### Compiling the Module

Remember, you require the Platform SDK in order to compile. See the [Introduction](https://www.iis.net/overview) for more information about obtaining it and enabling Visual Studio to reference it.

## Deploying a Native Module

After you have compiled your module, you must deploy it on the server. Compile the module, and then copy IIS7NativeModule.dll (and the IIS7NativeModule.pdb debugging symbols file if desired) to any location on the machine running IIS.

Native modules, unlike managed modules that can be added directly to the application, need to first be installed on the server. This requires Administrative privileges.

In order to install a native module, you have several options:

- **Use APPCMD.EXE command line tool**  
 APPCMD makes module installation simple. Go to Start&gt;Programs&gt;Accessories, Right click on the Command Line Prompt, and choose Run As Administrator. In the command line window, execute the following:  
    **%systemroot%\system32\inetsrv\appcmd.exe install module /name:MyModule /image:[FULL\_PATH\_TO\_DLL]**  
 Where [FULL\_PATH\_TO\_DLL] is the full path to the compiled DLL containing module you just built.
- **Use the IIS Administration Tool**  
 This enables you to add a module by using a GUI. Go to Start&gt;Run, type in inetmgr, and press Enter. Connect to localhost, locate the Modules task, and double-click to open it. Then, click the     **Add a Native Module** task on the right pane.
- **Install the module manually**  
 Install the module manually by adding it to the &lt;system.webServer&gt;/&lt;globalModules&gt; configuration section in applicationHost.config configuration file, and add a reference to it in the &lt;system.webServer&gt;/&lt;modules&gt; configuration section in the same file in order to enable it. We recommend that you use one of the previous two options to install the module instead of editing the configuration directly.

The task is complete--we have finished configuring the new native module.

## Summary

In this walkthrough, you learned how to develop and deploy a custom native module using the new native (C++) extensibility APIs. Please consult the [IIS 7.0 SDK documentation](https://msdn.microsoft.com/en-us/library/ms692515.aspx) to learn more about the native (C++) server APIs.

To learn about extending IIS using managed code and the .NET framework, see [Developing an IIS module With .NET](developing-a-module-using-net.md). To learn more about managing IIS modules, see the [module overview white paper](../../get-started/introduction-to-iis/iis-modules-overview.md).
  
  
[Discuss in IIS Forums](https://forums.iis.net/1042.aspx)