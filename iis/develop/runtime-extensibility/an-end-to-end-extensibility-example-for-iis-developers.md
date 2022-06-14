---
title: "An End-to-End Extensibility Example for IIS 7.0 Developers"
author: rick-anderson
description: "IIS 7 and above are built with a completely modular architecture, on top of rich extensibility APIs. This enables developers to easily add, remove and even r..."
ms.date: 11/24/2007
ms.assetid: dc56d2a3-5097-4c93-977a-6e13f4caec76
msc.legacyurl: /learn/develop/runtime-extensibility/an-end-to-end-extensibility-example-for-iis-developers
msc.type: authoredcontent
---
# An End-to-End Extensibility Example for IIS 7.0 Developers

by [Saad Ladki](https://twitter.com/saadladki)

IIS 7 and above are built with a completely modular architecture, on top of rich extensibility APIs. This enables developers to easily add, remove and even replace built-in IIS components with hand-crafted ones, specifically suited for any given Web site. It has never been so easy to plug code deep into the IIS core pipeline and extend IIS in ways that were impossible before.

To give some examples: a few lines of code allows developers to write modules or handlers that provide new authentication and authorization schemes, do run-time or security analysis of incoming request and inspect responses. But to provide a real value-add, these modules must be manageable via programming interfaces, command-line tools and a user interface.

This white paper is an end-to-end example of how to extend the IIS web server with a custom request handler. It shows how to add API and command-line support for the configuration of this handler and how to write a user interface module plugs into the IIS Management interface.

The solution has been tested on Windows Vista and Windows Server® 2008 Beta 3. It will be updated once the final version of Windows Server 2008 is available.

## Feature Set

- Managed handler inserts a copyright message into image files
- Copyright message feature is configuration driven and uses the new IIS configuration system
- Configuration can be schematized and made accessible to configuration APIs, WMI scripting and IIS command-line tools
- User Interface Extension Module allows configuration of copyright message feature through the IIS user interface

## Prerequisites

To follow the steps in this document, the following software must be installed:

### ASP.NET

Install ASP.NET via the Windows Vista Control Panel. Select "Programs" - "Turn on or off Windows features". Then open "Internet Information Services" - "World Wide Web Services" - Application Development Features" and check "ASP.NET.

If you have a Windows Server 2008 build. open "Server Manager" - "Manage Roles" and select "Web Server (IIS)". Click "Add role services". Under "Application Development" check "ASP.NET".

You must also install "IIS Management Scripts and Tools" to take advantage of the WMI extensibility in IIS. To do this, select "Programs" - "Turn on or off Windows features". Then open "Internet Information Services" - "Web Management Tools" and check " IIS Management Scripts and Tools".

If you have a Windows Server 2008 build, open "Server Manager" - "Roles" and select "Web Server (IIS)". Click "Add role services". Under "Web Management Tools" check " IIS Management Scripts and Tools ".

### Visual C# Express Edition or Visual Studio 2005

For the User Interface Module, you need a C# Development Tool. If you do not have a copy of Visual Studio 2005, [download Visual Studio](https://visualstudio.microsoft.com/) for free.

### Dealing With User Account Control Issues

Windows Vista User Account Protection removes the Administrator privileges from your access token. By default, you will not have access to IIS configuration and content locations. To fix this problem, we recommend going through this article by using an elevated command prompt.

To start an elevated command prompt, go to the "Start" menu, click "All Programs" - "Accessories". Right click "Command Prompt" and click "Run as administrator". Confirm the elevation prompt.

## Scenario

The following example dynamically decorates images served by our web server with copyright information in the lower left corner as seen in Figure 1.

![Screenshot of the web page displaying an image of snow covered rocky mountains on the backdrop of a cloudy sky.](an-end-to-end-extensibility-example-for-iis-developers/_static/image1.png)  
**Figure 1: Image Copyright Module in Action**

We use managed code for developing the handler that decorates the images. As part of the sample, we also specify the configuration for this handler and store it in the IIS configuration store. Last, we will develop a User Interface plug-in for IIS Manager.

## Step 1 – Configuration Extensibility: Configuration for the Image Copyright Handler

The IIS configuration store can be extended by simply copying a schema file into the IIS schema directory. The schema declares the name of the new configuration section and its attributes, types and default values. For our example, we declare a new configuration section called imageCopyright. It lives within the system.webServer configuration group. Its properties are:

- A Boolean flag that enables or disables the imageCopyright functionality
- A string attribute containing the copyright message
- A color attribute specifying the color of the copyright message

### Schema Declaration

Save the following schema definition as imagecopyright.xml in `%windir%\system32\inetsrv\config\schema`:

[!code-xml[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample1.xml)]

If you get an "access denied" message, you did not do this from the elevated command prompt. Once the schema file is added, the schema needs to be declared in the applicationhost.config file. Add the following XML to `%windir%\system32\inetsrv\config\applicationhost.config`

[!code-xml[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample2.xml)]

### Configure It

The process is complete. You can set the new configuration settings via the command-line or directly within applicationhost.config or web.config. Try it. Open a command shell and enter the following:

[!code-xml[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample3.xml)]

The output shows the configuration section was recognized, with its default configuration:

[!code-css[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample4.css)]

Now add your configuration settings via appcmd.exe, e.g.

[!code-css[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample5.css)]

Check to see if the configuration was saved by running:

[!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample6.cmd)]

See the saved configuration:

[!code-xml[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample7.xml)]

## Make imageCopyright Configuration Scriptable

> [!NOTE]
> Making the imageCopyright handler configuration available for WMI scripting is optional. You can go directly to "Step 2 – Core Extensibility: The Image Copyright Handler" without affecting the remaining steps.

To make the imageCopyright handler configuration available for WMI scripts, complete the following steps:

- Installation of IIS WMI support
- Creating the imageCopyright.mof file
- Including the imageCopyright.mof file into webadministration.mof and compilation of the WMI schema files
- Writing and executing the script

### Installation of IIS WMI support

The default install of IIS does not include the WMI scripting components. You must add them.

### Installation of WMI Support on Vista Client SKUs

Install "IIS Management Scripts and Tools" via the Windows Vista Control Panel. Select "Programs" - "Turn on or off Windows features". Then open "Internet Information Services" - "Web Management Tools" and check "IIS Management Scripts and Tools".

### Installation of WMI Support on Windows Server 2008 SKUs

If you have a Windows Server 2008 build, open "Server Manager" - "Roles" and select "Web Server (IIS)". Click "Add role services". Under "Management Tools" check "IIS Management Scripts and Tools".

### Creating the imageCopyright.mof File

The schema declaration of WMI properties is very similar to the schema declaration of IIS properties in the previous step. WMI schemas are declared in .mof files and are compiled by a tool called mofcomp. Mofcomp adds the schema declaration to the WMI repository.

### Tasks to Add the Schema Information

Open a notepad instance and copy the following lines into it:

[!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample8.cmd)]

The schema declaration contains the same entries as imageCopyright.xml in the previous step, namely the name and type of the configuration setting and its default value. Save the file as `%windir%\system32\inetsrv\imageCopyright.mof`.

## Compilation of WMI Schema Files

Compile imageCopyright.mof by executing the following command

[!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample9.cmd)]

## The WMI Script

Mofcomp added the imageCopyright schema to the WMI repository. Set IIS configuration settings by scripting the IIS WMI provider. Here is an example:

### Tasks

Open an instance of NOTEPAD and copy the following lines into it. Save the file as SetCopyrightConfig.vbs:

[!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample10.cmd)]

This is a standard WMI script that connects to the IIS WMI provider. It gets the configuration section at the specified location ("Default Web Site") and changes its values. The Put\_ call will save the changes to disk.

If you execute the script, it adds the copyright message with the current date into `%systemdrive%\inetpub\wwwroot\web.config`. Have a look.

Next, add the image copyright handler itself.

## Step 2 – Core Extensibility: The Image Copyright Handler

A handler is a piece of code that gets executed when the request matches a certain pattern, usually a file extension. Requests ending with .ASP are mapped to ASP.DLL, for example. In IIS 6.0, you had to write an ISAPI extension to handle requests with certain file extension. ASP.NET also allowed handling file extensions, but only if you mapped the request to ASP.NET first. In IIS, you can handle arbitrary file extensions without involving ASP.NET. In our example, we handle requests with the extension .JPG. Here is how to do it:

### Creating the Content Directory

Create a content directory, for example `c:\inetpub\mypictures`, and copy some digital pictures of your choice into it. Make sure these files are image files with the extension .JPG.

> [!NOTE]
> For simplicity purposes, the code examples shown here do not include error handling code for files that are not image files.

Create a sub directory called App\_Code underneath your new directory: for example, `c:\inetpub\mypictures\App\_Code`.

### Create the mypictures Application

You can create an application that points to `c:\inetpub\mypictures` via the IIS Management console, but there are more interesting ways to do it. Create a new application via appcmd. The following command creates an app called "mypictures" on the "Default Web Site" with the physical path `c:\inetpub\mypictures`:

[!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample11.cmd)]

Because we want to see the JPG files copied into this directory, enable directory browsing. Do this via the IIS Management Console, or resort to a more interesting method and use appcmd. Here is how to set directory browsing to true via appcmd:

[!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample12.cmd)]

If you request `http://localhost/mypictures`, you see a directory listing with your pictures.

## Time to Write Code

Now write the actual image handling code. Write a few lines of C# code and you have the result: use the code below as a reference and save it as imagecopyrighthandler.cs in your App\_Code directory, for example `c:\inetpub\mypictures\App\_Code\imagecopyrighthandler.cs`.

[!code-csharp[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample13.cs)]

The above code does the following:

- Reads the configuration
- Calls HandleImage

HandleImage does the following:

- Creates a Graphics object from the bitmap
- Creates a font object using the configured values
- Draws the message into the bitmap

To use the Microsoft.Web.Administration class, you must add the reference to the IIS Administration API assembly. To do this, open `%systemdrive%\inetpub\mypictures\web.config` and add the following entries:

[!code-xml[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample14.xml)]

You can also compile the handler into an assembly and put it into the mypictures/bin. If you do this, you do not have to add the Microsoft.Web.Administration assembly to your web.config file.

## Handler Configuration

You only have to tell IIS to invoke your new handler if a .JPG file is requested. Do this via the IIS Management Console or you use appcmd:

[!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample15.cmd)]

The appcmd command above configures the new handler in the /mypictures directory only. Because handler entries are in a collection, you have to use the +[] syntax. This syntax is always used when add elements must be added to collections. The elements of the handler configuration are:

### name

Can be any unique name. The name is only used to uniquely identify the handler.

### path

Tells IIS when to execute this handler. \*.JPG tells IIS to execute this handler for all files ending in .JPG. If you use foo\*.JPG as a path, only JPG files starting with foo are executed by this handler.

### verb

Comma-separates list of http verbs that have to match to execute this handler. In our case, we only want to execute the request when a GET request comes in.

**type**

The managed type of the class that should be executed when the request matches. It is comprised of the namespace and the IHttpHandler derived class in your App\_Code directory.

## One Last Note

Before you start testing the copyrighted images, make sure that the IIS worker process which executes the request picks up the schema changes you made. It is possible that the worker process was already running when you added the imageCopyright.xml file to the schema directory. If this happens, you get a configuration exception in imagecopyrightconfig.cs. The author encountered into this issue when writing this article and it cost quite a bit of time.

Simply recycling the Application Pool solves this problem:

[!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample16.cmd)]

The process is complete. If you now request `http://localhost/mypictures/<imageOfYourChoice>.jpg)`, you see the copyright message.

Options:

- You can change the copyright message options via appcmd or by directly editing the web.config file
- You can map the imageCopyright handler to other image types, e.g. BMP or GIF by adding the same handler for a different extension. Example:

[!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample17.cmd)]

## Step 3 - Creating the Image Copyright UI Module

Time for the finishing touches. We already extended the IIS core server with a few lines of code; we extended the IIS configuration system with no code at all and got command-line support for free. Now to configure our imageCopyright handler via the IIS Management Console.

We do this via the following tasks:

- Creating the project in Microsoft Visual Studio or Microsoft Visual C# Express so that the assembly can be used inside the IIS Management Console
- Creating a module provider
- Creating a module that reads and sets imageCopyright properties.

## Creating the Project

To create an extensibility module for InetMgr you need to create a DLL project also known as a Class Library project. This DLL needs to be strongly named so that it can be registered in the GAC (Global Assembly Cache) which is a requirement for Modules that are used by the IIS Management Console.

### Steps

1. Click Start, click Programs and run Microsoft Visual Studio 2005 or Microsoft Visual C# 2005 Express Edition.
2. In the File Menu select the option New Project.
3. In the New Project dialog select Class Library as the project type and type imageCopyrightUI as the name of the project and click OK.

    ![Screenshot of New Project dialog box with Class Library selected and image Copyright U I entered in the Name filed as the name of the project.](an-end-to-end-extensibility-example-for-iis-developers/_static/image3.png)  
    **Figure 2: New Project Dialog**

4. Remove the file Class1.cs that was added by default since we will not be using that.

5. Using the Add New Reference option from the Project Menu, add a reference to Microsoft.Web.Management.dll located in the \Windows\system32\inetsrv directory. This is the DLL that contains all the extensibility classes needed for creating modules for the IIS Management Console.

6. Using the Add New Reference option from the Project Menu, add a reference to Microsoft.Web.Administration.dll located in the \Windows\system32\inetsrv directory. This is the DLL that contains all the configuration classes needed for reading configuration writing IIS configuration.

7. Since we will be using code to create UI based on WinForms, we also want to add a reference to System.Windows.Forms.dll; for that again using the Add New Reference option from the Project Menu, select System.Windows.Forms.dll and System.Web.dll in the.NET list of assemblies.

8. One of the requirements for libraries to be used inside InetMgr is that they need to be registered inside the GAC. For that, we need to make sure our DLL is strongly named (sometimes referred as Signed). Visual Studio offers an easy way to create new names and to select one for the project, so for that, using the Project menu select the option imageCopyrightUI Properties.

9. In the Signing Tab check the Sign the assembly.

10. In the Create Strong Name Key type imageCopyrightUI as the name for the key and uncheck the Protect my key file with a password check box. Click OK.

    ![Screenshot of Create Strong Name Key dialog box displaying image Copyright U I entered as Key file name and password created and confirmed.](an-end-to-end-extensibility-example-for-iis-developers/_static/image5.png)  
    **Figure 3: Create Strong Name Dialog**

    The signing tab displays:

    ![Screenshot of Signing tab with image Copyright U I dot s n k selected in the Choose a strong name key file field.](an-end-to-end-extensibility-example-for-iis-developers/_static/image1.jpg)  
    **Figure 4: VS Project Signing Tab**

11. Since we want the assembly to be in the GAC, we will add some Post-build events so that it automatically gets added to the GAC every time we compile. This will make it really straight forward to debug and make changes as we add new functionality. For this, select the **Build Events** tab and add the following Post-build event command line:

    [!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample18.cmd)]

    [!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample19.cmd)]

    ![Screenshot of Post Build Event command line populated with code.](an-end-to-end-extensibility-example-for-iis-developers/_static/image8.png)  
    **Figure 5: VS Post-Build Events Tab**

    **(Optional)** If you are using Microsoft Visual Studio 2005 (this will not work with the Visual C# Express Edition), setup debugging correctly to use F5 to run your code. To do this, go to the project properties, select Debug tab and set it to start an external program choosing \windows\system32\inetsrv\inetmgr.exe

    ![Screenshot of Debug tab set to Start external program action.](an-end-to-end-extensibility-example-for-iis-developers/_static/image10.png)  
    **Figure 6: Debugging Tab**

12. Finally, close the project properties, select the option Save All in the File Menu and click OK.

    Now compile the project using Build Solution under Build menu. This automatically builds the DLL and adds it to the GAC.

## Creating the Module Provider

The IIS user interface is as customizable and modular as the IIS core server and the IIS configuration system. The IIS user interface is a set of feature modules that can be removed or replaced. The entry point for each UI module is a module provider. A list of all module providers can be found in `%windir%\system32\inetsrv\Administration.config` in the `<modules>` section.

As a first step, create the imageCopyrightUI module provider.

### Steps

1. Select the option Add New Item from the Project Menu. In the Add New Item dialog select the Class template and type imageCopyrightUIModuleProvider.cs as the name for the file.

   ![Screenshot of Add New Item dialog box with Class template selected and the Name field populated with image Copyright U I Module Provider dot c s.](an-end-to-end-extensibility-example-for-iis-developers/_static/image12.png)  
   **Figure 7: Add New Item Dialog**

2. Change the code so that it looks as follows:

   [!code-csharp[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample20.cs)]

   This code creates a ModuleProvider that supports all types of scopes (Server, Site and Application) and registers a client-side Module called imageCopyrightUI. To only show your module on the application level, the SupportsScope function looks like this:

   [!code-csharp[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample21.cs)]

## Creating the UI Module

A Module is the main entry point in the client for all extensibility objects. It has one main method called **Initialize**. This is the method where all the action takes place.

### Steps

1. Select the option Add New Item in the Project Menu.

2. Select the Class template and type imageCopyrightUI.cs as the file name. Change the code so that it looks as follows:

   [!code-csharp[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample22.cs)]

   In the above code, we specify the Text of the entry in the list of UI Modules and the type of a single page that should be displayed when a user clicks this text.

All that is left is to write the page itself.

## Creating the Module Page

In this task, you create the most basic Module Page. ModulePage is the base class provided by the framework to create a new user interface. There are four different classes that are provided by the framework that are helpful, depending on the scenario you are trying to build.

- **ModulePage.** This base class offers only the most basic services, and offers no special user interface at all. None of the features that are included in InetMgr derives from this class directly.
- **ModuleDialogPage.** This base class offers similar semantics as a dialog, including an Apply and Cancel links in the task list and offer specific methods you can override to handle this common tasks. It also handles things like Refresh and other functions automatically. Samples of features that derive from this page include Machine Key, Management Service, etc.
- **ModulePropertiesPage.** This base class offers a UI similar to the Visual Studio Property Grid where all the properties are displayed in a hierarchical grid-like control. Samples of this include CGI, ASP, .NET Compilation, etc.
- **ModuleListPage.** This base class is useful whenever you need to display a list of items. It includes a ListView control you can use to display the settings and offers searching, grouping and views automatically. Samples include Application Settings, Modules, Worker Processes, etc.

### Steps

1. Select the option Add New Item from the Project Menu.

2. In the Add New Item dialog, select the Class template and type imageCopyrightUIPage.cs as the name for the file. Change the code so that it looks as follows:

   [!code-csharp[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample23.cs)]

   Although there is a lot, this code does nothing more than put a couple of controls on the ModulePage and reads and writes to the IIS configuration store.

## Reading Configuration

The ReadConfig function uses the same Microsoft.Web.Administration interfaces to open the IIS configuration store. The UI itself provides the scope at which the configuration settings will be applied.

Example:

[!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample24.cmd)]

## Saving Configuration

The configuration is saved when the Apply button is clicked (applyClick function). The changes made in the UI transfer into the section attributes and the section saves to disk.

[!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample25.cmd)]

At this point, you are ready to compile everything again using "Build Solution" from the Build Menu. This builds the assembly imageCopyrightUI and puts it into the Global Assembly Cache.

## Module Registration

The UI Module is built, but we still must tell the IIS Management Console to load it. Do this by:

- Getting the UI module's strong name from the Global Assembly Cache
- Adding the strong name and type to the IIS Management Console's configuration file. This will cause the IIS Management Console to load the type on startup
- Enabling the module in the UI modules list

### Steps

1. Open or use an existing elevated command shell and register the Visual Studio 8.0 environment variables by executing the following command:

   [!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample26.cmd)]

2. Run GacUtil

   [!code-console[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample27.cmd)]

3. Open `%windir%\system32\inetsrv\config\administration.config` and add the following right after the `<moduleProviders>` entry:

   [!code-xml[Main](an-end-to-end-extensibility-example-for-iis-developers/samples/sample28.xml)]

## The Result

The task is complete. Look at the results.

Open the IIS Management Console and navigate to the /mypictures application.

Double-click the "Image Copyright" entry.

![Screenshot of I I S Management Console with my pictures application selected and image Copyright message displayed.](an-end-to-end-extensibility-example-for-iis-developers/_static/image14.png)  
**Figure 8: Image Copyright User Interface**

Change the copyright message, click apply and refresh your browser. The copyright message changed. Look into the web.config file in the `%systemdrive%\inetpub\mypictures` directory to see the changed configuration.

## Summary

IIS is extensible in ways that were not possible before. You can extend the IIS core processing pipeline with your own component, store the configuration for this component together with the IIS configuration and even write a user interface plug-in that lives side-by-side with the standard IIS settings. To review what we did in the previous example:

### IIS Core Extensibility

We added an image handler to the IIS core that inserts a copyright message into each .JPG file that gets served. This was accomplished with only a few lines of C# code. The functionality of the handler was configuration driven. We stored the configuration in the regular IIS configuration files applicationhost.config and web.config. We also added caching support for the images.

### IIS Configuration System Extensibility

We added the image copyright handler configuration to the IIS configuration system. Benefits like a highly readable and xml store, instant API and command-line support, delegation and distributed deployments came for free. We did not have to write a single line of code.

### IIS User Interface Extensibility

To give our feature the visibility it deserves, we added an IIS User Interface Module. Although not shown, the IIS User Interface is completely remotable via HTTPS.
