---
title: "Shared Hosting Using Application Request Routing (ARR)"
author: rick-anderson
description: "Using Application Request Routing (ARR) in a shared hosting environment introduces a new deployment architecture that provides additional benefits and opport..."
ms.date: 07/02/2008
ms.assetid: 430a0892-9b7f-4391-9b10-0b6d71c32381
msc.legacyurl: /learn/extensions/configuring-application-request-routing-arr/shared-hosting-using-application-request-routing-arr
msc.type: authoredcontent
---
# Shared Hosting Using Application Request Routing (ARR)

Using Application Request Routing (ARR) in a shared hosting environment introduces a new deployment architecture that provides additional benefits and opportunities for shared hosters. This scenario is enabled by a feature called host name affinity in Application Request Routing. For more information about the host name affinity feature and how it relates to shared hosting, refer to [Shared hosting deployment using Application Request Routing](../planning-for-arr/overview-of-shared-hosting-deployment-using-application-request-routing-20.md).

This topic leads you through the steps to configure the host name affinity feature in Application Request Routing, as illustrated below:

![](shared-hosting-using-application-request-routing-arr/_static/image1.jpg)

## Goal

To configure Application Request Routing in a shared hosting environment.

## Prerequisites

This walkthrough requires the following prerequisites:

- IIS 7.0 or above on Windows 2008 (any SKU) or newer.
- Microsoft Application Request Routing Version 1 and dependent modules.
- Minimum of two application servers with working sites and applications.

  - The servers should be configured to use shared configuration and shared content. For more information about shared configuration, see the [Shared Configuration](../../manage/managing-your-configuration-settings/shared-configuration_264.md) article.
  - The sites on the servers should be using host name binding.

If the Application Request Routing RC has not been installed, download it at:

- Download Microsoft Application Request Routing Version 1 for IIS 7 (x86) [here](https://iis.net/downloads/default.aspx?tabid=34&amp;g=6&amp;i=1709).
- Download Microsoft Application Request Routing Version 1 for IIS 7 (x64) [here](https://iis.net/downloads/default.aspx?tabid=34&amp;g=6&amp;i=1712).

Follow the steps outlined in [this](../installing-application-request-routing-arr/install-application-request-routing.md) document to install Application Request Routing.

As another prerequisite, you must define and configure a server farm by following the steps outlined in [**Define and Configure an Application Request Routing (ARR) Server Group**](define-and-configure-an-application-request-routing-server-farm.md).

## Step 1 – Enable host name affinity

Before proceeding, ensure that the server farm was created with the application servers that are configured with shared configuration and shared content. The sites on the application servers should also be using host name binding.

### To enable host name affinity using the UI

1. Launch IIS Manager.

2. Select the server farm that has been created for this walkthrough.

3. The following icons are shown:

   ![](shared-hosting-using-application-request-routing-arr/_static/image3.jpg)

4. Double-click **Server Affinity**.

5. To enable host name affinity, select **Use host name**, and then click **Apply**.

   ![](shared-hosting-using-application-request-routing-arr/_static/image5.jpg)

   Note that there are two providers for determining which server(s) the host name should be affinitized to. This is different from the load balance algorithm and the provider is only used for the host name affinity feature. The two providers are:

   - Microsoft.Web.Arr.HostNameRoundRobin
   - Microsoft.Web.Arr.HostNameMemory

   Microsoft.Web.Arr.HostNameRoundRobin tries to evenly distribute the number of affinitized host name in round robin. Using this provider has no requirements on the application servers.

   Microsoft.Web.Arr.HostNameMemory tries to distribute the number of affinitized host names based on the amount of available memory on the application servers where the server with the most amount of available memory would be assigned with the next host name. This provider uses WMI to query the available memory (defined as committed memory / physical memory). Therefore, the application servers must be Windows servers and additional configurations must be made on the application servers to allow remote WMI queries. Refer to [How to configure WMI service on application servers for HostNameMemory affinity provider](how-to-configure-wmi-service-on-application-servers-for-hostnamememory-affinity-provider.md) for more details.

   The time-out value is used to determine how long after the last request with the same host name the affinitization should be reset. This value should be set to the same value as the idle time-out value for the application pools on the application servers. By default, this value is 20 minutes.

6. To verify this functionality, click **Display Routing Table**.

   ![](shared-hosting-using-application-request-routing-arr/_static/image7.jpg)

7. Type the name of the host, and then click **Lookup by host name**. The server address shown is the location to where the host name is affinitized.

### To enable host name affinity using the command-line

1. Open a command prompt with administrator privileges.

2. Navigate to `%windir%\system32\inetsrv`.

3. To enable host name affinity, enter (the below example uses **myServerFarm** as the name of the server farm):

   [!code-console[Main](shared-hosting-using-application-request-routing-arr/samples/sample1.cmd)]

## Step 2 - Specify the number of servers to use per host name

By default, all host names can use one application server. However, if the site owners want additional capacity, the hoster can specify the number of application servers that sites can use per host name.

### To specify the number of servers to use using the UI

1. On the **Server Affinity** page, click **Advanced Settings**.

   ![](shared-hosting-using-application-request-routing-arr/_static/image9.jpg)

2. In the **Host Name** column, type the host name. This field is required.

3. In the **Number of Allocated Servers** column, type the number of servers that this host name can use.

4. **Alternate Host Names** is an optional field that can be used to specify additional host names that should be treated the same way as the values in the **Host Name** column. For example, a site owner may have multiple DNS entries for the same site. In this case, he would want ARR to treat the multiple DNS entries the same way so that only one worker process starts on the application server for both domain names.

5. To save changes, click **OK**.

6. To verify this functionality, click **Display Routing Table**.

   ![](shared-hosting-using-application-request-routing-arr/_static/image11.jpg)

7. Type the name of the host, and then click **Lookup by host name**. The number of server addresses returned will be the same as what you specified for the **Number of Allocated Servers**. These are the servers to which the host name can be affinitized.

### To specify the number of servers to use using the command-line

1. Open a command prompt with administrator privileges.

2. Navigate to `%windir%\system32\inetsrv`.

3. To specify the number of servers per host name, enter (the following example uses **myServerFarm** as the name of the server farm, and sets the number of servers to 2 for the `www.contoso.com` host name):

   [!code-console[Main](shared-hosting-using-application-request-routing-arr/samples/sample2.cmd)]

## Summary

You have now successfully configured the host name affinity feature in Application Request Routing for a shared hosting scenario. For additional Application Request Routing properties and capabilities, refer to other Application Request Routing [walkthroughs](../planning-for-arr/using-the-application-request-routing-module.md).
