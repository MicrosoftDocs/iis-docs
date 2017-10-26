---
title: "IIS 10.0 Version 1709 HTTP Strict Transport Security (HSTS) Support | Microsoft Docs"
author: bangbingsyb
description: "The article introduces native HTTP Strict Transport Security (HSTS) support in IIS 10.0 version 1709."
ms.author: yashi
ms.date: 10/24/2017
ms.topic: article
ms.technology: iis
ms.prod: iis
msc.type: authoredcontent
---
IIS 10.0 Version 1709 HTTP Strict Transport Security (HSTS) Support
====================
by [Yanbing Shi](https://github.com/bangbingsyb)

> In IIS 10.0 version 1709, the administrator has the option of enabling HSTS and HTTP to HTTPS redirection at site level.

### Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 version 1709 | The features described in this article were introduced in IIS 10.0 version 1709 |
| IIS 10.0 and earlier | The features described in this article were not supported prior to IIS 10.0 version 1709 |


## HTTP Strict Transport Security (HSTS)

HTTP Strict Transport Security (HSTS), specified in [RFC 6797](https://tools.ietf.org/html/rfc6797), allows a website to declare itself as a secure host and to inform browsers that it should be contacted only through HTTPS connections. HSTS is an opt-in security enhancement and protects clients from man-in-the-middle type attacks that exploit insecure redirects.

HSTS enforces the use of HTTPS through a policy that requires support from both web servers and browsers. An HSTS enabled web host can include a special HTTP response header `Strict-Transport-Secuirty` (STS) along with a `max-age` directive in an HTTPS reply to request the browser to contact it through HTTPS in the future. The browser receives the header, and memorizes the HSTS policy for the number of seconds specified by the “max-age” directive. Within this period, if the user tries to visit the same website but types http:// or omits the scheme at all, the browser will redirect all such requests to HTTPS. The browser also prevents users from “clicking through” security warning (e.g. a warning about an invalid server certificate). For a user to take advantage of HSTS, the browser has to see the HSTS header at least once. To protect the user in the first connection to a given domain, HSTS has a separate mechanism to preload a list of domains to the browser out of the box.

## Challenges on Enabling HSTS before IIS 10.0 Version 1709

Before IIS 10.0 version 1709, enabling HSTS on an IIS server requires complex configuration.

Two solutions for enabling HSTS prior to IIS 10.0 version 1709 are provided for an example scenario: the web administrator wants to enable HSTS for a domain contoso.com that accepts both HTTP and HTTPS connections and to redirect all HTTP traffic to HTTPS.

### Solution 1: HTTP Redirect Module + Custom Headers

Redirecting all HTTP traffic to HTTPS can be achieved using the [HTTP Redirect Module](https://docs.microsoft.com/en-us/iis/configuration/system.webserver/httpredirect/) with two separate websites, one for HTTP and the other for HTTPS, to avoid a redirection loop.

[!code-xml[Main](iis-10-version-1709-hsts/samples/sample-httpredirect-two-sites.xml)]

A redirection rule is configured in the web.config of the HTTP site to route all its traffic to the HTTPS site, and the later actually serves the contents.

[!code-xml[Main](iis-10-version-1709-hsts/samples/sample-httpredirect-http-site.xml)]

The STS header can be added through [Custom Headers](https://docs.microsoft.com/en-us/iis/configuration/system.webServer/httpProtocol/customHeaders/) by configuring the web.config of the HTTPS site.

[!code-xml[Main](iis-10-version-1709-hsts/samples/sample-httpredirect-https-site.xml)]

### Solution 2: URL Rewrite Module

An alternative solution is installing the [URL Rewrite Module](https://docs.microsoft.com/en-us/iis/extensions/url-rewrite-module/using-the-url-rewrite-module) and configuring rewrite rules for a single website with both HTTP and HTTPS bindings. The HTTP to HTTPS redirection can be specified by an inbound rule while adding the STS header to HTTPS reply can be achieved by an outbound rule.

[!code-xml[Main](iis-10-version-1709-hsts/samples/sample-urlrewrite-single-site.xml)]

## IIS 10.0 Version 1709 Native HSTS Support

With the release of Windows Server 2016 version 1709, we are pleased to announce that IIS 10.0 version 1709 now supports HSTS natively. The configuration for enabling HSTS is significantly simplified - HSTS can be easily enabled at site-level by configuring the attributes of the `<hsts>` element under each `<site>` element - more details can be found in the configuration reference of HSTS [HSTS Settings for a Web Site <HSTS>](https://docs.microsoft.com/en-us/iis/configuration/system.applicationhost/sites/site/hsts).

The example scenario can be simply achieved through configuring the `enabled`, `max-age`, and `redirectHttpToHttps` attributes of `<hsts>` element of the website.

[!code-xml[Main](iis-10-version-1709-hsts/samples/sample-hsts-single-site.xml)]

The native support of HSTS can also be used together with [HTTP Redirect Module](https://docs.microsoft.com/en-us/iis/configuration/system.webserver/httpredirect/) to protect more complex redirections.

An example scenario is that a website contoso.com redirects all traffic to its subdomain www.contoso.com, and both websites accept HTTP and HTTPS connections. This is a typical scenario if the website is preferable to have a single canonical address. HSTS is recommended to be enabled for both the root domain and the subdomain to protect users when they directly visit either one (e.g. through bookmark). Enabling `includeSubDomains` attribute of the `<hsts>` element of the root domain further enhances the coverage its HSTS policy to all the subdomains.

[!code-xml[Main](iis-10-version-1709-hsts/samples/sample-hsts-subdomain.xml)]

In addition, the redirection from the root domain to the subdomain can be configured through the `<httpRedirect>` element in the web.config of the root domain site. With such configuration, an HTTP request to contoso.com will be redirected to HTTPS, and an HTTPS request to the same site will be redirected to www.contoso.com with the STS header added in the response.

[!code-xml[Main](iis-10-version-1709-hsts/samples/sample-hsts-subdomain-redirect.xml)]

The sample configurations above also apply to the scenario of redirecting traffic from a source site to a destination site that is not a subdomain of the source site, with a minor modification: disabling `includeSubDomains` on the source site.
