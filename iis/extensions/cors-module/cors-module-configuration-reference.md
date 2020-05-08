---
title: "CORS Module Configuration Reference"
author: jhkimnew
description: "This article provides an overview of the IIS CORS module and explains the configuration of the module."
ms.date: 09/19/2017
ms.assetid:
msc.legacyurl:
msc.type: authoredcontent
---
IIS CORS module Configuration Reference
====================
by the IIS Team

> This article provides an overview of the IIS CORS module and explains the configuration of the module.

<a id="_Functionality_Overview"></a>
## Functionality Overview

The Microsoft IIS CORS Module is an extension that enables web sites to support the [CORS](https://www.w3.org/TR/cors/)(Cross-Origin Resource Sharing) protocol.

The IIS CORS module provides a way for web server administrators and web site authors to make their applications support the CORS protocol. With this module, developers can move CORS logic out of their applications and rely on the web server. The module's handling of CORS requests is determined by rules defined in the configuration. These CORS rules can be easily defined or configured making it simple to delegate all CORS protocol handling to the module.

### IIS CORS module is a server-side CORS component

The CORS protocol governs client/server communication. Usually, web browsers act as the client-side CORS component, while the IIS server works as the server-side CORS component with the help of the IIS CORS module.

A CORS request occurs when a protocol aware client, such as a web browser, makes a request to a domain (origin) that differs from the current domain. This scenario is known as a cross-origin request. When CORS is not used, cross-origin requests will be blocked by the client. When the CORS module is used, IIS will inform clients whether a cross-origin request can be performed based on the IIS configuration.

### CORS preflight request

A CORS preflight request is used to determine whether the resource being requested is set to be shared across origins by the server. The CORS preflight uses the HTTP _OPTIONS_ method with the _ACCESS-CONTROL-REQUEST-METHOD_ and the _ORIGIN_ request headers. The IIS CORS module is designed to handle the CORS preflight requests before other IIS modules handle the same request. The OPTIONS requests are always anonymous, so CORS module provides IIS servers a way to correctly respond to the preflight request even if anonymous authentification needs to be disabled server-wise.

<a id="_IISCORS_Configuration"></a>
## CORS Configuration

The IIS CORS is configured via a site or application *web.config* file and has its own `cors` configuration section within `system.webServer`.

Below are the configuration examples to enable CORS for a site named contentSite. The \* origin allows all host origins; however, those that start with `http://*` are later excluded. For the `https://*.microsoft.com` host origin, the CORS response is customized with various CORS configurations as an example.

 ```xml
 <?xml version="1.0" encoding="UTF-8"?>
 <configuration>
     <system.webServer>
         <cors enabled="true" failUnlistedOrigins="true">
             <add origin="*" />
             <add origin="https://*.microsoft.com"
                  allowCredentials="true"
                  maxAge="120"> 
                 <allowHeaders allowAllRequestedHeaders="true">
                     <add header="header1" />
                     <add header="header2" />
                 </allowHeaders>
                 <allowMethods>
                      <add method="DELETE" />
                 </allowMethods>
                 <exposeHeaders>
                     <add header="header1" />
                     <add header="header2" />
                 </exposeHeaders>
             </add>
             <add origin="http://*" allowed="false" />
         </cors>
     </system.webServer>
 </configuration>
 ```

With the IIS CORS module, you can:

1. Enable, disable CORS for a whole IIS server or for a specific IIS site, an application, a virtual directory, a physical directory or a file (system.webServer/cors).
2. Configure all the origin host domains to be accepted with \* origin host rule.
3. Configure the list of specific origin host domains and allow only the CORS request which has the same value of the origin request header as one of listed origin host domains.
4. Configure wild card origin host domains when configuring the list of origin domain such as `http://*` or `https://*.mydomain.com`.
5. Configure a list of origin domains which should be disallowed as CORS request.
6. Customize the CORS response header values with the configured values.

## Attributes of the cors element

| **Attribute** | **Description** |
| --- | --- |
| `enabled` | Optional Boolean attribute.<br>Specifies whether CORS is enabled.<br>The default value is `false`. |
| `failUnlistedOrigins` | Optional Boolean attribute.<br>Specifies whether the CORS response status code to be set with 403 if the requested origin is not matched to the configured list of origin or if the origin host is configured to be disallowed.<br>The default value is `false`. |

### Adding Origin rule &lt;add&gt;

<a id="001"></a>
## Origin rules

The `<add>` element of the `<cors>` collection specifies an individual origin to be added to the list of origin rules.

### Attributes of the origin rule

| **Attribute** | **Description** |
| --- | --- |
| `origin` | Required string attribute.<br>Specifies origin host on which to impose an origin rule. You can use an asterisk (\*) to apply this rule to all origin request header values. You can also use an asterisk (\*) as a wildcard for the child subdomain name. If there are multiple origin rules, it is applied to the most specific origin host name rule regardless of the allowed attribute value.  |
| `allowed` | Optional Boolean attribute.<br>Specifies whether to accept the CORS request for the origin host.<br>The default value is `true`.  |
| `allowCredentials` | Optional Boolean attribute.<br>Specifies whether to set the Access-Control-Allow-Credentials: `true` CORS response header. This attribute should be used only for a specific origin host name rather than \* origin host for CORS protocol compliance.<br>The default value is `false`. |
| `maxAge` | Optional integer attribute. Duration in seconds.<br>Specifies the value of the `Access-Control-Max-Age` response header for the preflight CORS request. The Access-Control-Max-Age response header is supposed to be set only for the CORS preflight requests. If you don't want to set the Access-Control-Max-Age header in the CORS response, set -1 for this attribute.<br>The default value is `-1`.  |

#### Using only \* origin host rule

If there is only \* origin host rule, IIS CORS module has some different behaviors compared to when there is a specific origin host name rule.
If there is only \* origin host rule, IIS CORS module does the following:

1. The value of Access-Control-Allow-Origin response header is set to \* regardless of the value of the `origin` request header sent by the client-side CORS component.
2. Vary: `origin` response header is not added because IIS CORS does not generate Access-Control-Allow-Origin response header values other than \* and there is no need to use the Vary: `origin` response header value.

### Child Elements of the origin host rule

| **Element** | **Description** |
| --- | --- |
| **allowHeaders** | configures **allowHeaders** collection that is used for the value of the `Access-Control-Allow-Headers` CORS response header for the **origin** host specified in the origin host rule.<br>The `Access-Control-Allow-Headers` response header will be set only for the actual CORS requests rather than the preflight requests. |
| **allowMethods** | configures **allowMethods** collection that is used for the value of the `Access-Control-Allow-Methods` CORS response header for the **origin** host specified in the origin host rule.<br>The `Access-Control-Allow-Methods` response header will be set only for the CORS preflight requests.|
| **exposeHeaders** | configures **exposeHeaders** collection that is used for the value of the `Access-Control-Expose-Headers` CORS response header for the **origin** host specified in the origin host rule.<br>The `Access-Control-Expose-Headers` response header will be set only for the actual CORS requests rather than the preflight requests.|

### Attributes of the allowHeaders element

| **Attribute** | **Description** |
| --- | --- |
| `allowAllRequestedHeaders` | Optional Boolean attribute. If this is true, IIS module will take the value of the given Access-Control-Request-Headers CORS request header and set the Access-Control-Allow-Headers response header with the same value, which means all the given headers are allowed. If this is false, it sets the Access-Control-Allow-Headers response header with the header values of the allowHeaders collection, which means that only the listed headers are allowed. The default value is `false`. |

<a id="_Sample_Code"></a>
## Sample Code

### C\#

[!code-csharp[Main](cors-module-configuration-reference/samples/sample1.cs)]

### JavaScript

[!code-csharp[Main](cors-module-configuration-reference/samples/sample2.cs)]

### Command Line (AppCmd)

[!code-console[Main](cors-module-configuration-reference/samples/sample3.cmd)]

### PowerShell

[!code-console[Main](cors-module-configuration-reference/samples/sample4.cmd)]
