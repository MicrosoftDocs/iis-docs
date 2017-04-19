---
title: "Planning Step 4: Plan Application Security | Microsoft Docs"
author: rmcmurray
description: "In this phase of building your website, consider the security needs of your ASP.NET application."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2013
ms.topic: article
ms.assetid: fa53abca-5bda-4b1c-a35c-25610e76e78b
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/scenario-build-an-aspnet-website-on-iis/planning-step-4-plan-application-security
msc.type: authoredcontent
---
Planning Step 4: Plan Application Security
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In this phase of building your website, consider the security needs of your ASP.NET application. The following sections describe application security settings available in IIS 8:

<a id="41"></a>
## 4.1. Isolate Web Applications

One of the most effective ways to improve security for your web application is to isolate it from other applications on your web server. An application pool has its own worker process, which processes requests and runs application code. The worker process has a security identifier (SID). And each application pool has a unique application-pool identity. By default, when you create a web application, a new application pool is also created with the same name as the application. If you keep web applications in separate application pools, you can isolate them from one another.

Web application isolation entails the following:

- Site isolation: Separate different applications into different sites with different application pools.
- Least privilege: Run your worker process as a low privileged identity (virtual application pool identity) that is unique per site.
- Temp isolation: Set up a separate ASP.NET temp folder per site and only give access to appropriate process identity.
- Content isolation: Make sure to set an ACL (access control list) on each site root to allow only access to the appropriate process identity.

**Tip**: It is a good idea to host your website and web application content on a drive other than your system drive (C:).

<a id="42"></a>
## 4.2. .NET Trust Levels

An application *trust level* determines the permissions that the ASP.NET code access security (CAS) policy grants. CAS defines two trust categories: full trust and partial trust. An application that has full trust permissions can access all resource types on a server and perform privileged operations. Applications with full trust are affected only by the security settings of the operating system.

Partial-trust web applications are applications that do not have full trust and have a restricted set of code access permissions. As a result, partial-trust applications are limited in their ability to access secured resources and perform other privileged operations. Certain permissions are denied to partial-trust applications, so resources that require those permissions cannot be directly accessed. Other permissions are granted in a restricted way, so resources that require those permissions might be accessible, but in a limited way. For example, restricted file IO permission give the application can access to the file system, but only in directories beneath the application's virtual directory root.

By configuring a web application or web service for partial trust, you can restrict the application ability to access crucial system resources or resources that belong to other web applications. By granting only the permissions that the application requires and no more, you can build least privileged web applications and limit potential damage if the web application is compromised by a code injection attack.

The following list shows the restrictions associated with each trust level:

- Full trust applications have unrestricted access to all resource types and can perform privileged operations.
- High, medium, low, or minimal trust applications are unable to call unmanaged code or serviced components, write to the event log, access Message Queuing queues, or access OLE DB data sources.
- High trust applications have unrestricted access to the file system.
- Medium trust applications have restricted file system access and can only access files in their own application-directory hierarchy.
- Low or minimal trust applications cannot access SQL Server databases.
- Minimal trust applications cannot access any resources.

<a id="43"></a>
## 4.3. .NET Authentication

Authentication helps you confirm the identity of clients who request access to your sites and applications. When authentication is enabled, IIS 8 uses the account credentials supplied by the user to determine what permissions the user has been granted and what resources the user can access.

This section describes the authentication modes that are specific to ASP.NET applications.

1. [ASP.NET Forms Authentication](#431)
2. [ASP.NET Impersonation Authentication](#432)

<a id="431"></a>
### ASP.NET Forms Authentication

Forms authentication uses client-side redirection to forward unauthenticated users to an HTML form where they can enter their credentials, which are usually a user name and password. After the credentials are validated, users are redirected to the page they originally requested. Forms authentication often employs cookies to pass user credentials between the server and the client browser.

The following sections describe what you need to know to plan adding forms authentication to your site:

1. [Forms authentication basics](#4311)
2. [Authentication cookies](#4312)

<a id="4311"></a>
#### Forms authentication basics

ASP.NET Forms-based authentication works well for sites or applications on public web servers that receive many requests. This authentication mode lets you manage client registration and authentication at the application level, instead of relying on the authentication mechanisms the operating system provides.

> [!IMPORTANT]
> Because Forms authentication sends the user name and password to the web server as plaintext, use Secure Sockets Layer (SSL) encryption for the logon page and for all other pages in your application except the home page. For information about SSL, see [4.5. TLS/SSL Communication](#45).

Forms authentication lets users log on by using identities from an ASP.NET membership database. This authentication method uses redirection to an HTML logon page to confirm the identity of the user. You can configure Forms authentication at the site or application levels.

Forms authentication is convenient for the following reasons:

- It allows either a custom data store, such as a SQL server database, or Active Directory to be used for authentication.
- It integrates easily with a web user interface.
- Clients can use any browser.

If you want to use membership roles for authorization, use Forms authentication or a similar custom authentication method.

> [!IMPORTANT]
> If you select Forms authentication, you cannot use any of the challenge-based authentication methods at the same time.

By default, the login URL for Forms authentication is Login.aspx. You can create a unique login page for clients who visit a site or application. For example, you might want to collect specific information from visitors, or offer membership to selected pages on the site or selected applications.

The default time-out value for Forms authentication is 30 minutes. Consider changing the time-out value to a shorter period, to shorten the session lifetime and to reduce the chance of cookie replay attacks.

<a id="4312"></a>
#### Authentication cookies

Authentication cookies are used as a token to verify that a client has access to some or all pages of an application. By contrast, personalization cookies contain user-specific settings that determine user experience on a specific site or application.

Important: Because authentication cookies are passed between client and server together with every request, always secure authentication cookies using Secure Sockets Layer (SSL). For information about SSL, see [4.5. TLS/SSL Communication](#45).

Cookies are a more efficient way to track visitors to a site than query strings, because they do not require redirection. However, they are browser-dependent, and some browsers do not support their use. In addition, the use of cookie-based authentication is not always effective because some users disable cookie support in their browsers.

By default, the cookie name for ASP.NET applications is .ASPXAUTH. However, you can instead use a unique cookie name and path for each application. Doing so can prevent users who are authenticated for one application from being authenticated for other applications on a web server.

You can choose one of the following cookie modes for your site or application:

| Mode | Description |
| --- | --- |
| Use cookies | Cookies are always used regardless of device. |
| Do not use cookies | Cookies are not used. |
| Auto Detect | Cookies are used if the device profile supports cookies. Otherwise, no cookies are used. For desktop browsers that are known to support cookies, ASP.NET checks to determine whether cookies are enabled. This setting is the default. |
| Use device profile | Cookies are used if the device profile supports cookies. Otherwise, no cookies are used. ASP.NET does not check to determine whether cookies are enabled on devices that support cookies. This setting is the default for IIS 8. |

The cookie protection mode defines the function a Forms authentication cookie performs for a specific application. The following table shows the cookie protection modes that you can define:

| Mode | Description |
| --- | --- |
| Encryption and validation | Specifies that the application use both data validation and encryption to help protect the cookie. This option uses the configured data validation algorithm (based on the machine key). If triple-DES (3DES) is available and if the key is long enough (48 bytes or more 3DES is used for encryption. This setting is the default (and recommended) value. |
| None | Specifies that both encryption and validation are disabled for sites that are using cookies only for personalization and have weaker security requirements. We do not recommend that you use cookies in this manner; however, it is the least resource-intensive way to enable personalization by using the .NET Framework. |
| Encryption | Specifies that the cookie is encrypted by using Triple-DES or DES, but data validation is not performed on the cookie. Cookies used in this manner might be subject to plaintext attacks. |
| Validation | Specifies that a validation scheme verifies that the contents of an encrypted cookie have not been changed in transit. |

> [!IMPORTANT]
> For security reasons, consider keeping Encryption and Validation cookies separate from each other. The theft of encryption cookies would be a greater security exposure than the theft of validation cookies.

If an application contains objects that clients request frequently, improve application performance by caching those objects. If the user accesses the cached object before the authentication cookie times out, IIS 8 allows the cached object to remain in the cache, and the timer is reset. However, if the user does not access the cached object during that time, IIS 8 removes the cached object from the cache.

Consider enabling this setting under the following circumstances:

- You have a limited amount of memory available for caching.
- You have many objects to cache, because this setting allows only the most frequently requested objects to remain in the cache.

> [!NOTE]
> You specify the number of minutes before an authentication cookie times out with **Authentication cookie time-out (in minutes)**.

<a id="432"></a>
### ASP.NET Impersonation Authentication

Use ASP.NET impersonation when you want to run your ASP.NET application under a security context different from the default security context for ASP.NET applications.

If you enable impersonation for an ASP.NET application, that application can run in one of two different contexts: either as the user authenticated by IIS 8 or as an arbitrary account that you set up. For example, if you use Anonymous authentication and choose to run the ASP.NET application as the authenticated user, the application would run under an account that is set up for anonymous users (typically, IUSR). Likewise, if you chose to run the application under an arbitrary account, it would run under whatever security context was set up for that account.

By default, ASP.NET impersonation is disabled. If you enable impersonation, your ASP.NET application runs under the security context of the user authenticated by IIS 8.

<a id="44"></a>
## 4.4. Machine Key Settings

Machine keys help protect Forms authentication cookie data and page-level view state data. They also verify out-of-process session state identification. ASP.NET uses the following types of machine keys:

- A *validation key* computes a Message Authentication Code (MAC) to confirm the integrity of the data. This key is appended to either the Forms authentication cookie or the view state for a specific page.
- A *decryption key* is used to encrypt and decrypt Forms authentication tickets and view state.

IIS 8 enables you to configure validation and encryption settings and generate machine keys for use with ASP.NET application services, such as view state, forms authentication, membership, roles, and anonymous identification.

Before you generate machine keys for your application, make the following design decisions:

- Decide what validation method to use: AES, MD5, SHA1 (default), TripleDES, HMACSHA256, HMACSHA384, or HMACSHA512.
- Decide what encryption method to use: Auto (default), AES, TripleDES, or DES.
- Decide whether to generate the validation key at runtime automatically.
- Decide whether to generate a unique validation key for each application.
- Decide whether to generate the decryption key at runtime automatically.
- Decide whether to generate a unique decryption key for each application.

<a id="45"></a>
## 4.5. TLS/SSL Communication

Transport Layer Security (TLS) and its predecessor, Secure Sockets Layer (SSL) are protocols that provide communication security your website. You can use TLS/SSL to authenticate servers and clients and then use it to encrypt messages between the authenticated parties.

In the authentication process, a TLS/SSL client sends a message to a TLS/SSL server, and the server responds with the information that the server needs to authenticate itself. The client and server perform an additional exchange of session keys, and the authentication dialog ends. When authentication is completed, SSL-secured communication can begin between the server and the client by using the symmetric encryption keys that are established during the authentication process.

To configure TSL/SSL for your website, do the following:

1. Obtain a server certificate from a certification authority (CA). See [Server Certificates](#451).
2. Add SSL binding to the site. See [SSL Binding](#452).
3. Set IIS to require SSL on the site. See [Require SSL for Your Site](#453).
4. Consider using client certificates for your site. See [Client Certificates](#454).

<a id="451"></a>
### Server Certificates

You can obtain a server certificate from a certification authority (CA). Obtaining a server certificate from a certification authority is one step in configuring Secure Sockets Layer (SSL) or Transport Layer Security (TLS). You can obtain server certificates from a third-party CA. A third-party CA might require you to provide proof of identity before a certificate is issued. You can also issue your own server certificates by using an online CA, such as Microsoft Certificate Services.

Digital certificates are electronic files that work like an online password to verify the identity of a user or a computer. They are used to create the SSL encrypted channel that is used for client communications. A certificate is a digital statement that is issued by a certification authority (CA) that vouches for the identity of the certificate holder and enables the parties to communicate in a secure manner by using encryption.

Digital certificates do the following:

- They authenticate that their holders-people, web sites, and even network resources such as routers-are truly who or what they claim to be.
- They protect data that is exchanged online from theft or tampering.

Digital certificates are issued by a trusted third-party CA or a Microsoft Windows public key infrastructure (PKI) using Certificate Services, or they can be self-signed. Each type of certificate has advantages and disadvantages. Each type of digital certificate is tamper-proof and can't be forged.

Certificates can be issued for several uses. These uses include web user authentication, web server authentication, Secure/Multipurpose Internet Mail Extensions (S/MIME), Internet Protocol security (IPsec), Transport Layer Security (TLS), and code signing.

A certificate contains a public key and attaches that public key to the identity of a person, computer, or service that holds the corresponding private key. The public and private keys are used by the client and the server to encrypt the data before it is transmitted. For Windows-based users, computers, and services, trust in a CA is established when there is a copy of the root certificate in the trusted root certificate store and the certificate contains a valid certification path. For the certificate to be valid, the certificate must not have been revoked and the validity period must not have expired.

<a id="452"></a>
### SSL Binding

You can assign multiple bindings to a site when you have site content that serves different purposes or for which you must use a different protocol. For example, a commerce site might have an application that requires that users log on to an account to purchase merchandise. The company hosts the site over HTTP, but users must log on to their account on an HTTPS page. In this example, the site would have two bindings: one for the HTTP portion and one for the HTTPS portion.

Out of the box, you cannot add bindings for protocols other than HTTP and HTTPS by using IIS Manager. If you want to add a binding for a different protocol, such as a protocol supported by Windows Communication Foundation (WCF), use one of the other administration tools. However, if you install the IIS File Transfer Protocol (FTP) server, you can add FTP bindings by using IIS Manager. There might also be other modules or third-party functionality available for download that extend the UI.

<a id="453"></a>
### Require SSL for Your Site

Secure Sockets Layer (SSL) encryption protects confidential or personal information sent between a client and a server. When SSL is enabled, remote clients access your site by using URLs that start with https://.

First configure a server certificate and create an HTTPS binding to enable any SSL settings. Then require Secure Sockets Layer (SSL) encryption in one or more of the following circumstances:

1. When confidential or personal content on your server must be protected by an encrypted channel.
2. When you want users to be able to confirm the identity of your server before they transmit personal information.
3. When you want to use client certificates to authenticate clients that access your server.

<a id="454"></a>
### Client Certificates

When you want clients to verify their identity before they access content on your web server, configure client certificates. By default, client certificates are ignored.

Before you can configure client certificate on your website, configure a server certificate and create an HTTPS binding to enable any Secure Sockets Layer (SSL) settings.

If you want all clients to verify their identity, specify that client certificates are required. If some clients can access content without first verifying their identity, specify that client certificates are accepted.