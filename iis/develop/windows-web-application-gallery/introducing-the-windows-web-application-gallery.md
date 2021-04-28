---
title: "Introducing the Windows Web Application Gallery"
author: chrissfanos
description: "The Windows Web Application Gallery makes it easy to explore, discover and install popular community ASP.Net and PHP applications on Windows. Users can brows..."
ms.date: 03/18/2009
ms.assetid: a6fef702-77c2-4c2c-963b-c8c361c37fe0
msc.legacyurl: /learn/develop/windows-web-application-gallery/introducing-the-windows-web-application-gallery
msc.type: authoredcontent
---
# Introducing the Windows Web Application Gallery

by [Chris Sfanos](https://github.com/chrissfanos)

> [!NOTE]
> The Windows Web Application Gallery (WWAG) is being retired on July 1, 2021. We are no longer taking submissions via the Submission Portal. Please contact webpi@microsoft.com to make updates to your existing submission.

The [Windows Web Application Gallery](https://www.microsoft.com/web/gallery) makes it easy to explore, discover and install popular community ASP.Net and PHP applications on Windows. Users can browse and view applications for different types of Web sites, ranging from photo galleries to blogs to ecommerce sites.

The Web Application Gallery integrates with the [Web Platform Installer 3.0](https://www.microsoft.com/web/downloads/platform.aspx), so that when a user clicks "Install" for an application, the Web Platform Installer 3.0 launches with context set on the user's selection. This powerful combination of application discovery and simplified installation makes it easier than ever for community-based applications to run on Windows.

The Web Application Gallery also provides a way for developers to reach millions of Windows users. When an application is accepted by the Web Application Gallery, the application is added to the Web Application Gallery ATOM feed. The ATOM feed is consumed by the Web Application Gallery itself, Web Platform Installer 3.0, WebMatrix, IIS Manager, and participating Hosting Control Panels.

[![](introducing-the-windows-web-application-gallery/_static/image4.png)](introducing-the-windows-web-application-gallery/_static/image3.png)

## Application Discovery and Installation by Users

Users can browse the Web App Gallery by viewing by categories or groups like "Most Popular" or searching by keywords. Once the user clicks "Install", the Web App Gallery detects if the Microsoft Web Platform Installer is present on the computer. If not, the Web App Gallery redirects the user to install the Microsoft Web Platform Installer. When the Web Platform Installer is on the computer, the user can select "Install" and the Web Platform Installer will launch to install the selected application.

The Web Platform Installer knows about the dependencies for each application in the Web Application Gallery. As a result, when the user installs an application, the Web Platform Installer also includes any required dependencies, such as PHP.

Once the Web Platform Installer completes the installation of the application, the user can get started using or extending the application. Users can also rate applications after logging into the site.

## Application Submissions to the Web Application Gallery by Developers

The Windows Web Application Gallery provides a way for developers to more easily deploy applications to Windows users. The Web Application Gallery does not store code snapshots of applications. Instead, the App Gallery and Web PI retrieve the application package from the application developer's Web site. The application developer owns the originating distribution point, which Web Platform Installer uses to retrieve the package for deployment. The information displayed with the package, such the Publisher link, is all provided by the application developer during the application submission process. The Web Application Gallery will cache application screenshots and icon URLs to prevent inadvertent rerouting, but the application developer is free to provide new URLs at any time to the Microsoft Web Application for updates.

The App Gallery contains both ASP.NET and PHP applications that follow the [Web Application Gallery Principles](windows-web-application-gallery-principles.md) and use [Microsoft Web Deploy for application packaging](package-an-application-for-the-windows-web-application-gallery.md) to streamline deployment on Windows.

Developers follow four steps to submit an application to the Web Application Gallery.

[![](introducing-the-windows-web-application-gallery/_static/image7.png)](introducing-the-windows-web-application-gallery/_static/image6.png)

### Step 1: Apply Web App Gallery Principles

First, developers must review and apply the [Web Application Gallery Principles](windows-web-application-gallery-principles.md) to their applications. These Principles reflect the Web Application Gallery's goals to deliver a quality, safe user experience that is consistent across platforms supported by Windows Platform Installer. If developers have any questions about the Principles, the developer can ask questions or post comments to the [Web Application Gallery Developer forum](https://forums.iis.net/1158.aspx).

### Step 2: Tune Application Based on Best Practices and Principles

Next, developers can visit IIS.NET for best practices in running applications on IIS. For ASP.NET applications, developer can start with a snapshot of [ASP.NET Technical Resources](../../application-frameworks/building-and-running-aspnet-applications/aspnet-technical-resources.md) or check out the [Running ASP.NET Applications on IIS](../../application-frameworks/building-and-running-aspnet-applications/index.md) section. For PHP applications, developers can browse the [Running PHP Applications](../../application-frameworks/running-php-applications-on-iis/index.md) for articles on how to make PHP applications work well on Windows. Guidance for PHP developers includes [how to use web.config to set default document and static rewrite rules.](../../application-frameworks/install-and-configure-php-applications-on-iis/translate-htaccess-content-to-iis-webconfig.md) IIS.NET also hosts guidance for any application developer on Windows, such as [Securing Content on IIS Using File System ACLs](../../get-started/planning-for-security/secure-content-in-iis-through-file-system-acls.md). You can also post questions about running PHP applications on Windows or the Principles in the [Web App Gallery Developer forum](https://forums.iis.net/1158.aspx).

### Step 3: Package Using Web Deploy

After tuning the application package with best practices, the developer adds Web Deploy support to the application package. Microsoft Web Deploy provides the framework for deploying and migrating Web applications and Web servers locally and remotely on IIS. With Web Deploy, a developer adds a couple of manifest files to the root directory of an existing ZIP package that tell IIS how to deploy the application.

The manifest.XML file tells IIS what is in the package and allows the developer to set the name of the directory and Web site where the package is deployed. The parameters.xml file gives developers the ability to ask the user for information during the install process, such as Web site path. Learn more about how to define the Web Deploy manifest files in the [Application Packaging Guide](package-an-application-for-the-windows-web-application-gallery.md).

### Step 4: Submit Application to Web Application Gallery

Once the manifest files are added and tested in an application package, the Web developer is ready to submit the package to the Web Application Gallery. The Web Application Gallery Submission form in theWeb Application Gallery starts by collecting information about the application. See the [Submitting Links to the Web Application Gallery](windows-web-application-gallery-link-addition-process-walkthrough.md) walkthrough for a detailed description of how to submit an application. Each application is reviewed to make sure that the application follows the Web Application Gallery Principles. Microsoft may contact the application developer in the course of the review, and also to inform the application developer about the state of the submission.

### Web Application Gallery Developers

If an application developer is accepted into the Web Application Gallery, the lifecycle of the application continues at the developer's pace. With each package update, the application developer must contact the Microsoft Web Application Gallery to provide a new MD5 hash, which helps secure the distribution point.

Some users will visit the Web Application Gallery user forum or Web Platform Installer forums where the Web Application Gallery team member will help diagnose the point of failure as Web PI, Web Deploy, the application package, or the application itself. If the failure occurs in the application package Web Deploy integration, the Web Application Gallery team will inform the application developer about the issue with the application package.

Otherwise, for general application questions and issues, the Web Application Gallery team redirects the user to the application's free support forums. The application developer is also encouraged to use IIS.NET as a technical resource to answer any questions in forums that might stem from Web Application Gallery or Web Platform Installer, starting with the [Troubleshooting Web Platform Installer 3.0](../../troubleshoot/web-platform-installer-issues/troubleshooting-problems-with-microsoft-web-platform-installer.md) article and [Known Issues with Web Application Gallery](windows-web-application-gallery-known-issues.md).

Since the Web Platform Installer points to the application download URL, the application developer can collect download statistics on the app download server (which is owned by the application developer) by checking for the Web App Gallery user agent.
