---
title: "Remote Administration Behavior Matrix | Microsoft Docs"
author: NitashaV
description: "This document contains the matrix of scenarios for remote administration for IIS Manager and the runtime behavior for each one. It helps understand the diffe..."
ms.author: iiscontent
manager: soshir
ms.date: 02/14/2008
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/remote-administration/remote-administration-behavior-matrix
msc.type: authoredcontent
---
Remote Administration Behavior Matrix
====================
by [Nitasha Verma](https://github.com/NitashaV)

## Introduction

This document contains the matrix of scenarios for remote administration for IIS Manager and the runtime behavior for each one. It helps understand the different administration scenarios and troubleshooting issues (401s).

A prerequisite for remote administration via the IIS UI is starting the remote administration service (WMSVC) on the server machine. A good article for this information is [Remote Administration for IIS Manager](remote-administration-for-iis-manager.md).

General rules of thumb which are valid for every item in the matrix:

- Redirection.config, applicationHost.config and administration.config are always read (even for site and app connections).
- Redirection.config is always read using the identity in which the service WMSVC runs (by default: NT Service\WMSVC).
- If configurationRedirection is enabled in Redirection.config, then:

    - Server Config files (applicationHost.config, administration.config) are always read using the username and password specified in redirection.config
- If configurationRedirection is disabled, then: 

    - Server Config files (applicationHost.config, administration.config) are always read using the identity in which WMSVC runs (NT Service\WMSVC by default)
- UI does nothing special when trying to read Root web.config, the ASP.NET counterpart of applicationHost.config

## Remote Administration Behavior Matrix

| Connect As: | Windows Administrator | Windows User | IIS Manager User |
| --- | --- | --- | --- |
| Default Experience | Server Connection: - UI impersonates as the windows admin when writing to the server config files (applicationHost.config, administration.config and root web.config) | Server Connection: - N/A | Server Connection: - N/A |
| Site Connection: - UI impersonates as the windows admin when reading from and writing to the site's web.config | Site Connection: - UI impersonates as the windows user when reading from and writing to the site's web.config | Site Connection: - Site's web.config file is read from and written to using the identity in which WMSVC runs (NT Service\WMSVC) |
| App Connection: - Same as the site connection | App Connection: - Same as the site connection | App Connection: - Same as the site connection |
| Site or App on UNC | Server Connection: - UI impersonates as the windows admin when writing to the server config files( applicationHost.config, administration.config and root web.config) | Server Connection: - N/A | Server Connection: - N/A |
| Site Connection: - If UNC credentials are specified for the UNC share, UI will read the site's web.config file using those UNC credentials and write as windows administrator - If UNC credentials are not specified for the UNC share, UI will read from and write to the site's web.config file as windows administrator | Site Connection: - If UNC credentials are specified for the UNC share, UI will read the site's web.config file using those UNC credentials and write as windows user - If UNC credentials are not specified for the UNC share, UI will read from and write to the site's web.config file as windows user | Site Connection: - If UNC credentials are specified for the UNC share, UI will read the site's web.config file using those UNC credentials and write using the identity in which WMSVC runs (NT Service\WMSVC) - If UNC credentials are not specified for the UNC share, UI will read from and write to site's web.config using the identity in which WMSVC runs (NT Service\WMSVC) *\*see note below* |
| App Connection: - Same as the site connection | App Connection: - Same as the site connection | App Connection: - Same as the site connection *\* see note below* |
| Configuration Redirection is enabled in Redirection.Config Config files: **applicationHost.config administration.config** | Server Connection: - Server files are read using the username and password specified in redirection.config - UI impersonates as the windows admin when writing to the server config files( applicationHost.config, administration.config and root web.config) | Server Connection: - N/A | Server Connection: - N/A |
| Site Connection: - UI impersonates as the windows admin when reading from and writing to the site's web.config | Site Connection: - UI impersonates as the windows user when reading from and writing to the site's web.config | Site Connection: - Site's Config is read from and written to as the identity in which WMSVC runs (NT Service\WMSVC) |
| App Connection: - Same as the site connection | App Connection: - Same as the site connection | App Connection: - Same as the site connection |

> [!NOTE]
> If NT Service\WMSVC does not have permissions to the UNC share -- which will be the case for UNC shares on another machine -- (WMSVC means nothing outside the realm of a local machine), update the identity of Web Management Service (services.msc) to be a domain user that has access to the server as well as the UNC share.

**IMPORTANT**: Do *not* use a Network Service identity – it is a possible security risk, since that is the identity under which ASP.NET applications run. If you use ACLs to this account, you will open your content/configuration up for anyone to access via an aspx page.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1111.aspx)