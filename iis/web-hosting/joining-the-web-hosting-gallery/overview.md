---
title: "Overview | Microsoft Docs"
author: rick-anderson
description: "This set of documentation describes how hosting providers can prepare to join the Microsoft Web Hosting Gallery —a comprehensive marketplace of hosting provi..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/04/2010
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/joining-the-web-hosting-gallery/overview
msc.type: authoredcontent
---
Overview
====================
by Simon Tan

## Overview

This set of documentation describes how hosting providers can prepare to join the [Microsoft Web Hosting Gallery](https://www.microsoft.com/web/hosting/ "Microsoft Web Hosting Gallery")—a comprehensive marketplace of hosting providers—while standing out as 100% [**WebMatrix**](https://www.microsoft.com/web/webmatrix/ "Microsoft WebMatrix")**compatible** for maximum visibility. This is also known as having **Spotlight status**.

Being WebMatrix compatible means that you can make a guarantee to your end users: that they can publish applications from [WebMatrix](https://www.microsoft.com/web/webmatrix/ "Microsoft WebMatrix") and the [Web Application Gallery](https://www.microsoft.com/web/gallery/ "Microsoft Web Application Gallery") to your servers with confidence.

**What is covered:** This documentation outlines how to extend an existing Windows/IIS7 shared hosting environment so users can publish to it using the WebMatrix web development tool.

**What is not covered:** This document does not describe how to create a Windows hosting environment "from scratch".

It assumes that you have a hosting environment that runs on IIS7, offers ASP.NET hosting, and that you have experience with managing such environments. Please see [this article](../planning-the-web-hosting-architecture/shared-hosting-configuration.md "Basics of setting up shared hosting") to learn more about the basics of setting up a Windows shared hosting environment if you do not have one already.

This documentation will walk you through the following setup steps:

1. [Installing the required server components](install-server-components.md "Install server components")
2. [Configuring the server to allow remote publishing of websites by end-users](configure-site-for-web-deploy-publishing.md "Configuring Web Deploy settings")
3. [Validating your server configuration using a small tool](validate-your-server-configuration.md "Validating your server configuration using ServerValidator")
4. [Crafting a publishing Profile XML file containing server credentials for your end users](generate-a-profile-xml-file.md "Creating a publishing Profile XML file")
5. [Composing new account welcome e-mails that make it easy for your customers to get started with WebMatrix](create-welcome-e-mails.md "Creating welcome e-mails for new accounts")

After completing the above steps, you will then need to formally [submit an application](https://www.microsoft.com/web/hosting/hostingprovider/addoffers) to the Web Hosting Gallery. To be considered for Spotlight status, this application will need to include a sample test account (in the form of a Profile XML file) that represents a typical account from your WebMatrix compatible offer.

## How your customers will publish to you

[![](overview/_static/image2.jpg)](overview/_static/image1.jpg)

1. Customer finds your offer in the [Web Hosting Gallery](https://www.microsoft.com/web/hosting/ "Microsoft Web Hosting Gallery"), and signs up for an account
2. You provision required resources (including a SQL Server and/or MySQL database) for the customer

    - IIS site provisions: 

        - Creates a IIS Management username and password
        - Applies deployment and management permission to the IIS Site
    - SQL Database provisions: 

        - Creates SQL account and password
        - Applies permissions to the database for the SQL account
3. You send the customer their server credentials in the form of a [Profile XML](generate-a-profile-xml-file.md "Generating a Profile XML file")
4. Customer uses WebMatrix or other tools to deploy their web applications to your servers.

## Next Steps

First, you need to make sure you have the [necessary server components](install-server-components.md "Install required server components") to fully support WebMatrix and fulfill the Spotlight requirements of the Web Hosting Gallery.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1157.aspx)