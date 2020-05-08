---
title: "Configuring Step 4: Configure SSL Central Certificate Store"
author: rmcmurray
description: "In the final phase of building a web farm with IIS servers, you add a central certificate store to your farm. This store enables you to place your SSL certif..."
ms.date: 04/14/2013
ms.assetid: 7d367f12-05e8-433f-9b96-816cbefa261f
msc.legacyurl: /learn/web-hosting/scenario-build-a-web-farm-with-iis-servers/configuring-step-4-configure-ssl-central-certificate-store
msc.type: authoredcontent
---
Configuring Step 4: Configure SSL Central Certificate Store
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In the final phase of building a web farm with IIS servers, you add a central certificate store to your farm. This store enables you to place your SSL certificates on one file server and share them with all web servers in farm. You no longer have to have copies of every certificate on every server.

This article guides you through configuring a central certificate store and testing it on your web farm.

When you are done with these tasks, record your design decisions before going on to [Step 5: Configure Application Deployment](configuring-step-5-configure-application-deployment.md).

<a id="41"></a>
## 4.1. Configure a Central Certificate Store

Before attempting to configure a central certificate store, create a shared folder on a dedicated back-end file server. You must provide a UNC path to the shared folder (for example, \\CertServer\Certs).

### To configure a central certificate store

1. On your ARR server, open IIS Manager.
2. In the **Connections** pane, select the server node.
3. Double-click **Centralized Certificates**.
4. In the **Actions** pane, click **Edit Feature Settings**.
5. In the **Edit Centralized Certificates Settings** dialog, select the **Enable Centralized Certificates** check box.
6. In the **Physical path** box, type the UNC path to the shared certificate folder.
7. In the **User name** box, type the name of the custom user account on the file server.
8. In the **Password** and **Confirm password** boxes, type the password for the account.
9. If your certificates use a private key password, type the password in the **Password** and **Confirm password** boxes.
10. Click **OK**.

## See Also

- [Step 3: Configure IIS Web Farm Load Balancing](configuring-step-3-configure-iis-web-farm-load-balancing.md)
- [Step 5: Configure Application Deployment](configuring-step-5-configure-application-deployment.md)
- [Step 4: Plan SSL Central Certificate Store](planning-step-4-plan-ssl-central-certificate-store.md)
- [Configure a Web Farm with IIS Servers](configure-a-web-farm-with-iis-servers.md)
- [Build a Web Farm with IIS Servers](overview-build-a-web-farm-with-iis-servers.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)
