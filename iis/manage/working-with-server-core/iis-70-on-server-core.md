---
title: "IIS 7.0 on Server Core"
author: tobint
description: "As you may know from TechEd 2007 announcements and a Bill Staples' blog post, IIS 7.0 is supported on the Server Core installation option of Windows Server..."
ms.date: 11/16/2007
ms.assetid: f7b99d1e-868f-4bb7-8968-a93550f248f2
msc.legacyurl: /learn/manage/working-with-server-core/iis-70-on-server-core
msc.type: authoredcontent
---
# IIS 7.0 on Server Core

by [Tobin Titus](https://github.com/tobint)

As you may know from TechEd 2007 announcements and [a Bill Staples' blog post](https://blogs.iis.net/bills/archive/2007/06/04/iis7-on-server-core.aspx), IIS 7.0 is supported on the Server Core installation option of Windows Server® 2008. IIS 7.0 on Server Core combines a powerful new Web server with a minimal footprint server operating system, which has a smaller disk space requirement, lower memory utilization, a reduced attack surface, and lower servicing needs.

This article provides basic instructions for getting started with IIS 7.0 on Server Core, including installation instructions for running Classic ASP applications.

## IIS Deployment and Configuration Tips

**Q1. How to install IIS 7.0 on Server Core?**

A. You can use pkgmgr.exe command line tool option to install IIS 7.0 on your Server core box. For **default IIS install option**, type following on the command-window:

[!code-console[Main](iis-70-on-server-core/samples/sample1.cmd)]

For **Full IIS install** option, you can type following in command-line:

[!code-console[Main](iis-70-on-server-core/samples/sample2.cmd)]

> [!NOTE]
>
> 1. To uninstall IIS, you can pass "/uu:" instead of "/iu:" for the commands mentioned above (Ex. Start /w pkgmgr **/uu:** IIS-WebServerRole….).
> 2. For more information on pkgmgr.exe, see the [Installing IIS 7.0 from the Command Line](../../install/installing-iis-7/installing-iis-from-the-command-line.md) article.

**Q2. Which features of IIS 7.0 are not available on Server Core installation option of Windows Server 2008?**

Server Core installations on Windows Server 2008 comes with certain differences from regular Windows Server 2008 OS installations. In a nutshell, .Net framework is not available (hence no ASP.Net) and there is no windows shell so GUI administration tools are not available. As a note, availability and support of .Net framework on Server Core installation option is being discussed so there is no final answer on that as of this date yet.

A. Following features are not available as installation options on Server Core:

- IIS-ASPNET
- IIS-NetFxExtensibility
- IIS-ManagementConsole
- IIS-ManagementService
- IIS-LegacySnapIn
- IIS-FTPManagement
- WAS-NetFxEnvironment
- WAS-ConfigurationAPI

**Q3. How do you install Classic ASP on Server Core?**

A. Type following pkgmgr.exe command to install Classic ASP along with features for Static Content Web Server on Server Core machine.

[!code-console[Main](iis-70-on-server-core/samples/sample3.cmd)]

## Server Core Administration Tips

This section includes a few command line utilities and commands to perform common tasks/actions on command-line.

**Q1. How do you start a command window on Server Core installation?**

A. Click Ctrl+Alt+Del and then choose "Start Task Manager". In Task Manager window, click File and choose "New Task (Run…)" option on the menu. Type cmd.exe on Create New Task window and hit ok.

**Q2. How do you enable Remote Desktop for Server Core installed box?**

A. If you plan to access from another Windows Server 2008 or Vista machine, please execute this from command-line:

[!code-console[Main](iis-70-on-server-core/samples/sample5.cmd)]

Otherwise, if you plan to access from a machine which has earlier version of Windows OS (i.e. Windows XP), please execute following:

[!code-console[Main](iis-70-on-server-core/samples/sample6.cmd)]

[!code-console[Main](iis-70-on-server-core/samples/sample7.cmd)]

**Q3. How do you change administrator password?**

A. Type `Net user administrator *` in the command-window. When prompted, please type the new password for administrator user.

**Q4. How do you add a user to local administrators group?**

[!code-console[Main](iis-70-on-server-core/samples/sample8.cmd)]

**Q5. How do you add a user to local administrators group?**

[!code-console[Main](iis-70-on-server-core/samples/sample9.cmd)]

**Q6. How do you change machine name?**

A. If machine is in a workgroup, then please type following in command window:

[!code-console[Main](iis-70-on-server-core/samples/sample10.cmd)]

Otherwise, if machine is a member of a domain then please type following in command window:

[!code-console[Main](iis-70-on-server-core/samples/sample11.cmd)]

**Q7. How do you join a machine to domain?**

A. Type following on command-window:

[!code-console[Main](iis-70-on-server-core/samples/sample12.cmd)]

**Q8. How do you remove a machine from the domain?**

[!code-console[Main](iis-70-on-server-core/samples/sample13.cmd)]

**Q9. How do you disable the firewall?**

[!code-console[Main](iis-70-on-server-core/samples/sample14.cmd)]

**Q10. How do you restart a Server Core machine?**

[!code-console[Main](iis-70-on-server-core/samples/sample15.cmd)]

**Q11. How do you install an updates?**

[!code-console[Main](iis-70-on-server-core/samples/sample16.cmd)]

**Q12. How do you access event logs?**

A. Enumerate event log names by typing "*Wevtutil el*". In order to see/query events in a particular log, please type "*Wevtutil qe &lt;event log name&gt;*".
