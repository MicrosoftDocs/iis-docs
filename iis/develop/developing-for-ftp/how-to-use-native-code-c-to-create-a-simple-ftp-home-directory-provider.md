---
title: "How to Use Native Code (C++) to Create a Simple FTP Home Directory Provider"
author: rmcmurray
description: "Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features tha..."
ms.date: 03/18/2009
ms.assetid: 6b1688f9-8478-49d1-8535-c3a032b94bd7
msc.legacyurl: /learn/develop/developing-for-ftp/how-to-use-native-code-c-to-create-a-simple-ftp-home-directory-provider
msc.type: authoredcontent
---
How to Use Native Code (C++) to Create a Simple FTP Home Directory Provider
====================
by [Robert McMurray](https://github.com/rmcmurray)

Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features that enable Web authors to publish content more easily than before, and offers Web administrators more security and deployment options.

The new FTP 7.5 service supports extensibility that lets you extend the built-in functionality that is included with the FTP service. More specifically, FTP 7.5 supports the creation of your own authentication and authorization providers. You can also create providers for custom FTP logging and for determining the home directory information for your FTP users.

This walkthrough will lead you through the steps to use native code to create a simple FTP home directory provider.

### Prerequisites

The following items are required to complete the procedures in this article:

1. IIS 7.0 or above must be installed on your Windows Server 2008 server, and the Internet Information Services (IIS) Manager must also be installed.
2. The new FTP 7.5 service must be installed. You can download and install the FTP 7.5 service from the [https://www.iis.net/](https://www.iis.net/) web site using one of the following links: 

    - [FTP 7.5 for IIS (x86)](https://go.microsoft.com/fwlink/?LinkId=143196)
    - [FTP 7.5 for IIS (x64)](https://go.microsoft.com/fwlink/?LinkId=143197)
3. You must create a root folder for FTP publishing.
4. You must use Visual Studio 2008. 

    > [!NOTE]
    > If you use an earlier version of Visual Studio, some of the steps in this walkthrough may not be correct.
    
    > [!NOTE]
    > If you plan to develop custom FTP providers for computers that use a 64-bit version of Windows, you will have to install the 64-bit tools and compilers for Visual Studio. You can find additional information about 64-bit development in the [Installing Visual Studio 64-bit Components](https://msdn.microsoft.com/library/ms246588.aspx) topic on the Microsoft MSDN Web site.
5. A home directory for each user must be created; the code sample uses `C:\Ftpusers\%*UserDomain*%\%*UserName*%`, but you could change that as necessary.

## Step 1: Set up the Project Environment

In this step, you will create a project in Visual Studio 2008 for the demo provider.

1. Open Microsoft Visual Studio 2008.
2. Click the **File** menu, then **New**, then **Project**.
3. In the **New Project** dialog box: 

    - Choose **Visual C++** as the project type.
    - Choose **ATL Project** as the template.
    - Type **FtpHomeDirectoryDemo** as the name of the project.
    - Click **OK**.
4. When the **ATL Project Wizard** dialog appears: 

    - Click **Next**.
    - Ensure that only **Dynamic-link library (DLL)** is checked.
    - Click **Finish**.
5. When the project opens, add an ATL Class to the project: 

    - Click **Project**, and then click **Add Class**.
    - Choose **ATL Simple Object** as the template.
    - Click **Add**.
6. When the **ATL Simple Object Wizard** appears: 

    - Enter "**FtpHomeDirDemo**" for the short name and accept the defaults for the other values.
    - Click **Next**.
    - Choose the following options: 

        - Choose **Apartment** for the **Threading model**. *(Note: This can be customized depending on your application's needs.)*
        - Choose **No** for **Aggregation**. *(Note: This can be customized depending on your application's needs.)*
        - Choose **Custom** for the **Interface**.
    - Click **Finish**.
7. Add the extensibility interfaces: 

    - Click **View**, and then click **Class View**.
    - In the **Class View** window, expand **FtpHomeDirectoryDemo**.
    - Right-click **CFtpHomeDirDemo**, then click **Add**, then click **Implement Interface**.
    - Choose **File** for the interface implementation.
    - For the **Location**, enter the full path of the FTP extensibility type library. For example: 

        [!code-console[Main](how-to-use-native-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample1.cmd)]

        > [!NOTE]
        > If you are developing on a 64-bit computer, you should copy the FTP extensibility type library to the following 32-bit path and use that location. For example: 

        [!code-console[Main](how-to-use-native-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample2.cmd)]
    - Choose the following interface to implement: 

        - **IFtpHomeDirectoryProvider**
    - Click **Finish**.
8. Configure the project so that the DLL will not be registered automatically: 

    - Click **Project**, and then click **FtpHomeDirectoryDemoProperties**.
    - Expand **Configuration Properties**, and then click **Linker**.
    - Select **Register Output**, and select **No** from the drop-down menu.
    - Click **OK**.
9. Optional: If you are developing your custom provider on a 32-bit version of Windows, you can optionally add a custom build event to automatically deploy and register the DLL on your development computer.

    > [!NOTE]
    > These steps will not work on a 64-bit version of Windows.

    To add the custom build event, follow these steps:

    - Click **Project**, and then click **FtpHomeDirectoryDemo Properties**.
    - Expand **Configuration Properties**, then expand **Build Events**, then click **Post-build Event**.
    - Click the ellipsis **(...)** on the right side of the **Command line** text box.
    - Enter the following in the **Command line** dialog box: 

        [!code-console[Main](how-to-use-native-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample3.cmd)]
    - Click **OK** to close the **Command line** dialog box.
    - Click **OK** to close the **FtpHomeDirectoryDemo Property Pages** dialog box.
10. If you are developing a provider for a 64-bit version of Windows, you will need to add a build configuration for 64-bit complilation: 

    - Click **Build**, and then click **Configuration Manger...**
    - Select **&lt;New...&gt;** in the **Active Solution Platform** drop-down menu.
    - Select **x64** in the **Type or select the new platform** drop-down menu.
    - Click **OK**.
    - Click **Close**.
11. Save the project.

## Step 2: Implement the Extensibility Interface

In this step, you will implement the extensibility interface for the demo provider.

1. Implement **IFtpHomeDirectoryProvider**: 

    - In the **Class View** window, double-click the **GetUserHomeDirectoryData** method.
    - Replace the existing implementation with the following code: 

        [!code-csharp[Main](how-to-use-native-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample4.cs)]
2. Add an include file reference for **strsafe.h** to the start of the **FtpHomeDirDemo.h** file:

    [!code-console[Main](how-to-use-native-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample5.cmd)]
3. Save and compile the project.

## Step 3: Add the Home Directory Provider to FTP

In this step, you will add the demo provider to your FTP service and the default Web site.

1. Add the extensibility provider to the global list of FTP authentication providers: 

    - Open the **Internet Information Services (IIS) Manager**.
    - Click your computer name in the **Connections** pane.
    - Double-click **FTP Authentication** in the main window.
    - Click **Custom Providers...** in the **Actions** pane.
    - Click **Register**.
    - Enter **FtpHomeDirectoryDemo** for the provider **Name**.
    - Click **Native Provider (COM)**.
    - Enter the class name for the extensibility provider as **FtpHomeDirectoryDemo.FtpHomeDirDemo**.
    - Click **OK**.
    - Clear the **FtpHomeDirectoryDemo** check box in the providers list.
    - Click **OK**.
2. Add the custom provider to a site: 

    - At the moment there is no UI that enables you to add custom features to a site, so you will have to use the following command line: 

        [!code-console[Main](how-to-use-native-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample6.cmd)]
3. Configure user isolation to use a custom provider: 

    - At the moment there is no UI that enables you to specify custom features for user isolation, so you will have to use the following command line: 

        [!code-console[Main](how-to-use-native-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample7.cmd)]

## Summary

In this walkthrough you learned how to:

- Create a project in Visual Studio 2008 for a custom FTP home directory provider.
- Implement the extensibility interface for custom FTP home directory lookups.
- Add a custom home directory provider to your FTP service.

When users connect to your FTP site, the FTP service will set each user's home directory to the path that you specified in the demo provider.
