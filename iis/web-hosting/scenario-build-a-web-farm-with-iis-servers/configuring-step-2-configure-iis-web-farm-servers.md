---
title: "Configuring Step 2: Configure IIS Web Farm Servers"
author: rmcmurray
description: "In the second phase of building your web farm, you configure shared content and shared configuration on your first web server. Then you add more web servers..."
ms.date: 04/14/2013
ms.assetid: 15299639-f499-4b4f-9e5f-811dda98b618
msc.legacyurl: /learn/web-hosting/scenario-build-a-web-farm-with-iis-servers/configuring-step-2-configure-iis-web-farm-servers
msc.type: authoredcontent
---
# Configuring Step 2: Configure IIS Web Farm Servers

by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

In the second phase of building your web farm, you configure shared content and shared configuration on your first web server. Then you add more web servers to your farm.

When you are done with these tasks, record your design decisions before going on to [Step 3: Configure IIS Web Farm Load Balancing](configuring-step-3-configure-iis-web-farm-load-balancing.md).

<a id="21"></a>
## 2.1. Prepare Your Back-end File Server

In this procedure, you set up a back-end file server with two shared folders. One folder contains the shared content files for the website. The other folder contains the shared configuration files.

Once the shared content folder is ready, copy the files for the website you set up on the primary web server to the content folder.

### To set up your back-end file server

1. On the file server, open Windows Explorer.
2. Create a folder for the shared content, for example `C:\Content`.
3. Create a folder for the shared configuration, fox example `C:\Config`.
4. Share the content folder by using the custom user credentials.
5. Share the configuration folder by using the custom user credentials.
6. Copy the files from the working website on your primary web server to the content folder on the file server, for example `C:\Content\MySite`.

<a id="22"></a>
## 2.2. Configure Shared Content

In this procedure, you set up shared content of your primary web server. When finished, your web server retrieves content from the back-end file server.

### To configure shared content

1. On your primary, open IIS Manager, select you website, and click **Advanced Settings** in the **Actions** pane.
2. On the **Advancing Settings** page, change the value of **Physical Path** to the configuration UNC path, for example `\\FileServer\Content\MySite`.
3. Select **Physical Path Credentials**, and click the ellipsis (...) button.
4. In the **Connect As** dialog, select **Specific user**, and click **Set**.
5. Enter the credentials of the custom shared user account, and click **OK**.
6. Click **OK** two more times to exit **Advanced Settings**.
7. If your web farm supports ASP.NET, open command prompt, and enter one the following commands depending on your system:

    - 64-bit systems: `cd %windir%\Microsoft.NET\Framework64\v4.030319`
    - 32-bit systems: `cd %windir%\Microsoft.NET\Framework\v4.030319`
8. Enter the following command:

    `caspol -m -ag 1. -url file://<file server>/<content>/<website>/* FullTrust`

    Replace `<file server>` with the name of your file server. Replace `<content>` with the name of your shared content folder. Replace `<website>` with the folder name for your website. Note **FullTrust** is case-sensitive.
9. Close the command prompt, select **Application Pools** in the **Connections** page.
10. Select the application pool for your site, and click **Recycle** in the **Actions** pane.
11. Open a browser, view your site with **localhost**. The site is displayed as usual, but the content is coming from the back-end file server.

<a id="23"></a>
## 2.3. Set up Shared Configuration

To configure shared configuration, export the configuration files to the back-end file server. Then point the web server to the shared configuration location.

### To set up shared configuration

1. Open IIS Manager, select your server name, and double-click **Shared Configuration**.
2. In the **Actions** pane, click **Export Configuration**.
3. In the **Physical path** box, type the UNC path for the shared configuration folder on the file server, for example `\\FileServer\Config`.
4. Click **Connect As**.
5. Enter the credentials of the custom shared user account, and click **OK**.
6. Under **Encryption Keys**, type a password for encryption the configuration files, and confirm the password.
7. Click **OK**.
8. On the Shared Configuration page, select the **Enable shared configuration** check box.
9. In the **Physical path** box, type the UNC path to the configuration folder on the file server.
10. In the **User name** box, type the custom shared user name.
11. In the **Password** and **Confirm password** boxes, type the password for the custom share user account.
12. In the **Actions** pane, click **Apply**.
13. In the **Encryption Keys Password** dialog, type the encryption keys password and click **OK**.
14. Close IIS Manager, and reopen it. IIS is now using the configuration files that are located of the file server.

<a id="24"></a>
## 2.4. Add Web Servers to Your Farm

A web server added to your farm by using this procedure retrieves both configuration information and website content from the back-end file server.

### To add a web server to your farm

1. Open IIS Manager, select your server name, and double-click **Shared Configuration**.
2. On the Shared Configuration page, select the **Enable shared configuration** check box.
3. In the **Physical path** box, type the UNC path to the configuration folder on the file server.
4. In the **User name** box, type the custom shared user name.
5. In the **Password** and **Confirm password** boxes, type the password for the custom share user account.
6. In the **Actions** pane, click **Apply**.
7. In the **Encryption Keys Password** dialog, type the encryption keys password and click **OK**.
8. Close and reopen IIS Manager.
9. If your web farm supports ASP.NET, open command prompt, and enter one the following commands depending on your system:

    - 64-bit systems: `cd %windir%\Microsoft.NET\Framework64\v4.030319`
    - 32-bit systems: `cd %windir%\Microsoft.NET\Framework\v4.030319`
10. Enter the following command:

    `caspol -m -ag 1. -url file://<file server>/<content>/<website>/* FullTrust`

    Replace `<file server>` with the name of your file server. Replace `<content>` with the name of your shared content folder. Replace `<website>` with the folder name for your website. Note **FullTrust** is case-sensitive.
11. Close the command prompt, select **Application Pools** in the **Connections** page.
12. Select the application pool for your site, and click **Recycle** in the **Actions** pane.
13. Open a browser, view your site with **localhost**. The site displays like it did on the primary server.

## See Also

- [Step 3: Configure IIS Web Farm Load Balancing](configuring-step-3-configure-iis-web-farm-load-balancing.md)
- [Step 1: Install IIS Web Farm Infrastructure](configuring-step-1-install-iis-web-farm-infrastructure.md)
- [Step 2: Plan IIS Web Farm Configuration](planning-step-2-plan-iis-web-farm-configuration.md)
- [Configure a Web Farm with IIS Servers](configure-a-web-farm-with-iis-servers.md)
- [Build a Web Farm with IIS Servers](overview-build-a-web-farm-with-iis-servers.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)
