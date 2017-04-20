---
title: "Create an IIS Manager Provider that uses SQL to Store User Credentials | Microsoft Docs"
author: rmcmurray
description: "Microsoft's Internet Information Services (IIS) was built with extensibility in mind for a variety of management tasks. This extensibility allows developers..."
ms.author: iiscontent
manager: soshir
ms.date: 05/18/2010
ms.topic: article
ms.assetid: 80179bb5-19f6-4088-a17e-1d221efb7bd9
ms.technology: iis-develop
ms.prod: iis
msc.legacyurl: /learn/develop/extending-the-management-ui/how-to-create-an-iis-manager-provider-that-uses-a-sql-database-to-store-user-credentials
msc.type: authoredcontent
---
Create an IIS Manager Provider that uses SQL to Store User Credentials
====================
by [Robert McMurray](https://github.com/rmcmurray)

## Overview

Microsoft's Internet Information Services (IIS) was built with extensibility in mind for a variety of management tasks. This extensibility allows developers the ability to create their own providers that can replace the core management functionality that was shipped when IIS was released. One of the great features in IIS is the IIS Managers, which are accounts that can be allowed to manage the configuration settings even if they are non-Windows accounts that only exist within the context of IIS.

This document walks you through creating a new provider for the IIS Managers feature that uses an SQL database for authentication.

### Prerequisites

The following items are required to complete the procedures in this article:

- IIS 7 or above must be installed on your Windows Server 2008 or Windows Server 2008 R2 computer, along with the following role services: 

    - The IIS Management Console, this is used to configure IIS Managers.
    - The IIS Management Service, this allows for remote management of IIS.
- If you do not have access to an existing SQL Server, you must install SQL Server.

> [!NOTE]
> This document was written using Visual Studio 2008 and an instance of SQL server that is installed on the local web server. You could use this walkthrough with a different version of Visual Studio or a remote database, but you would need to change the appropriate steps accordingly.

## Step 1: Create the SQL Database

The first step is to create the SQL database that will store the usernames, passwords, and statuses for IIS Managers. To do so, use the following steps:

1. Modify the highlighted sections in the following TSQL script for your environment. For example, the script as-written will create the physical database files in `C:\databases`, which is probably not a valid path on your system.

    [!code-sql[Main](how-to-create-an-iis-manager-provider-that-uses-a-sql-database-to-store-user-credentials/samples/sample1.sql)]
2. Open your SQL Server management studio and execute the script as a new query. This will create the "DemoDB" database and the "Authentication" table that the provider will use.
3. Because the management service for IIS runs as "NT AUTHORITY\LOCAL SERVICE", you need to add the "NT AUTHORITY\LOCAL SERVICE" account to the SQL Server database that you just created on your server. To do so, use the following steps: 

    - Open the SQL Server Enterprise Manager on the web server.
    - Create a SQL Server login for NT AUTHORITY\LOCAL SERVICE.
    - Grant the login access to the DemoDB database by creating a database user.
    - Add the database user to the **db\_datareader** and **db\_datawriter** database roles.

## Step 2: Set up the Visual Studio Project Environment

1. Open Microsoft Visual Studio 2008.
2. Click the **File** menu, then **New**, then **Project**.
3. In the **New Project** dialog: 

    - Choose **Visual C#** as the project type.
    - Choose **Class Library** as the template.
    - Type **SqlIisManagerDemo** as the name of the project.
    - Click **OK**.
4. Add a reference path to the Microsoft.Web.Management library: 

    - Click **Project**, then **Add Reference...**
    - Click the **Browse** tab.
    - Navigate to your `%WinDir%\System32\Inetsrv` folder.
    - Select the "Microsoft.Web.Management.dll" file.
    - Click **OK**.
5. Add a strong name key to the project: 

    - Click **Project**, then **SqlIisManagerDemo Properties**.
    - Click the **Signing** tab.
    - Check the **Sign the assembly** check box.
    - Choose **&lt;New...&gt;** from the strong key name drop-down box.
    - Enter **SqlIisManagerDemoKey** for the key file name.
    - If desired, enter a password for the key file; otherwise, uncheck the **Protect my key file with a password** box.
    - Click **OK**.
6. OPTIONAL: Add a custom build event to automatically GAC the DLL: 

    - Click **Project**, then **SqlIisManagerDemo Properties**.
    - Click the **Build Events** tab.
    - Enter the following in the **Post-build event command line** box:  

        [!code-console[Main](how-to-create-an-iis-manager-provider-that-uses-a-sql-database-to-store-user-credentials/samples/sample2.cmd)]
7. OPTIONAL: Enable debugging with IIS Manager: 

    - Click **Project**, then **SqlIisManagerDemo Properties**.
    - Click the **Debug** tab.
    - Click to select **Start External Program**, then enter the following in the text box:  

        [!code-console[Main](how-to-create-an-iis-manager-provider-that-uses-a-sql-database-to-store-user-credentials/samples/sample3.cmd)]
  
 Where C: is your operating system drive.
8. Save the project.

## Step 3: Create the Extensibility Class

1. Add the code for the class: 

    - In **Solution Explorer**, double-click the **Class1.cs** file.
    - Remove the existing code.
    - Paste the following code into the editor: 

        [!code-csharp[Main](how-to-create-an-iis-manager-provider-that-uses-a-sql-database-to-store-user-credentials/samples/sample4.cs)]
2. Save and compile the project.

## Step 4: Add the Provider to IIS

1. Determine the assembly information for the provider: 

    - In Windows Explorer, open your `C:\Windows\assembly` path, where C: is your operating system drive.
    - Locate the **SqlIisManagerDemo** assembly.
    - Right-click the assembly and click **Properties**.
    - Copy the **Culture** value; for example: **Neutral**.
    - Copy the **Version** number; for example: **1.0.0.0**.
    - Copy the **Public Key Token** value; for example: **426f62526f636b73**.
    - Click **Cancel**.
2. Replace the default provider with your demo provider: 

    - Open the administration.config file for editing.
    - In &lt;system.webServer&gt;/&lt;management&gt;, locate and comment out the following default authentication provider: 

        [!code-xml[Main](how-to-create-an-iis-manager-provider-that-uses-a-sql-database-to-store-user-credentials/samples/sample5.xml)]
    - Add the following default authentication provider: 

        [!code-xml[Main](how-to-create-an-iis-manager-provider-that-uses-a-sql-database-to-store-user-credentials/samples/sample6.xml)]
    - Save and close the the administration.config file.
3. Close and re-open the IIS Manager.
4. If you are using the Windows Management Service for IIS, you need to restart that service: 

    - Open IIS Manager.
    - Highlight your server in the **Connections** tab.
    - Double-click the **Management Service** feature in the **Home** pane.
    - Click **Restart** in the **Actions** pane.

## Summary

In this walkthrough you completed the following:

1. Created a SQL database to store usernames, passwords, and statuses.
2. Created a C# class project in Visual Studio for an IIS Management Provider.
3. Replaced the default IIS Management Provider with your custom IIS Management Provider.

After completing all of these steps, when you configure IIS to allow remote management using IIS Manager credentials, those credentials will come from the SQL database instead of the built-in IIS Manager provider.
