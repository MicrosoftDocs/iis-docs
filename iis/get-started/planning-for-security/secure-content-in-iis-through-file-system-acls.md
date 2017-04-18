---
title: "Secure Content in IIS Through File System ACLs | Microsoft Docs"
author: naziml
description: "The access control list (ACL) is a list of permissions associated with an object. Each of these permission entries is called an access control entry (ACE); a..."
ms.author: iiscontent
manager: soshir
ms.date: 03/17/2009
ms.topic: article
ms.assetid: 1adc180c-a714-41c1-b4ca-9a3f75e106d0
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/planning-for-security/secure-content-in-iis-through-file-system-acls
msc.type: authoredcontent
---
Secure Content in IIS Through File System ACLs
====================
by [Nazim Lala](https://github.com/naziml)

## Introduction

The access control list (ACL) is a list of permissions associated with an object. Each of these permission entries is called an access control entry (ACE); an ACE contains permissions associated with a particular object for a particular identity. For example, for file system objects, you can set ACLs on files/directories on an NTFS file system.

You can use graphical user interface (GUI) tools (such as My Computer or Windows® Explorer) to set or edit ACLs. Simply right-click any file or folder resource from one of these tools, select **Properties**, and then click the **Security tab** to see a graphical representation of the ACL on the resource you chose. From this dialog box, you can apply or remove group or user permissions to system resources such as files and folders. You can also use a command-line utility Cacl.exe to display or modify file ACLs.

## ACL Basics

It is useful to start with some ACL basics.

### Common IIS Permissions

The most common permissions of interest in ACE are read, write, execute, and list folder contents.

- **Read / Write Permissions.** The read and write permissions give read and write access to the file system object, respectively.
- **List Folder Contents Permission.** The list folder content permission is used for displaying the contents of a folder and is required to register file change notifications on a directory.
- **Execute Permission.** The execute permission is used to specify if the operating system should execute a particular application as the specified user. This does not cover dynamic application scenarios such as PHP (or Microsoft® ASP.NET). You are running code when you invoke a .php or .aspx file, but not from the perspective of the operating system. Instead of setting the execute permission, you should look into using the script/execute permissions.
- **Full Control.** The full control permission gives all access to the file system object. Avoid full control, and use more granular read/write permissions.
- **IIS Script / Execute Permissions.** Files with dynamic content, such as .php (or .aspx) files, need script permission to function. But note that while the file system ACLs have an execute flag, they have nothing for script. This is because Internet Information Services 7 and above (IIS 7 and above) have a special configuration to denote if a particular file has dynamic content; this configuration is stored in IIS configuration, outside file system ACLs. When script or execute permissions are discussed, it is actually the IIS configuration not the file system execute permission.
- **Object Inheritance.** File system ACLs are usually inherited. In some cases, the parent directory might have very loose ACLs that need to be overridden at the child level to adequately lock content. This is unlikely to be an issue in a hosted scenario since there are few permissions at the root.

### Common IIS Identities

You can either allow or deny permissions to particular identities through ACLs to secure your content. There are two types of identities: process identities (those that the IIS worker process is launched with) and the request handler identities (those from authentication of the request).

- **Worker Process Identity (WPI)**. The IIS worker process runs as the WPI, which is configurable through the Application Pool configuration settings in IIS. IIS 6.0 on Windows Server® 2003 and IIS 7 and above on Windows Server® 2008 have the "Network Service" identity as the default WPI. Windows Server® 2008 R2 however uses the application pool identity as the default WPI. If your application authenticates and impersonates, your request hander identity is the authenticated user identity.  
 If your Php.ini has fcgi.impersonate set to "true" (recommended for IIS), then your PHP processes are running as the authenticated user. It is important to note that in the case of anonymous authentication, the authenticated user would be the configured anonymous user.
- **IIS\_IUSRS.** This is a built-in identity group that is a container of all worker process identities (WPIs) on the server. IIS automatically includes all WPIs in this group (no need to add them manually).  
 On IIS 6.0 on Windows Server 2003, this group is called IIS\_WPG. This is an overarching group that contains all WPIs, and is therefore not a good candidate for isolating content. Any application running in any application pool would be running as an identity that falls into this group, so giving this group read access means that all applications are able to read your content.
- **IUSR / Anonymous User Identity.** The built-in IUSR account is the default used to denote the user identity of anyone using anonymous authentication. The anonymous user identity is configurable and can be set to an identity besides this built-in default.   
 In practice, you should configure a custom account for the anonymous user account and never use the built-in account. It is important to understand that in IIS, the anonymous user is not the lack of an authenticated user. Rather, anonymous requests should be considered as requests where the authenticated user is the anonymous user identity.
- **Application Pool Identity.** This is a virtual identity associated with a particular application pool. Whenever a user creates an application pool, a virtual identity (security identifier or SID) is created with it; this identity is injected into the IIS worker process so that the worker process running under this application pool has access to content with permissions locked to this virtual identity. In Windows Server 2008 Service Pack 2 (SP2), the administrator can create their worker processes with this virtual identity. This is configurable in the IIS application pool configuration settings as the "Application Pool Identity" type and is the default WPI identity type for Windows Server 2008 R2. (Identity is unique to the application pool that created it and can therefore be used to isolate content on the server to application pools more effectively.)
- **Authenticated User Identity.** If your application uses any form of authentication (including anonymous authentication), then this is the identity of the authenticated user. In the anonymous authentication case, this identity would be your configured anonymous user identity.

#### IIS Execution Pipeline

To understand which identities are applicable at which stages, it is helpful to understand the basics of the IIS execution pipeline. The two parts of the pipeline that are most applicable are authentication and handler mapping.

- **Authentication.** Before authentication, the authenticated user context is unknown and all IIS worker processes are running as the WPI. If you have a PHP request that is trying to access content before the request is authenticated, then the WPI needs access to the content. This scenario comes into play when using the Global rules for URL Rewriter that run in the global pre-begin request phase of the IIS pipeline, which occurs before authentication. The URL Rewriter has the ability to process rules differently based on whether the resource being accessed is a file or a directory. For this to be evaluated, a filesystem access needs to occur, and due to its position in the execution pipeline, this access request occurs as the WPI.  

    Post authentication, the authenticated user context is set, but you are not necessarily impersonating until your request gets mapped to a handler. For phases between authentication and handler mapping, you are most likely to be running as WPI.
- **Handler Mapping.** In this phase of the execution pipeline, your request gets mapped to a handler; for example, requests to \*.php get mapped to the FastCGI handler. After this mapping occurs and you have impersonation enabled, the handler identity is the Authenticated User, and all resource access in this phase occurs using the authenticated user identity.

### Select an Identity

Figuring out the right accounts to grant permissions depends on the profile and critical resources of your application. The main considerations are which permissions to grant and whether or not you are authenticated.

- **Granting the Proper Permissions.** Dynamic content such as that in PHP and ASP.NET applications needs IIS script permission and read access. If you need to run executables, they need to have the IIS execute permission and they need to be properly configured in the CGI Restriction List. Anything that is not user-uploaded needs only read access on the file system.  
 Content that is going to be uploaded by a user should reside in a separate folder to which you assign write access. It is important not to give this folder IIS execute or script permissions so users can't upload and execute malicious code.   
 In general, the WPI should have read access to all content for your application to work correctly.
- **Applications That Require Authentication.** For applications that require authentication, lock down all resources to a group containing all authenticated users. If you have different categories of users (admin and non-admin), create separate groups, and give access accordingly. For example, if your application has an admin directory that contains administration scripts, give permissions to read this directory only to the admin group. If your application is impersonating, then the handler identity is the authenticated user; otherwise, it is your WPI. If you have set fcgi.impersonate to "true" in your Php.ini file, then your fcgi processes identity is the authenticated user identity; otherwise, it is the WPI. With this information, an administrator can determine the right set of ACLs to place on the content.
- **Applications That Run Anonymously.** It is important to note that running anonymously on IIS means that you are authenticated as the anonymous user identity. In this case, lock down resources to either the application pool identity or your custom configured anonymous identity, and give access to the application pool identity over the anonymous identity. If you give IIS\_IUSRS group access to your content, the applications running in any application pool have access to your content. If you allow anonymous users to upload files, your application should ensure further checks on the types of content these users can upload in order to keep the server secure.

## How to Set ACLs

There are several ways to set your ACLs through the shell, including command-line tools such as Icacls.exe. This article focuses on the Web Deployment Tool manifest (XML) mechanism that can be used to set ACLs. This is used when installing an application through the Web Deployment Tool or the Web Platform Installer.

To give Read, Execute, and Write permissions to *MyApp* file system directory for user *Foo*, add the following line to the Manifest.xml file:

[!code-xml[Main](secure-content-in-iis-through-file-system-acls/samples/sample1.xml)]

To set the ACL on the path *MyApp/Upload* to allow anonymous users to upload content, add the following line to your Manifest.xml file:

[!code-xml[Main](secure-content-in-iis-through-file-system-acls/samples/sample2.xml)]

Note that ***anonymousAuthenticationUser*** is a special token that will resolve to your configured anonymous authentication identity.

To grant Read access to the MyApp\Data folder for the application pool identity, add the following line to the Manifest.xml file:

[!code-xml[Main](secure-content-in-iis-through-file-system-acls/samples/sample3.xml)]

Note that the *setAclUse* r is not used here (the default value for this is Application Pool Identity).

## Links for Further Information

[Understanding the Built-In User and Group Accounts in IIS7 and Above](understanding-built-in-user-and-group-accounts-in-iis.md)