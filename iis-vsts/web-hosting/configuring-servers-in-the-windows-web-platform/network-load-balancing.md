---
title: "Network Load Balancing"
author: walterov
description: "Network load balancing (NLB) in Windows Server ® 2008 provides traffic distribution using TCP/IP and can be used with the IIS shared configuration feature to..."
ms.date: 12/02/2007
ms.assetid: 3cf969b2-260d-4e54-91e7-e78b3453942d
msc.legacyurl: /learn/web-hosting/configuring-servers-in-the-windows-web-platform/network-load-balancing
msc.type: authoredcontent
---
Network Load Balancing
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

Network load balancing (NLB) in Windows Server® 2008 provides traffic distribution using TCP/IP and can be used with the IIS shared configuration feature to create a Web farm that provides redundancy and fault-tolerance. NLB works by balancing traffic between the nodes in a Web farm or cluster. Servers emit a  heartbeat message to other hosts in the cluster and listen for the heartbeat of other hosts. If a host fails, the remaining hosts adjust and redistribute the workload.

NLB does not monitor the health of your application. Instead, it allows the application developer to determine how healthy a load-balanced application is. Since each application has its own notion of load and health, measuring and monitoring these quantities is best achieved by the application itself. By using collected measurements from your application and the NLB public WMI provider, it is a relatively simple task to add load and health monitoring to your load-balanced application.

> [!NOTE]
> It is recommended that the servers have two networks. One is for the public cluster IP address that is shared by every host or node in the cluster. This will likely be used as the IP for Web sites on the server. The second one is for private traffic between the nodes of a Web farm. For example, if the server is using an internal network for traffic to internal resources like the file server or Active Directory servers, this could be used for traffic between the nodes.

## Installing and Configuring

**To install NLB**

1. Navigate to **Administrative Tools** and click **Server Manager**.
2. Scroll down to the **Features** section or click the **Features** node in the left-hand tree view.
3. Click **Add Features**.
4. In the **Add Features Wizard**, select **Network Load Balancing** from the list of available optional components.
5. Click **Next**, and **Install**, as applicable to complete the wizard.

**To configure NLB**

1. Navigate to **Administrative Tools** and click **Network Load Balancing Manager**, or run nlbmgr from a command prompt.
2. Right-click **Network Load Balancing Clusters** and click **New Cluster**.
3. Connect to the host that will be part of the cluster, in this case the Web server. In the **Host** text box, type the name of the host, and then click **Connect**.
4. Select the interface you want to use with the cluster, and then click **Next**.
5. On the **Host Parameters** page, select a value from the **Priority (unique host identifier)** drop-down list.
6. In the **Dedicated IP Addresses** area, click **Add** to type the IP address that is shared by every host in the cluster. NLB will add this IP address to the TCP/IP stack on the selected interface of all hosts chosen to be part of the cluster. Click **Next** to continue.
7. On the **Cluster IP Addresses** page, click **Add**.
8. In the **Add IP Address** dialog box, type the IP address and subnet mask, and then click **OK**.
9. Click **Next**.
10. On the **Cluster Parameters** page, in the **Cluster operation mode** area, click **Unicast** to specify that a unicast media access control (MAC) address should be used for cluster operations. Click **Next** to continue.
11. On the **Port Rules** page, click **Edit** to modify the default port rules if you need advanced rules. Otherwise, use the default.
12. Click **Finish** to create the cluster.  
  
 To add more hosts to the cluster, right-click the new cluster, and then click **Add Host to Cluster**.