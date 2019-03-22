---
title: "Walkthrough: Creating a Hosted Web Core Application"
ms.date: "10/07/2016"
ms.assetid: d59ceebe-e5dc-4e2d-a95d-cb98ad8ca331
---
# Walkthrough: Creating a Hosted Web Core Application
This walkthrough demonstrates how to create a Windows console application that uses the Hosted Web Core features that are available in [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)].  
  
 The Hosted Web Core functionality in [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] enables you to create an application that loads an instance of the IIS core, which is the base Web application and content-serving functionality that is provided by IIS. For more information about the Hosted Web Core, see [Hosted Web Core API Reference](../../web-development-reference/native-code-api-reference/hosted-web-core-api-reference.md).  
  
 You have to provide a configuration file for your application that follows the format of the ApplicationHost.config file. However, you should not use your actual ApplicationHost.config file, because it may contain settings that conflict with your Web site settings. For more information about how to create a configuration file for your application, see [Walkthrough: Creating a Configuration File for Hosted Web Core](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-configuration-file-for-hosted-web-core.md).  
  
 Tasks illustrated in this walkthrough include the following:  
  
-   Creating a C++ project for your application.  
  
-   Adding the C++ code for your application.  
  
-   Compiling and testing your application.  
  
-   Troubleshooting errors when you use your application.  
  
## Prerequisites  
 The following software is required to complete the steps in the example:  
  
-   [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)].  
  
> [!NOTE]
>  While you will have to run your Hosted Web Core application on a computer that has [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] installed, you do not have to compile the example application on a computer that has [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] installed. You can compile your application on a different version of Windows and then copy your application to a computer that has [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] installed.  
  
-   [!INCLUDE[vsprvslong](../../wmi-provider/includes/vsprvslong-md.md)].  
  
> [!NOTE]
> You may also use Visual Studio .NET 2003 or earlier, although the walkthrough steps may not be identical.  
  
## Creating a Hosted Web Core Application  
 In this part of the walkthrough, you will create a C++ console application project for your application.  
  
#### To create a C++ project for your application  
  
1.  Start [!INCLUDE[vsprvslong](../../wmi-provider/includes/vsprvslong-md.md)].  
  
2.  Verify that the global options have all the correct paths to the SDK include files:  
  
    1.  On the **Tools** menu, click **Options**.  
  
         The **Options** dialog box opens.  
  
    2.  Expand the **Projects and Solutions** node in the tree view, and then click **VC++ Directories**.  
  
    3.  In the **Show directories for** box, select **Include files**.  
  
    4.  Verify that the path where you installed the SDK include files is listed. If the path is not listed, click the **New Line** icon, and then add the path where you installed the SDK include files.  
  
    5.  Click **OK**.  
  
3.  Create a new C++ project:  
  
    1.  On the **File** menu, point to **New**, and then click **Project**.  
  
         The **New Project** dialog box opens.  
  
    2.  In the **Project types** pane, expand the **Visual C++** node, and then click **Win32**.  
  
    3.  In the **Templates** pane, click **Win32 Project**.  
  
    4.  In the **Name** box, type **HostedWebTest**.  
  
    5.  In the **Location** box, type the path for the project.  
  
    6.  Click **OK**.  
  
         The **Win32 Application Wizard** opens.  
  
    7.  Click **Application Settings**.  
  
    8.  Under **Application type**, click **Console Application**.  
  
    9. Click **Finish**.  
  
         Visual Studio opens the HostWebTest.cpp project.  
  
4.  Configure the project to compile by using the `__stdcall (/Gz)` calling convention:  
  
    1.  On the **Project** menu, click **HostedWebTest Properties**.  
  
    2.  Expand the **Configuration Properties** node in the tree view, expand the **C/C++** node, and then click **Advanced**.  
  
    3.  In the **Configuration** box, select **All Configurations**  
  
    4.  In the **Calling Convention** box, select **__stdcall (/Gz)**.  
  
    5.  Click **OK**.  
  
## Adding the Code for the Application  
 This section shows how to replace the code that was automatically added to your C++ file with code that will run the Hosted Web Core.  
  
> [!NOTE]
> This example looks for a file named HostedWebTest.config in your Inetsrv folder. You can modify the path and file name, but you must provide a valid configuration file. For more information about how to create a configuration file for your application, see [Walkthrough: Creating a Configuration File for Hosted Web Core](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-configuration-file-for-hosted-web-core.md).  
  
#### To add the C++ code for your application  
  
1.  Open the HostedWebTest.cpp file, if it is not already open, and then remove all the existing C++ code.  
  
2.  Copy the following C++ code into the file:  
  
<!-- TODO: review snippet reference      [!CODE [CHostedWebCoreHostedWebTest#1](CHostedWebCoreHostedWebTest#1)]  -->  
  
3.  Save the HostedWebTest.cpp file.  
  
## Compiling and Testing the Application  
 After creating and saving your C++ file, the next step is to compile and test your application.  
  
> [!NOTE]
> If you do not compile your application on a computer that has [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] installed, you will have to copy the HostedWebTest.exe file to a computer that has [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] installed before you test the application.  
  
#### To compile and test your application  
  
1.  Compile the application:  
  
    1.  On the **Build** menu, click **Build Solution**.  
  
    2.  Verify that Visual Studio did not return any errors or warnings. If you see any errors or warnings, you will have to resolve those issues before testing the project.  
  
2.  Open Windows Explorer and locate the folder that you specified when you created the C++ project.  
  
     Depending on your build options, you should see a folder named **Debug** or **Release** in the default folder for your project.  
  
3.  Inside the **Debug** or **Release** folder, locate the file named HostedWebTest.exe.  
  
4.  Verify that your configuration file is in the appropriate folder for your application. For example, the code example listed earlier in this walkthrough is designed to use a file named HostedWebTest.config that is located in your Inetsrv folder.  
  
5.  Open the Command Prompt window and change directories to the path where your HostedWebTest.exe file is located.  
  
6.  Type **HostedWebTest** and press ENTER to start the application.  
  
7.  You should see output from your application that resembles the following:  
  
    ```  
    DLL loaded successfully.  
    WebCoreActivate successfully resolved.  
    WebCoreShutdown successfully resolved.  
    Activating the Web core...  
    WebCoreActivate was successful.  
    Press any key to continue...  
    ```  
  
8.  Minimize the Command Prompt window without pressing any keys on the keyboard.  
  
9. Depending on your configuration settings, you can open a Web browser and browse to the Web site that is defined in your configuration file.  
  
10. When you have finished browsing to your Web site, return to the Command Prompt window and press SPACEBAR.  
  
11. You should see output from your application that resembles the following:  
  
    ```  
    Shutting down the Web core...  
    WebCoreShutdown was successful.  
    ```  
  
## Troubleshooting Errors  
 If your application does not load, or it returns an error when it is running, the following steps will help you diagnose some of the errors that you might experience.  
  
#### To troubleshoot errors in your application  
  
-   If your application returns the following error:  
  
    ```  
    Could not load DLL.  
    Error: 0x8007007e  
    ```  
  
     This is an ERROR_MOD_NOT_FOUND status. This error indicates that the Hwebcore.dll file cannot be located. This error will occur if IIS is not installed.  
  
-   If your application returns the following error:  
  
    ```  
    DLL loaded successfully.  
    WebCoreActivate successfully resolved.  
    WebCoreShutdown successfully resolved.  
    Activating the Web core...  
    WebCoreActivate failed.  
    Error: 0x8007000d  
    ```  
  
     This is an ERROR_INVALID_DATA status. This error indicates that your configuration file cannot be located or contains errors. You should look in the Windows Event Viewer for additional error descriptions.  
  
-   If your application returns the following error:  
  
    ```  
    DLL loaded successfully.  
    WebCoreActivate successfully resolved.  
    WebCoreShutdown successfully resolved.  
    Activating the Web core...  
    WebCoreActivate failed.  
    Error: 0x800700b7  
    ```  
  
     This is an ERROR_ALREADY_EXISTS status. This error indicates that your configuration file was loaded, but it contains duplicate information. For example, you may have defined more than one application pool, or you may have created duplicate Web site bindings. You should examine the Windows Event Viewer for additional error descriptions.  
  
-   If your application loads successfully, but you receive HTTP 404 errors when you browse the Web site that is hosted by your application, you should examine the IIS logs that are created by your application for the 404 substatus codes. Here are some of the substatus codes that you may see:  
  
    -   404.3 "Denied by Mime Map"—This substatus code indicates that the MIME type for a requested resource is not correctly configured. For example, you will encounter this code if you browse to a file that has a .txt file name extension, and you have not added that extension to the MIME map in your configuration file.  
  
    -   404.4 "No Handler"—This substatus code indicates that no handler has been configured for the requested resource. For example, you will encounter this code if you browse to a file that has an .htm file name extension, and you have not added the static file handler to your configuration file.  
  
    -   404.7 "File Extension Denied"—This substatus code indicates that the file name extension has been blocked by request filtering. For example, you will encounter this code if you browse to a file that has a .gif file name extension, and request filtering has been configured to deny access to files that have that extension.  
  
     Each of these errors indicates a problem with the settings in your application's configuration file. For more information, see [Walkthrough: Creating a Configuration File for Hosted Web Core](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-configuration-file-for-hosted-web-core.md).  
  
## See Also  
 [Creating Hosted Web Core Applications](../../web-development-reference/native-code-development-overview/creating-hosted-web-core-applications.md)   
 [Walkthrough: Creating a Configuration File for Hosted Web Core](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-configuration-file-for-hosted-web-core.md)   
 [PFN_WEB_CORE_ACTIVATE Function](../../web-development-reference/native-code-api-reference/pfn-web-core-activate-function.md)   
 [PFN_WEB_CORE_SHUTDOWN Function](../../web-development-reference/native-code-api-reference/pfn-web-core-shutdown-function.md)