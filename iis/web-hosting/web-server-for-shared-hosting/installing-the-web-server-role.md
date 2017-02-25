---
title: "Installing the Web Server Role | Microsoft Docs"
author: rick-anderson
description: "To install the Web Server role on a machine that already is running Windows Server ® 2008 R2 (as is the case when building a reference machine for deployment..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/01/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/installing-the-web-server-role
msc.type: authoredcontent
---
Installing the Web Server Role
====================
by Walter Oliver

To install the Web Server role on a machine that already is running Windows Server® 2008 R2 (as is the case when building a reference machine for deployment in a data center), follow these steps:

**Important**: Run these steps as an administrator.

**To install the Web Server role using Server Manager**

1. Navigate to **Administrative Tools** and click **Server Manager**.
2. In Server Manager, in the **Roles Summary** section, click **Add Roles** to start the **Add Roles Wizard**.
3. Click **Server Roles.**
4. Under **Select one of more roles to install on this server**, select **Web Server (IIS)**.
5. Click **Next** and continue with the **Add Roles Wizard**.

> [!NOTE]
> If you use the **Add Roles Wizard** to install IIS, you get the default installation, which has a minimum set of role services. If you need additional IIS role services, such as **Application Development** or **Health and Diagnostics**, make sure to select the check boxes associated with those features in the **Select Role Services** page of the wizard.

**To install using a script:** 

[!code-console[Main](installing-the-web-server-role/samples/sample1.cmd)]

- > [!IMPORTANT]
 > If you use this script, you get the full IIS installation, which installs all available feature packages. If there are feature packages you do not need, you should edit the script to install only the packages you require.

If you want to install IIS components that rely on the .NET Framework, you must first install the .NET Framework. The components that rely on the .NET Framework will not be installed if the .NET Framework is not already installed.

**Type the following command into a script:** 

[!code-console[Main](installing-the-web-server-role/samples/sample2.cmd)]

For scripting the full IIS installation on Server Core, use the following script.

**Type the following command into a script:** 

[!code-console[Main](installing-the-web-server-role/samples/sample3.cmd)]

- > [!IMPORTANT]
 > If you use this script, you get the full IIS installation, which installs all available feature packages for Server Core. If there are feature packages you do not need, you should edit the script to install only the packages you require.