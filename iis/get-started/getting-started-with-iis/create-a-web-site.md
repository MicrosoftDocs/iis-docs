---
title: "Create a Web Site | Microsoft Docs"
author: rick-anderson
description: "When you want to publish content for access over the Internet or an intranet connection, you can add a Web site to your Web server to hold the content. Durin..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 0fc44a63-8c65-4d28-896f-dd6b573d9511
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/getting-started-with-iis/create-a-web-site
msc.type: authoredcontent
---
Create a Web Site
====================
by Tali Smith

## Introduction

When you want to publish content for access over the Internet or an intranet connection, you can add a Web site to your Web server to hold the content.

During the installation of Internet Information Services (IIS), a default Web site configuration is created in the \Inetpub\Wwwroot directory on your Web server. You can either use this default directory to publish your Web content, or create a directory at a file system location of your choice.

When you add a Web site in IIS, a site entry is created in the ApplicationHost.config file. The entry specifies the network binding for the site, maps the site to a location in the file system, and optionally specifies user credentials for content access.

For information about the levels at which you can perform this procedure, and the modules, handlers, and permissions that are required to perform this procedure, see [Sites Feature Requirements (IIS 7)](https://technet.microsoft.com/en-us/library/cc754865(WS.10).aspx).

## Add a Web Site

You can perform this procedure by using the IIS Manager user interface (UI), by running Appcmd.exe commands in the Command Prompt window, by editing configuration files directly, or by writing Windows® Management Instrumentation (WMI) scripts.

### Use the UI

1. Start **IIS Manager**. For information about starting IIS Manager, see [Open IIS Manager (IIS 7)](https://technet.microsoft.com/en-us/library/cc770472(WS.10).aspx). For information about navigating to locations in the UI, see [Navigation in IIS Manager (IIS 7)](https://technet.microsoft.com/en-us/library/cc732920(WS.10).aspx).
2. In the **Connections** pane, right-click the **Sites** node in the tree view, and then click **Add Web Site**.
3. In the **Add Web Site** dialog box, type a *friendly name* for your Web site in the **Web site name** box.
4. If you want to select a different application pool than the one listed in the Application Pool box. In the **Select Application Pool** dialog box, select an application pool from the **Application Pool** list, and then click **OK**.
5. In the **Physical path** box, type the *physical path* of the Web site's folder, or click the browse button **(...)** to browse the file system to find the folder.
6. If the physical path that you entered in step 5 is to a remote share, click **Connect as** to specify credentials that have permission to access the path. If you do not use specific credentials, select the **Application user (pass-thru authentication)** option in the **Connect As** dialog box.
7. Select the protocol for the Web site from the **Type** list.
8. The default value in the **IP address** box is **All Unassigned**. If you must specify a static IP address for the Web site, type the *IP address* in the **IP address** box.
9. Type a *port number* in the **Port** text box.
10. Optionally, type a *host header name* for the Web site in the **Host Header** box.
11. If you do not have to make any changes to the site, and you want the Web site to be immediately available, select the **Start Web site immediately** check box.
12. Click **OK**.

### Use the Command Prompt

To add a site, use the following syntax:


[!code-console[Main](create-a-web-site/samples/sample1.cmd)]


The variable **name** *string* is the name, and the variable **id** *uint* is the unsigned integer that you want to assign to the site. The variables **name** *string* and **id** *uint* are the only variables that are required when you add a site in Appcmd.exe. Note that When you add a site without specifying the values for the **bindings** and **physicalPath** attributes, the site will not be able to start.

The variable **physicalPath** *string* is the path of the site content in the file system.

The variable **bindings** *string* contains information that is used to access the site, and it should be in the form of <em>protocol</em>**/**<em>IP\_address</em>**:** <em>port</em>**:** *host\_header*. For example, a Web site binding is the combination of protocol, IP address, port, and host header. A binding of **http/\*:85:** enables a Web site to listen for HTTP requests on port 85 for all IP addresses and domain names (also known as host headers or host names). On the other hand, a binding of **http/\*:85:marketing.contoso.com** enables a Web site to listen for HTTP requests on port 85 for all IP addresses and the domain name **marketing.contoso.com**.

To add a Web site named Contoso with an ID of 2 that has content in `C:\Contoso`, and that listens for HTTP requests on port 85 for all IP addresses and a domain name of **marketing.contoso.com**, type the following at the command prompt, and then press ENTER:


[!code-console[Main](create-a-web-site/samples/sample2.cmd)]


For more information, see [Appcmd.exe](https://technet.microsoft.com/en-us/library/cc772200(WS.10).aspx).

## Configuration

You can configure the following elements:

[!code-xml[Main](create-a-web-site/samples/sample3.xml)]

For more information about configuration, see [IIS 7: IIS Settings Schema](https://go.microsoft.com/fwlink/?LinkId=88551) on Microsoft® Developer Network (MSDN®).

For more information about WMI and IIS, see [Windows Management Instrumentation (WMI) in IIS 7](https://technet.microsoft.com/en-us/library/cc771707(WS.10).aspx). For more information about the classes, methods, or properties associated with this procedure, see the [IIS WMI Provider Reference](https://go.microsoft.com/fwlink/?LinkId=79310) on the MSDN site.

## Links for Further Information

- [Managing Sites in IIS 7](https://technet.microsoft.com/en-us/library/cc771341(WS.10).aspx).