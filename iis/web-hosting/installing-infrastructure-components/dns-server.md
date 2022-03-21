---
title: "DNS Server"
author: walterov
description: "You must have a working Dynamic Name Services (DNS) server on the network to run Windows Deployment Services. Administrators may choose to dedicate an entire..."
ms.date: 01/22/2008
ms.assetid: a0831f7f-21b0-4bbf-b29f-ec8c70b204d5
msc.legacyurl: /learn/web-hosting/installing-infrastructure-components/dns-server
msc.type: authoredcontent
---
# DNS Server

by [Walter Oliver](https://github.com/walterov)

## Prerequisites

You must have a working Dynamic Name Services (DNS) server on the network to run Windows Deployment Services. Administrators may choose to dedicate an entire server to one role or to install multiple server roles on a single computer. For simplicity, the Dynamic Host Configuration Protocol (DHCP) and Domain Name System (DNS) roles can be installed together on one server.

## Installation Information

Domain Name System (DNS) is the name resolution protocol for TCP/IP networks, such as the Internet. A DNS server hosts the information that enables client computers to resolve memorable, alphanumeric DNS names to the IP addresses that computers use to communicate with each other. Here is a summary:

### To install a DNS server

1. Open Server Manager. To open Server Manager, click **Start**, and then click **Server Manager**.
2. Under **Roles Summary**, click **Add Roles**.

   ![Screenshot that shows Server Manager, with Add Roles highlighted.](dns-server/_static/image1.png)

3. On **Before You Begin**, click **Next**.

   ![Screenshot that shows the Add Roles Wizard dialog box. Before You Begin tab is selected.](dns-server/_static/image3.png)

4. On **Confirm Installation Selections**, click **Install**.

   ![Screenshot that shows the Add Roles Wizard dialog box. Confirmation tab is selected and D N S Server and the Install button are highlighted.](dns-server/_static/image5.png)

5. On **DNS Server**, click **Next**.

   ![Screenshot that shows the Add Roles Wizard dialog box. D N S Server tab is selected.](dns-server/_static/image7.png)

6. On **Installation Results**, click **Close**.

   ![Screenshot that shows the Add Roles Wizard dialog box. Results tab is selected.](dns-server/_static/image9.png)
