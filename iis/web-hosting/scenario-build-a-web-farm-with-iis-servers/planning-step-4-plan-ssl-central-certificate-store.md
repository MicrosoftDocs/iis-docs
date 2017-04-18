---
title: "Planning Step 4: Plan SSL Central Certificate Store | Microsoft Docs"
author: rmcmurray
description: "In this phase of planning for a web farm, you add support for SSL-secured websites by configuring a central certificate store. Centralized SSL certificate su..."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 472a47cf-2ecb-448c-9719-66455ebf9e62
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/scenario-build-a-web-farm-with-iis-servers/planning-step-4-plan-ssl-central-certificate-store
msc.type: authoredcontent
---
Planning Step 4: Plan SSL Central Certificate Store
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In this phase of planning for a web farm, you add support for SSL-secured websites by configuring a central certificate store. Centralized SSL certificate support is a new feature on IIS 8.

When you are done with these tasks, record your design decisions before going on to [Step 5: Plan Application Deployment](planning-step-5-plan-application-deployment.md).

<a id="41"></a>
## 4.1. Introduction to Centralized Certificates

On Windows Server® 2012, the **Centralized SSL Certificate Support** feature allows server administrators to store and access the certificates centrally on a file share. You can configure a centralized certificate store on you web farm to load the certificates from the file share.

Using centralized certificates simplifies management SSL bindings. SSL requires the DNS name and CN name of a certificate to match. Similar contract can be extended to the file names of the certificates. For example, *www.contoso.com* would use the certificate with a file name *www.contoso.com.pfx*. This contract enables Windows Server 2012 to have just one SSL binding, regardless of the number of secure sites that are using this feature. IIS 8 infers what certificate to use by the SNI value or hostname of the requested website, and by matching it to the file name of the certificate.

<a id="42"></a>
## 4.2 Plan a Central Certificate Store

Similar to shared configuration, the centralized certificates uses a shared folder on a dedicated back-end file server to store the certificates for the web farm. Do not put the certificate shared folder on the content file server.

The central certificate store requires certificates to use the following naming conventions:

- Certificate names must the following form: CN\_name.pfx (for example, www.contoso.com.pfx).
- If the certificate is a wild character certificate, use an underscore (\_) as the wild character (for example, \_.contoso.com.pfx).
- If the certificate has multiple CN names, they must be named as individual files (for example, www.contoso1.com.pfx, www.contoso2.com.pfx, and so forth).

## See Also

- [Step 5: Plan Application Deployment](planning-step-5-plan-application-deployment.md)
- [Step 3: Plan IIS Web Farm Load Balancing](planning-step-3-plan-iis-web-farm-load-balancing.md)
- [Step 4: Configure SSL Central Certificate Store](configuring-step-4-configure-ssl-central-certificate-store.md)
- [Plan a Web Farm with IIS Servers](plan-a-web-farm-with-iis-servers.md)
- [Build a Web Farm with IIS Servers](overview-build-a-web-farm-with-iis-servers.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)