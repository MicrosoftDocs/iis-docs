---
title: "Managing Applications and Application Pools on IIS 7.0 with WMI | Microsoft Docs"
author: rick-anderson
description: "Managing application and application pools on IIS 7.0 and above can be performed with relative ease by using WMI scripting. This article describes how to acc..."
ms.author: iiscontent
manager: soshir
ms.date: 11/23/2007
ms.topic: article
ms.assetid: 4d472865-8cb2-469d-903f-b246992706c9
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/scripting/managing-applications-and-application-pools-on-iis-with-wmi
msc.type: authoredcontent
---
Managing Applications and Application Pools on IIS 7.0 with WMI
====================
by Tim Ammann

## Introduction

Managing application and application pools on IIS 7.0 and above can be performed with relative ease by using WMI scripting. This article describes how to accomplish the following entry-level tasks with just a few lines of VBScript:

- Create and enumerate applications
- Create, configure, and delete application pools
- Start, stop, and recycle application pools
- View the state of application pools
- List all the application pools on the server

## First Steps

1. Make sure IIS and scripting are enabled. 

    - If you are using Windows Vista, open Control Panel, Programs and Features, and then Windows Features. Under "Web Management Tools," select "IIS Management Scripts and Tools" to enable scripting.
    - If you are using Windows Server® 2008, open Server Manager. Use the Add Roles Wizard to install the IIS 7.0 Web server. On the Select Role Services page, in the Management Tools section, select "IIS Management Scripts and Tools."
2. Run commands as administrator. To open an elevated Command Prompt window, click Start, point to All Programs, click Accessories, right-click Command Prompt, and then click Run as administrator. If you open a command shell as administrator, all applications that you run from that command shell will run as administrator.
3. Save the script files in text format with a .vbs extension. They can be run at the command prompt by using the syntax "cscript.exe *&lt;scriptname&gt;*.vbs".
4. Before you start, make a backup of the System32\inetsrv\config\applicationhost.config file with the AppCmd tool. The backup copy will enable you to restore IIS to its original state by just copying the original version over the later one. To make a backup, follow these steps:

> a. Open an elevated Command Prompt window.
> 
> b. Type cd `%Windir%\system32\inetsrv\`
> 
> c. Type appcmd add backup *backupName* to back up the ApplicationHost.config file, where *backupName* is the name that you specify for the backup. A directory with the backup name that you specify will be created under the `%Windir%\system32\inetsrv\backup` directory. If you do not specify a name, appcmd will generate a directory name automatically using the current date and time.


## Creating and Enumerating Applications

Applications can be easily created and enumerated by using WMI scripting in IIS.

### Creating an Application

To create an application, IIS uses the new application Create method. This is a static method that takes two required string parameters: ApplicationPath and SiteName. ApplicationPath defines the virtual path for the new application, and SiteName contains the name of the Web site on which the application will be created. A third parameter, PhysicalPath, is optional and specifies the path for the application's directory on disk.

ApplicationPath and SiteName are key properties and cannot be changed after you create the application (notice that ApplicationPath is called "Virtual Path" in the UI).

The following script creates a new application called "NewApp" on the default Web site. Observe how the Create method is called on the Application class definition. Copy the script into notepad and save it with the filename AppCreate.vbs.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample1.vb)]

To run the script, open an elevated command prompt window and navigate to the directory in which you saved the AppCreate.vbs file. Run the script by typing the following in the command prompt window you just opened:

[!code-console[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample2.cmd)]

Remember that ApplicationPath and SiteName must be specified for Create to complete successfully. You also want to specify the PhysicalPath property. If you specify a nonexistent directory for the PhysicalPath parameter, the directory will *not* be created for you. The script will terminate silently, and a new node for the application will in fact appear in IIS Manager. However, when you try to open the node of the new application, you will receive the error "Could not find a part of the path *&lt;path&gt;*".

### Enumerating Applications

After you have created your application, you can easily display its properties through WMI script.

The following VBScript shows the site name, application path, application pool, and enabled protocols for each application on a server. The script uses the WMI InstancesOf method to retrieve all the applications, then iterates through them to display their properties.

Copy the code into notepad and save it with the filename AppEnumerate.vbs.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample3.vb)]

To run the script, open an elevated command prompt window and navigate to the directory in which you saved the AppEnumerate.vbs file. Run the script by typing the following in the command prompt window you just opened:

[!code-console[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample4.cmd)]

Next, you see how to create, configure, and manage the application pools that host your Web applications.

## Creating and Configuring Application Pools

This section presents some basic but important tasks that you can accomplish with application pools by using WMI scripting. Application pools connect one or more applications to one or more worker processes. Application pools help separate applications from each another, and this isolation increases their security and reliability.

### Creating an Application Pool

To create an application pool, IIS uses the ApplicationPool class Create method. This static method has two parameters: the first, AppPoolName, is a required string that specifies the name of the new application pool; the second, AutoStart, is an optional Boolean.

AutoStart, which is true by default, specifies that the application pool you create will start after it is created, and will start automatically thereafter when IIS itself is started. If you set AutoStart to false, you must start the application pool manually. However, disabling automatic startup may be useful when you want to make configuration or content changes to an application in the application pool before the application pool starts.

The following example creates two application pools, "NewAppPool" and "OneMoreAppPool" with just three lines of code. Note how the Create method is called—not on an instance of ApplicationPool, but on its class definition.

Copy the script into notepad and save it with the filename AppPoolCreate.vbs.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample5.vb)]

To run the script, open an elevated command prompt window and navigate to the directory in which you saved the AppPoolCreate.vbs file. Run the script by typing the following in the command prompt window you just opened:

[!code-console[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample6.cmd)]

### Creating Application Pools Interactively

With just a few more lines of code, you can create a convenient script that will throw up an input box so that you can create application pools interactively. As before, copy and paste the script into notepad, save it as a file with a .vbs extension, and run the file by using cscript.exe.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample7.vb)]

### Assigning an Application to an Application Pool

Now that you have created an application pool, assign an application to it. It is easy to change the application pool for an application by using WMI script, but there are two important things to remember. First, because IIS does not check whether the application pool you specify actually exists, make sure that you create it first. Second, to save the application pool assignment change, remember to use the Put\_ method. The Application class inherits the Put\_ method from WMI.

The following script changes the application pool for the "/NewApp" application on the default Web site to "NewAppPool". As before, copy and paste the script into notepad. Save it with the filename AppPoolAssign.vbs, then run it with cscript.exe.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample8.vb)]

### Deleting a Specific Application Pool

If you want to get rid of the old application pool completely, you can use the Delete\_ method that the ApplicationPool class inherits from WMI.

This next script deletes the application pool called "OneMoreAppPool" that you created earlier. As before, copy and paste the script into notepad. Save it with the filename AppPoolDelete.vbs, then run it with cscript.exe.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample9.vb)]

### Setting the Default Application Pool for a Web Site

If you want to make your application pool the default application pool for all applications on a Web site, use the Site object's ApplicationDefaults.ApplicationPool property. Once again, use the Put\_ method on the Site object to save the change.

The following script sets the default application pool for the default Web site to the "NewAppPool" that you created earlier. Copy and paste the script into notepad, save it with the filename SetAppPoolDefault.vbs, then run it with cscript.exe.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample10.vb)]


## Administering Application Pools

You can start, stop, and recycle, and create application pools easily by using WMI scripting. This section shows you how to execute each of these tasks. In addition, it also shows how you can obtain the current state of an application pool.

### Stopping an Application Pool

IIS's ApplicationPool.Stop method corresponds to the IIsApplicationPool.Stop method in IIS 6.0.

Stopping an application pool can be accomplished in three lines of script. Copy and paste the script below into notepad, save it with the filename AppPoolStop.vbs, then run it with cscript.exe.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample11.vb)]

### Starting an Application Pool

IIS has an ApplicationPool.Start method that corresponds to the IIsApplicationPool.Start method in IIS 6.0.

Starting an application pool is equally straightforward. Copy and paste the script below into notepad, save it with the filename AppPoolStart.vbs, then run it with cscript.exe.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample12.vb)]

### Recycling an Application Pool

IIS's ApplicationPool.Recycle method corresponds to the IIsApplicationPool.Recycle method in IIS 6.0.

Recycling an application pool follows the same pattern as the previous examples; the only caveat is that the Recycle method works only on an application pool that is already started.

Copy and paste the script below into notepad, save it with the filename AppPoolRecycle.vbs, then run it with cscript.exe.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample13.vb)]

### Getting the State of an Application Pool

The run-time state of an application pool can be retrieved by using the ApplicationPool object's GetState method, which returns an enumeration value from 0 to 4. The following example shows what these values mean and how you can use a simple helper function to display them. This method has no direct counterpart in IIS 6.0.

Copy and paste this script into notepad, save it with the filename AppPoolState.vbs, and run it with cscript.exe.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample14.vb)]

Note that the value returned will reflect the state of the application pool at the time that the script was run. Of course, it will not update itself in real time. If you require this, schedule a task to run the script to report on the health of a particular application pool or pools at set intervals.

### Listing the Application Pools on a Server

You can use the WMI InstancesOf method to retrieve all application pools and then iterate through them to display their properties. The following code displays the application pools and their mode (Integrated or ISAPI).

Copy and paste the script below into notepad, save it with the filename ListAppPools.vbs, then run it with cscript.exe.

[!code-vb[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample15.vb)]

Your output should resemble this:

[!code-console[Main](managing-applications-and-application-pools-on-iis-with-wmi/samples/sample16.cmd)]

## Conclusion

This article presented information about how to accomplish the following basic tasks with WMI scripting:

- Create and enumerate applications
- Create, configure, and delete application pools
- Start, stop, and recycle application pools
- View the state of application pools
- List all the application pools on the server

The Application and ApplicationPool classes have additional features not covered in this article. For more information, see the [IIS 7.0 WMI Provider Reference](https://go.microsoft.com/fwlink/?LinkId=79310).