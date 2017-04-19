---
title: "How to Use Managed Code (C#) to Create an FTP Provider that Prevents Leeching | Microsoft Docs"
author: rmcmurray
description: "[This documentation is preliminary and is subject to change.] Compatibility Version Notes IIS 8.0 The FTP 8.0 service is required for custom FTP event handli..."
ms.author: iiscontent
manager: soshir
ms.date: 04/20/2012
ms.topic: article
ms.assetid: a734a198-37e6-419a-acb6-a601409ebc35
ms.technology: iis-develop
ms.prod: iis
msc.legacyurl: /learn/develop/developing-for-ftp/how-to-use-managed-code-c-to-create-an-ftp-provider-that-prevents-leeching
msc.type: authoredcontent
---
How to Use Managed Code (C#) to Create an FTP Provider that Prevents Leeching
====================
by [Robert McMurray](https://github.com/rmcmurray)

[This documentation is preliminary and is subject to change.]

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 8.0 | The FTP 8.0 service is required for custom FTP event handling. |
| IIS 7.5 | Custom FTP event handling is not supported in FTP 7.5 for IIS 7.5. |
| IIS 7.0 | Custom FTP event handling is not supported in FTP 7.0 for IIS 7.0. |

Note: The FTP 8.0 service ships as a feature for IIS 8.0 in Windows 8 and Windows 8 Server.

## Introduction

Microsoft has created a new FTP 8.0 service for Windows Server® 2012 that builds upon the rich set of features that were introduced in FTP 7.0 and FTP 7.5. In addition, this new FTP service extends the list of Application Programming Interfaces (APIs) for FTP with new extensibility features like support for custom authorization and simple event processing.

With that in mind, this walkthrough will lead you through the steps to use managed code to create a simple FTP provider that prevents users from downloading more files per-session than you want to allow, which is a behavior that is known that is known in Internet-speak as "[leeching](http://leeching.urbanup.com/392924)." The FTP provider in this walkthrough implements the `IFtpPreprocessProvider.HandlePreprocess()` and `IFtpPostprocessProvider.HandlePostprocess()` methods in order to restrict a user to a maximum number of downloads that you specify in your provider's entry in the ApplicationHost.config file.

### Prerequisites

The following items are required to complete the procedures in this article:

1. IIS 8.0 must be installed on your Windows Server 2012 server, and the Internet Information Services (IIS) Manager must also be installed.
2. The new FTP 8.0 service must be installed.
3. You need to install Visual Studio.

Note: This walkthrough was written by using Visual Studio 2010. You may use other versions of Visual Studio, but some of the steps in this walkthrough may not be exact.

<a id="01"></a>

## Step 1: Set up the Project Environment

In this step, you will create a project in Visual Studio 2010 for the demo provider.

1. Open Microsoft Visual Studio 2010.
2. Click the **File** menu, then **New**, then **Project**.
3. In the **New Project** dialog box: 

    - Choose **Visual C#** as the project type.
    - Choose **Class Library** as the template.
    - Type **FtpLeechPrevention** as the name of the project.
    - Click **OK**.
4. Add a strong name key to the project: 

    - Click **Project**, and then click **FtpLeechPrevention Properties**.
    - Click the **Signing** tab.
    - Check the **Sign the assembly** check box.
    - Choose **&lt;New...&gt;** from the strong key name drop-down box.
    - Enter **FtpLeechPreventionKey** for the key file name.
    - If desired, enter a password for the key file; otherwise, clear the **Protect my key file with a password** check box.
    - Click **OK**.
5. Add a custom build event to add the DLL automatically to the Global Assembly Cache (GAC) on your development computer: 

    - Click **Project**, and then click **FtpLeechPrevention Properties**.
    - Click the **Build Events** tab.
    - Enter the following in the **Post-build event command line** dialog box: 

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-prevents-leeching/samples/sample1.cmd)]
6. Save the project.

<a id="02"></a>

## Step 2: Create the Extensibility Class

In this step, you will implement the extensibility interface for the demo provider.

1. Add a reference to the FTP extensibility library for the project: 

    - Click **Project**, and then click **Add Reference...**
    - Click the **Browse** tab.
    - Navigate to your `%ProgramFiles(x86)%\Reference Assemblies\Microsoft\IIS` folder.
    - Click **Microsoft.Web.FtpServer** and then click **OK**.
2. Add the code for the authentication class: 

    - In **Solution Explorer**, double-click the **Class1.cs** file.
    - Remove the existing code.
    - Paste the following code into the editor: 

        [!code-csharp[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-prevents-leeching/samples/sample2.cs)]
3. Save and compile the project.

> [!NOTE]
> If you did not use the optional steps to register the assemblies in the GAC, you will need to manually copy the assemblies to your IIS 8.0 computer and add the assemblies to the GAC using the Gacutil.exe tool. For more information, see the following topic on Microsoft the MSDN Web site:

[Global Assembly Cache Tool (Gacutil.exe)](https://msdn.microsoft.com/en-us/library/ex0ss12c.aspx)

<a id="03"></a>

## Step 3: Add the Custom Provider to FTP

In this step, you will add the demo provider to your FTP service and an FTP site.

1. Determine the assembly information for the extensibility provider: 

    - Open a command prompt and enter the following commands: 

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-prevents-leeching/samples/sample3.cmd)]
    - Copy the information for the the **FtpLeechPrevention** assembly; for example: 

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-prevents-leeching/samples/sample4.cmd)]
    - Close the .
2. Add the extensibility provider to the global list of FTP providers: 

    - At the moment there is no UI that enables you to add a custom provider with its related configuration settings to IIS, so you will have to use command line syntax like the following example: 

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-prevents-leeching/samples/sample5.cmd)]

        > [!NOTE]
        > You need to update the above syntax using the managed type information for your provider and your desired number of downloads.
3. Add the custom provider to a site: 

    - At the moment there is no UI that enables you to add custom features to a site, so you will have to use command line syntax like the following example that configures the Default Web Site: 

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-prevents-leeching/samples/sample6.cmd)]

<a id="04"></a>

## Summary

In this walkthrough you learned how to:

- Create a project in Visual Studio 2010 for a custom FTP provider.
- Implement the extensibility interface for custom FTP functionality.
- Add a custom provider to your FTP service.

When an FTP client connects to the FTP service, the FTP provider will count the number of times that an FTP client downloads a file, and prevent the user from downloading more files per-session than you have allowed in your configuration settings.