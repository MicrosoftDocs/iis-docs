---
title: "Running IIS Express without Administrative Privileges | Microsoft Docs"
author: vaidy4github
description: "IIS Express was designed to allow the most common web development and testing tasks to be performed without administrative privileges. This is very helpful i..."
ms.author: iiscontent
manager: soshir
ms.date: 01/11/2011
ms.topic: article
ms.assetid: 5de2e3e1-779a-40cf-a346-ae62f3c7d3ef
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/using-iis-express/running-iis-express-without-administrative-privileges
msc.type: authoredcontent
---
Running IIS Express without Administrative Privileges
====================
by [Vaidy Gopalakrishnan](https://github.com/vaidy4github)

## Overview

IIS Express was designed to allow the most common web development and testing tasks to be performed without administrative privileges. This is very helpful in scenarios where developers are not running with administrative rights on their computers. Even for administrative users, this feature eliminates the User Account Control (UAC) popup window in Windows Vista and Windows 7 from interrupting workflow.

This article explains what standard users can do with IIS Express and describes the tasks that are limited to administrators.

## Running Sites Locally

With IIS Express, standard users can run websites locally using non-reserved ports (ports greater than 1024). The default website binding for IIS Express is http://localhost:8080. By default, WebMatrix and Visual Studio 2010 SP1 Beta also configure websites to use localhost and a non-reserved port.

In contrast, administrative privileges are needed to serve content for external requests or using a reserved port such as 80 or 443.

## Configuring Websites and Applications

Both IIS and IIS Express use an *applicationhost.config* file that contains server-wide configuration information. With IIS Express, every user owns his or her own copy of *applicationhost.config*, which means the user can add sites, remove sites, configure virtual directories, and so on without special privileges. IIS Express looks for an *applicationhost.config* file in the user's *Documents* folder (for example, *%userprofile%\Documents\IISExpress\config* on Windows 7). IIS Express can also be pointed to a custom *applicationhost.config* file using the /config command-line switch. The result is that it is not necessary to be an administrator to use IIS Express with Visual Studio.

Because IIS uses a computer-wide *applicationhost.config* file that standard users cannot write to, the same tasks under IIS can be performed only by administrators. (Because IIS is typically used on server computers, this is generally not a restriction from the point of view of an individual developer.)

## Starting and Stopping Sites

With IIS Express, a standard user can start and stop his or her web server at will. This can be done using WebMatrix and Visual Studio 2010 SP1 Beta, or by using the iisexpress.exe command executable. A Windows system tray application also allows users to browse and shut down IIS Express instances.

With IIS, users cannot launch their website directly. Instead, the Worker Process Activation Service (WAS) is responsible for activating websites. Because WAS is a system service, only administrators can start or stop it.

## Using SSL

Configuring access over the secure sockets layer (SSL) requires administrative privileges on IIS Express, just like it does on IIS. However, the IIS Express setup program performs the following tasks that enable standard users to use SSL with IIS Express:

- It automatically creates and installs a self-signed SSL server certificate in the local machine store.
- It configures HTTP.SYS to reserve ports 44300 through 44399 for SSL. Incoming SSL requests that use localhost and one of the ports in the specified range are automatically associated with the self-signed certificate.

(HTTP.SYS is an operating system component that handles SSL for IIS and IIS Express. The setup program is able to configure HTTP.SYS because setup runs under elevated privileges.)

Consequently, using SSL to test a website with IIS Express is as simple as adding a binding like the following to the site element in *applicationhost.config*:

[!code-xml[Main](running-iis-express-without-administrative-privileges/samples/sample1.xml)]

This works only for local traffic (localhost requests) and for the specified range of ports. Administrator privileges are required in order to configure a custom SSL certificate or to run SSL using a port outside the specified range.

## Summary

IIS Express enables non-administrative users to perform the following tasks:

- Run a website locally and use a port number greater than 1024.
- Add, remove, and modify websites, applications, and virtual directories.
- Start and stop the web server.
- Add SSL support to test a website using a pre-installed self-signed SSL certificate and a port between 44300 and 44399.

Administrative privileges are required in order to perform the following tasks:

- Use a reserved port such as 80 or 443.
- Serve requests for external traffic.
- Configure a custom SSL certificate.
- Run SSL using a port outside the range of 44300 to 44399.