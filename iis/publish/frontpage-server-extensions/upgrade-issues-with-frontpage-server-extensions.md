---
title: "Upgrade Issues with FrontPage Server Extensions | Microsoft Docs"
author: rmcmurray
description: "When upgrading a computer that is running a previous version of IIS to Windows Vista ® or Windows Server ® 2008, the IIS web services will be disabled if the..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/16/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/publish/frontpage-server-extensions/upgrade-issues-with-frontpage-server-extensions
msc.type: authoredcontent
---
Upgrade Issues with FrontPage Server Extensions
====================
by [Robert McMurray](https://github.com/rmcmurray)

## Introduction

When upgrading a computer that is running a previous version of IIS to Windows Vista® or Windows Server® 2008, the IIS web services will be disabled if the FrontPage Server Extensions (FPSE) were installed on the computer. This behavior is a security measure to prevent unwarranted access to files where FPSE keeps metadata for your web site. The FrontPage Server Extensions were not updated, yet are available on [IIS.NET for download](https://www.iis.net/downloads?tabid=34&amp;g=6&amp;i=1460), on Windows Vista and Windows Server 2008. However, the files and folders that contain metadata and other content-related information about your web site will not be removed during an upgrade. The purpose of this article is to discuss the various files and folders that you should manually remove or secure before you enable web services on an IIS 7.0 or above web server.

> [!NOTE]
> This document discusses the potential threats to the default folders and files that are created and used by the FrontPage Server Extensions. If administrators/authors have been modifying the content in these files and folders, there may be greater risk involved. Administrations should always analyze their environments to determine if any threats exist.

## Threat Levels and Recommended Actions

When discussing potential security risks, this document makes use of the following threat levels:


| Threat Level | Description |
| --- | --- |
| High | When the threat to security is set to high, any failure in securing or deleting the folders/files listed may result in unauthorized access to sensitive information. Administrations should always follow the actions recommended in this document. |
| Medium | When the threat level is set to medium, the folders/files listed may contain information that administrators may not want to expose. Administrations should analyze their environment and usually follow the actions recommended in this document. |
| Low | When the threat is set to low, the folders/files listed should normally contain information that is safe for public access. Because of this, no additional actions will usually need to be accomplished. Administrations should still analyze their content to determine if any threats exist that are outside the scope of this document. |


When recommending actions for administrators, this document makes use of the following recommended definitions:


| Recommended Action | Description |
| --- | --- |
| Delete | The folders/files listed should be deleted. |
| Secure | The folders/files listed should be secured. Usually this can be accomplished at the folder level by removing read access on the path through the IIS administration tool, or by copying the content to a safe location outside of your web site's content folders and then removing the content from web site. |
| N/A | No additional actions will usually need to be accomplished. |


## Securing FrontPage Folders and Files

### Folders Found Within a FrontPage Web Site

The following table lists the folders that are used by the FrontPage Server Extensions and recommended actions. If the folders listed in this table were used for additional functionality, you should always secure those folders as appropriate.


| Folder | Threat | Action | Notes |
| --- | --- | --- | --- |
| \_derived | Low | N/A | FrontPage keeps derived files like generated images in this folder. |
| \_fpclass | Medium | Secure | Should contain publicly available FrontPage code - but should be secured if a user has modified the code. |
| \_overlay | Low | N/A | FrontPage keeps derived files like generated images in this folder. |
| \_private | High | Secure | The FrontPage Server Extensions often keep sensitive data files in this folder, so it should be configured to prevent browsing. |
| \_vti\_bin | High | Delete | This is the virtual directory for the FrontPage Server Extensions executables. Although the IIS security settings should block any unknown code from executing within this path, this path is configured to allow executables to function and should be removed from your web site's configuration if present. |
| \_vti\_bot | Medium | Secure or Delete | This folder should not usually exist for FrontPage, and contains user-generated FrontPage Web Bots. Administrations should examine what files are located in this folder and secure or delete them as appropriate. |
| \_vti\_cnf | High | Secure or Delete | The FrontPage Server Extensions keep sensitive metadata files in this folder, so it should be deleted or configured to prevent browsing. The potential threat is the revelation of domain/user names and other metadata. |
| \_vti\_log | Medium | Secure or Delete | The FrontPage Server Extensions keep author logs in this folder, so it should be deleted or configured to prevent browsing. The potential threat is the revelation of domain/user names and other author-related activity. |
| \_vti\_pvt | High | Secure or Delete | This folder holds several files that contain various metadata for your web site, and should be secured. Note: For more details, please see the section Files found within the \_vti\_pvt folder |
| \_vti\_script | Medium | N/A or Delete | This folder is used by FrontPage for scripts that search web sites using Index Server. Administrators that configure Index Server searching may want to keep this folder, or they may wish to delete it. The potential threat is the revelation of physical file paths on the server that are listed in IDQ files. |
| \_vti\_shm | Low | Delete | This folder should not exist, and is a leftover from FrontPage 1.x, so it is safe to delete. |
| \_vti\_txt | High | Delete | This folder contains the text indices and catalogs for the older FrontPage WAIS search. Since later versions of FrontPage only used Index Server, it is safe to delete this folder. The potential threat is the revelation of the contents for files within your web site. |
| cgi-bin | Medium | Secure or Delete | This folder should not exist for FrontPage, and may be a leftover from early versions of FrontPage. Administrations should examine what files are located in this folder and secure or delete them as appropriate. The potential threat is legacy FrontPage or other CGI applications that can be executed within the content area that may no longer be safe. |
| fpdb | High | Secure | FrontPage keeps databases in this folder, so it should be configured to prevent browsing. The potential threat is the unauthorized access to databases in your web site. |
| images | Low | N/A | FrontPage keeps image files in this folder. |


### Files Found Within the \_vti\_pvt Folder

The following table lists the files that are located within the \_vti\_pvt folder of a FrontPage Web site. These files are used by the FrontPage Server Extensions to store various metadata for a web site, and should usually be secured or deleted at the folder-level.


| File | Threat | Action | Notes |
| --- | --- | --- | --- |
| \_x\_browsers.xml | Low | N/A | Contains usage information for web browsers. |
| \_x\_domains.xml | Low | N/A | Contains usage information for domains. |
| \_x\_pagehits.xml | Low | N/A | Contains usage information for individual pages. This is mostly safe, unless you have pages that are not publicly available. |
| \_x\_systems.xml | Low | N/A | Contains usage information for operating systems. |
| \_x\_todo.htm | High | Delete | Contains the to do list for users. The potential threat is the revelation of domain/user names. |
| \_x\_todoh.htm | High | Delete | Contains the to do history for users. The potential threat is the revelation of domain/user names. |
| \_x\_users.xml | High | Delete | Contains usage information for specific users. The potential threat is the revelation of domain/user names. |
| access.cnf | High | Delete | Contains access information for a FrontPage web site. |
| botinfs.cnf | Low | N/A | Contains FrontPage WebBot information for a FrontPage web site. |
| bots.cnf | Low | N/A | Contains FrontPage WebBot information for a FrontPage web site. |
| deptodoc.btr | Medium | Delete | Document dependencies database - safe to delete. |
| doctodep.btr | Medium | Delete | Document dependencies database - safe to delete. |
| frontpg.lck | Low | Delete | Lock file - safe to delete. |
| linkinfo.btr | Medium | Delete | Document dependencies database - safe to delete. |
| service.cnf | High | Secure | Contains the metadata for a FrontPage web site. The potential threat is the revelation of domain/user names , local file paths, and other metadata. |
| service.lck | Low | Delete | Lock file - safe to delete. |
| services.cnf | Low | N/A | Contains FrontPage subsite information. Note: If you delete this you will lose your FrontPage web site/subsite hierarchy and subsites will become part of the parent FrontPage web site. |
| structure.cnf | Low | N/A | Contains the FrontPage web site structure. |
| svcacl.cnf | Medium | Delete | Contains information about the end-user permissions for a FrontPage web site. (e.g. Whether subsites have unique permissions and any IP address restrictions.) |
| usage.lck | Low | Delete | Lock file - safe to delete. |
| writeto.cnf | High | Delete | Contains a list of files that can be written to. (e.g. Form handler result files.) |


### Files Found Within the Root Folder of a FrontPage Web Site

The following table lists the files that are located within the root folder of a FrontPage Web site.


| File | Threat | Action | Description |
| --- | --- | --- | --- |
| \_vti\_inf.html | Low | Delete | This file contains the virtual paths to the FrontPage Server Extensions executables, and is used by any client that communicates with the FrontPage Server Extensions. |
| postinfo.html | Low | Delete | This file contains information for the Windows Web Publishing Wizard. |


## Summary

In this article, you were instructed on where to locate FrontPage Server Extensions 2002 for Windows Vista and Windowa Server 2008. As well, you saw in detail what data is pertinent to FrontPage installations and how to accurately secure this data.