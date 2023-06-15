---
title: "Configuring Step 3: Configure IIS Web Farm Load Balancing"
author: rmcmurray
description: "Now that IIS is installed all web servers. All web servers share both contend and configuration. And IIS and ARR are installed on your load balancing server...."
ms.date: 04/14/2013
ms.assetid: 36ca05ca-3041-4421-956e-00a8e92e0ff2
msc.legacyurl: /learn/web-hosting/scenario-build-a-web-farm-with-iis-servers/configuring-step-3-configure-iis-web-farm-load-balancing
msc.type: authoredcontent
---
# Configuring Step 3: Configure IIS Web Farm Load Balancing

by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

Now that IIS is installed on all web servers. All web servers share both content and configuration. And IIS and ARR are installed on your load balancing server. It is time to configure ARR and turn your servers into a functioning web farm.

When you are done with these tasks, record your design decisions before going on to [Step 4: Configure SSL Central Certificate Store](configuring-step-4-configure-ssl-central-certificate-store.md).

<a id="31"></a>
## 3.1. Create a Server Farm with ARR

To create your server farm, you must enter the IP address of every web server in your farm.

### To create a server farm with ARR

1. Open IIS Manager.
2. In the **Connections** pane, expand the server node, and select **Server Farms**.
3. In the **Actions** pane, click **Create Server Farm**. The **Create Server Farm** wizard opens to the **Specify Server Farm Name** page.
4. In the **Server farm name** box, type a name for your server farm, and click **Next**. The **Add Server** page is displayed.
5. In the **Server address** box, type the IP address of the first server, and click **Add**.
6. Continue typing IP addresses and clicking **Add** until all web servers are entered.
7. Click **Finish**.

<a id="32"></a>
## 3.2. Configure Load Balancing with ARR

This procedure configures ARR load balancing with an algorithm that distributes incoming request evenly among the web servers. It then sets up the server-farm health test feature.

### To configure load balancing with ARR

1. Open IIS Manager.
2. In the Connections pane, expend the server
3. Under the server node, expand **Server Farms**, and then select the server farm that you created.
4. In the **Server Farm** pane, double-click **Load Balance**.
5. On the **Load Balance** page, select **Weighted round robin** from the **Load balance algorithm** list, and then click **Apply**.
6. In the **Connections** pane, select the server farm that you created.
7. In the **Server Farm** pane, double-click **Health Test**.
8. On the **Health Test** page, in the **URL** box, enter a URL that you want ARR to test by sending a GET request to determine the health of the servers. Click **Apply**.
9. To verify the health of your farm, click **Verify URL Test**.

<a id="33"></a>
## 3.3. Change Application Pool Settings

Because all HTTP requests and responses go through ARR, delays or errors occur if the application pool times out or recycles unexpectedly. Set the idle time-out and application pool recycle settings to zero to avoid problems.

### To change application pool settings

1. On one of the web servers in your farm, open IIS Manager.
2. In the **Connections** pane, select **Application Pools**.
3. In the **Application Pools** pane, select the application pool for you website, and then click **Advanced Settings** in the **Actions** pane.
4. In the **Advanced Settings** dialog box, expand **Process Model**, and change the **Idle Time-out (minutes)** value to 0.
5. Expand **Recycling**, and change the **Regular time intervals (in minutes)** value to 0.
6. Click **OK**.

## See Also

- [Step 4: Configure SSL Central Certificate Store](configuring-step-4-configure-ssl-central-certificate-store.md)
- [Step 2: Configure IIS Web Farm Servers](configuring-step-2-configure-iis-web-farm-servers.md)
- [Step 3: Plan IIS Web Farm Load Balancing](planning-step-3-plan-iis-web-farm-load-balancing.md)
- [Configure a Web Farm with IIS Servers](configure-a-web-farm-with-iis-servers.md)
- [Build a Web Farm with IIS Servers](overview-build-a-web-farm-with-iis-servers.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)
