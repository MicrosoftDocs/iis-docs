---
title: "Windows Web Application Gallery Link Addition Process Walkthrough"
author: rick-anderson
description: "This walkthrough will guide you through the process of submitting an application to the Windows Web Application Gallery. Overview of the submission process T..."
ms.date: 03/18/2009
ms.assetid: 218769b5-1bdf-49a2-97dc-a8e6c64bd724
msc.legacyurl: /learn/develop/windows-web-application-gallery/windows-web-application-gallery-link-addition-process-walkthrough
msc.type: authoredcontent
---
# Windows Web Application Gallery Link Addition Process Walkthrough

by IIS Team

> [!NOTE]
> The Windows Web Application Gallery (WWAG) is being retired on July 1, 2021. We are no longer taking submissions via the Submission Portal. Please contact webpi@microsoft.com to make updates to your existing submission.

This walkthrough will guide you through the process of submitting an application to the Windows Web Application Gallery.

## Overview of the submission process

The steps from developing an application to seeing it live in the Web Application Gallery are shown below. This document concentrates on the step in Green, which can be exploded out into the process below it:

[![](windows-web-application-gallery-link-addition-process-walkthrough/_static/image8.jpg)](windows-web-application-gallery-link-addition-process-walkthrough/_static/image7.jpg)

## Starting the Submission Process

The Windows Web Application Gallery submission process begins on the [Web Application Gallery](https://www.microsoft.com/web/gallery/developer.aspx). This page contains links to all of the information you will need to understand and participate in the Windows Web Application Gallery.

The following items are available on this landing page.

- Application Packaging Guide. This document contains the overview of creating a package for the Gallery.
- Application Submission Agreement. This is the agreement you will need to accept as part of the submission process.
- Application Gallery Policies. These are the guiding policies for the Application Gallery

## Submitting your application

To submit your application, you will need to fill out the [submission form](https://www.microsoft.com/web/gallery/submit.aspx). This form is broken down into three sections, all of which must be completed. Each section is described below, with each field explained.

- Application Information

    - App Name - This is the name that you want the application listed with.
    - **Description** - The description can be up to 200 words. This is the description that is shown to the user when the user is looking at a page or screen dedicated to your application in either the Gallery or the WebPI.
    - **Brief Description** - The Brief Description can be up to 40 words in length. This description will show up whenever your application is listed with other applications in the Gallery, and in the Web Platform Installer.
    - **App ID** - An indentifier for your application. Use only letters and digits, no spaces or punctuation. This ID is used as the page name for your application in the application Gallery.
    - Version - The version must be detailed enough to uniquely identify this release / build compared to future releases
    - Submitting Entity - The Publisher is the entity that owns the rights for the application being submitted. It can be a company, an individual, a community, etc...
    - Submitting Entity URL - Website for the application Publisher.
    - App Web Site URL - Website for the Application. This may be the same as the Publisher URL.
    - Support URL - The URL for whatever Support mechanism you provide. i.e. forums, help desk system, wiki, etc...
    - Release Date - This is the date that the application at this version was released to the public. It may be different from the date that the application is available in the Gallery.
    - Primary Category - This is the category in which your application will be displayed on microsoft.com/web/gallery.
    - Secondary Category - This is the secondary category which may also be used by microsoft.com/web/gallery.
    - Professional Services URL - Website where you may offer professional services to your application customers.
    - Commercial Products URL - Website where you may offer other commercial products.
    - Images - use this section of the form to specify product screen shots.
    - Package Information - This portion of the form contains two tabs for specifying the details for your installation package. One tab for a 32-bit version, and a second for a 64-bit version, if needed.

        - Package Location URL - This specifies the location that the WebPI will use to download your application onto users' systems. If this changes for any reason, please return and update this form, or your application won't be usable.
        - Application Start Page URL - This is any path or file name that you want the user to execute the first time the user visits his installation of your application. For example, if your application requires a setup routine to run after the WebPI is finished, you might put "/setup/index.php" here. Then, when the user installs the application via the WebPI, the link that the user sees to visit their installation will include this path.
        - SHA-1 - The WebPI uses a SHA-1 hash to confirm that the version downloaded onto a user's computer is the same file that you want it to be. If the installation package changes at all, the hash will need to be updated so that the application can contnue to be installed correctly.
        - File Size (in bytes) - the size of your application package.
        - Language - This is a dropdown list for the primary language that the application supports. If the application supports multiple langagues, please select the one that is the default here.
    - Dependencies - The Dependencies section gives you the opportunity to specify software and environmental prerequisites for your application. When the application is installed via the Web Platform Installer, the WebPI will ensure that the environment has these Dependencies. The WebPI will set up all of the specified dependencies so the application can function properly. The IIS components required to support the language will automatically be determined and installed by the WebPI. The IIS Components list allows you to select IIS extensions that your application depends on which go beyond the requirements for the framework. For example, if you specify PHP 5.2, the WebPI knows to install and configure FastCGI. However, if your application requires the URL Rewriter, you will need to select it in the Web Server Extensions column.  
  
  There are three lists for specifying dependencies:

    - Framework - Specify one framework from the list of ASP.NET and PHP versions. This should be the version that your application depends on to function.
    - Database - Select all of the databases that your application supports.
    - IIS Components Select each of the IIS and other components that your application depends on to function. An example component is the IIS URL Rewriter.
- Terms and Conditions - You must agree to the [Terms and Conditions](https://www.microsoft.com/web/insertproperlink) of the Web Application Gallery before you can submit your application.

When you have completed the form, submit the form. This data will be used to populate the Application Gallery with metadata for your application. At the application level of the Gallery, this data will be displayed as in the image below:

[![](windows-web-application-gallery-link-addition-process-walkthrough/_static/image10.jpg)](windows-web-application-gallery-link-addition-process-walkthrough/_static/image9.jpg)

## Testing

After the application submission form has been sent, Microsoft will review the contents of the form and the application. Our process will be to:

1. Download the application package zip.
2. Scan for Viruses and other materials that violate the Agreement
3. Ensure the application meets the [Web Application Gallery Principles](windows-web-application-gallery-principles.md).
4. Run some basic tests to make sure the application will install.

We will be in contact with you throughout the process to keep you informed during the verification process.

## Production

When all of the testing is complete, we will push the metadata into the production version of the Web Application Gallery. At this point your application will be live, and available to all of the users that discover Web applications through the Gallery, and all of the programs that make use of its Atom feed.

## What comes next?

When the application is in production, there may be required updates, or new versions. For any new submissions (including application updates), you can edit the details of your submission using the [MyApps page](https://www.microsoft.com/web/gallery/myapps.aspx). If you have any questions about the process, please check out our Web Application Gallery: Developers &amp; Integrators [forum](https://forums.iis.net/1158.aspx "Web APplication Gallery: Developers &amp; Integrators").
