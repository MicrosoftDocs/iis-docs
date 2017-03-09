---
title: "Windows Web App Gallery FAQ | Microsoft Docs"
author: SunBuild
description: ""
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/18/2012
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/develop/windows-web-application-gallery/frequently-asked-questions
msc.type: authoredcontent
---
Windows Web App Gallery FAQ
====================
by [Sunitha Muthukrishna](https://github.com/SunBuild)

## Frequently Asked Questions

Here is a list of frequently asked questions designed to provide a better understanding of the Windows Web App Gallery Submission and validation processes.

**Q. How do I submit my Web Application to Windows Web Application Gallery?**   
 A. You can submit your application at the following URL:

- *Windows Web App Gallery for Developers*  
    [http://webgallery.microsoft.com](http://webgallery.microsoft.com/)

**Q. Is my web application qualified to be part of Windows Web Application Gallery?**  
 A. Your web application must satisfy the following principles in order to be a part of Web Application Gallery. If you have more questions, please contact [appgal@microsoft.com](mailto:appgal@microsoft.com).

**Q. How long does it take for the Web Application Gallery Team to validate the application?**  
 A. Once the application is submitted, it will take 3-5 business days for us to validate the application and send you the status. You can review our process at the following URL:

- *Windows Web Application Gallery Link Addition Process Walkthrough*  
    [https://www.iis.net/learn/develop/windows-web-application-gallery/windows-web-application-gallery-link-addition-process-walkthrough](windows-web-application-gallery-link-addition-process-walkthrough.md)

**Q. How do I build a package for Web Application Gallery?**  
 A. Please refer to these articles to build a package for Web Application Gallery:

- *Packaging Guidelines*  
    [https://www.iis.net/learn/develop/windows-web-application-gallery/package-an-application-for-the-windows-web-application-gallery](package-an-application-for-the-windows-web-application-gallery.md)
- *Reference for Web Application Gallery*  
    [https://www.iis.net/learn/develop/windows-web-application-gallery/reference-for-the-web-application-package](reference-for-the-web-application-package.md)

**Q. How can I verify my web application package?**  
 A. You can verify your application package with Sniffer Installer Reporter (SIR) for Application Gallery; you can find instructions for downloading and using the SIR tool at the following URL:

- *Sniffer.Installer.Reporter (SIR) for Application Gallery*  
    [https://blogs.iis.net/kateroh/archive/2010/01/25/sniffer-installer-reporter-sir-for-application-gallery.aspx](https://blogs.iis.net/kateroh/archive/2010/01/25/sniffer-installer-reporter-sir-for-application-gallery.aspx)

Please report any issues to [appgal@microsoft.com](mailto:appgal@microsoft.com).

**Q. How do I submit an application to Azure App Gallery?**  
 A. If you are already a part of Windows Web Application Gallery, then please contact [appgal@microsoft.com](mailto:appgal@microsoft.com) for more information on Azure App Gallery. If you are not part of the Windows Web Application Gallery, we request you to submit your application to Windows Web Application Gallery for review. Please do send an email to [appgal@microsoft.com](mailto:appgal@microsoft.com) notifying us about your interest in the Azure App Gallery. We shall respond within 3-5 business days.

**Q. How do I test my application for Windows App Gallery?**  
 A. To test your article, please refer the following article:

- *Testing a Web Application Zip Package for Inclusion with the Web Application Gallery*  
    [https://www.iis.net/learn/develop/windows-web-application-gallery/testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery.md)

You can use also the [Web PI command line tool](https://blogs.iis.net/satishl/archive/2011/01/26/webpi-command-line.aspx) to test the application. We recommend that you test your application with Web PI and WebMatrix for the following :

1. The application must install successfully onto IIS
2. The application must install successfully onto WebMatrix (IIS Express)
3. If you application has a database , you should be able to view the database in WebMatrix
4. Publish your application to a remote site using WebMatrix
5. Download your application to the local site created on WebMatrix

**Q. How do I build a custom feed for Web Platform Installer?**  
 A. First, please make sure you are using the latest version of Web PI. You can find a sample custom feed as a part of the following article:

- *Testing a Web Application Zip Package for Inclusion with the Web Application Gallery*  
    [https://www.iis.net/learn/develop/windows-web-application-gallery/testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery.md)

You can update the custom feed sample for your applications, and make sure that the following changes have been made so that you application is shown in Web PI:

- Update &lt;productId&gt; ( This must be unique)
- Update &lt;Title&gt;
- Update &lt;Version&gt;
- Update the &lt;installerURL&gt;
- Update &lt;SHA1&gt; hash
- Update &lt;fileSize&gt;
- If your application requires uses SQL or MySQL or both, add the appropriate Keywords in &lt;keywords&gt;:

    - &lt;keywordId&gt;SQL&lt;keywordId&gt;
    - &lt;keywordId&gt;MySQL&gt;keywordId&gt;

If you are still seeing issues with the custom feed from loading in Web PI or are facing any other issues please email us at [appgal@microsoft.com](mailto:appgal@microsoft.com).

**Q. My Application is already in the Windows Web App Gallery, how do I submit an update for my application?**  
 If your application version is the same then update the existing submission with the following as listed below and submit it to Web App Gallery through the [submission form](https://www.microsoft.com/web/gallery/submit.aspx):

- Include any metadata changes such as Description, Brief Description, etc., if needed
- Update the package URL
- Update the SHA1 hash

If you application version is different than the one that is live, you should create a new submission for the Application and submit it to Web App Gallery through the submission form. Please note the process from submission to live can take 3-5 business days.