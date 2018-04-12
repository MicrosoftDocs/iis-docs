---
title: "IISAdministration PowerShell Cmdlets | Microsoft Docs"
author: rick-anderson
description: ""
ms.author: iiscontent
manager: soshir
ms.date: 09/16/2016
ms.topic: article
ms.assetid: adb61044-9074-4961-9186-cf5e340cee5b
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/whats-new-in-iis-10/iisadministration-powershell-cmdlets
msc.type: authoredcontent
---
IISAdministration PowerShell Cmdlets
====================
by Baris Caglar

### Compatibility


| Version | Notes |
| --- | --- |
| IIS 10.0 | IISAdministration PowerShell Cmdlets were introduced in IIS 10.0. The latest version of IISAdministration is supported via Powershell gallery. |
| IIS 8.5 and earlier | IISAdministration PowerShell Cmdlets were not supported prior to IIS 10.0. However, users can install it via Powershell gallery. |

Visit [iis.net](https://blogs.iis.net/iisteam/introducing-iisadministration-in-the-powershell-gallery "Introducing IISAdministration in the Powershell gallery") to learn about how to get the latest version of IISAdministration.

## IISAdministration Overview

With Windows 10 and Windows Server 2016, the IIS Team is releasing a new and simplified `IISAdministration` module side by side with the existing `WebAdministration` Cmdlets. There are many reasons behind the decision to release an entirely new PowerShell Cmdlet module and here are a few of them:

- `IISAdministration` will scale better in scripts that take a long time to run with `WebAdministration`.
- You can now get a direct reference to an instance of `Microsoft.Web.Administration.ServerManager` object and do anything that you can do in `Microsoft.Web.Administration` namespace alongside your scripts.
- PowerShell pipeline compatibility was the driving force behind the design of many cmdlets. As such, `IISAdministration` works much better with PowerShell Pipeline.

The version of the Cmdlets which was released for Windows 10 was a rough version with room for improvement; the targeted release was Windows Server 2016 for the finished and polished product. The reason for the earlier release was to get feedback from real PowerShell users and IIS Administrators in the industry, to answer any questions, and to receive suggestions about not only the existing functionality but also potentially for new functionality our users would want from IIS Administration as it pertains to PowerShell.

Here are some examples on the usage of the new provider:

### Pipelining

[!code-console[Main](iisadministration-powershell-cmdlets/samples/sample1.cmd)]

`Get-IISConfigSection` is at the beginning of most pipelines and in the specific example above, we are first getting the &quot;system.webServer/defaultDocument&quot; section (Case Sensitive!), then get the files collection, and finally get a collection element with the given attribute value.

[!code-console[Main](iisadministration-powershell-cmdlets/samples/sample2.cmd)]

This one is more of a hybrid example where the section is first put into a variable, then used in the pipeline.

### Simple Commands

The number of simple commands are greatly reduced to a few. The examples include Get-IISSite and Get-IISAppPool. Other simple operations for which the commands do not exist can be performed through pipeline operations.

[!code-console[Main](iisadministration-powershell-cmdlets/samples/sample3.cmd)]

### Get-IISServerManager

[!code-console[Main](iisadministration-powershell-cmdlets/samples/sample4.cmd)]

As you can see, once you have access to the server manager, the sky is the limit.

### Start-IISCommitDelay / Stop-IISCommitDelay

By enclosing your operations between these commands, you can make sure that your changes are committed at the same time.

These are only a handful of examples of what you can do with the new provider. Visit [Online document](https://docs.microsoft.com/en-us/powershell/module/iisadministration/?view=win10-ps "IISAdministration") for the complete documentation and more examples.
