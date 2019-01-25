---
title: "Using Visual Studio 2008 with IIS 7"
author: leanserver
description: "Visual Studio ® provides several options for working with IIS when developing Web sites and applications. These include the Web application and Web site proj..."
ms.date: 03/12/2008
ms.assetid: 6c1189e2-07b7-43c9-b91a-fe2467e9414e
msc.legacyurl: /learn/develop/using-visual-studio-with-iis/using-visual-studio-2008-with-iis
msc.type: authoredcontent
---
Using Visual Studio 2008 with IIS 7
====================
by [Mike Volodarsky](https://github.com/leanserver)

## Introduction

Visual Studio® provides several options for working with IIS when developing Web sites and applications. These include the Web application and Web site projects. In Visual Studio 2008, these features receive a much awaited upgrade to properly support IIS 7 and above in Windows Vista® and Windows Server® 2008. In addition, the recently released Web Deployment Project 2008 also provides support for IIS 7 and above.

This article provides an overview of using Visual Studio 2008 Web development features with IIS, including information on the steps necessary to enable these features to work correctly.

### Prerequisites

To use Visual Studio 2008 to work with Web sites and applications on your local machine, do the following:

1. Install IIS 7 or above.
2. Install ASP.NET.
3. Install IIS 6.0 Metabase Compatibility.  
  
 On Windows Vista, open the Control Panel, click Programs and Features, click the Turn Windows features on and off link, check the **Internet Information Services** check box, as well as the **Web Management Tools** \ **IIS 6 Management Compatibility** \ **IIS Metabase** and **IIS 6 configuration compatibility** and the **World Wide Web Services** \ **Application Development Features** \ **ASP.NET** check boxes under it.  

    [![](using-visual-studio-2008-with-iis/_static/image2.png)](using-visual-studio-2008-with-iis/_static/image1.png)

    On Windows Server 2008, use **Server Manager** to install the Web Server (IIS) role, and add the **Management Tools**\**IIS 6 Management Compatibility**\**IIS 6 Metabase Compatibility** and "**Application Development**\ **ASP.NET** role services. For more information, see [Installing IIS on Windows Server 2008](../../install/installing-iis-7/installing-iis-7-and-above-on-windows-server-2008-or-windows-server-2008-r2.md).

    To use Visual Studio 2008 to work with Web sites and applications on a remote machine, see the section "Using Visual Studio 2008 with a Remote IIS Server" later in this article.

### Starting Visual Studio 2008 as Administrator

Certain tasks, including debugging and creating local IIS applications, require that you start Visual Studio as a user with Administrative privileges. On Windows Vista, and Windows Server 2008 when not running as the built-in Administrator account, this requires right-clicking the Visual Studio 2008 icon in the Start Menu and choosing **Run as administrator**.

To make this process easier, you can create a shortcut and check the **Run this program as an administrator** check box on the **Compatibility** tab of the shortcut properties.

## Create a New IIS Web Site or Application Project

Visual Studio provides two conceptual models for working with Web applications: the Web *site* project model, and the Web *application* project model.

While both options allow you to create Web applications and publish them to an IIS server, they do have significant differences in how the corresponding ASP.NET application is built and deployed. Some of the differences between the two models are:

- The Web application project option requires the source application files to be located on the local file system, or, on a network share. However, you can subsequently publish the Web application to a remote IIS Web site by using a network share, FTP, or Front Page Server Extensions.
- The Web site project option allows you to connect directly to a local IIS Web site, or to a remote IIS Web site by using a network share, FTP, or Front Page Server Extensions. With the Web site project, you work directly with the content of your IIS Web site and there is no project file.

You can find the detailed explanation of the two models and their differences in [https://msdn.microsoft.com/en-us/library/aa730880(VS.80).aspx](https://msdn.microsoft.com/en-us/library/aa730880(VS.80).aspx).

> [!NOTE]
> Visual Studio 2008 provides the options to create a New project and Open an existing project. This does not necessarily mean that you must create a new IIS Web application project or open an existing application project – you can use either of the options with an existing IIS Web application.

**To create a new project using the Web application project option:** 

1. In Visual Studio, on the **File** menu, select **New Project**, and then select the **ASP.NET Web Application** template.
2. Click **OK**. Visual Studio opens to the **Source** view of the Default.aspx page so that you can edit it.

> [!NOTE]
> Unlike the Web site project option, you must place the application files on the local file system or a network share, and later use the **Publish** option to publish the contents of your application to an IIS Web site.

**To publish the project to an IIS Web site:** 

1. Create the IIS Web site using IIS Manager, AppCmd, or another configuration tool. For more information, see [https://technet.microsoft.com/en-us/library/cc772350(v=ws.10).aspx](https://technet.microsoft.com/en-us/library/cc772350(v=ws.10).aspx). Alternatively, use an existing IIS Web site.
2. In Visual Studio, use the **Build** \ **Publish** option to publish the contents of your Web application to an IIS Web site.  
    [![](using-visual-studio-2008-with-iis/_static/image4.png)](using-visual-studio-2008-with-iis/_static/image3.png)   

    > [!NOTE]
    > The **Publish Web** dialog by default publishes only the parts of your project that comprise your Web application - it does not publish the project file, obj directory, and other files. This is important because exposing these components to your Web users may be a security risk.  
  
    By clicking the "…" button, you can chose one of the four options for publishing your Web site: 

    - **File System**. When using this option, Visual Studio opens / creates the Web application as a folder, and uses the built-in ASP.NET Development Server to host the Web site. This option may be sufficient for basic testing of ASP.NET applications – however, this mode does not support running ASP.NET applications in Integrated mode, and it does not support application technologies other than ASP.NET (such as PHP, ASP, CGI, etc).
    - **Local IIS**. When using this option, Visual Studio allows you to publish your application files to a local IIS Web site or application. You can also use the dialog to create new IIS applications or virtual directories to publish your files to.
    - **FTP Site**. When using this option, Visual Studio supports editing your application files if they are shared through FTP. You can still use Visual Studio to debug your applications by configuring the URL of your application in project start settings. For more information, see the section "Using Visual Studio 2008 with a Remote IIS Server" later in this article.
    - **Remote Site**. Using this option, Visual Studio can connect to a remote IIS server. To use this option, you need to have Front Page Server Extensions installed on the remote server and configure your Web site to use FPSE. For more information on this, see the "Using Visual Studio 2008 with a Remote IIS Server" section later in this article.
3. Select **Local IIS**. You can also map the Web application project directory as a virtual directory on the local IIS installation by opening the project **Properties**, clicking the **Web** tab, and clicking the **Create Virtual Directory** button. You can use the **Create Virtual Directory** option as a quick way to host your Web application locally on IIS without going through the **Publish Web** option. However, this option is not generally recommended because it places all of the project files, source files, object files, and other temporary files in the servable namespace of the IIS virtual directory, which may result in a security risk. A better practice is to use the **Publish** options, which by default publish only the Web servable portions of the project.
4. Configure debugging. By default, projects created using the Web application project model use the built-in ASP.NET Development Server ("Cassini") when testing or debugging your project. This provides a convenient way to test your ASP.NET application without IIS – however, we recommend that you configure Visual Studio to test your application by using the IIS environment. The reasons for this are:  

    - The ASP.NET Development Server does not support hosting ASP.NET applications in Integrated mode, which is the default mode of operation used by IIS. This may introduce differences in application behavior.
    - The ASP.NET Development Server does not support many of the IIS configuration features, so if your application relies on or uses them, its behavior may be different or incorrect when hosted under the ASP.NET Development Server.
    - The ASP.NET Development Server does not support hosting portions of your application that utilize application technologies other than ASP.NET, such as PHP, CGI, and other third party frameworks.
  
If you are developing on Windows Vista, you can easily take advantage of IIS to test your application locally by using the same environment it will be on when it is deployed - use the **Create Virtual Directory** option or the **Publish Web** dialog as discussed earlier in this article.  
  
Alternatively, you can configure Visual Studio to connect to the a remote IIS server to which you publish your application.  
  
In those cases, you can configure Visual Studio to debug your application in the IIS environment. To do this, right-click the project node, chose **Properties**, and click the **Web** tab. In the **Web** tab, select the **Use Local IIS Web server** option. The base URL of your Web application should populate automatically.  

[![](using-visual-studio-2008-with-iis/_static/image6.png)](using-visual-studio-2008-with-iis/_static/image5.png)

For more information on configuring remote debugging, see "Debugging IIS Web Applications" later in this article.

**To create a new project using the Web site project option:** 

1. Create the IIS Web site using IIS Manager, AppCmd, or another configuration tool. For more information, see [https://technet.microsoft.com/en-us/library/cc772350(v=ws.10).aspx](https://technet.microsoft.com/en-us/library/cc772350(v=ws.10).aspx). Alternatively, use an existing IIS Web site.
2. In Visual Studio, on the **File** menu, select **New Web Site** to create a new Web site project using the IIS Web site you created.
3. In the **New Web Site** dialog, select one of the Visual Studio Web site templates, such as **ASP.NET Web Site**.
4. Next, indicate where this Web site should be located. To do this, click the **Browse** button, which displays a **Choose Location** dialog similar to what you get when you publish a Web application project. Here, click the **Local IIS** button again to select an existing Web site or application on the local machine, or create a new Web application or virtual directory to host your project files.
5. Click **OK**. Visual Studio opens to the **Source** view of the Default.aspx page so that you can edit it.  

    Alternatively, you will have the option to place your new Web site project on the local File System for use with the ASP.NET Development Server, upload it to a remote server using FTP, or upload it to a remote IIS server using Front Page Extensions. For more information on connecting to a remote server, see the "Using Visual Studio 2008 with a Remote IIS Server" section later in this article.

## To Open an Existing IIS Web Site or Application

**To create a project based on an existing IIS Web site**:

1. To open an existing IIS Web site, on the Visual Studio **File** menu, select **Open Web Site**.
2. Click **Local IIS** to select the local IIS server.  

    In the resulting dialog, you can select the Web site or a child application to open. Alternatively, in the top right hand corner of the dialog box, you can use the **Create New Web Application**, **Create New Virtual Directory**, and **Delete** buttons to manage the Web site hierarchy.

    > [!NOTE]
    > Be sure to back up your configuration first before making changes.

    [![](using-visual-studio-2008-with-iis/_static/image8.png)](using-visual-studio-2008-with-iis/_static/image7.png)
3. Click **Open**.  

    If you do not have IIS or any of the prerequisites installed, Visual Studio 2008 displays a message when you attempt to connect to the Local IIS server telling you to install the required components. To do this, see the "Prerequisites" section earlier in this article.

    [![](using-visual-studio-2008-with-iis/_static/image10.png)](using-visual-studio-2008-with-iis/_static/image9.png)

    > [!NOTE]
    > Visual Studio provides several different options for working with existing Web sites, in addition to connecting to an existing IIS Web site. These options include:

    - **File System**. When using this option, Visual Studio opens or creates the Web application as a folder, and uses the built-in ASP.NET Development Server to host the Web site. You can use this option to connect to an existing IIS Web site by opening its virtual directory's root folder on the local file system or through a network share.
    - **FTP Site**. When using this option, Visual Studio supports editing your application files if they are shared through FTP. For more information, see the section "Using Visual Studio 2008 with a Remote IIS Server" later in this article.
    - **Remote Site**. Using this option, Visual Studio can connect to a remote IIS server. To use this option, you need to have Front Page Server Extensions installed on the remote server and configure your Web site to use FPSE. For more information on this, see the section "Using Visual Studio 2008 with a Remote IIS Server" later in this article.
4. Configure debugging.  

    If you have opened an existing IIS Web site using the **Local IIS** or **Remote Site** options, your project is automatically configured to use the IIS Web site when debugging so no further action is necessary (the Remote Site option requires additional configuration to enable remote debugging, as explained later in the article).

    If you have opened your Web site project using the **File System** or **FTP** site options, it is by default configured to use the ASP.NET Development Server for testing and debugging. It is recommended that you configure Visual Studio to use the IIS server on which the Web site is located for debugging.

    To do this, right-click on the Web site project node in Visual Studio and chose **Start Options**. In the dialog, select the **Use custom server** option and type in the base URL of your Web application on the remote server.

    [![](using-visual-studio-2008-with-iis/_static/image12.png)](using-visual-studio-2008-with-iis/_static/image11.png)

## Using Visual Studio 2008 with a Remote IIS Server

In order to open an existing Web site or create a new Web site on a remote IIS server, you can use many of the options mentioned earlier:

- **File System**. You can create a file share pointing to the root virtual directory of your Web application, and use the "File System" option to connect to it. To use this option, select the "File System" button in the "Open Web Site" dialog. You then have to configure the URL of your application in project start settings to be able to debug the application using Visual Studio. You cannot create new IIS Web sites, applications, or virtual directories on the remote machine using this option.
- **FTP Site**. If your Web site or application files are shared using FTP, you can access these files using this option. You then have to configure the URL of your application in project start settings to be able to debug the application using Visual Studio. To use this option, select the "FTP Site" button in the "Open Web Site" dialog. You cannot create new IIS Web sites, applications, or virtual directories on the remote machine using this option.
- **Remote Site**. This option uses Front Page Server Extensions to connect to a remote IIS server. To use this option to connect to a remote IIS server on Windows Server 2008 or Windows Vista computers, you first need to install Front Page Server Extensions on the remote computer.

### Connect to an IIS Web site using FTP

You can use the FTP Site option if you have used FTP to share the IIS virtual directory you want to publish to.

> [!NOTE]
> When using FTP, you cannot create or edit IIS Web sites, applications, or virtual directories, but you can publish and edit files.

To use this option, provide the address of the FTP server, the port, the directory to which you are connecting, and logon credentials if not using anonymous access.

[![](using-visual-studio-2008-with-iis/_static/image14.png)](using-visual-studio-2008-with-iis/_static/image13.png)

For more information on using the FTP server included in Windows Vista and Windows Server 2008, see [FTP Site Setup (IIS 6.0)](https://www.microsoft.com/technet/prodtechnol/WindowsServer2003/Library/IIS/31c2427c-c0a5-49fa-9e03-823f34fba3e8.mspx?mfr=true). To use the new [FTP 7](https://go.microsoft.com/fwlink/?LinkId=87847), which is available as a download from IIS.NET, see [Adding FTP to a Web Site](https://go.microsoft.com/fwlink/?LinkId=89116). If you are using Windows Server 2008 R2, the new version of FTP (FTP 7.5) is already included.

### Connect to an IIS Web Site Using Front Page Server Extensions

You can use the Remote Site option if you have shared the IIS Web site you want to publish to using Front Page Server Extensions. Unlike the FTP Site option, you can create and edit IIS applications and virtual directories when using this option.

[Front Page Server Extensions for IIS 7](https://go.microsoft.com/fwlink/?LinkId=86544) are available as a free download for Windows Vista and Windows Server 2008. For more information on installing and enabling Front Page Server Extensions for IIS Web sites, see [Installing Front Page Server Extensions for IIS](https://go.microsoft.com/fwlink/?LinkId=88546).

To quickly enable a remote Web site to be used with the "Remote Site" option in Visual Studio, do the following:

1. Download and install FPSE on the remote IIS server. The provided installer automatically installs all required IIS components.
2. Create an IIS Web site to connect to (optional, if the site does not already exist).
3. Enable either Basic authentication or Windows authentication methods for the Web site. This is required for FPSE to be able to manage the site.  

    > [!NOTE]
    > If you use Basic authentication, the username and password are transmitted in clear text, so do not use Basic authentication for connecting to Web sites over public networks unless you also use SSL to protect the communication.
4. Enable the Web site to be managed with FPSE. You can do this by executing the following from the command line:  

    [!code-console[Main](using-visual-studio-2008-with-iis/samples/sample1.cmd)]

    Where &lt;SITEID&gt; is the site id of the Web site you want to enable for FPSE, and the &lt;USERNAME&gt; is the Windows account that can act as FPSE administrator.
5. Connect to the site Using the "Remote Site" option in the Open Web Site dialog or the New Site dialog. This allows you to connect to an existing Front Page Server Extensions – enabled Web site, or create new Web applications and virtual directories.  

    [![](using-visual-studio-2008-with-iis/_static/image16.png)](using-visual-studio-2008-with-iis/_static/image15.png)

    If you receive the following error dialog during connection, double-check that you have installed FPSE on the remote server, and have enabled FPSE management for the Web site to which you are attempting to connect.

    [![](using-visual-studio-2008-with-iis/_static/image18.png)](using-visual-studio-2008-with-iis/_static/image17.png)

    If you are using Windows authentication for your FPSE-enabled Web site, Visual Studio attempts to authenticate using the account under which it was started. If this authentication fails, it prompts you to provide credentials for authentication with the remote server.

    If you are using Basic authentication, Visual Studio immediately prompts you for credentials.

    > [!NOTE]
    > Basic authentication sends credentials in clear text, so it can lead to unintended disclosure of your username and password if the site is not protected with SSL. For this reason, we recommend using Windows authentication for intranet environments, and using Basic authentication over SSL for internet environments *.*

    If you have not enabled a suitable authentication method (Windows authentication, Basic authentication, or Digest authentication), you will receive the following error dialog when you connect. To resolve this, enable one of the authentication methods mentioned above.

    [![](using-visual-studio-2008-with-iis/_static/image20.png)](using-visual-studio-2008-with-iis/_static/image19.png)

    > [!NOTE]
    > The "New Web Site …" button in the "Remote Site" dialog cannot be used to create a new IIS Web site. Instead, it is used to create a new Web application with the specified path for an existing Front Page Server Extensions – enabled IIS Web site.

## Debugging IIS Web Applications

After you have opened a Web site or application in Visual Studio, you can take advantage of Visual Studio debugging features to test it. In doing so, you have the following options:

- **Use F5 debugging to debug from Visual Studio**. If you have opened an IIS Web site project using one of the options discussed earlier, this gives you the most convenient way to debug your Web application. You can debug it simply by pressing F5, and then interacting with your application using a browser window. In the rest of this article, we will focus on this option.
- **Attach to the IIS worker process directly**. If you know which IIS worker process is hosting your application, you can use this option to attach directly to that process.

### Use F5 to Debug a Local IIS Web Application from Visual Studio

F5 debugging provides the most convenient way to debug your Web application with Visual Studio. To use it, do the following:

1. Open an IIS Web site using one of the options discussed earlier.
2. Select the project file to which you want to make the initial request (optional).
3. Set the desired breakpoints in your application source code (optional, you can also set them during debugging).
4. Press F5 to begin debugging. Visual Studio will make an initial request to the IIS Web application, attach to the hosting IIS worker process, and open a new browser window where you can interact with your application.

In order to successfully debug a local IIS Web application, you must meet the following requirements:

1. Be logged on as a user that has Administrative privileges on the local computer (Either the built-in Administrator account, or an account that is a member of the built-in Administrators group).
2. Start Visual Studio in Administrator mode by right-clicking the Visual Studio 2008 icon in the Start menu and selecting **Run as administrator**.  

    If you do not do this, Visual Studio receives a filtered UAC token and cannot debug.

    If you have opened an ASP.NET application using the **File System** option, Visual Studio by default starts the ASP.NET Development Server to host your application. In this option, IIS is not involved, and you are not required to be an Administrator to debug your application. However, when using the ASP.NET Development Server, you do not have the full range of features and services that IIS environment provides, which may make your application behave differently from when it is deployed on IIS. This includes the following:

    - No support for ASP.NET Integrated Mode.
    - No support for IIS features such as compression, native URL authentication, request filtering, and others.
    - No support for application technologies other than ASP.NET, such as PHP, ASP, CGI, and others.

### Use F5 to Debug a Remote IIS Web Application from Visual Studio

You can use F5 to debug an IIS Web application running on a remote server. The process is similar to what was described earlier for debugging local IIS applications, but requires additional configuration to enable remote debugging to take place.

First, you must open the remote IIS Web site or application project using the **File System**, **FTP Site** or **Remote Site** options as discussed in the "Using Visual Studio 2008 with a Remote IIS Server" section earlier in this article.

In order to successfully debug a remote application, you must also meet the following requirements:

1. Install the Remote Debugging components on the server machine. For more information, see [How to: Set Up Remote Debugging](https://msdn.microsoft.com/en-us/library/bt727f1t.aspx).
2. Run the Remote Debugging monitor (msvsmon.exe) on the server machine. See further notes about how to do this properly.
3. Open the required firewall ports for remote debugging.  

    When you run msvsmon.exe for the first time on the remote machine, it warns you if the ports are not open, and offers to open them automatically. If you want to configure the firewall manually or to see which ports are opened, see [How to: Manually Configure the Windows Vista Firewall for Remote Debugging](https://msdn.microsoft.com/en-us/library/bb385831.aspx).
4. If you are using a Web application project and publishing to a remote IIS server, or if you have opened the remote Web site project using the **File System** or **FTP Site** options, you must configure the Visual Studio project start options to enable debugging. To do this for a Web site project, right-click on the Web site project node, and then chose **Start Options**. In the dialog, select the **Use custom server** option and type in the base URL of your Web application on the remote server.  

    For a Web application project, right-click on the project node, chose **Properties**, and the click the **Web** tab. In the **Web** tab, select the **Use IIS Web server** option and type in the base URL of your Web application on the remote server.

    This process is described in detail earlier in the article.
5. Configure permissions to allow debugging to take place. See further notes about how to do this properly.

How you run the Remote Debugging monitor (msvsmon.exe) and configure your permissions depends on whether your are operating in a domain or workgroup environment.

**To set up remote debugging in a workgroup environment**

1. Create an account with the same username and password on both the Visual Studio 2008 client computer and the remote server computer. This account must have Administrative rights on the remote server computer.  

    > [!NOTE]
    > If you are using Windows authentication in your application, this account must be the built-in Administrator account. This means that the built-in Administrator account must have the same password on both computers.
2. Log on to the remote server computer using the account created in Step 1, and run the Visual Studio 2008 Remote Debugger from the Start menu by right-clicking it, and choosing **Run as administrator**. This is important because otherwise the Remote Debugging monitor receives a UAC-filtered token and cannot debug IIS worker processes.  

    > [!NOTE]
    > Do not use the RunAs.exe command to run the msvsmon.exe process, as this always results in a UAC-filtered token and prevents debugging from working *.*

    You also have an option to run the Remote Debugging monitor as a service by opening the **Visual Studio 2008 Remote Debugger Configuration Wizard** from the Start menu. (Select **Start**, **All Programs**, **Microsoft Visual Studio 2008**, and then locate it in the **Visual Studio Tools** folder). If you use this option, you must configure the Remote Debugging monitor to log on using the account created in Step 1. You then also must grant the corresponding account the "Log On As A Service" right in the computer's Local Security Policy console.
3. Log on to the Visual Studio 2008 client computer with the account created in step #1. Run Visual Studio 2008 by right-clicking its icon in the Start menu, and choosing **Run as administrator**.  

    > [!NOTE]
    > It is very important to both log in using the account created in Step 1, and use the **Run as administrator** option when running Visual Studio. As mentioned in Step 1, the account you are using MUST be an Administrative user on the remote server machine.
4. Open the remote IIS Web site by using the **File System**, **FTP Site** or **Remote Site** option).

If you are using Windows authentication in your IIS Web site, you must be running Visual Studio 2008 using the built-in Administrator account and therefore also run the Remote Debugging monitor on the remote computer using the built-in Administrator account. The password for the Administrator account must be the same on the client and remote server computers.

In addition, you can do the following:

- Use the FTP Site option to connect to the remote IIS Web site, and use Anonymous authentication. Then, you do not need to use the built-in Administrator account, as long as the account you are using is an Administrative user on the remote server computer.
- Use the Remote Site option to connect to the remote IIS Web site, and use Basic or Digest authentication. Then, you do not need to use the built-in Administrator account, as long as the account you are using is an Administrative user on the remote server computer.

If you need to use Windows authentication in your IIS Web site, and you cannot use synchronized Administrator accounts, you must turn off UAC on the remote server computer and reboot prior to attempting to debug. This is not recommended for production servers because it may negatively affect the security of your server.

**To set up remote debugging in a domain environment**

Debugging in a domain environment is simpler to configure. To debug in a domain environment, you must:

1. Make the domain account you will be using to run Visual Studio 2008 a member of the Administrators group on the remote server computer.
2. Log on to the remote server computer using the domain account, and run the Remote Debugging monitor (msvsmon.exe) using the **Run as administrator** option.  

    You also have an option to run the Remote Debugging monitor as a service by right clicking the **Visual Studio 2008 Remote Debugger Configuration Wizard** from the Start menu, and choosing **Run as administrator**. You can let the Remote Debugging monitor service run as LocalSystem.
3. Log on to the Visual Studio 2008 client computer with the domain account. Run Visual Studio 2008 by right-clicking its icon in the Start menu, and choosing **Run as administrator**.
4. Open the remote IIS Web site by using the **FTP Site** or **Remote Site** option.

## Summary

This article provided information about using Visual Studio 2008 to work with IIS Web sites located on the local and remote computers, and how to debug Web applications hosted in IIS.
