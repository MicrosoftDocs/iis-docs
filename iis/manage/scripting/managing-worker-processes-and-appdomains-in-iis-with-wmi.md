---
title: "Managing Worker Processes and AppDomains in IIS 7 with WMI | Microsoft Docs"
author: rick-anderson
description: "WMI scripting lets you manage worker processes and application domains (AppDomains) in IIS with relative ease. IIS worker processes are spawned by the Window..."
ms.author: iiscontent
manager: soshir
ms.date: 11/23/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/scripting/managing-worker-processes-and-appdomains-in-iis-with-wmi
msc.type: authoredcontent
---
Managing Worker Processes and AppDomains in IIS 7 with WMI
====================
by Tim Ammann

## Introduction

WMI scripting lets you manage worker processes and application domains (AppDomains) in IIS with relative ease. IIS worker processes are spawned by the Windows Process Activation Service (WAS) and executed by W3wp.exe. Worker processes can contain AppDomains that are typically created in response to a request for an .aspx page.

This article describes how to accomplish, with just a few lines of VBScript, the following tasks:

- View the currently executing requests for a worker process
- Get the state of all worker processes
- Unload a specific AppDomain or all AppDomains
- Display all AppDomains and their properties

## First Steps


1. Make sure IIS and scripting are enabled.


> a. If you are using Windows Vista, open Control Panel, Programs and Features, and then Windows Features. Under "Web Management Tools," select "IIS Management Scripts and Tools" to enable scripting.   
> b. If you are using Windows Server® 2008, open Server Manager. Use the Add Roles Wizard to install the IIS Web server. On the Select Role Services page, in the Management Tools section, select "IIS Management Scripts and Tools."


2. Run commands as administrator. To open an elevated Command Prompt window, click Start, point to All Programs, click Accessories, right-click Command Prompt, and then click Run as administrator. If you open a command shell as administrator, all applications that you run from that command shell will run as administrator.

3. Save the script files in text format with a .vbs extension. They can be run at the command prompt by using the syntax "cscript.exe *&lt;scriptname&gt;*.vbs".

4. Before you start, make a backup of the System32\inetsrv\config\applicationhost.config file with the AppCmd tool. The backup copy will enable you to restore IIS to its original state by just copying the original version over the later one. To make a backup, follow these steps:

a. Open an elevated Command Prompt window.  
 b. Type cd %Windir%\system32\inetsrv\  
 c.Type appcmd add backup *backupName* to back up the ApplicationHost.config file, where *backupName* is the name that you specify for the backup. A directory with the backup name that you specify will be created under the %Windir%\system32\inetsrv\backup directory. If you do not specify a name, appcmd will generate a directory name automatically using the current date and time.

## Worker Processes

This section shows you how to retrieve the currently executing requests for each worker process on a Web server. You then learn how to display the each worker process PID, state, and the application pool to which it belongs.

### Get Executing Requests

One exciting new feature of IIS is the ability to see the requests that are currently executing in a worker process. You can do this with the WorkerProcess.GetExecutingRequests method.

The WorkerProcess.GetExecutingRequests method reports in a snapshot manner the requests that were executing at the time that the method was run. Because most requests execute very quickly, it may not be easy for you to test the method manually with a Web browser. For this reason, you will create a Web page just for this purpose.

Use notepad to put the following text into a text file. Then, save the file by using the name Sleep.aspx.

[!code-xml[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample1.xml)]

Put the Sleep.aspx file in the content directory of the default Web site: %systemdrive%\inetpub\wwwroot.

The Sleep.aspx file that you created forces the request for the Web page to take 30 seconds to execute. This will give you time to run a script that will show GetExecutingRequests in action.

The GetExecutingRequests method takes an empty array variable as an OUT parameter, which it then fills with HttpRequest objects. You can iterate through these requests to show the attributes for each request. The following script takes the HttpRequest object output and displays the current module, verb, host name, and URL for each request.

Copy the following script into notepad and save it with the filename GetRequests.vbs.

[!code-vb[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample2.vb)]

Open an elevated command prompt window and navigate to the directory in which you saved the GetRequests.vbs file.

Before you run the script, type [http://localhost/sleep.aspx](http://localhost/sleep.aspx) into the address bar of a Web browser. This will start the request execution and set the browser spinning for 30 seconds while it waits to render the Sleep.aspx page.

While the browser is still waiting to render the page, run the script by typing the following in the command prompt window you just opened:

[!code-console[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample3.cmd)]

#### Sample Output

The output you see should resemble the following.


[!code-console[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample4.cmd)]


### Getting the State of a Worker Process

The WorkerProcess object in the IIS WMI provider has a GetState method that reveals whether a worker process is starting, running, or stopping. WorkerProcess also has two properties that interest us here: ApplicationPool and PID. The ApplicationPool property represents the application pool to which the worker process belongs. The PID property contains the process ID that uniquely identifies the worker process.

You can use the following code to list each worker process PID and state, and its application pool. If no worker processes are running, the script will exit silently. Copy the code into notepad and save it with the filename GetState.vbs.

[!code-vb[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample5.vb)]

Open an elevated command prompt window and navigate to the directory in which you saved the GetState.vbs file. Run the script by typing the following in the command prompt window you just opened:

[!code-console[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample6.cmd)]

#### Sample Output

Your output should resemble this:


[!code-console[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample7.cmd)]


Now that you have learned to use WMI scripting to reveal the secrets of worker processes, do the same for application domains.


## AppDomains

The first time a request for an ASP.NET page is received, the IIS managed engine module creates an application domain (AppDomain) in memory. The AppDomain processes requests for aspx pages, or any page that uses managed code. Unloading and enumerating AppDomains by using WMI is easy, and this section shows you how to do both.

### Unloading a Specific AppDomain

AppDomain unloading in IIS 7 and above works somewhat differently than in IIS 6.0. Whereas the IIS 6.0 AppUnload command unloaded out-of-process ASP applications, the IIS 7 and above AppDomain.Unload method unloads only ASP.NET application domains. The AppUnload functionality has disappeared because the IIS 5.0 compatibility mode that it supported is no longer present in IIS 7 and above.

To unload a specific AppDomain, you must be able to uniquely identify it. AppDomain objects have three key properties: ApplicationPath, ID, and SiteName. However, just one of these may be sufficient for your purposes.

Incidentally, the AppDomain ID property is not a number, but a path that looks like this:


[!code-console[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample8.cmd)]


The "1" in the path listed is the Site ID (by default, 1 corresponds to the default Web site.) If you must generate a list of your server's AppDomains and their properties first, see the "Enumerating AppDomains" section later in this article.

The next script unloads the AppDomain called "Northwind." The script iterates through the available AppDomains until it finds the one with the matching ApplicationPath. Copy the code into notepad, replace "Northwind" with the AppDomain application path of your choice, and save the file with the name AppDomainUnload.vbs.

Open an elevated command prompt window and navigate to the directory in which you saved the AppDomainUnload.vbs file. Run the script by typing the following in the command prompt window you just opened:

[!code-console[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample9.cmd)]

[!code-vb[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample10.vb)]

### Unloading All AppDomains

Unloading all AppDomains on a server is even easier: you simply retrieve them, iterate through them, and unload each in turn.

The following example unloads all application domains on an IIS Web server. Note how a simple WQL query (WQL is WMI's version of SQL) is used to retrieve the AppDomains.

Copy the code into notepad and save the file with the name AppDomainUnloadAll.vbs. Open an elevated command prompt window and navigate to the directory in which you saved the AppDomainUnloadAll.vbs file. Run the script by typing the following in the command prompt window you just opened:

[!code-console[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample11.cmd)]

[!code-vb[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample12.vb)]

As an alternative to the WQL query syntax, you can use the WMI InstancesOf method, just as you did earlier with WorkerProcess:


[!code-console[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample13.cmd)]


### Enumerating AppDomains

You can display all currently running AppDomains and their properties by using an approach similar to that of the previous scripts. Here is a list of AppDomain properties:

> ApplicationPath  
> Id  
> IsIdle  
> PhysicalPath  
> ProcessId  
> SiteName


The following script shows all properties for each AppDomain except the Physical Path property, but you can add this easily enough. For convenience, the script displays the key and run-time properties separately.

Copy the code into notepad and save the file with the name AppDomainProps.vbs. Open an elevated command prompt window and navigate to the directory in which you saved the AppDomainProps.vbs file. Run the script by typing the following in the command prompt window you just opened:

[!code-console[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample14.cmd)]

[!code-vb[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample15.vb)]

#### Sample Output

Your output should look like the following:


[!code-console[Main](managing-worker-processes-and-appdomains-in-iis-with-wmi/samples/sample16.cmd)]


## Conclusion

This article showed some basic WMI scripting techniques for retrieving information about IIS worker processes and AppDomains. The WMI InstanceOf method and WQL queries were used to retrieve them. Here is a brief review of the tasks presented and the methods that were used:

- View the currently executing requests for a worker process: **WorkerProcess.GetExecutingRequests**
- Get the state of all worker processes: **WorkerProcess.GetState**
- Unload a specific AppDomain or all AppDomains: **AppDomain.Unload**

For more information, see the [IIS 7.0 WMI Provider Reference](https://go.microsoft.com/fwlink/?LinkId=79310).