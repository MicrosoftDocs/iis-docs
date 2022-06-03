---
title: "Provisioning a Server Farm with the Web Farm Framework 2.0 for IIS 7"
author: rick-anderson
description: "You can use the Web Farm Framework 2.0 for IIS 7 and above to perform both platform and application provisioning on the servers in your server farm. You can..."
ms.date: 07/21/2010
ms.assetid: 2959f52b-9c8a-4ea9-9933-ba27283078ca
msc.legacyurl: /learn/web-hosting/microsoft-web-farm-framework-20-for-iis-7/provisioning-a-server-farm-with-the-web-farm-framework-20-for-iis
msc.type: authoredcontent
---
# Provisioning a Server Farm with the Web Farm Framework 2.0 for IIS 7

by Randall DuBois

You can use the Web Farm Framework 2.0 for IIS 7 and above to perform both platform and application provisioning on the servers in your server farm. You can also install applications and components by selecting them from a list of products offered by the Microsoft Web Platform Installer.

<a id="Platform"></a>

## Platform Provisioning

Platform provisioning is the process of synchronizing a secondary server with the web platform components and additional modules installed on the primary server. You can select the applications to provision, as well as the interval between synchronization cycles.

You can install any web platform components that are available in the Web Platform Installer. For more information, see [Microsoft Web Platform Installer](https://go.microsoft.com/?linkid=9739157 "Microsoft Web Platform Installer").

### To configure platform provisioning

1. Start **IIS Manager**, and then in the **Connections** pane, select the name of the server farm you want to configure settings for.
2. On the **Server Farm** page, double-click **Platform Provisioning**.

   ![Screenshot of the Server Farm page within I I S Manager. The Platform Provisioning icon is circled.](provisioning-a-server-farm-with-the-web-farm-framework-20-for-iis/_static/image4.png)

   > [!NOTE]
   > The icons for provisioning are not displayed when **Content View** is selected. If you do not see the icons, click the **Features View** tab at the bottom of the **Content** pane.

3. On the **Platform Provisioning** page, expand the **Additional Products** section.
4. To add a product to be synchronized, click twice in the **Product Name** field and then select the product you want to add. When you select a product, a new row is added.  
  
    ![Screenshot of the Platform Provision Page with the Product Name field expanded.](provisioning-a-server-farm-with-the-web-farm-framework-20-for-iis/_static/image8.png)

   The selected products will be provisioned to the secondary servers in the farm in addition to the platform components and additional applications installed on the primary server in the server farm.

5. Add the products you want, and then in the **Actions** pane, click **Apply**. You can remove products or change the order in which they are listed using the buttons to the right of the products.

## Application Provisioning

Application provisioning is similar to platform provisioning, but instead of synchronizing platform components and applications, you can specify additional Web Deploy providers to be synchronized to the servers in the farm. Application provisioning uses Microsoft Web Deploy technology. For more information see [Web Deploy](https://www.iis.net/downloads/microsoft/web-deploy).

### To configure application provisioning

1. Start **IIS Manager**, and then in the **Connections** pane, select the name of the server farm you want to configure settings for.
2. On the **Server Farm** pane, double-click **Application Provisioning**.  
  
    ![Screenshot of the Server Farm page within I I S Manager. The Application Provisioning icon is circled.](provisioning-a-server-farm-with-the-web-farm-framework-20-for-iis/_static/image12.png)
  
    > [!NOTE]
    > The icons for provisioning are not displayed when **Content View** is selected. If you do not see the icons, click the **Features View** tab at the bottom of the **Content** pane.

3. In the **Application Provisioning** pane, expand the **Additional Providers** section.  
  
    ![Screenshot of the Application Provisioning pane with the Provider field drop down menu expanded.](provisioning-a-server-farm-with-the-web-farm-framework-20-for-iis/_static/image16.png)
4. To add a provider to be synchronized, click twice in the **Provider** field and then select the provider you want to add.  
   When you select a provider, a new row is added.
5. Enter a path in which to install the provider on the secondary servers. This must be a file system path, such as `C:\inetpub\`. The field cannot be empty.
6. In the **Settings** field, specify the provider settings that you want to use for the selected provider. Click the field and use the browse **(…)** button to open the **Provider Settings** dialog box. For more information, see [Web Deploy Provider Settings](/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/dd569001(v=ws.10)).
7. Add the providers you want, and then in the **Actions** pane click **Apply**.

## Installing Applications on Servers

You can also install web platform products on a selected server or all servers in the farm using the **Install Products** dialog box. When you open this dialog box for a specific server, it displays web platform products offered in the Web Platform Installer whether or not they are already installed on that server. You can select the products and components you want to install, and they will be installed by the Web Farm Framework using Web Platform Installer.

### To install products using the Install Products dialog

1. Open **IIS Manager**, expand the nodes in the **Connections** pane to display your server farm, and then do one of the following: 

    - If you want to install products on all the servers in your server farm, select your server farm in the **Connections** pane, and then in the **Actions** pane click **Install Products**.  
  
       ![Screenshot of the I I S Manager Window on the Server Farm page. Install Products option is circled in the Actions menu.](provisioning-a-server-farm-with-the-web-farm-framework-20-for-iis/_static/image18.png)
    - If you want to install products on a specific server, expand the server farms node and then select the **Servers** node. In the **Servers** pane select the server you want, and then in the **Actions** pane click **Install Products**.
2. In the **Install Products** dialog box, select the products you want to install, and then click **OK**.  
  
    ![Screenshot of the Install Products dialog box.](provisioning-a-server-farm-with-the-web-farm-framework-20-for-iis/_static/image20.png)

You can view the installation status using the trace messages displayed on the **Servers** page.

![Screenshot of the Servers page displaying the installation status trace messages.](provisioning-a-server-farm-with-the-web-farm-framework-20-for-iis/_static/image22.png)
