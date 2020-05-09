---
title: "Install and Configure IIS 7 on Server Core"
author: rick-anderson
description: "Introduction Server Core, the minimal server installation option for Windows Server ® 2008, is available in Standard, Enterprise, and Datacenter editions. Se..."
ms.date: 01/30/2008
ms.assetid: 2128f157-5a8f-407a-9fd7-6b1ea714fc60
msc.legacyurl: /learn/install/installing-iis-7/install-and-configure-iis-on-server-core
msc.type: authoredcontent
---
Install and Configure IIS 7 on Server Core
====================
by IIS Team

## Introduction

Server Core, the minimal server installation option for Windows Server® 2008, is available in Standard, Enterprise, and Datacenter editions. Server Core supports a subset of the server roles available in full installations of the operating system, including the Internet Information Services 7 and above (IIS 7 and above) Web server. In a Server Core installation, only the services, roles, and features required for an installed role are installed.

Running IIS on Server Core provides a modular, customizable Web server on a thin server operating system. This makes it ideal for appliance-like environments, Web farm front-end servers and Web sites, or applications that require minimal maintenance.

With the addition of the Microsoft® .NET Framework to Server Core in Windows Server® 2008 R2, the Server Core installation option becomes even more appealing for those who want to use a very small footprint server for hosting their applications. Availability of the .NET Framework provides:

- **Microsoft®** **ASP.NET support.**  
 With Windows Server 2008 R2, Server Core can be used to host ASP.NET applications.
- **IIS Remote Management.**   
 Server Core does not provide any user interface other than the command-line interface. With the Windows Server 2008 R2 Server Core option, it is possible use IIS Manager for Remote Administration to connect to IIS and perform all management tasks from within the familiar user interface (UI) of IIS Manager.
- **Windows PowerShell™.**  
 The Windows Server 2008 R2 Server Core option includes the IIS Windows PowerShell snap-in (also available with other installation options of Windows Server 2008 R2).

## Install Server Core

To install IIS on an installed and configured Server Core installation of Windows Server 2008, you must have an administrator user account and password for the server running the Server Core installation.

1. Server Core is set up like a typical Windows Server 2008 server, except the "Server Core Installation" option is selected. The Server Core then forces a change in the administrator password.  
    [![](install-and-configure-iis-on-server-core/_static/image2.jpg)](install-and-configure-iis-on-server-core/_static/image1.jpg)  
    *Figure 1: Select Server Core option*
2. Next, verify the NIC and IPConfig (not necessary if there is a Dynamic Host Configuration Protocol [DHCP] server running on the network). To fix an IP address, type the following:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample1.cmd)]
3. To add a Domain Name System (DNS) server entry, type:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample2.cmd)]
4. To find the computer name, type:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample3.cmd)]
5. To change the computer name type:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample4.cmd)]
6. Reboot with the command:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample5.cmd)]
7. To join the domain, type:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample6.cmd)]
8. Reboot with the command:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample7.cmd)]
9. To prevent a later setup error in MySQL, open an exception for MySQL:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample8.cmd)]
10. Reboot with the command:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample9.cmd)]
11. Next, activate Server Core.  

    - Use the following command if connected to the Internet:  

        [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample10.cmd)]
    - If not connected to the Internet, use phone activation.   
    Type one of the following:  

        [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample11.cmd)]
  
    (This displays the installation identification to be given to Microsoft.)  

        [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample12.cmd)]
  
    (This activates the server using the confirmation ID given by Microsoft.)

For more information on the initial setup tasks such as managing the Windows® Firewall and configuring for automatic updates, see [Making Sense of Server Core](https://technet.microsoft.com/magazine/2009.02.geekofalltrades.aspx?pr=blog). Also see the [Server Core Installation Option Getting Started Guide](https://technet.microsoft.com/library/cc753802(WS.10).aspx).

After the Server Core installation is complete and the server is configured, you can install one or more server roles. The Server Core installation of Windows Server 2008 supports the following server roles:

- Active Directory® Domain Services
- Active Directory Lightweight Domain Services
- DHCP Server
- DNS Server
- File Services
- Media Services
- Print Services
- Hyper-V™
- Web Services (IIS) (Limited)
- Web Server (IIS)

## Install IIS

See [Install IIS 7.5 on Windows Server 2008 R2 using a Server Core installation](https://technet.microsoft.com/library/cc771209.aspx) for detailed instructions. Note that the full IIS installation, which installs all available feature packages for Server Core. If there are feature packages you do not need, you should edit the script to install only the packages you require. The default IIS installation installs a minimal set of available feature packages.

If you want to install IIS components that rely on the .NET Framework, you must first install the .NET Framework. The components that rely on the .NET Framework will not be installed if the .NET Framework is not already installed.

To use a script to install the .NET Framework and the full IIS 7.5 installation on Server Core, type the following command into a script:

[!code-console[Main](install-and-configure-iis-on-server-core/samples/sample13.cmd)]
 
To use a script for the full IIS 7.5 installation on Server Core, type the following command into a script:

[!code-console[Main](install-and-configure-iis-on-server-core/samples/sample14.cmd)]

To use a script for the default installation on Server Core, type the following command into a script:

[!code-console[Main](install-and-configure-iis-on-server-core/samples/sample15.cmd)]

See [IIS 7.0 on Server Core](../../manage/working-with-server-core/iis-70-on-server-core.md) and  Installing IIS 7.0 on Server Core for more information about installing IIS 7.0.

## Install Roles and Services

1. Use the command **oclist** to list the available and installed roles and services on the server. The oclist command also renders component dependencies.  
    [![](install-and-configure-iis-on-server-core/_static/image2.gif)](install-and-configure-iis-on-server-core/_static/image1.gif)  
    *Figure 2: Output of oclist command*  
  
   In the figure above, the oclist output shows that IIS-FTPExtensibility is dependent on IIS-FTPSvc. To install IIS-FTPExtensibility, it is first necessary to install IIS-FTPSvc.
2. Use the **ocsetup** command to install and uninstall individual roles and services.
3. Next,run **oclist | more** to verify which IIS components have been installed.

### Install the .NET Framework

If you plan to use ASP.NET or IIS Remote Management then it is necessary to install .NET Framework first. To install it use the following commands:

[!code-console[Main](install-and-configure-iis-on-server-core/samples/sample16.cmd)]

### Install ASP.NET

1. Install ASP.NET by running the following commands (in order):  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample17.cmd)]

### Install Windows PowerShell and IIS Snap-In

1. Install Windows PowerShell by running the following command:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample18.cmd)]
2. Next, start Windows PowerShell with the following command:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample19.cmd)]

   You should see a PowerShell prompt.
3. In order to enable the IIS snap-in, you must change the script execution policy by running this command:  

    [!code-powershell[Main](install-and-configure-iis-on-server-core/samples/sample20.ps1)]
4. Restart PowerShell for the policy changes to take effect. After restarting PowerShell, import the IIS snap-in:  

    [!code-powershell[Main](install-and-configure-iis-on-server-core/samples/sample21.ps1)]
5. You can obtain the list of available IIS cmdlets by typing:  

    [!code-powershell[Main](install-and-configure-iis-on-server-core/samples/sample22.ps1)]

Refer to [Managing IIS with IIS 7.0 PowerShell Snap-in](../../manage/powershell/index.md) and [Managing IIS with the IIS 7.0 PowerShell Snap-in](../../manage/powershell/index.md) for more information.

For information about Windows PowerShell on Server Core, see [Dmitry's PowerBlog: PowerShell and Beyond](http://dmitrysotnikov.wordpress.com/2008/05/15/powershell-on-server-core/).

### Enable IIS Remote Management

Because Windows Server 2008 R2 Server Core does not have a graphical user interface (GUI), the command prompt must be used for administrative tasks. It may be more convenient to manage Server Core from another computer using IIS remote management.

The IIS Manager for Remote Administration:

- Remotely manages IIS from Windows® 7, Windows Vista®, Windows® XP, and Windows Server® 2003.
- Connects directly to a Web server, Web site, or Web application.
- Installs even when IIS is not installed on the local computer.
- Allows multiple simultaneous connections.
- Supports delegated administration to Web sites and Web applications, so owners can connect to and manage their own site directly.
- Is a familiar and easy-to-use administration tool.
- Supports HTTP over Secure Sockets Layer (SSL) for more secure management.
- Automatically downloads features to the local IIS Manager for Remote Administration console to match features newly installed on the remote Web server.

For more information, see [IIS Manager for Remote Administration](https://www.iis.net/downloads/microsoft/iis-manager) and [Remote Administration for IIS Manager](../../manage/remote-administration/remote-administration-for-iis-manager.md#01).

1. By default, Remote Desktop is not enabled on the Server Core. Install the IIS remote management service by using the following command:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample23.cmd)]
2. Enable remote management with the following command:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample24.cmd)]
3. Start the management service by typing:  

    [!code-console[Main](install-and-configure-iis-on-server-core/samples/sample25.cmd)]
4. Connect to the IIS on the Server Core from a remote machine by using [IIS Manager for Remote Administration](https://www.iis.net/downloads?tabid=34&g=6&i=1626 "IIS Remote Manager").

To uninstall the Web Server (IIS) role, use the following command:

[!code-console[Main](install-and-configure-iis-on-server-core/samples/sample26.cmd)]

## Links for Further Information

- [IIS 7.0 on Server Core](../../manage/working-with-server-core/iis-70-on-server-core.md).
- [Setup IIS on Server Core – Windows Server 2008 R2](https://blogs.iis.net/ruslany/archive/2009/02/26/setup-iis-on-server-core-windows-server-2008-r2.aspx).
- [Server Core Presentation](https://download.microsoft.com/download/6/3/5/6350896f-1e08-440b-9f24-d50f5e9b2390/ServerCoredeepdive.ppt).
- [Server Core Installation Option Getting Started Guide](https://technet.microsoft.com/library/cc753802(WS.10).aspx).
- [Administering IIS7 on Server Core Installations of Windows Server 2008](https://blogs.iis.net/metegokt/archive/2007/06/26/administering-iis7-on-server-core-installations-of-windows-server-2008.aspx).
