---
title: "How to use the Sample Read-Only XML Membership and Role Providers with IIS 7.0"
author: rmcmurray
description: "When ASP.NET 2.0 was released, the Microsoft Developer Network (MSDN) Web site provided two sample providers for ASP.NET Membership and Roles. These provider..."
ms.date: 01/03/2009
ms.assetid: 93fffee2-fccf-4f51-9c3f-50ecf2bee871
msc.legacyurl: /learn/application-frameworks/building-and-running-aspnet-applications/how-to-use-the-sample-read-only-xml-membership-and-role-providers-with-iis
msc.type: authoredcontent
---
How to use the Sample Read-Only XML Membership and Role Providers with IIS 7.0
====================
by [Robert McMurray](https://github.com/rmcmurray)

## Introduction

When ASP.NET 2.0 was released, the Microsoft Developer Network (MSDN) Web site provided two sample providers for ASP.NET Membership and Roles. These providers were read-only providers that used XML files for the list of users and roles, and were available at the following URLs:

- **Membership Providers**[https://msdn.microsoft.com/library/aa479031.aspx](https://msdn.microsoft.com/library/aa479031.aspx)
- **Role Providers**[https://msdn.microsoft.com/library/aa479032.aspx](https://msdn.microsoft.com/library/aa479032.aspx)

These samples are excellent for use with IIS 7.0 and above for demonstration or test Web sites, but they don't work as-written with IIS because of the way that security is designed in IIS. The original instructions allowed you to deploy the sample membership/role providers into the App\_Code folder of your Web site, but IIS requires that providers are registered in the Global Assembly Cache (GAC) before they can be deployed. With that in mind, the following steps will walk you through compiling and deploying the read-only XML providers on a development system.

### Prerequisites

The following items are required to complete the procedures in this article:

1. IIS 7.0 or above must be installed on your Windows Vista or Windows Server 2008 computer.
2. ASP.NET must be installed for your version of IIS.
3. The Internet Information Services Manager for IIS 7.0 and above must be installed.
4. You will need Gacutil.exe on your IIS computer; this is required to add the assemblies to your Global Assembly Cache (GAC).

## Step 1: Set up the XML provider projects

In this first step you will create a solution in Visual Studio that contains two projects: one for the XML-based membership provider and the other for the XML-based role provider.

1. Open Microsoft Visual Studio 2008.
2. Click the **File** menu, then **New**, then **Project**.
3. In the **New Project** dialog: 

    - Choose **Visual C#** as the project type.
    - Choose **Class Library** as the template.
    - Type **ReadOnlyXmlMembershipProvider** as the name of the project.
    - Type **ReadOnlyXmlProviders** as the name of the solution.
    - Click **OK**.
4. Remove the **Class1.cs** file from the **ReadOnlyXmlMembershipProvider** project: 

    - In the solution explorer, right-click the **Class1.cs** file in the **ReadOnlyXmlMembershipProvider** project, then **Delete**.
    - Click **OK** when prompted to permanently delete the class.
5. Add a reference path to the System.Configuration library: 

    - In the solution explorer, right-click the **ReadOnlyXmlMembershipProvider** project, then **Add Reference...**
    - Click the .NET tab.
    - Select "System.Configuration" in the list of assemblies.
    - Click **OK**.
6. Add a reference path to the System.Web library: 

    - In the solution explorer, right-click the **ReadOnlyXmlMembershipProvider** project, then **Add Reference...**
    - Click the .NET tab.
    - Select "System.Web" in the list of assemblies.
    - Click **OK**.
7. Add a strong name key to the project: 

    - In the solution explorer, right-click the **ReadOnlyXmlRoleProvider** project, then **Properties**.
    - Click the **Signing** tab.
    - Check the **Sign the assembly** check box.
    - Choose **&lt;New...&gt;** from the strong key name drop-down box.
    - Enter **ReadOnlyXmlMembershipProviderKey** for the key file name.
    - If desired, enter a password for the key file; otherwise, uncheck the **Protect my key file with a password** box.
    - Click **OK**.
8. (Optional) Add a custom build event to automatically register the DLL in the GAC: 

    - In the solution explorer, right-click the **ReadOnlyXmlRoleProvider** project, then **Properties**.
    - Click the **Build Events** tab.
    - Enter the following in the **Post-build event command line** box:  

        [!code-console[Main](how-to-use-the-sample-read-only-xml-membership-and-role-providers-with-iis/samples/sample1.cmd)]
9. Add a second project to the solution: 

    - Click **File**, then **Add**, then **New Project...**
    - Choose **Visual C#** as the project type.
    - Choose **Class Library** as the template.
    - Type **ReadOnlyXmlRoleProvider** as the name of the project.
    - Click **OK**.
10. Remove the **Class1.cs** file from the **ReadOnlyXmlRoleProvider** project: 

    - In the solution explorer, right-click the **Class1.cs** file in the **ReadOnlyXmlRoleProvider** project, then **Delete**.
    - Click **OK** when prompted to permanently delete the class.
11. Add a reference path to the System.Configuration library: 

    - In the solution explorer, right-click the **ReadOnlyXmlRoleProvider** project, then **Add Reference...**
    - Click the .NET tab.
    - Select "System.Configuration" in the list of assemblies.
    - Click **OK**.
12. Add a reference path to the System.Web library: 

    - In the solution explorer, right-click the **ReadOnlyXmlRoleProvider** project, then **Add Reference...**
    - Click the .NET tab.
    - Select "System.Web" in the list of assemblies.
    - Click **OK**.
13. Add a strong name key to the project: 

    - In the solution explorer, right-click the **ReadOnlyXmlRoleProvider** project, then **Properties**.
    - Click the **Signing** tab.
    - Check the **Sign the assembly** check box.
    - Choose **&lt;New...&gt;** from the strong key name drop-down box.
    - Enter **ReadOnlyXmlRoleProvider** for the key file name.
    - If desired, enter a password for the key file; otherwise, uncheck the **Protect my key file with a password** box.
    - Click **OK**.
14. (Optional) Add a custom build event to automatically register the DLL in the GAC: 

    - In the solution explorer, right-click the **ReadOnlyXmlRoleProvider** project, then **Properties**.
    - Click the **Build Events** tab.
    - Enter the following in the **Post-build event command line** box:  

        [!code-console[Main](how-to-use-the-sample-read-only-xml-membership-and-role-providers-with-iis/samples/sample2.cmd)]
15. Save the solution.

## Step 2: Add the provider classes for the projects

In this second step you will create the classes for the XML-based membership and role providers. The code for these classes is copied from the [Membership Providers](https://msdn.microsoft.com/library/aa479031.aspx) and [Role Providers](https://msdn.microsoft.com/library/aa479032.aspx) topics on MSDN.

1. Add a new class to the **ReadOnlyXmlMembershipProvider** project: 

    - In the solution explorer, right-click the **ReadOnlyXmlMembershipProvider** project, then **Add**, then **Class...**
    - Name the class **ReadOnlyXmlMembershipProvider.cs**.
    - Click **Add**.
    - Remove the existing code.
    - Paste the following sample code from the [Membership Providers](https://msdn.microsoft.com/library/aa479031.aspx) topic into the editor: 

        [!code-csharp[Main](how-to-use-the-sample-read-only-xml-membership-and-role-providers-with-iis/samples/sample3.cs)]
2. Add a new class to the **ReadOnlyXmlRoleProvider** project: 

    - In the solution explorer, right-click the **ReadOnlyXmlRoleProvider** project, then **Add**, then **Class...**
    - Name the class **ReadOnlyXmlRoleProvider.cs**.
    - Click **Add**.
    - Remove the existing code.
    - Paste the following sample code from the [Role Providers](https://msdn.microsoft.com/library/aa479032.aspx) topic into the editor: 

        [!code-csharp[Main](how-to-use-the-sample-read-only-xml-membership-and-role-providers-with-iis/samples/sample4.cs)]
3. Save and compile both projects.

> [!NOTE]
> If you did not use the optional steps to register the assemblies in the GAC, you will need to manually copy the assemblies to your IIS computer and add the assemblies to the GAC using the Gacutil.exe tool. For more information, see the following topic on Microsoft the MSDN Web site:
> - [Global Assembly Cache Tool (Gacutil.exe)](https://msdn.microsoft.com/library/ex0ss12c(VS.80).aspx)

## Step 3: Add the providers to IIS

In this third step you will determine the assembly information for the membership and role providers, and then add that information to the list of trusted providers for IIS.

1. Determine the assembly information for both providers: 

    - In Windows Explorer, open your `C:\Windows\assembly` path, where C: is your operating system drive.
    - Locate the **ReadOnlyXmlMembershipProvider** and **ReadOnlyXmlRoleProvider** assemblies.
    - Right-click each assembly and click **Properties**.
    - Copy the **Culture** values; for example: **Neutral**.
    - Copy the **Version** numbers; for example: **1.0.0.0**.
    - Copy the **Public Key Token** values; for example: **426f62526f636b73**.
    - Click **Cancel**.
2. Add the XML providers to the list of trusted providers for IIS: 

    - Open the Administration.config file for editing. 

        > [!NOTE]
        > This file is located in your `%WinDir%\System32\Inetsrv\Config` folder.
    - Add the providers with the assembly properties from the previous steps to the `<trustedProviders>` section using the following syntax: 

        [!code-xml[Main](how-to-use-the-sample-read-only-xml-membership-and-role-providers-with-iis/samples/sample5.xml)]
    - Save and close the Administration.config file.

## Step 4: Configure a site for Forms Authentication using the XML providers

In this fourth step you will configure a Web site to use forms authentication with the XML-based membership and role providers by manually creating a Web.config file for your Web site, adding an XML file with the list of users to the Web site's App\_Data folder, and adding a Login.aspx page to the Web site that will process forms authentication requests.

1. Create an XML file for the membership users and roles: 

    - Paste the following code into a text editor: 

        [!code-xml[Main](how-to-use-the-sample-read-only-xml-membership-and-role-providers-with-iis/samples/sample6.xml)]
    - Save the code as "Users.xml" in the App\_Data folder of your Web site.
2. Create a Login.aspx file for your Web site: 

    - Paste the following code into a text editor: 

        [!code-aspx[Main](how-to-use-the-sample-read-only-xml-membership-and-role-providers-with-iis/samples/sample7.aspx)]
    - Save the code as "Login.aspx" in the root of your Web site.
3. Create a Web.config file for your Web site: 

    - Paste the following code into a text editor: 

        [!code-xml[Main](how-to-use-the-sample-read-only-xml-membership-and-role-providers-with-iis/samples/sample8.xml)]

        > [!NOTE]
        > The PublicKeyToken values in the `<providers>` sections your web.config must match the PublicKeyToken values in the `<trustedProviders>` section of your Administration.config file.
    - Save the code as "Web.config" in the root of your Web site.

## Summary

In this walkthrough, you completed the following:

- Set up two class projects in Visual Studio 2008 for the read-only XML membership and role providers.
- Compiled the projects and added them to the Global Assembly Cache.
- Added the XML membership and role providers as trusted providers for IIS.
- Configured a Web site for Forms Authentication using the XML providers.
