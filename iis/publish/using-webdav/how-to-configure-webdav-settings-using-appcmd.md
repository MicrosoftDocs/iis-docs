---
title: "How to Configure WebDAV Settings Using AppCmd | Microsoft Docs"
author: rmcmurray
description: "Introduction Microsoft released a new WebDAV extension module that was completely rewritten for Internet Information Services 7.0 (IIS 7.0) on Windows Server..."
ms.author: iiscontent
manager: soshir
ms.date: 02/14/2008
ms.topic: article
ms.assetid: 
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/using-webdav/how-to-configure-webdav-settings-using-appcmd
msc.type: authoredcontent
---
How to Configure WebDAV Settings Using AppCmd
====================
by [Robert McMurray](https://github.com/rmcmurray)

<a id="00"></a>

## Introduction

Microsoft released a new WebDAV extension module that was completely rewritten for Internet Information Services 7.0 (IIS 7.0) on Windows Server® 2008. This new WebDAV extension module incorporated many new features that enable web authors to publish content better than before, and offers web administrators more security and configuration options. Microsoft has released an update to the WebDAV extension module for Windows Server® 2008 that provides shared and exclusive locks support to prevent lost updates due to overwrites.

This document will walk you through using the new AppCmd.exe utility in IIS 7.0 to configure WebDAV settings from a command-line or batch script.

### In This Walkthrough

- [Basic AppCmd Concepts](how-to-configure-webdav-settings-using-appcmd.md#01)
- [Getting Started with WebDAV](how-to-configure-webdav-settings-using-appcmd.md#02)
- [Working with WebDAV Authoring Rules](how-to-configure-webdav-settings-using-appcmd.md#03)
- [Summary](how-to-configure-webdav-settings-using-appcmd.md#04)

### Prerequisites

The following items are required to complete the procedures in this article:

- IIS 7.0 must be installed on your server, and the following must be configured: 

    - The Default Web Site that is created by the IIS 7.0 installation must still exist.
- The new WebDAV extension module must be installed. For information regarding the installation of the new WebDAV module, please see the following document: 

    - [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)

> [!NOTE]
> You need to make sure that you follow the steps in this document using full administrative permissions. This is best accomplished using one of two methods:

- Log in to your computer using the local "administrator" account.
- If you are logged in using an account with administrative permissions that is not the local "administrator" account, open IIS Manager and all command prompt sessions using the "Run as Administrator" option.

The above condition is required because the User Account Control (UAC) security component in Windows Server 2008 will prevent administrative access to IIS 7.0's configuration settings. For more information about UAC, please see the following documentation:

- [https://go.microsoft.com/fwlink/?LinkId=113664](https://go.microsoft.com/fwlink/?LinkId=113664)

> [!NOTE]
> Request Filtering settings may block several file types from WebDAV authoring by default. When you configure WebDAV using the IIS Manager UI, the request filtering settings are automatically updated in order to unblock WebDAV authoring. However, if you choose to configure WebDAV in any manner other than using the IIS Manager UI see the [How to Configure WebDAV with Request Filtering](how-to-configure-webdav-with-request-filtering.md) walkthrough.

<a id="01"></a>

## Basic AppCmd Concepts

AppCmd.exe is a new command-line tool for administering IIS 7.0. In many ways, think of it as a replacement for the adsutil.vbs script from previous IIS versions. AppCmd.exe supports a wide range of command switches for various objects, making it easily scriptable in batch files to configure a myriad of IIS settings. (Note: The AppCmd.exe utility is located in the %WinDir%\System32\InetSrv folder.)

The general syntax for AppCmd.exe is:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample1.cmd)]

AppCmd.exe also provides extensive command-line help support, which can be accessed using one of the following methods:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample2.cmd)]

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample3.cmd)]

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample4.cmd)]

The list of commands depends on the object, and the following objects are supported:

> | Object | Description |
> | --- | --- |
> | SITE | Administration of virtual sites |
> | APP | Administration of applications |
> | VDIR | Administration of virtual directories |
> | APPPOOL | Administration of application pools |
> | CONFIG | Administration of general configuration sections |
> | WP | Administration of worker processes |
> | REQUEST | Administration of HTTP requests |
> | MODULE | Administration of server modules |
> | BACKUP | Administration of server configuration backups |
> | TRACE | Working with failed request trace logs |


For example, you can list which web sites are configured on your server using the SITE object with the following syntax:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample5.cmd)]

Likewise, you can list which application pools are configured on your server using the APPPOOL object with following syntax:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample6.cmd)]

AppCmd can also be used to set the values for various configuration settings using the SITE object, and you can use the following command to list the available settings for your Default Web Site using the following syntax:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample7.cmd)]

To list the configuration settings for a specific path, you use the CONFIG object like the following example:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample8.cmd)]

The CONFIG object can also be used to set configuration settings, as shown in the following example:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample9.cmd)]

You can also control where AppCmd will write the settings that you specify by using the "/commit:" command-line parameter. For example, later in this document we will take a look at the following command that enables WebDAV on your Default Web Site:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample10.cmd)]

> [!NOTE]
> This command enables WebDAV for the Default Web Site and writes that setting to the ApplicationHost.config file.

AppCmd is an extremely powerful utility, and realistically speaking there's too much to cover in such a short space, so for more information about becoming familiar with AppCmd.exe, please see the following article on the IIS.NET web site:

- [Getting Started with AppCmd.exe](../../get-started/getting-started-with-iis/getting-started-with-appcmdexe.md)

Thatsaid, we move on to configuring WebDAV on your server.

<a id="02"></a>

## Getting Started with WebDAV

WebDAV installs an extension to the default schema for IIS settings, which is what makes AppCmd work with WebDAV without any special modifications. The new WebDAV module stores all of its configurable settings in ApplicationHost.config file, and uses the following sections:

- system.webServer/webdav/authoring
- system.webServer/webdav/authoringRules

The "authoring" settings are only configurable at the root of a web site, whereas the "authoringRules" settings can be configured per-URL. To see which settings have been configured for each of these sections for a given path, you can use AppCmd as seen in the following examples:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample11.cmd)]

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample12.cmd)]

<a id="02a"></a>

### Enabling or Disabling WebDAV for a Web Site

Understandably enough, the most basic and useful command for WebDAV is enabling or disabling WebDAV for a site. The syntax for enabling WebDAV a web site follows the following example:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample13.cmd)]

In this example, we set the "enabled" attribute to "true" for the WebDAV "authoring" section on the Default Web Site and force that change to be written to the ApplicationHost.config file. Conversely, you can disable WebDAV by setting that same value to "false" as shown in the following example:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample14.cmd)]

<a id="02b"></a>

### Requiring SSL for WebDAV Authoring for a Web Site

In order to protect the information that you may be transferring, WebDAV can be configured to require SSL for all operations. This is accomplished by setting the "requireSsl " attribute to "true" for the WebDAV "authoring" section using syntax like the following:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample15.cmd)]

This functionality can be disabled by setting the "requireSsl" attribute to "false" using syntax like the following:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample16.cmd)]

<a id="02c"></a>

### Allowing Access to Hidden Files for a Web Site

For security reasons, you can suppress whether files that are marked as hidden on the server will be returned in file listings. To do so, set the "allowHiddenFiles" attribute to "true" on the "fileSystem" element in the "authoring" section using syntax like the following:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample17.cmd)]

To disable listing hidden files, set the "allowHiddenFiles" attribute to "false" using syntax like the following:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample18.cmd)]

<a id="02d"></a>

### Configuring WebDAV Compatibility Settings for a Web Site

In order to be compatible with previous versions of WebDAV for IIS, some optional features are exposed through compatibility settings. Currently the list of options is as follows:

> | Compatibility Setting | Description |
> | --- | --- |
> | None | Specifies that no compatibility features should be supported. |
> | MsAuthorVia | Specifies that the "MS-Author-Via" header should be returned. (Note: Several of Microsoft's web authoring tools use this header.) |
> | MultiProp | Specifies that multiple &lt;prop&gt; statements should be allowed in client requests. |
> | CompactXml | Defines whether the XML returned by the WebDAV module will terminate each line with a CRLF sequence. |
> | IsHidden | Specifies that the IsHidden pseudo-live property should be supported. |
> | IsCollection | Specifies that the IsCollection pseudo-live property should be supported. |


To set any of these features, you will need to set the value of "compatFlags" attribute on the "authoring" section using syntax like the following:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample19.cmd)]

Notice that the compatibility settings are specified as a set of comma-separated flags.

<a id="03"></a>

## Working with WebDAV Authoring Rules

The new WebDAV module makes use of authoring rules, which allow you to configure the way that WebDAV responds to authoring request from clients. For example, your web site may have anonymous access enabled for Internet users, but your web authoring access should be restricted to a certain set of users. Using authoring rules, you can configure which users have access to the various parts of your web site's content.

<a id="03a"></a>

### Configuring Authoring Rule Defaults

#### Specifying whether non-MIME-mapped files are allowed

For security reasons, IIS does not allow access to files that are not listed in the MIME map by default. With that in mind, web authors may need to work with certain file types on a server that are not listed in the MIME map. (For example: include files, data files, etc.) To enable access to non-MIME-mapped files, you need to set the "allowNonMimeMapFiles" attribute to "true" on the "authoringRules" section. The following syntax example illustrates how this is accomplished:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample20.cmd)]

This functionality can be disabled by setting the "allowNonMimeMapFiles" attribute to "false" using syntax like the following:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample21.cmd)]

#### Specifying the default MIME type

When working with file types that are not in the MIME list, IIS still needs to return a MIME type to clients. By default this is set to "application/octet-stream", which means that the file should be treated as a raw binary file regardless of the content type. To set the default MIME type for non-MIME-mapped files to a text file type you could use the following syntax:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample22.cmd)]

To reset the default MIME type, use the following syntax:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample23.cmd)]

<a id="03b"></a>

### Managing Authoring Rules

Authoring rules are kept in a collection, and each rule can contain the following attributes:

> | Attribute | Description |
> | --- | --- |
> | path | Specifies the content type for the rule. (See below) |
> | users | Specifies the user name for the rule. (See below) |
> | roles | Specifies a group/role for the rule. |
> | access | Specifies the access type for the rule. (See below) |


**Notes**:

- The "path" attribute is used to specify the content type for the authoring rule. This can be for specific content types like "\*.aspx", "\*.htm", etc., or you can use "\*" to indicate that the authoring rule is for all content.
- The "roles" and "users" attributes should be declared exclusive to each other. That is to say, an authoring rule should be for either "users" or "roles", but not both.
- The following special values for the "users" attribute are defined: 

    | **Value** | **Description** |
    | --- | --- |
    | **\*** | All users |
    | **?** | Anonymous users |

    > [!NOTE]
    > Anonymous users cannot read/write content; this setting is used to restrict the file types for anonymous property queries.
- The following values are defined for the access types:  

    | **Value** | **Description** |
    | --- | --- |
    | **None** | Specifies that access is not allowed for the content type |
    | **Read** | Specifies read access for the content type |
    | **Write** | Specifies write access for the content type |
    | **Source** | Specifies access to the source code for the content type |

#### Adding an authoring rule

To add an authoring rule for a path, you can use syntax like the following examples:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample24.cmd)]

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample25.cmd)]

#### Editing an authoring rule

Once an authoring rule has been added, you can edit that rule using syntax like the following:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample26.cmd)]

#### Removing an authoring rule

You can remove an authoring rule by simply specifying the user or role name using syntax like the following:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample27.cmd)]

> [!NOTE]
> If more than one authoring rule exists for that user, the above command will only remove the first authoring rule in the list and you would need to repeat the command to remove subsequent rules for that user.

Or you can specify both the user or role name and the content type like the following example:

[!code-console[Main](how-to-configure-webdav-settings-using-appcmd/samples/sample28.cmd)]

<a id="04"></a>

## Summary

This document has shown you how to do the following:

- [Work with AppCmd to perform basic WebDAV tasks](how-to-configure-webdav-settings-using-appcmd.md#02): 

    - [Enable or disable WebDAV for a web site](how-to-configure-webdav-settings-using-appcmd.md#02a)
    - [Require SSL for WebDAV authoring for a web site](how-to-configure-webdav-settings-using-appcmd.md#02b)
    - [Allow access to hidden files for a web site](how-to-configure-webdav-settings-using-appcmd.md#02c)
    - [Configure WebDAV compatibility settings for a web site](how-to-configure-webdav-settings-using-appcmd.md#02d)
- [Work with WebDAV Authoring Rules](how-to-configure-webdav-settings-using-appcmd.md#03): 

    - [Configure Authoring Rule Defaults](how-to-configure-webdav-settings-using-appcmd.md#03a)
    - [Manage Authoring Rules](how-to-configure-webdav-settings-using-appcmd.md#03b)

### More Information

For additional information about using WebDAV, please see the following articles:

- [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)
- [How to use custom properties with WebDAV](https://go.microsoft.com/fwlink/?LinkId=108320)

> [!NOTE]
> As mentioned earlier, your default request filtering settings may block several file types from WebDAV authoring. If you do not modify your request filtering settings, you may see various errors when you try to publish files that are blocked. For example, if you attempt to upload or download a web.config file you will see errors in your WebDAV client. For more information about configuring your request filtering settings, see the [How to Configure WebDAV with Request Filtering](how-to-configure-webdav-with-request-filtering.md) walkthrough.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1045.aspx)