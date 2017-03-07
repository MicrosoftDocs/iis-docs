---
title: "IISAdministration PowerShell Cmdlets | Microsoft Docs"
author: rick-anderson
description: ""
ms.author: aspnetcontent
manager: wpickett
ms.date: 09/16/2016
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/get-started/whats-new-in-iis-10/iisadministration-powershell-cmdlets
msc.type: authoredcontent
---
IISAdministration PowerShell Cmdlets
====================
by Baris Caglar

### Compatibility


| Version | Notes |
| --- | --- |
| IIS 10.0 | IISAdministration PowerShell Cmdlets were introduced in IIS 10.0 |
| IIS 8.5 and earlier | IISAdministration PowerShell Cmdlets were not supported prior to IIS 10.0 |


## IISAdministration Overview

With Windows 10 and Windows Server 2016, the IIS Team is releasing a new and simplified `IISAdministration` module side by side with the existing `WebAdministration` Cmdlets. There are many reasons behind the decision to release an entirely new PowerShell Cmdlet module and here are a few of them:

- `IISAdministration` will scale better in scripts that take a long time to run with `WebAdministration`.
- You can now get a direct reference to an instance of `Microsoft.Web.Administration.ServerManager` object and do anything that you can do in `Microsoft.Web.Administration` namespace alongside your scripts.
- PowerShell pipeline compatibility was the driving force behind the design of many cmdlets. As such, `IISAdministration` works much better with PowerShell Pipeline.

The version of the Cmdlets which was released for Windows 10 was a rough version with room for improvement; the targeted release was Windows Server 2016 for the finished and polished product. The reason for the earlier release was to get feedback from real PowerShell users and IIS Administrators in the industry, to answer any questions, and ti receive suggestions about not only the existing functionality but also potentially for new functionality our users would want from IIS Administration as it pertains to PowerShell.

Here are some examples on the usage of the new provider:

### Pipelining

[!code-unknown[Main](iisadministration-powershell-cmdlets/samples/sample-134411-1.unknown)]

`Get-IISConfigSection` is at the beginning of most pipelines and in the specific example above, we are first getting the &quot;system.webServer/defaultDocument&quot; section (Case Sensitive!), then get the files collection, and finally get a collection element with the given attribute value.

[!code-unknown[Main](iisadministration-powershell-cmdlets/samples/sample-134411-2.unknown)]

This one is more of a hybrid example where the section is first put into a variable, then used in the pipeline.

### Simple Commands

The number of simple commands are greatly reduced to a few. The examples include Get-IISSite and Get-IISAppPool. Other simple operations for which the commands do not exist can be performed through pipeline operations.

[!code-unknown[Main](iisadministration-powershell-cmdlets/samples/sample-134411-3.unknown)]

### Get-IISServerManager

[!code-unknown[Main](iisadministration-powershell-cmdlets/samples/sample-134411-4.unknown)]

As you can see, once you have access to the server manager, the sky is the limit.

### Start-IISCommitDelay / Stop-IISCommitDelay

By enclosing your operations between these commands, you can make sure that your changes are committed at the same time.

These are only a handful of examples of what you can do with the new provider. Visit [TechNet](https://technet.microsoft.com/en-us/library/mt270166.aspx "IISAdministration") for the complete documentation and more examples.