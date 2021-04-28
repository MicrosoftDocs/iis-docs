---
title: "TTesting a Zip Package for Inclusion with the Web Application Gallery"
author: rick-anderson
description: "The Web Application Gallery makes it easy for Windows users to find and deploy a free open source, community application onto a computer running Windows XP o..."
ms.date: 12/14/2009
ms.assetid: 6f721a96-8210-4e2a-a110-09103f8f0b98
msc.legacyurl: /learn/develop/windows-web-application-gallery/testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery
msc.type: authoredcontent
---
# Testing a Zip Package for Inclusion with the Web Application Gallery

by [Mai-lan Tomsen Bukovec](https://twitter.com/mailant)

> [!NOTE]
> The Windows Web Application Gallery (WWAG) is being retired on July 1, 2021. We are no longer taking submissions via the Submission Portal. Please contact webpi@microsoft.com to make updates to your existing submission.

The [Web Application Gallery](https://www.microsoft.com/web/gallery) makes it easy for Windows users to find and deploy a free open source, community application onto a computer running Windows XP or later. To learn more about how to build Web Deploy support for a zip package so that the application can be included in the Web Application Gallery, read the [Package An Application for the Web Application Gallery](package-an-application-for-the-windows-web-application-gallery.md) guide or view the [Adding Web Deployment Tool Support to Community Application ZIP Packages videocast](https://blogs.iis.net/mailant/archive/2009/05/04/real-world-iis-adding-web-deployment-tool.aspx). Once you have build Web Application Gallery integration for your zip package, you can test the Web Application Integration using [Web Platform Installer](https://www.microsoft.com/web/downloads/platform.aspx).

Both the Web Application Gallery and the Web Platform Installer consume the same application and product feeds. The Web Platform Installer also orchestrates every deployment from the Web Application Gallery. As a result, you can test the deployment experience from the Web Application Gallery by using the Web Platform Installer and local feeds modified to contain the location of the application package that you want to test. Once you get done with the application testing, you can submit your application link to the Web Application Gallery team on the [Web Application Gallery developers site](https://www.microsoft.com/web/gallery/developers.aspx).

You can take two different approaches to test your application package in your computer:

1. Modify a local copy of the live xml feeds. You may want to use this approach if: 

    - You have already published your application in the Web Application Gallery, and
    - You only need to modify a few fields in the feed xml (installer url, version, and sha-1 hash), and
    - You want to test a new updated package of your application following the end-to-end user experience that your users will see when using the Web Platform Installer.
2. Create a custom feed. You may want to use this approach if:

    - You want to build and maintain your own custom feed file.
    - You want to avoid making changes to the feeds that will drive all of the Web Platform Installation.

Details for each of the two approaches follow.

## Test by modifying a local copy of the live XML feeds

To test your application package locally by modifying a copy of the live XML feed files, follow these steps:

#### Step 1. Download the Web Platform Installer

The Web Platform Installer orchestrates the installation of applications from the Web Application Gallery, and is the tool you use to validate local feeds with your modified zip package. You can down the Web Platform Installer from: [https://www.iis.net/extensions/webpi](https://www.microsoft.com/web/downloads/platform.aspx).If you already have Web Platform Installer installed, please make sure it is the latest version of Web Platform Installer.

#### Step 2. Download Web Application Gallery feeds locally.

Download the two WebPI feeds to your computer:

- WebProductList.xml: [https://www.microsoft.com/web/webpi/4.2/WebProductList.xml](https://www.microsoft.com/web/webpi/4.2/WebProductList.xml). This XML feed contains the products and application dependencies for Web Platform Installer.
- WebApplicationList.xml: [https://www.microsoft.com/web/webpi/4.2/WebApplicationList.xml](https://www.microsoft.com/web/webpi/4.2/WebApplicationList.xml). This XML feed contains the information for all applications in the Web App Gallery.

#### Step 3. Make Sure the Local XML Feeds Can Talk to Each Other

In the WebProductList.xml feed, look for the reference to WebApplicationList.xml. Change the location to point the location that you installed WebApplicationList.xml on your local computer.

##### Example:

[!code-html[Main](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/samples/sample1.html)]

Save the change.

#### Step 4. Modify the Local WebApplicationList.XML Feed to Point to the New Application Package

Next, you'll have to modify the WebApplicationList.xml to point to your new zip package xml file for testing. You will be eidting the XML entry for an application that would be similar to yours or, if your package is already included in the Web Application Gallery, the XML entry for your existing application.

When you find &quot;&lt;productId&gt;SimilarApp&lt;/productId&gt;&quot;, you will see a child &lt;entry type=&quot;application&quot;&gt; element. Within this element,look for the &lt;installerURL&gt; element.

##### Example

[!code-xml[Main](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/samples/sample2.xml)]

Change the location within that element to point to your local application zip package.

##### Example

[!code-xml[Main](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/samples/sample3.xml)]

You will also need to find the &lt;sha1&gt; element and change it to the new hash value or remove it. If you forget this step, your application testing will fail based on mismatched hash values.   
 Save the changes.

#### Step 5. Set Up the Test Environment with Dependencies

When a user installs an application from the Web Application Gallery, the Web Platform Installer will check the user's machine for application dependencies. If the user's machine is missing an application dependency, such as FastCGI for PHP applications, Web Platform Installer will take care of installing those dependencies. However, the Web Platform Installer test feed configuration does not support application dependency installations; the test feed configuration assumes all dependencies are present.

As a result, when you are testing your application install in a clean machine, you will have to install application dependencies yourself. There are two ways to simplify the installation of application dependencies in your test feed environment:

1. You can use the Web Platform Installer to install Internet Information Services (IIS), FastCGI 1.0, Web Deployment Tool 1.0, and other dependencies for your application like SQL Express.
2. You can install a similar application from Web Platform Installer or Web Application Gallery. For example, if you are testing a PHP application and want to set up a clean machine with the right dependencies, you can install another PHP application from the Web Application Gallery. That installation process will automatically install and configure the right dependencies on your computer for PHP application testing.

Once you have the test environment configured, you are ready to run Web Platform Installer against your local modified feed.

#### Step 6. Run Web Platform Installer Against Local Feed

Follow these steps so that Web Platform Installer will point to the local feed when it loads:

- Click on Start -&gt; Run
- Type 'regedit' and Click OK
- Under HKEY\_LOCAL\_MACHINE\Software\Microsoft\Webplatforminstaller, add a string key &quot;ProductXmlLocation&quot; and let it point to the local copy of Webproductlist.xml
- Close any instances of Web Platform Installer
- Launch Web Platform Installer
- Click on 'Options' to select IIS or IIS Express (Web Matrix) and Click OK
- Look for the application you are testing and Click on Add
- Click on Install

  Web Platform Installer will now install the test application package onto IIS or Web Matrix. 

## Test by creating a custom feed

To test your application package locally by modifying a copy of the live XML feed files, follow these steps (for more details see: [https://blogs.iis.net/kateroh/archive/2009/10/24/web-pi-extensibility-custom-feeds-installing-custom-products.aspx](https://blogs.iis.net/kateroh/archive/2009/10/24/web-pi-extensibility-custom-feeds-installing-custom-products.aspx)):

#### Step 1. Create a new custom feed XML file

Use the example below to create the custom feed XML file. This example illustrates:

- How to add applications with ASP.NET/SQL and PHP/MySql dependencies,
- Create a new tab and subtabs based on keywords,
- Group products together and hint Web PI that your product is available in different languages.

Notice that you have to define a new custom tab for your custom products, since they cannot to be added to Web PI core tabs.

[!code-html[Main](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/samples/sample4.html)]

You can delete the &lt;entry type=&quot;application&quot;&gt; element that do not correspond to the type of application you are interested in. Also, if you have already published your application in the Application gallery, you could copy your application's &lt;entry type=&quot;application&quot;&gt; from the live feed: [https://www.microsoft.com/web/webpi/4.2/WebApplicationList.xml](https://www.microsoft.com/web/webpi/4.2/WebApplicationList.xml).

Notice how applications are grouped based on keywords: xml element &lt;keywords&gt;.

#### Step 2. Enter the Installer URL for your zip package

In the custom feed file, locate the &lt;installerURL&gt; element and provide the path for your zip package, if it in located in the local file system use &quot;file://&quot; instead of &quot;http://&quot;

##### Example

[!code-xml[Main](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/samples/sample5.xml)]

#### Step 3. Enter the new SHA-1 hash

In the custom feed file, locate &lt;sha1&gt; and substitute the value for the corresponding has for your zip package. You can get a hash of your zip package, by using a free utility called [File Checksum Integrity Verifier (FCIV)](https://support.microsoft.com/kb/841290) and running fciv.exe -sha &lt;path to your zip package&gt; from the command prompt.

#### Step 4. Test your custom feed file

Now, you can try the custom feed file by saving it locally or storing it in a web server, and opening the Options dialog and adding a feed through either a physical path or URL.

[![](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/_static/image2.png)](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/_static/image1.png)

[![](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/_static/image4.png)](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/_static/image3.png)

You should be able to click in the new tab and see your application in it.

[![](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/_static/image6.png)](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/_static/image5.png)

[![](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/_static/image8.png)](testing-a-web-application-zip-package-for-inclusion-with-the-web-application-gallery/_static/image7.png)

From here you can select your application and proceed with the installation.
