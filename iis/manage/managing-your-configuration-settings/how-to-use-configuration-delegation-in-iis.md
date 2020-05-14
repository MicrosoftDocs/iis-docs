---
title: "How to Use Configuration Delegation in IIS 7.0"
author: rick-anderson
description: "This article explains how to enable delegated configuration on the server. It discusses how to deploy configuration settings for the server and for your appl..."
ms.date: 11/23/2007
ms.assetid: 3261f849-ca15-4cd3-924f-450c6a779b76
msc.legacyurl: /learn/manage/managing-your-configuration-settings/how-to-use-configuration-delegation-in-iis
msc.type: authoredcontent
---
How to Use Configuration Delegation in IIS 7.0
====================
by [Saad Ladki](https://twitter.com/saadladki)

## Abstract

This article explains how to enable delegated configuration on the server. It discusses how to deploy configuration settings for the server and for your applications, together with the content pages and application code.

Once the machine administrator has defined the application or virtual directory for your use in the master configuration file `%windir%\system32\inetsrv\config\applicationHost.config`, and allowed specific sections to be delegated, you can control the settings at the application level: by making settings in the application's web.config file, you override global defaults. This is possible if you have access to the application's directory, even if you are not a local administrator on the machine.

After reading this document, you will know how to define applications and virtual directories at the global level, unlock configuration sections for delegation, and override configuration settings for individual applications at a lower level of the configuration hierarchy.

<a id="Introduction"></a>

## Introduction

IIS allows machine administrators to delegate the task of setting and changing configuration to site and application owners. To do this, use web.config files in the content directories. These files specify configuration sections which take effect on their level in the hierarchy and downward. The machine administrator must explicitly unlock sections at the global level to enable such delegation. By default, most IIS sections are locked down for delegation, and all .NET framework sections (including ASP.NET) are not locked at the global level.

This document explains how to define new applications and virtual directories at the global level (only machine administrators can perform this task; it can never be delegated).

This document then explains how to xcopy-deploy web.config with the application content to override some settings for the specific level. It also explains core concepts of the configuration system, and therefore explains how to do these tasks using direct editing of configuration files, without using the UI or other abstractions on top of the configuration system.

<a id="Prerequisites"></a>

## Prerequisites

- Make sure IIS 7.0 or above is installed on the machine. Go to [http://localhost/](http://localhost/) from IE and see that the default "Under Construction" page opens. If IIS is not installed, refer to the Setup How-To for installation instructions.
- Make sure you have administrative privileges on the machine. By default, you do not have them if you are logged on as a user other than the built-in Administrator account, even if this user was added to the local Administrators group on the machine. This is a new security feature in Windows Server® 2008, called LUA, which is beyond the scope of IIS. Either log-on as the built-in Administrator account, or explicitly invoke applications as the built-in Administrator, as needed, using the "runas" cmd-line tool:

For example, to launch notepad.exe, run this command: "runas /user:administrator notepad.exe". You will be prompted for the password of the Administrator account. It is useful to have a cmd-box shell that is already elevated, by running "runas /user:administrator cmd.exe". Every application run from that cmd-box is elevated as well, and you do not need to use the "runas" syntax from that cmd-box.

- Make sure the master configuration file is backed up. Simply copy applicationHost.config to a different file, so that you can restore it later. You will find applicationHost.config under the inetsrv\ directory, which in turn is under the system directory.

> [!NOTE]
> You must be an administrator to do this – see previous bullet point above.

- Before you start, make sure you're in a "clean state". To do so, revert changes you may have done to the applicationHost.config file in previous exercises. (If you are using a VPC image, the easiest way to do that is to restart the image without saving its state).
- It is recommended that you turn off friendly HTTP error messages in IE (**Tools** &gt; **Options** &gt; **Advanced**) for quicker troubleshooting.

<a id="Step1"></a>

## Step 1: Define a New Application

1. Using a text editor such as Notepad, open the ApplicationHost.config file in the following location:

    [!code-console[Main](how-to-use-configuration-delegation-in-iis/samples/sample1.cmd)]
2. Navigate to the `<sites>` section, which looks similar to the following:

    [!code-xml[Main](how-to-use-configuration-delegation-in-iis/samples/sample2.xml)]
3. Verify that the Web server is running and that you can access the default Web site. To do so, launch the browser and request [http://localhost/](http://localhost/)
4. The request should return a Web page. If it does not, start the IIS server by typing "**net start w3svc**" from the command-box, or troubleshoot using the Windows Event Log viewer.
5. In the browser, request [http://localhost/app](http://localhost/app)

    This request does not return a page (you see an error page), because the virtual path is not yet defined in the configuration—this is the next procedure.
6. In the ApplicationHost.config file, add an `<application>` element with path "**/app**" that includes a top-level `<virtualDirectory>` element. Top-level virtual directory is one with path "**/**". For the physical path of the virtual directory, specify `C:\tmp`(or something similar that you will later work with).

    When you are finished, the `<sites>` sections looks similar to the following:

    [!code-xml[Main](how-to-use-configuration-delegation-in-iis/samples/sample3.xml)]

    You have just defined a new application in the configuration file.
7. In the browser, request [http://localhost/app](http://localhost/app)

    The Web server returns an error page, saying that directory browsing is not enabled. This happens because you do not have content yet in `c:\tmp`, so the server is handling the request as a request to browse the directory. Copy iisstart.htm from the `\inetpub\wwwroot` directory into `c:\tmp` and refresh the browser. Now you see the Under Construction page.

<a id="Step2"></a>

## Step 2: Unlock Configuration Sections

1. Using a text editor such as Notepad, open applicationHost.config and locate the &lt;authentication&gt; section group.
2. Move the &lt;anonymousAuthentication&gt; and `<windowsAuthentication>` sections from their current location in the file into a new location tag at the bottom of the file that has overrideMode="Allow" on it, as follows:

    [!code-xml[Main](how-to-use-configuration-delegation-in-iis/samples/sample4.xml)]

    These sections are now over-ridable by lower-levels of the namespace, because they are in a location tag that specifies overrideMode="Allow". All lower-level web.config files can now override these settings.

<a id="Step3"></a>

## Step 3: Override Settings at the Application Level

1. Using a text editor such as Notepad, create a new text file in the application folder (e.g. `c:\tmp`) named **web.config**.
2. In the web.config file, create a `<configuration>` element and a `<system.webServer>` element as its child. Within the `<system.webServer>` element, create a `<security>` element that contains an `<authentication>` element.
3. Enter the settings to disable the Windows authentication and anonymous authentication schemes, which are turned on by default at the global level.

    When you are finished, the web.config file looks like the following:

    [!code-xml[Main](how-to-use-configuration-delegation-in-iis/samples/sample5.xml)]
4. In a browser, request [http://localhost/app](http://localhost/app).

    > [!NOTE]
    > You are not authorized to see the page, because you disabled all authentication methods to this page in your web.config file.
5. In the browser, request [http://localhost/](http://localhost/) and confirm that you can access the page. The configuration in the web.config file applies only at the application level.
6. In the web.config file, enable basic authentication by adding a `<basicAuthentication>` element with its **enabled** attribute set to true.

    When you are finished, the web.config file looks like the following:

    [!code-xml[Main](how-to-use-configuration-delegation-in-iis/samples/sample6.xml)]
7. Request [http://localhost/app](http://localhost/app) again. You see an error page saying that some configuration is locked at the global level and the web.config files is trying to override it--therefore it is a configuration error. To resolve this, allow the &lt;basicAuthentication&gt; section at the global level (applicationHost.config) to be overridden, as you did for the two other sections. Then refresh the browser .

    You will now be prompted for a user name and password, which indicates the basic authentication is taking place.
8. Enter the user name and password of the logged-on user, and note that the page displays.

    If you request [http://localhost/](http://localhost/), you will not be asked to enter user name and password, because the changes to configuration you made apply at the application level only.

    > [!NOTE]
    > The server and the browser both cache the user token. If you wish to start from scratch and you no longer see the user-name prompt, close the browser, and stop the IIS worker process (or run "net stop /y http' from the Windows command line, then "net start w3svc", to restart IIS).

<a id="Summary"></a>

## Summary

This document explains how to define applications and virtual directories in the master configuration file, applicationHost.config. It also covers how to deploy application-specific configuration files that contain server settings in the `<system.webServer>` section. You can add settings to the web.config file in the `<system.web>` section group, such as ASP.NET settings.

A good practice is to set access control lists (ACLs) on the web.config file or on the entire directory of your application so that non-administrative users cannot access the file.
