---
title: "Provision an IIS Web Site in a Hosting Environment"
author: simtan
description: "When provisioning a site, most hosters have some sort of control panel that allows them to capture the information required for provisioning. This informatio..."
ms.date: 03/10/2011
ms.assetid: e74b2c7d-d37c-44df-9121-4bd9adb2a27d
msc.legacyurl: /learn/publish/deploying-application-packages/provision-an-iis-web-site-in-a-hosting-environment
msc.type: authoredcontent
---
Provision an IIS Web Site in a Hosting Environment
====================
by [Simon Tan](https://github.com/simtan)

When provisioning a site, most hosters have some sort of control panel that allows them to capture the information required for provisioning. This information can then be passed to simple scripts to create the user, configure it for hosting, create a database, and import the application package.

Here are the basic steps for provisioning a site:

1. Gather information from user.

    - What package do they want?
    - What is the FQDN?
    - What are the database requirements?
    - What is the user name for the site?
    - What is the site password?
    - What is database user name?
    - What is the database password?
2. Create a DNS entry for the site that points to the server IP address.
3. Create SQL database(s) (MSSQL or MySQL) for the application (if required).
4. Create database user(s) and apply permissions.
5. Create the IIS site and application pool.

For more detailed information on how to provision an IIS Web site in a hosting environment, refer to [Configuring Remote Administration and Feature Delegation in IIS](../../manage/remote-administration/configuring-remote-administration-and-feature-delegation-in-iis-7.md).
