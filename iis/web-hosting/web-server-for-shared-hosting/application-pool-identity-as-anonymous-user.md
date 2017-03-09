---
title: "Application Pool Identity as Anonymous User | Microsoft Docs"
author: walterov
description: "In prior versions of IIS, the anonymous user allowed classic ASP content to be isolated by using a different anonymous user for each site. Isolation was acco..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/01/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/application-pool-identity-as-anonymous-user
msc.type: authoredcontent
---
Application Pool Identity as Anonymous User
====================
by [Walter Oliver](https://github.com/walterov)

In prior versions of IIS, the anonymous user allowed classic ASP content to be isolated by using a different anonymous user for each site. Isolation was accomplished by preventing ASP scripts from reverting back to the process identity, called the "impersonation sandbox". In mixed environments where you use classic ASP, ASP.NET and other dynamic content, the impersonation sandbox is not as helpful. For instance, ASP.NET uses a different isolation technique called Trust Levels and always runs as the process identity, unless you use a different type of impersonation.

To achieve isolation in IIS 7 and above, you can run the application pools as separate identities. If no anonymous user account is configured for a Web site, IIS can be configured to automatically use the application pool identity. This can greatly reduce the number of accounts needed for Web sites and make management of the accounts easier.

**To configure the Web server to use the application pool identity as the anonymous identity**

- Open a command prompt and run the following:


[!code-console[Main](application-pool-identity-as-anonymous-user/samples/sample1.cmd)]


> [!NOTE]
> Enable this feature by setting the anonymous user attribute to a blank string, for example, username="". Removing the element from the applicationHost.config file will result in a different behavior than having a blank string.

> [!NOTE]
> The settings described in this article are not compatible with SQL Server Express. SQL Server Express should never be used in Shared Hosting scenarios; this edition was meant for application development environments only; see [SQL Server Express and Hosting](https://blogs.msdn.com/sqlexpress/archive/2008/02/22/sql-server-express-and-hosting.aspx "SQL Server Express and Hosting") for details.

**To configure the Web server to use the application pool identity as the anonymous identity using the [IIS PowerShell Provider](../../manage/powershell/installing-the-iis-powershell-snap-in.md)**

- Open a PowerShell prompt and run the following:


[!code-powershell[Main](application-pool-identity-as-anonymous-user/samples/sample2.ps1)]