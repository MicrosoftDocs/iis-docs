---
title: "Shared Configuration and Remote Provisioning"
author: walterov
description: "When using the IIS 7 Shared Configuration featured in an environment where site provisioning tasks are driven from a remote machine, you can encounter what i..."
ms.date: 12/13/2007
ms.assetid: 4408306d-79cf-4666-87fe-a6bef6d05b68
msc.legacyurl: /learn/manage/provisioning-and-managing-iis/shared-configuration-and-remote-provisioning
msc.type: authoredcontent
ms.custom: sfi-image-nochange
---
# Shared Configuration and Remote Provisioning

by [Walter Oliver](https://github.com/walterov)

When using the IIS 7 Shared Configuration featured in an environment where site provisioning tasks are driven from a remote machine, you can encounter what is know as the "double-hop authentication issue". This issue will prevent you from executing provisioning tasks. This article describes the problem and provides workarounds for it.

## Problem Description

The provisioning topology illustrated in the following diagram could be one common option for leveraging the new shared configuration feature available in IIS 7, which the configuration is centralized on a network share, and a centralized provisioning server will perform provisioning operations in multiple web server farms. We assume all web server farms are running Windows Server® 2008 R2 with IIS 7.

[![Diagram that shows links between Provisioning Server, Web Server Farms, and Network Share Shared Configuration. File Share connects Network Share Shared Configuration to the Web Server Farms.](shared-configuration-and-remote-provisioning/_static/image3.jpg)](shared-configuration-and-remote-provisioning/_static/image1.jpg)  
Typical Provisioning Topology

Shared Configuration can be enabled easily via IIS Manager as shown in the following screen shot.

[![Screenshot that shows the I I S Manager. The Shared Configuration pane is open.](shared-configuration-and-remote-provisioning/_static/image7.jpg)](shared-configuration-and-remote-provisioning/_static/image5.jpg)  
 A set of new managed APIs has been provided in IIS 7 in the Microsoft.Web.Administration namespace. The APIs contain a method OpenRemote, which enable remote administrations across the network as illustrated in the following diagram.

[![Diagram that shows links between Provisioning Server, Web Server Farms, and Network Share Shared Configuration. Provisioning Calls connects Provisioning Server to the Web Server Farms.](shared-configuration-and-remote-provisioning/_static/image11.jpg)](shared-configuration-and-remote-provisioning/_static/image9.jpg)

The following code snippet demonstrates the use of OpenRemote to provision an application on a different web server.

[![Screenshot that shows the code snippet demonstrating the use of Open Remote.](shared-configuration-and-remote-provisioning/_static/image15.jpg)](shared-configuration-and-remote-provisioning/_static/image13.jpg)

When shared configuration is enabled for the remote web server, you get the following error when execute the sample code:

[![Screenshot that shows Command Prompt. Remote is entered in the command line, and the operation failed due to insufficient permissions.](shared-configuration-and-remote-provisioning/_static/image18.jpg)](shared-configuration-and-remote-provisioning/_static/image17.jpg)

The issue does not exist if the remote web server is using local configuration instead of shared configuration.

Disable the shared configuration:

[![Screenshot that shows the Shared Configuration pane. Enable shared configuration checkbox is cleared.](shared-configuration-and-remote-provisioning/_static/image20.jpg)](shared-configuration-and-remote-provisioning/_static/image19.jpg)

Re-run the sample application:

[![Screenshot that shows Command Prompt. Remote is entered in the command line, and the operation succeeded.](shared-configuration-and-remote-provisioning/_static/image22.jpg)](shared-configuration-and-remote-provisioning/_static/image21.jpg)

The modification is successfully committed.

[![Screenshot that shows the Default Web Site Home pane. Test is circled under the Default Web Site node in the Connections pane.](shared-configuration-and-remote-provisioning/_static/image24.jpg)](shared-configuration-and-remote-provisioning/_static/image23.jpg)

This is a double-hop authentication issue caused by shared configuration across multiple servers. The OpenRemote call is simply remotely invoking the COM object via DCOM. If the configuration is not configured locally, the COM object will try to do the double hop which is not allowed when using COM. Keep in mind that this only occurs in write operation to the shared configuration.

When read operation is performed, the underline configuration system is using the credential stored in the redirection.config file to authenticate on the remote network share server, which will not have this double-hop issue. With write operations, the underline configuration is using the caller security token to conduct the operations which the security token is invalid on the remote network share server.

## Workarounds

### Option 1: Modify the DCOM Configuration for Configuration COM Object Using a Specified Account

To work around the double-hop issue with configuration COM object, we need to change the DCOM configuration to use a specified account instead of caller's security context to enable the configuration COM object authenticating at the remote network share server with specified credential.  
You can locate the IIS 7 configuration COM object – ahadmin under DCOM Config by using Component Services on the remote web server as illustrated in the following diagram:

[![Screenshot that shows the a h admin Properties dialog box. The launching user radio is selected.](shared-configuration-and-remote-provisioning/_static/image26.jpg)](shared-configuration-and-remote-provisioning/_static/image25.jpg)

Right-click the ahadmin node, and select properties…, select the Identity tab, change the option to This User instead of The launching user, and specify a user account with the following permissions:

1. Have change permissions on the shared configuration files on the network share server.
2. Have read permission to redirection.config file stored under system32\inetsrv\config
3. Member of local administrators group, otherwise you will have can't decrypt exception.

[![Screenshot that shows the a h admin Properties dialog box. The This user radio is selected with entries for User, Password, and Confirm Password.](shared-configuration-and-remote-provisioning/_static/image28.jpg)](shared-configuration-and-remote-provisioning/_static/image27.jpg)

Click **OK**.

After the change, re-run the sample application, it works successfully.

[![Screenshot that shows Command Prompt. Remote is entered in the command line, and the remote admin operation succeeded.](shared-configuration-and-remote-provisioning/_static/image30.jpg)](shared-configuration-and-remote-provisioning/_static/image29.jpg)

The Test application is provisioned correctly.

[![Screenshot that shows the test Home pane. Test is selected and circled in the Connections pane.](shared-configuration-and-remote-provisioning/_static/image32.jpg)](shared-configuration-and-remote-provisioning/_static/image31.jpg)

Using a specified account for the configuration COM object might expose additional security risks (i.e. any users could modify the configuration as long as they have permission to invoke the COM object). To reduce the security risks, only configure one web server in the web server farm using this option for provisioning, and configure firewall to only allow certain IP to access the server.

#### \*\*Security Warning\*\*

**This approach can potentially allow a non-administrator to make administrative level changes on the server, since the component will not be running under the security context of the caller**.

### Option 2: Using a Hosting Services Sample Approach

An alternative option is not using OpenRemote via DCOM call and instead creating a service like the [Hosting Services Code Sample](index.md), which is a set of web services built on top of WCF (Windows Communication Foundation), on one of the web server in the web farm as illustrated in the following diagram:  
[![Diagram that shows links between Provisioning Server, Web Server Farms, and Network Share Shared Configuration. Web Service connects Provisioning Server to the Web Server Farms.](shared-configuration-and-remote-provisioning/_static/image34.jpg)](shared-configuration-and-remote-provisioning/_static/image33.jpg)  
You can use Windows Service to hosting the services if you have concerns hosting in IIS 7. The web service is built on top of Microsoft.Web.Administration APIs and provides better integration option, and furthermore there is no needs to open the firewall as OpenRemote required.

#### Security Consideration

The service should be secured to only allow authorized and authenticated users to call into the service.

### Option 3: Using WMI

Another option to avoid the double-hop issue is to use WMI service as illustrated in the following diagram.  
   
WMI service has the option for you to specify the credential to connect to remote web server, the WMI service on the remote server will impersonate the identity while performing the provisioning option as shown in the following code snippet. To enable the operations working with shared configuration, you must specify the impersonate option while connecting to WMI on the remote server. WMI also requires certain ports open in the firewall for remote invocation.  
[![Diagram that shows links between Provisioning Server, Web Server Farms, and Network Share Shared Configuration. W M I connects Provisioning Server to the Web Server Farms.](shared-configuration-and-remote-provisioning/_static/image36.jpg)](shared-configuration-and-remote-provisioning/_static/image35.jpg)
