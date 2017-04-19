---
title: "Select a Provisioning Option | Microsoft Docs"
author: rick-anderson
description: "Both the IT administrator and the software developer need to consider the provisioning of Web sites in a hosting environment. The provisioning of Web sites i..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 1f918a2e-868f-497c-941d-7281d7b8f2e1
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/creating-websites/select-a-provisioning-option
msc.type: authoredcontent
---
Select a Provisioning Option
====================
by Tali Smith

## Introduction

Both the IT administrator and the software developer need to consider the provisioning of Web sites in a hosting environment. The provisioning of Web sites in Internet Information Services (IIS) can be done in several ways:

- Through the IIS Manager user interface (UI)
- Programmatically, through use of C#
- Through Windows PowerShell™ scripts

This article describes the advantages and disadvantages of the different options for IT administrators and software developers, and provides some examples. For more information, see [Provisioning Options in IIS](../provisioning-and-managing-iis/provisioning-options-in-iis-7.md).

## Use the UI or Remote Delegation

You can use IIS Manager, the management user interface that comes with IIS, to configure the most common properties in the ApplicationHost.config. Open the property sheets for a service, site, or virtual directory, and change values. Changes take place immediately without a need to stop and start the server.

- **Advantages**  
 When you create a site or virtual directory, or when you configure a feature with more than one property, the management user interface sets all the supporting properties. IIS Manager informs you if a new value is invalid.
- **Disadvantages**  
 Managing large IIS server configurations or multiple servers over the Internet can be slow and cumbersome. Not all configuration properties can be accessed in the user interface.

For instructions on using the UI to provision Web sites, see [Create a Web Site (IIS 7)](https://technet.microsoft.com/en-us/library/cc772350(WS.10).aspx).

## Use the Text Editor

You can use a text editor such as Notepad to directly edit the ApplicationHost.config file while IIS is running. Entries are case sensitive.

- **Advantages**  
 You can change multiple properties or create new nodes in one instance without having to open and close multiple property sheets.
- **Disadvantages**  
 It is easy to corrupt an IIS server by using edit-while-running. If your edits include XML that is not formatted correctly, IIS cannot read the ApplicationHost.config and the last history file must be restored. If your edits include an invalid configuration that does not comply with the rules in the schema, an error is logged in the event viewer, but the rest of IIS can run.   
 Property inheritance must be taken into consideration when cutting and pasting portions of the ApplicationHost.config. The section you paste might inherit properties from parent nodes and impart properties to child nodes.  
 If you are using edit-while-running over the network and the connection fails, you might end up with an invalid ApplicationHost.config. Note that using edit-while-running on multiple servers in a Web farm takes as much time as using the user interface.

## Use Windows Management Instrumentation (WMI)

You can use Windows® Management Instrumentation (WMI) to programmatically configure IIS in a script or compiled program. Changes take place immediately without needing to stop and start the server.

- **Advantages**  
 Configuring large sites or multiple servers with WMI is fast and efficient.WMI is also scriptable. An example of a WMI script follows.
- **Disadvantages**  
 If you create a site or virtual directory, or use a property that depends on others, you also must ensure that you know which supporting properties need to be created and set.

The following code can be used to create a Web site and an application pool.

[!code-vb[Main](select-a-provisioning-option/samples/sample1.vb)]

## Use AppCmd.exe

AppCmd.exe can be used to provision Web sites and run many commands to edit configuration.

The following code sample is an example of code that can be used to create a site and an application pool (with failed request tracing and W3svc log file locations).


[!code-console[Main](select-a-provisioning-option/samples/sample2.cmd)]


You can use the following code to configure the Failed Request Tracing log file location:


[!code-console[Main](select-a-provisioning-option/samples/sample3.cmd)]


You can use the following code to configure the W3SVC log file location:


[!code-console[Main](select-a-provisioning-option/samples/sample4.cmd)]


## Use a Managed API (Microsoft.Web.Administration)

You can use managed application programming interfaces (APIs) in Microsoft.Web.Administration to programmatically configure IIS in any Microsoft® .NET application. Microsoft.Web.Administration is a new API in IIS that allows developers using managed code to read and manipulate the server configuration in a simple way.

- **Advantages**  
 Configuring large sites or multiple servers is fast and efficient with Microsoft.Web.Administration. Microsoft.Web.Administration can be managed using remote procedure call (RPC) for remote server configuration. Microsoft.Web.Administration can create as many as 100,000 sites within 62 seconds (approximately 1,600 sites/sec).
- **Disadvantages**  
 Microsoft.Web.Administration can only be used on the Windows® operating system. Many objects are not exposed as strongly-typed objects, therefore, you must understand the lower level APIs to configure certain objects and properties.

The following code can be used to create a site and an application pool and to set temporary compilation directories.


[!code-csharp[Main](select-a-provisioning-option/samples/sample5.cs)]


To set a unique temporary compilation directory for each site, use the following code:


[!code-csharp[Main](select-a-provisioning-option/samples/sample6.cs)]


## Use Active Directory Service Interfaces (ADSI)

You can use the Active Directory® Service Interfaces (ADSI) to programmatically configure IIS in a script or compiled program. Changes take place immediately without a need to stop and start the server.

- **Advantages**  
 Configuring large sites or multiple servers with ADSI is fast and efficient. ADSI is scriptable, and you can configure IIS 4.0, IIS 5.0, IIS 5.1, and IIS 6.0, and IIS7 and above (with IIS6 compatible-mode enabled) with ADSI, as long as you use error checking to handle missing objects and properties. You can also extend the IIS schema with ADSI, though it is not recommended.
- **Disadvantages**  
 If you create a site or virtual directory, or use a property that depends on others, you also must ensure that you know which supporting properties need to be created and set. ADSI is only available for IIS 7 and above if IIS 6 compatible mode is enabled. Note that it is also difficult to use.

## Use OLE Automation

OLE Automation (ProgId=Microsoft.ApplicationHost.WritableAdminManager) can be used from Microsoft® JScript® and Microsoft® Visual Basic® Scripting Edition (VBScript).

- **Advantages**  
 Configuring large sites or multiple servers is fast and efficient. OLE automation is actually slightly faster than Microsoft.Web.Administration, and it is also remoteable.
- **Disadvantages**  
 You need to have an understanding of the lower level APIs to configure certain objects and properties. It requires RPC for remote server configuration.

## Use Admin Base Objects (ABO)

Use ABO to programmatically configure IIS in a compiled program written in C, C++, or Microsoft® Visual Basic® 6.0.

- **Advantages**  
 It is faster than using ADSI or WMI because the ADSI and WMI providers are wrappers for ABO.
- **Disadvantages**  
 If you create a site or virtual directory, or use a property that depends on others, you also must ensure that you know which supporting properties need to be created and set.   
 ABO is not scriptable. ABO applications can only be written in C++ or Visual Basic 6.0.  
 Since ABO accesses IIS at the lowest level, it is more difficult to use than ADSI or WMI because there are no methods that compress multiple lines of ABO code into one method call. Also, there are no safeguards to prevent you from configuring invalid settings.


> [!NOTE]
> *This article updates the articles in: "[Code Samples and Scripts](../provisioning-and-managing-iis/index.md)" by Walter Oliver, published on December 2, 2007.*


## Links for Further Information

- [IIS Configuration Reference](https://www.iis.net/configreference). 
- [Managing IIS with the IIS PowerShell Snap-in](../powershell/index.md).
- [C# and PowerShell Scripts Samples](../../web-hosting/configuring-components/powershell-scripts.md).
- [Provisioning Sample in C#.](../provisioning-and-managing-iis/provisioning-sample-in-c.md)