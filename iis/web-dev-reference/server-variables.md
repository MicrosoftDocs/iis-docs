---
title: "IIS Server Variables | Microsoft Docs"
author: shirhatti
description: "IIS Server Variables provide information about the server"
ms.author: soshir
manager: soshir
ms.date: 03/11/2008
ms.topic: article
ms.technology: iis-hosting
ms.prod: iis
msc.type: authoredcontent
---
IIS Server Variables
====================

IIS Server Variables provide information about the server, the connection with 
the client, and the current request on the connection. Additionally, inbound
URL rewrite rules can be used to set custom server variables.

> [!NOTE]
> Not all server variables listed in this document are available in versions of IIS prior to IIS 8.5.


| Server Variable       | Description                                           |
|-----------------------|-------------------------------------------------------|
| ALL_HTTP              | All HTTP headers sent by the client. The headers are prefixed by with HTTP_ and capitalized.<br/>For example, `HTTP_ACCEPT_ENCODING:gzip, deflate, br` |
| ALL_RAW               | All HTTP headers sent by the client in raw form.<br/> For example, `Accept-Encoding: gzip, deflate, br` |
| APPL_MD_PATH          | The metabase path of the application. |
| APPL_PHYSICAL_PATH    | The physical path of the application. |
| APP_POOL_CONFIG       | The physical path of the temporary IIS application pool configuration. |
| APP_POOL_ID           | The name of the application pool that is running the IIS worker process handling the request. |
| AUTH_PASSWORD         | The password provided by the client to authenticate using Basic Authentication. |
| AUTH_TYPE             | The authentication method that the server uses to validate users.<br/>It does not mean that the user was authenticated if AUTH_TYPE contains a value and the authentication scheme is not Basic or integrated Windows authentication. The server allows authentication schemes it does not natively support because an ISAPI filter may be able to handle that particular scheme.  |
| AUTH_USER             | The name of the user as it is derived from the authorization header sent by the client, before the user name is mapped to a Windows account. This variable is no different from REMOTE_USER. If you have an authentication filter installed on your Web server that maps incoming users to accounts, use LOGON_USER to view the mapped user name. |
| CACHE_URL             | For use in ISAPI applications only. Returns the unambiguous name for the current URL. It is necessary to use the Unicode version of this variable in conjunction with the kernel mode cache invalidation function to evict entries placed in the cache by HSE_REQ_VECTOR_SEND.<br/> |
| CERT_COOKIE           | Unique ID for the client certificate, returned as a string. This can be used as a signature for the whole client certificate. |
| CERT_FLAGS            |**bit0** is set to 1 if the client certificate is present.<br/>**bit0** is set to 1 if the certification authority of the client certificate is invalid (that is, it is not in the list of recognized certification authorities on the server).<br/>If bit 1 of CERT_FLAGS is set to 1, indicating that the certificate is invalid, IIS version 4.0 and later will reject the certificate. Earlier versions of IIS will not reject the certificate. |
| CERT_ISSUER           | The issuer field of the client certificate. |
| CERT_KEYSIZE          | The number of bits in the SSL/TLS connection key size. |
| CERT_SECRETKEYSIZE    | The number of bits in the SSL/TLS server private key. |
| CERT_SERIALNUMBER     | Serial number of the client certificate. |
| CERT_SERVER_ISSUER    | The issuer field of the server certificate. |
| CERT_SERVER_SUBJECT   | The subject field of the server certificate. |
| CERT_SUBJECT          | The subject field of the client certificate. |
| CONTENT_LENGTH        | The length of the request body.  |
| CONTENT_TYPE          | The MIME type of the request body. Used with queries that have attached information, such as **GET**, **POST**, and **PUT**. |
| CRYPT_CIPHER_ALG_ID   | The cryptographic cipher algorithm used to establish the connection. The hex value of the algorithm is established in the [ALG_ID data type](https://msdn.microsoft.com/en-us/library/windows/desktop/aa375549(v=vs.85).aspx).<br/>For example, 256-bit AES(CALG_AES_256) will be `6610`. |
| CRYPT_HASH_ALG_ID     | The hashing algorithm used for generating Message Authentication Codes (MACs). The hex value of the algorithm is established in the [ALG_ID data type](https://msdn.microsoft.com/en-us/library/windows/desktop/aa375549(v=vs.85).aspx).<br/>For example, MD5(CALG_MD5) will be `8003`.|
| CRYPT_KEYEXCHANGE_ALG_ID | The key-exchange algorithm used to establish the connection. The hex value of the algorithm is established in the [ALG_ID data type](https://msdn.microsoft.com/en-us/library/windows/desktop/aa375549(v=vs.85).aspx).<br/>For example, Elliptic curve Diffie-Hellman key exchange algorithm(CALG_ECDH) will be `aa05`. |
| CRYPT_PROTOCOL        | The cryptographic protocol used to establish the connection. The hex value of the protocol is established in the [SecPkgContext_ConnectionInfo structure](https://msdn.microsoft.com/en-us/library/windows/desktop/aa379819(v=vs.85).aspx).<br/>For example, **TLS 1.2** will be `400`. |
| DOCUMENT_ROOT         | The physical path of the directory the IIS Website. |
| FORWARDED_URL         | The forwarded URL. |
| GATEWAY_INTERFACE     | The revision of the CGI specification used by the server. The format is CGI/revision. |
| HTTPS                 | Returns **ON** if the request came in through a secure channel (for example, SSL); or it returns **OFF**, if the request is for an insecure channel.|
| HTTPS_KEYSIZE         | Number of bits in the SSL/TLS connection key size. |
| HTTPS_SECRETKEYSIZE   | Number of bits in the server certificate private key. |
| HTTPS_SERVER_ISSUER   | Issuer field of the server certificate. |
| HTTPS_SERVER_SUBJECT  | Subject field of the server certificate. |
| HTTP_METHOD           | The method used to make the request. |
| HTTP_URL              | The raw encoded URL.<br/>For example, `/vdir/default.aspx?querystring` |
| HTTP_VERSION          | The name and version of the request protocol (the raw form of **SERVER_PROTOCOL**). |
| INSTANCE_ID           | The IIS site ID. |
| INSTANCE_META_PATH    | The metabase path for the instance of IIS that responds to the request. |
| INSTANCE_NAME         |  The IIS site name. |
| LOCAL_ADDR            |  The server address on which the request came in. This is important on computers where there can be multiple IP addresses bound to the computer, and you want to find out which address the request used. |
| LOGON_USER            | The Windows account that the user is impersonating while connected to your Web server. Use **REMOTE_USER**, **UNMAPPED_REMOTE_USER**, or **AUTH_USER** to view the raw user name that is contained in the request header. The only time LOGON_USER holds a different value than these other variables is if you have an authentication filter installed. |
| MANAGED_PIPELINE_MODE | The managed pipeline mode of the application pool that is running the IIS worker process handling the request. |
| PATH_INFO             | Path information, as given by the client, for example, `/vdir/myisapi.dll/zip`. If this information comes from a URL, it is decoded by the server before it is passed to the CGI script or ISAPI filter.<br/>If the [AllowPathInfoForScriptMappings](https://msdn.microsoft.com/en-us/library/ms525840(v=vs.90).aspx) metabase property is set to true (to support exclusive CGI functionality), **PATH_INFO** will only contain `/zip` and ISAPI applications such as ASP will break. |
| PATH_TRANSLATED       | The physical path that maps to the virtual path in **PATH_INFO**, for example, `c:\inetpub\wwwroot\vdir\myisapi.dll`. This variable is used by IIS during the processing of ISAPI applications.<br/>If the [AllowPathInfoForScriptMappings](https://msdn.microsoft.com/en-us/library/ms525840(v=vs.90).aspx) metabase property is set to true (to support exclusive CGI functionality), PATH_INFO will only contain `/zip` and ISAPI applications such as ASP will break. |
| QUERY_STRING          | Query information stored in the string following the question mark (?) in the HTTP request. |
| REMOTE_ADDR           | The IP address of the remote host that is making the request. |
| REMOTE_HOST           | The name of the host that is making the request. If the server does not have this information, it will set REMOTE_ADDR and leave this empty. |
| REMOTE_PORT           | The client port number of the TCP connection. |
| REMOTE_USER           | The name of the user as it is derived from the authorization header sent by the client, before the user name is mapped to a Windows account. If you have an authentication filter installed on your Web server that maps incoming users to accounts, use LOGON_USER to view the mapped user name. |
| REQUEST_FILENAME      | The physical path for the current request. |
| REQUEST_METHOD        | The method used to make the request. |
| REQUEST_URI           | The path-absolute part of the URI.<br/>For example `https://contoso.com:8042/over/there?name=ferret` would return `/over/there` |
| SCRIPT_FILENAME       | The physical path of the current request. |
| SCRIPT_NAME           | A virtual path to the script being executed. |
| SCRIPT_TRANSLATED     | The [extended-length path](https://msdn.microsoft.com/en-us/library/aa365247(VS.85).aspx#maxpath) to the requested file (prefixed with `\\?\`). |
| SERVER_ADDR           | The IP address that the site is bound to. |
| SERVER_NAME           | The server's host name, DNS alias, or IP address as it would appear in self-referencing URLs. |
| SERVER_PORT           | The server port number to which the request was sent. |
| SERVER_PORT_SECURE    | A string that contains either `0` or `1`. If the request is being handled on the secure port, then this is `1`. Otherwise, it is `0`. |
| SERVER_PROTOCOL       | The name and revision of the request information protocol. The format is protocol/revision. (The canonicalized form of **HTTP_VERSION**.) |
| SERVER_SOFTWARE       | The name and version of the server software that answers the request and runs the gateway. The format is name/version. |
| UNENCODED_URL         | The raw unencoded URL. |
| UNMAPPED_REMOTE_USER  | The name of the user as it is derived from the authorization header sent by the client, before the user name is mapped to a Windows account (same as REMOTE_USER). If you have an authentication filter installed on your Web server that maps incoming users to accounts, use LOGON_USER to view the mapped user name. |
| URL                   | The base portion of the URL without any querystring information. |
