---
title: "Running Asp.Net Core with IIS on Nano Server | Microsoft Docs"
author: davidso
description: ""
ms.author: iiscontent
manager: soshir
ms.date: 09/16/2016
ms.topic: article
ms.assetid: 8987c573-9b1e-414d-a8a5-3e6313340db7
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/whats-new-in-iis-10/running-aspnet-core-with-iis-on-nano-server
msc.type: authoredcontent
---
Running Asp.Net Core with IIS on Nano Server
====================
by [David So](https://github.com/davidso)

This article outlines the steps required to get an ASP.Net Core application running with IIS on Nano.

### Compatibility


| Version | Notes |
| --- | --- |
| IIS 10.0 | The features described in this article were introduced in IIS 10.0 |
| IIS 8.5 and earlier | The features described in this article were not supported prior to IIS 10.0 |


## Installing IIS

First you need to install IIS on Nano, and the steps to do so are already covered in the official Nano documentation. For more information, see the following articles:

- [Getting Started with Nano Server](https://technet.microsoft.com/library/mt126167.aspx)
- [IIS on Nano Server](https://technet.microsoft.com/library/mt627783.aspx)
- [Introducing IIS on Nano Server (Blog)](https://blogs.iis.net/davidso/iisnano)

## Installing Reverse Forwarders

Currently, both [HttpPlatformHandler](https://www.iis.net/downloads/microsoft/httpplatformhandler) and Asp.Net Core Kestrel host requires Reverse Forwarders package to be installed on the Nano machine.

Reverse Fowarders can be installed offline (machine turned off) or online (machine running).

Offline, Reverse Forwarders can be installed by passing `–ReverseForwarders` parameters when calling New-NanoServerImage cmdlet. e.g.

[!code-powershell[Main](running-aspnet-core-with-iis-on-nano-server/samples/sample1.ps1?highlight=1)]

Online, Reverse Forwarders can be installed by calling dism on the relevant package:

- `dism /online /add-package /packagepath:c:\packages\Microsoft-OneCore-ReverseForwarders-Package.cab`
- `dism /online /add-package /packagepath:c:\packages\en-us\Microsoft-OneCore-ReverseForwarders-Package.cab`
- `<reboot>`

The 1st command installs the Reverse Forwarders feature package.

The 2nd command installs the associated language pack for the package.

In this case, `C:\packages` is a local directory that I created where I copied the Packages folder from the Nano Server media installation location.

After installing Reverse Forwarders package (whether offline or online), verify that IIS and Reverse Forwarders are correctly installed by running `dism /online /get-packages`.

You should see the Feature and Language packs for Microsoft-NanoServer-IIS-Package and Microsoft-OneCore-ReverseForwarders-Package.

## Installing HttpPlatformHandler

At this time, the install for HttpPlatformHandler on Nano is manual.

Understandably this is a pain…. so it's something that we're working on improving.

Nano is 64 bit only (no WOW), so you'll need to install the latest x64 version of HttpPlatformHandler ([https://www.iis.net/downloads/microsoft/httpplatformhandler](https://www.iis.net/downloads/microsoft/httpplatformhandler)) on a regular (not Nano) machine.

Once you have x64 bit version of HttpPlatformHandler installed on your regular (not Nano) machine, there are 2 files which we'll need to copy to the Nano machine:

- `%windir%\System32\inetsrv\httpPlatformHandler.dll`
- `%windir%\System32\inetsrv\config\schema\httpplatform_schema.xml`

On the Nano machine you'll need to copy those 2 files to the respective locations (dll-&gt;inetsrv, schema file-&gt;inetsrv\config\schema)

- `copy .\httpPlatformHandler.dll c:\Windows\System32\inetsrv`
- `copy .\httpplatform_schema.xml c:\Windows\System32\inetsrv\config\schema`

### Enabling HttpPlatformHandler (PowerShell)

You can execute the steps below in a remote PowerShell session to the Nano machine.

Note that the below steps works on a clean system, but is not meant to be idempotent. If you run this multiple times it will add multiple entries and you will run into problems! If you end up in a bad state, you can find backups of the applicationHost.config file at `%systemdrive%\inetpub\history`.

[!code-powershell[Main](running-aspnet-core-with-iis-on-nano-server/samples/sample2.ps1)]

### Enabling HttpPlatformHandler (manually editing applicationHost.config)

You can skip this section if you already did the PowerShell steps above.

I recommend following the PowerShell steps, although if you absolutely must edit the IIS applicationHost.config file to enable HttpPlatformHandler then these are the steps.

Open up `c:\windows\system32\inetsrv\applicationHost.config`

(if you are using Powershell ISE v5 you can do this using `psedit c:\windows\system32\inetsrv\applicationHost.config`)

Under `<configSections>` add

[!code-xml[Main](running-aspnet-core-with-iis-on-nano-server/samples/sample3.xml?highlight=2)]

In system.webServer section, unlock handlers from Deny to Allow

[!code-xml[Main](running-aspnet-core-with-iis-on-nano-server/samples/sample4.xml)]

In system.webServer section, add new httpPlatform section

[!code-xml[Main](running-aspnet-core-with-iis-on-nano-server/samples/sample5.xml?highlight=1)]

Add the following to globalModules

[!code-xml[Main](running-aspnet-core-with-iis-on-nano-server/samples/sample6.xml?highlight=1)]

Add the following to Modules

[!code-xml[Main](running-aspnet-core-with-iis-on-nano-server/samples/sample7.xml?highlight=1)]

## Installing Asp.Net Core application

First, make sure that your Asp.Net Core application is built targeting `coreclr and x64`.

This is very important as any other combination will not work on Nano.

After building for coreclr/x64 you will need to copy the whole application to the Nano machine – in this example I'm using `c:\HelloAspNetCore`.

Next I will setup a new Site pointing to `c:\HelloAspNetCore\wwwroot` using port 8000 (for simplicity we will go with Default App Pool)

There are no problems running the Asp.Net Core site on default port 80, though in a testing environment I like to separate the Asp.Net Core app from the default website, so that it's easier to troubleshoot when something goes wrong (e.g. so you can verify that the default IIS site still works fine).

Using IIS PowerShell:

[!code-powershell[Main](running-aspnet-core-with-iis-on-nano-server/samples/sample8.ps1)]

Creating the site manually (omit if you already created using PowerShell above) by editing `c:\windows\system32\inetsrv\applicationHost.config`:

[!code-xml[Main](running-aspnet-core-with-iis-on-nano-server/samples/sample9.xml?highlight=10-17)]

The next step is to open up port 8000 in the firewall.

[!code-powershell[Main](running-aspnet-core-with-iis-on-nano-server/samples/sample10.ps1)]

### Troubleshooting

First make sure that IIS itself is correctly installed. `http://<ipaddress>` should get you the default page (Blue IIS page) otherwise something very basic is not set up correctly.

Secondly, make sure that your Application can run standalone. e.g. `c:\HelloAspNetCore\approot\web.cmd`

Thirdly, check to make sure that you are seeing logs created by HttpPlatformHandler – e.g. `c:\HelloAspNetCore\logs`