---
title: "Configuring One-to-One Client Certificate Mappings | Microsoft Docs"
author: rlucero
description: "IIS 6 had a User Interface to configure and map one to one certificates for authentication. It allowed users to select the validation client certificate and..."
ms.author: iiscontent
manager: soshir
ms.date: 06/05/2008
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/configuring-security/configuring-one-to-one-client-certificate-mappings
msc.type: authoredcontent
---
Configuring One-to-One Client Certificate Mappings
====================
by [Robert Lucero](https://github.com/rlucero)

## Background

IIS 6 had a User Interface to configure and map one to one certificates for authentication. It allowed users to select the validation client certificate and assign the authorized user credentials. There isn't a similar UI in IIS 7 and above. This walkthrough is designed to instruct users to configure one to one client certificates using Administration Pack's Configuration Editor. Users who do not have this add-on can view the appendix section for AppCmd arguments and C# code examples to perform this walkthrough.

## IIS 7 and Above Schema

This is the schema for the IIS Client Certificate Mapping Authentication Feature in IIS 7 and above.

[!code-xml[Main](configuring-one-to-one-client-certificate-mappings/samples/sample1.xml)]

## Prerequisites

These are the prerequisites needed for this walkthrough. I won't be covering how to create or do these things.

1. Installed IIS Client Certificate Mapping module
2. A Web Site with an HTTPS binding, properly configured
3. A Base-64 certificate (.cer file). [*Note:* This can be any valid 64-bit certificate, but it must be in file form]
4. Installed a client certificate on a client
5. Installation of [IIS 7 Administration Pack Technical Preview 2](https://blogs.iis.net/rlucero/archive/2008/05/13/iis7-administration-pack-and-database-manager-technical-preview-2.aspx)

## Step 1: Getting the Certificate Blob

The oneToOneMappings collection item has an attribute called certificate. The required value for this attribute is not the certificate has but the actual certificate blob. Here's how you extract it.

1. Right click on your .cer file.
2. Select *Open With...* in the context menu
3. Select Notepad from the list of Other Programs and click OK. [*Note: Notepad may be hidden beneath a drop down in the Vista/Windows 2008 list view]*
4. This is what should be displayed in notepad:

    [!code-unknown[Main](configuring-one-to-one-client-certificate-mappings/samples/sample-127014-2.unknown)]
5. Remove -----BEGIN CERTIFICATE----- and -----END CERTIFICATE----
6. Format the certificate blob to be a single line.
7. Save this file as clientCertBlob.txt

## Step 2: Enabling IIS Client Certificates Mapping Authentication and One to One Certificate Mapping For A Web Site

The next steps will cover how to enable the Client Certificate Mapping Authentication feature, One to One Certificate Mapping and added a mapping entry.

1. Start **Inetmgr**, the IIS Manager UI
2. Select the SSL web site that is being configured and open **Configuration Editor**
3. Type "**system.webServer/security/authentication/iisClientCertificateMappingAuthentication**" in the **Section** drop down box.
4. Select the **enabled** field and change the value to **true**
5. Select the **oneToOneCertificateMappingsEnabled** property grid entry and change the value to **true**
6. Select the **oneToOneMappings** property grid entry and click **Edit Items...** in the Actions Task Pane
7. Click **Add** in the **Collection Editor** task list
8. Copy the single string certificate blob from above and paste it into the **certificate** field
9. Set the **userName** and **password** that clients will be authenticated as.
10. Set the **enabled** field to **true**
11. Close **Collection Editor**
12. Click **Apply** in the Actions Task Pane [*Note:* Click **Script Generation** prior to clicking **Apply** to get scripts for this process]

Once this is complete the server will be configured to handle IIS Client Certificate Mapping authentication with a single one to one certificate mapping entry.

## Step 3: Enabling Client Certificate Authentication For A Web Site Using SSL

Once a mapping has been created and the feature has been enabled, a site must be configured to use client certificates.

1. From within **Inetmgr,** the IIS Manager UI, select the SSL web site you want to use client certificates
2. Select the **SSL** UI module
3. Under **Client certificates:** selectthe **Accept** radio button
4. Click **Apply** in the Actions Task Pane

Now the web site is configured to accept and authenticate clients based on client certificates.

## Step 4: Verifying It All Works

The client that is trying to access the SSL web page needs the client certificate properly installed. If a client attempts to request a page without the certificate a 401 will be served. Once the client certificate is correctly installed, the page will be served as normal.

Play around with different combinations of authorization rules to suit your needs.

## Summary

You have now configured IIS Client Certificate Mappings and a single One to One Certificate mapping.

## Appendix

These are the Code Snippets to perform walkthrough steps 2 and 3. All of this was generated using Configuration Editor's Script Generation.

**AppCmd specific instructions**

[!code-console[Main](configuring-one-to-one-client-certificate-mappings/samples/sample3.cmd)]

**C# Code:** 

[!code-csharp[Main](configuring-one-to-one-client-certificate-mappings/samples/sample4.cs)]
  
  
[Discuss in IIS Forums](https://forums.iis.net/1043.aspx)