---
title: Authentication and Authorization
TOCTitle: Authentication and Authorization
ms:assetid: 3c577f0b-e21a-4d26-9304-e73292b90ff6
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547032(v=VS.90)
ms:contentKeyID: 37836873
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Authentication and Authorization

IIS Smooth Streaming Management REST Services provides security by supporting both authentication and authorization features. Authentication involves validating identification credentials such as a name and password. Authorization involves managing access to the publishing point (.isml) file.

## Authentication

All calls to IIS Smooth Streaming Management REST Services are authenticated through the HTTP authentication mechanisms supported by IIS. IIS 7 supports Basic authentication, Client Certificate Mapping authentication, Digest authentication, IIS Client Certificate Mapping authentication, and Windows authentication (Negotiate and NTLM). (IIS 7 also supports Anonymous authentication, but Anonymous authentication is explicitly blocked for REST services APIs). All operations are authenticated. Anonymous calls are rejected with an HTTP 401 (Unauthorized) status code even when Anonymous authentication is enabled.

Non-domain and non-Windows clients can call the services if they use standard HTTP authentication mechanisms and if Windows credentials are provided. In addition, client certificate mapping can be used in order to map generic certificates to Windows user accounts. For more information, see [Client Certificate Mapping Authentication](http://www.iis.net/configreference/system.webserver/security/authentication/clientcertificatemappingauthentication).

## Authorization

IIS Smooth Streaming Management REST Services authorization is performed by checking user access rights to the publishing point (.isml) file. GET operations require read access to the publishing point file. PUT or DELETE operations require write access for the files. Creating a new publishing point using the POST operation requires write access to the directory where the publishing point is being created.

Management access to a publishing point can be controlled by adding or removing read or write access to the publishing point file using Windows Explorer or other tools for setting Access Control List (ACL) permissions, or by setting permissions for web server virtual directories.

