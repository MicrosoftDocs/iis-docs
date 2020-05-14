---
title: "Troubleshooting IIS 7.x Installation Issues"
author: puneet-gupta
description: "System Update Readiness Tool MSConfig.exe This material is provided for informational purposes only. Microsoft makes no warranties, express or implied. Overv..."
ms.date: 04/09/2012
ms.assetid: 4daa9338-786e-47ac-9674-fe355e8dcee9
msc.legacyurl: /learn/troubleshoot/installation-issues/troubleshooting-iis-7x-installation-issues
msc.type: authoredcontent
---
# Troubleshooting IIS 7.x Installation Issues

by [Puneet Gupta](https://github.com/puneet-gupta)

#### Tools Used in this Troubleshooter:

- [System Update Readiness Tool](https://support.microsoft.com/kb/947821)
- MSConfig.exe

This material is provided for informational purposes only. Microsoft makes no warranties, express or implied.

## Overview

Troubleshooting IIS installation issues can be a very tricky task. The installation process does its own logging in simple text file, usually called IIS7.log (for IIS 7.x versions and IIS6.log for IIS 6.0).

In this section we will focus on IIS7.x installation issues and reference to its logging for troubleshooting purposes.

## Reviewing the IIS setup Logs

The first thing to look for is errors in the IIS7.LOG (ex: `c:\windows\iis7.log`).

Search for word "**FAIL**"

Here is an example of an entry in IIS7.log

[!code-console[Main](troubleshooting-iis-7x-installation-issues/samples/sample1.cmd)]

You can see that it clearly tells you the EXE the setup ran and if that succeeded or not. With the error message and installation command line, search bing.com for the error found: **"InstallFtpMetabaseEntries result=0x800708c5"**

You could rerun he setup command from the command line above (highlighted). Doing this will help you isolate the issue and will let you collect right data (like process monitor) for just that failure and you won't have to run the SETUP again and again.

Try stopping all 3rd party (non-Microsoft services from startup) and reboot the box before trying next install/uninstall of IIS.

To quickly identify and disable these services, go to start à run and Type "**msconfig**" (without quotes). It will open up system configuration dialogue box. Go to Services tab and select the check box "Hide all Microsoft services" at the bottom and then disable all 3rd party services that can be stopped without effecting server's reboot. Usually these are anti-virus software, backup software etc

Another common, but most important scenario people forget is to uninstall WPAS "Windows Process Activation Services" – especially when they are trying to uninstall and reinstall IIS. When you install IIS then installer adds WPAS for you automatically as one of the dependencies, BUT when you uninstall IIS WPAS does not get uninstalled automatically – leaving the core binaries intact (this is done for a reason and is not a BUG. In short, it's not uninstalled to make sure we don't end up breaking other services on the box that consume this process model explicitly – like WCF service). One has to make sure WPAS is explicitly uninstalled by going to features under server manager and choosing "Windows Process Activation Services" to uninstall.

> [!NOTE]
> This was changed in IIS 7.5. In IIS 7.5 the uninstaller will check for other dependencies for WAS (such as WCF), and if none are found then the IIS uninstallation process will remove WAS.

## Reviewing the CBS (Component based Setup) Logs

If IIS7.log is clean, then there is a good chance that the problem is in CBS (Component based Setup) engine. CBS logs can be found at `C:\Windows\Logs\CBS folder`.

Just like IIS7.log file, CBS.log file is a It is a text file and can be opened in a text editor of your choice (you will have to open this file from administrative command prompt). You can get some useful information out of these logs by keeping the time frame of the installation failure in mind and searching for "Failure will not be ignored: A rollback will be initiated" string in the CBS.LOG file. Here is an example of one such instance.

[!code-console[Main](troubleshooting-iis-7x-installation-issues/samples/sample2.cmd)]

As with the IIS7.log, you can start using your web searching skills on BING.COM and look for next clue.

> [!TIP]
> Try other ROLES and see if they fail. If they do IIS is just a victim and you can engage Platforms setup for assistance if you do not wish to follow the next steps.

Run the [System Update Readiness Tool](https://support.microsoft.com/kb/947821) (short name CHECKSUR) – This tool is available for Windows Vista, for Windows Server 2008, for Windows 7, and for Windows Server 2008 R2. The download for this tool is a little big but it is worth running it. If installation of this tool fails, then you have some other issues with the machine in question and need an expert assistance. Contact Microsoft support for the same.

Run the command **sfc /scannow** from an elevated command prompt. This command can take 5-10 minutes and if this tool detects corruption, it tries to fix it too. If there are errors and this tool fixed, them, then you may see something like this.

[!code-console[Main](troubleshooting-iis-7x-installation-issues/samples/sample3.cmd)]

If this command reports errors and it cannot fix it, then engage Microsoft support for assistance. You may see something like this.

[!code-console[Main](troubleshooting-iis-7x-installation-issues/samples/sample4.cmd)]

Only when both the tools run successfully, you should proceed further with your troubleshooting. Chances are that running these steps could have fixed whatever corruption was present in CBS because that's essentially what these tools do. It wouldn't be a bad idea to run these tools anyway, as it may take about 20-30 minutes to run both the tools, but if these tools find problems in CBS engine, it can really save the long time that you may spend on an issue.

### Other Resources

- [947821 Description of the System Update Readiness Tool for Windows Vista, for Windows Server 2008, for Windows 7, and for Windows Server 2008 R2](https://support.microsoft.com/default.aspx?scid=kb;EN-US;947821)
- [929833 How to use the System File Checker tool to troubleshoot missing or corrupted system files on Windows Vista or on Windows 7](https://support.microsoft.com/default.aspx?scid=kb;EN-US;929833)
- [928228 How to analyze the log file entries that the Microsoft Windows Resource Checker (SFC.exe) program generates in Windows Vista](https://support.microsoft.com/default.aspx?scid=kb;EN-US;928228)
- [2509997 Unable to install updates in Windows Vista, Windows 7, Windows Server 2008 and Windows Server 2008 R2](https://support.microsoft.com/default.aspx?scid=kb;EN-US;2509997)
