---
title: "Overview of Shared Hosting Deployment Using Application Request Routing 2.0 | Microsoft Docs"
author: rick-anderson
description: "Microsoft Application Request Routing (ARR) 2.0 is a proxy-based routing module that forwards HTTP requests to content servers based on HTTP headers and serv..."
ms.author: iiscontent
manager: soshir
ms.date: 07/02/2008
ms.topic: article
ms.assetid: a5d3b0ff-8c95-4dd8-ad79-67ed492018c8
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/planning-for-arr/overview-of-shared-hosting-deployment-using-application-request-routing-20
msc.type: authoredcontent
---
Overview of Shared Hosting Deployment Using Application Request Routing 2.0
====================
by [IIS Team](https://twitter.com/inetsrv)

Microsoft Application Request Routing (ARR) 2.0 is a proxy-based routing module that forwards HTTP requests to content servers based on HTTP headers and server variables, and load balance algorithms. For more information, refer to [Using Application Request Routing](using-the-application-request-routing-module.md).

There is a feature called host name affinity that is designed specifically for shared hosters. This article provides an overview of this feature and how it can be used to deploy an environment that is highly available and scalable, easy to manage, and potentially create additional business opportunities.

***Common Shared Hosting Deployment***

Below is a diagram of how a typical shared hosting deployment environment may look like:

[![](overview-of-shared-hosting-deployment-using-application-request-routing-20/_static/image3.jpg)](overview-of-shared-hosting-deployment-using-application-request-routing-20/_static/image2.jpg)

1. User requests www.site2.com.
2. DNS is requested for www.site2.com.
3. IP address for www.site2.com is returned.
4. Browser sends requests to the IP address.
5. Based on the host name, requests are routed to the corresponding site.
6. Responses for www.site2.com are returned.

While the above deployment works, it has the following disadvantages:

- There is no redundancy among sites.
- The administrator has to load balance the traffic by limiting the number of sites per server.
- The server resources may not be utilized evenly across servers.
- The administrator has to manage multiple configuration files.

***Shared Hosting with Application Request Routing***

The host name affinity feature in Application Request Routing enables shared hosters to rethink how sites are deployed. Application Request Routing affinitizes the requests, regardless of whether they are made from one client or multiple clients, to one server behind ARR, ensuring that a given site is consuming resources only on one of the servers. The below diagram illustrates this deployment environment:

[![](overview-of-shared-hosting-deployment-using-application-request-routing-20/_static/image5.jpg)](overview-of-shared-hosting-deployment-using-application-request-routing-20/_static/image4.jpg)

1. User requests www.site2.com.
2. DNS is requested for www.site2.com.
3. IP address for www.site2.com is returned.
4. Browser sends requests to the IP address.
5. **ARR load balances the requests to one server and affinitizes the requests for www.site2.com to the same server for the lifespan of corresponding worker process.**
6. Requests are sent to one of the servers.
7. Content for www.site2.com is requested from a file share.
8. Content for www.site2.com is returned.
9. Responses for www.site2.com are returned.

The above deployment environment with Application Request Routing provides the following benefits over the common shared hosting deployment:

- The requests are dynamically load balanced by Application Request Routing.
- The administrator can scale the environment horizontally by adding new servers without predefined site allocations.
- The servers' resources are more evenly distributed.
- The sites have high availability.
- There is only one shared configuration to manage.

With the ARR Version 1 release, hosters can specify the number of servers that sites can utilize per host name. This ability allows hosters to position each application server as a unit of capacity that the sites owners can purchase.

To learn how to use host name affinity in Application Request Routing, refer to [Shared Hosting using Application Request Routing](../configuring-application-request-routing-arr/shared-hosting-using-application-request-routing-arr.md).
  
  
[Discuss in IIS Forums](https://forums.iis.net/1154.aspx)