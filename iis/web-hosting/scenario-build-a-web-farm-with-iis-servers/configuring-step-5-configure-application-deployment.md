---
title: "Configuring Step 5: Configure Application Deployment"
author: rmcmurray
description: "n this step of building a web farm, you install and configure FTP for deploying website updates and new websites. You also install and configure Web Deploy f..."
ms.date: 04/14/2013
ms.assetid: ecf70784-d0b8-4c2f-9e4f-c547741cadf8
msc.legacyurl: /learn/web-hosting/scenario-build-a-web-farm-with-iis-servers/configuring-step-5-configure-application-deployment
msc.type: authoredcontent
---
Configuring Step 5: Configure Application Deployment
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In this step of building a web farm, you install and configure FTP for deploying website updates and new websites. You also install and configure Web Deploy for deploying web applications.

<a id="51"></a>
## 5.1. Install and Configure FTP for Your Web Farm

The procedures in this section guide you through installing and configuring FTP for you web farm. Install FTP on your load balancing computer (ARR server) only. The web servers do not need FTP installed. For more information about FTP configuration, see [Build an FTP Site on IIS](../../publish/using-the-ftp-service/scenario-build-an-ftp-site-on-iis.md).

### To install FTP for your farm

1. On the **Start** screen, and click the **Server Manager** tile.
2. In the **Server Manager Dashboard**, click **Add roles and features**.
3. If the **Before you begin** page of **Add Roles and Features Wizard** is displayed, click **Next**.
4. On the **Select installation type** page, select **Role-based or feature-based installation**, and click **Next**.
5. On the **Select destination server** page, select **Select a server from the server pool**, select your server from the **Server Pool** list, and then click **Next**.
6. On the **Select server roles** page, expand the **Web Server (IIS)** node, and then expand the **FTP Server** node.
7. Select the **FTP Server** check box and the **FTP Service** check box, and then click **Next**.
8. On the **Select features** page, click **Next**.
9. On the **Confirm installation selections** page, click **Install**.

### To add an FTP site

1. Open IIS Manager.
2. In the **Connections** pane, expand the server node and click the **Sites** node.
3. In the **Actions** pane, click **Add FTP Site** to open the **Add FTP Site** wizard.
4. On the **Site Information** page, in the **FTP site name** box, type a unique friendly name for the FTP site.
5. In the **Physical path** box, type the UNC path to the shared content folder on your back-end file server.
6. Click **Next** to open the **Binding and SSL Settings** page.
7. Under **Binding**, in the **IP Address** list, select or type an IP address if you do not want the IP address to remain **All Unassigned**.
8. In the **Port** box, type the port number.
9. Optionally, in the **Virtual Host** box, type a host name if you want to host multiple FTP sites on a single IP address. For example, type <strong>www.contoso.com</strong>.
10. Clear the **Start FTP site automatically** box if you want to start the site manually.
11. Under **SSL**, from the **SSL Certificate** list, select a certificate. Optionally, click **View** to open the **Certificates** dialog box and verify information about the selected certificate.
12. Select one of the following options:

    - **Allow SSL**: Allows the FTP server to support both non-SSL and SSL connections with a client.
    - **Require SSL**: Requires SSL encryption for communication between the FTP server and a client.
13. Click **Next** to open the **Authentication and Authorization Information** page.
14. Under **Authentication**, select the authentication method or methods that you want to use:

    - **Anonymous**: Allows any user to access content providing only the user name **anonymous** or **ftp**. (Most, but not all, FTP clients enter user name for you automatically.)
    - **Basic**: Requires users to provide a valid user name and password to access content. Because Basic authentication transmits unencrypted passwords across the network, use this authentication method only when you know that the connection between the client and FTP server is secure, such as by using Secure Sockets Layer (SSL).
15. Under **Authorization**, from the **Allow access to** list, select one of the following options:

    - **All Users**: All users, whether they are anonymous or identified, can access the content.
    - **Anonymous Users**: Anonymous users can access the content.
    - **Specified Roles or User Groups**: Only members of certain roles or user groups can access the content. Type the role or user group in the corresponding box.
    - **Specified Users**: Only specified users can access the content. Type the user name in the corresponding box.
16. If you selected an option from the **Allow access to** list, select one or both of the following permissions:

    - **Read**: Permits authorized users to read content from the directory.
    - **Write**: Permits authorized users to write to the directory.
17. Click **Finish**.

<a id="52"></a>
## 5.2. Install and Test Web Deploy for Your Web Farm

Install Web Deploy on your source computer (your development machine with IIS installed). Install Web Deploy on each of your web application servers. Use [Web Platform Installer](https://www.microsoft.com/web/downloads/platform.aspx) to install the current version of Web Deploy and its dependencies.

To test your Web Deploy installation, use it to update your website.

### To install Web Deploy for your farm

1. Open a browser to the [Web Deployment Tool](https://www.iis.net/downloads/microsoft/web-deploy) website, and click the **Install** button.
2. Click **Allow**, and then click **Yes**.
3. In the **Web Platform Installer** window, click **Install**.
4. Look over the components to be installed, and then click **I Accept**. When the installer completes the installation, it displays and summary showing what was installed.
5. Click **Finish**, and then click **Exit**.

### To update your website with Web Deploy

1. On your development computer, open IIS Manager.
2. In the **Connections** pane, select the updated website.
3. In the **Actions** pane, click **Export Application**. The **Export Application Package** wizard appears.
4. On the **Select the Contents of the Package** page, make sure all check boxes are selected, and click **Next**.
5. On the **Select Parameters** page, add parameters if needed for your application, and click **Next**.
6. On the **Save Package** page, type the path (including the package name) to the location where you want the package saved. This location could to a shared folder on the development computer or a shared folder on the destination computer (the ARR server).
7. Click **Next**. The package is exported and saved.
8. Click **Finish**.
9. On one of your web application servers, open IIS Manager.
10. In the **Actions** page, click **Import Application**. The **Import Application Package** appears.
11. On the **Select the Package** page, type the path (including the package name) to the location where you exported the package.
12. Click **Next**.
13. On the **Select the Contents of the Package** page, make sure all check boxes are selected, and click **Next**.
14. On the **Enter Application Package Information** page, type the path to your website, and click **Next**.
15. On the **Overwrite Existing Files** page, choose whether to delete all files that are in the new package, and click **Next**.
16. Click **Finish**. Web Deploy has updated your website.

<a id="53"></a>
## 5.3. Where do I go from here?

You now have a working web farm. It uses ARR for load balancing. It employs shared content and shared configuration. You have a central certificate store for use with SSL-secured websites. And you can deploy websites and web applications with either FTP or Web Deploy.

There are many ways to improve your web farm, here are a few suggestions:

- Allow users who are not administrators to deploy web applications with Web Deploy. For more information, see [Allowing non-admin users to deploy web applications](https://blogs.msdn.com/b/amol/archive/2011/02/09/allowing-non-admin-users-to-deploy-web-applications-on-iis-7-using-web-deploy-2-0.aspx).
- Use failover clustering to mirror your back-end file servers, eliminate signal points of failure on the back-end, and improve throughput. For more information, see [Failover Clustering](https://technet.microsoft.com/en-us/library/hh831579).
- You should also to eliminate signal points on failure on the front end. You can use Network Load Balancing (NLB) with multiple ARR servers achieve high availability, scalability, and stability on the front end of your farm. To learn more about using ARR and NLB together, see [Achieving High Availability and Scalability-ARR and NLB](../../extensions/configuring-application-request-routing-arr/achieving-high-availability-and-scalability-arr-and-nlb.md).

## See Also

- [Step 4: Configure SSL Central Certificate Store](configuring-step-4-configure-ssl-central-certificate-store.md)
- [Step 5: Plan Application Deployment](planning-step-5-plan-application-deployment.md)
- [Configure a Web Farm with IIS Servers](configure-a-web-farm-with-iis-servers.md)
- [Plan a Web Farm with IIS Servers](plan-a-web-farm-with-iis-servers.md)
- [Build a Web Farm with IIS Servers](overview-build-a-web-farm-with-iis-servers.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)