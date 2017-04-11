---
title: "Walkthrough: IIS 7.0 Output Caching | Microsoft Docs"
author: rick-anderson
description: "Web content can be divided into two categories: static content and dynamic content. Static content does not change from request to request. The content that..."
ms.author: iiscontent
manager: soshir
ms.date: 11/23/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/managing-performance-settings/walkthrough-iis-output-caching
msc.type: authoredcontent
---
Walkthrough: IIS 7.0 Output Caching
====================
by [Saad Ladki](https://twitter.com/saadladki)

## Introduction

Web content can be divided into two categories: static content and dynamic content. Static content does not change from request to request. The content that gets returned to the web browser is always the same. Examples of static content include HTML files, JPG or GIF files.

The other is dynamic content. This is the response that gets generated for dynamic content changes with every request. Examples include ASP.NET or PHP content.

There is a big range between these two categories which includes semi-dynamic content. Imagine a dynamic ASP.NET page that executes a database query. There is no reason to execute this query on every request if the underlying database tables change infrequently.

The IIS Output Caching feature targets semi-dynamic content. It allows you to cache static responses for dynamic requests and to gain tremendous scalability.

<a id="01"></a>

## Prerequisites

For this walkthrough, you need IIS 7.0 or above on Windows® Vista SP1 or on Windows Server® 2008 Beta 3 or later. This walkthrough also uses ASP.NET 2.0 which must be installed as an optional component in the IIS Setup.

<a id="02"></a>

## Walkthrough Overview

In the following walkthrough, we use the IIS extensibility interfaces to add language-specific copyright messages to JPG files.

First, we do this by adding a managed handler. Dynamically inserting a copyright message into every JPG file comes with a cost however, because now managed code must be executed for every JPG file.

Next, we install WCAT, an IIS performance analysis tool, to measure the throughput of our JPG copyright handler.

Then we add Output Caching to regain performance degradation incurred by adding our copyright handler.

<a id="03"></a>

## Part I – Writing and Configuring the Copyright Handler

1. Create a directory called 'pictures' under the %systemroot%\inetpub\wwwroot directory. Execute the following command in an elevated command shell:

[!code-console[Main](walkthrough-iis-output-caching/samples/sample1.cmd)]
2. Copy some digital pictures - this walkthrough assumes them to be JPG files - to the new pictures directory. Use the following picture if you don't have any JPG files handy: [http://wallpaper.iis7.org/gallery/iis7-highlight.jpg](http://wallpaper.iis7.org/gallery/iis7-highlight.jpg)

    > [!NOTE]
    > Due to the high Internet Explorer security settings on Windows Server 2008, you might get a security dialog box telling you that the web site is blocked. To download the IIS wallpaper, add wallpaper.iis7.org to the list of trusted sites.
3. Create an application with the appcmd command-line tool

[!code-console[Main](walkthrough-iis-output-caching/samples/sample2.cmd)]
4. Create the directory App\_Code underneath the pictures directory:  

    [!code-console[Main](walkthrough-iis-output-caching/samples/sample3.cmd)]
5. Open Notepad and paste the following code into it.

[!code-csharp[Main](walkthrough-iis-output-caching/samples/sample4.cs)]

    Save the file as %systemdrive%\inetpub\wwwroot\pictures\App\_Code\imageCopyrightHandler.cs
6. Create the handler that executes this code when a JPG file is requested:

[!code-console[Main](walkthrough-iis-output-caching/samples/sample5.cmd)]
7. We must also enable directory browsing because there is not yet a default document:

[!code-console[Main](walkthrough-iis-output-caching/samples/sample6.cmd)]
8. Browse to the pictures application by typing in the Internet Explorer address bar: [http://localhost/picures](http://localhost/picures). Click the link to your JPG file in the IIS directory listing. You should see the JPG image with the inserted Copyright message.
9. Look at the code. You see that the Copyright Message depends on the "Accept-Language" header that the browser sends. If you have a German version of Microsoft Server 2008 installed, you see the copyright message "IIS 7.0 Team - Alle Rechte vorbehalten"; if you have a Spanish language version, you see "Marca Registrada IIS 7.0 Team". In all other cases the copyright message will be "Copyright © IIS 7.0 Team". A way to test this code is to change the "Accept-Language" header Internet Explorer sends:

    - Open "Internet Explorer".
    - Open the "Tools" Menu and click "Internet Options".
    - Click the "Languages" button.
    - Click the "Add…" button and add "es" for Spanish or "de" for German.
    - Move the new language to the top of the list via the "Move Up" button.
    - Browse to [http://localhost/pictures/%3cyour\_jpg\_file%3e.jpg](http://localhost/pictures/%3cyour_jpg_file%3e.jpg). The Copyright message has changed to the language you configured.
    - Do not forget to go back into the "Languages" dialog box and reset-- otherwise you might wonder later why you get Spanish or German web pages.

<a id="04"></a>

## Part II - Performance Test of the imageCopyrightHandler

Once the JPG Copyright Handler works, we must determine how fast our code is. Install an IIS 6.0 Resource Kit Tool to run performance tests:

1. Download the [IIS 6.0 Resource Kit Tools](https://www.microsoft.com/downloads/details.aspx?FamilyID=56fc92ee-a71a-4c73-b628-ade629c89499&amp;DisplayLang=en) and install them. Do a custom install and install only the Web Capacity Analysis Tool (WCAT). WCAT is the only feature of the IIS 6.0 Resource Kit Tools we need to do our performance tests.

    > [!NOTE]
    > Due to the high Internet Explorer security settings on Windows Server 2008, you might get a security dialog box telling you that the web-site is blocked. To download the IIS 6.0 Resource Kit, add \*.microsoft.com to the list of trusted sites.
2. Create a directory called PERFTEST, for example:

[!code-console[Main](walkthrough-iis-output-caching/samples/sample7.cmd)]
3. The WCAT controller requires three input files:

    - A script file that tells WCAT which URLs to request. Each URL gets a unique ClassID
    - A distribution file that tells WCAT how the requests should be distributed across the URLs specified in the script file
    - A configuration file that configures the parameters of a particular performance run, e.g. the duration of the tests, how many HTTP clients to simulate, etc.

    **The Script File**

    Create a new file called script.cfg in the perftest directory and paste the following content into it:

    [!code-console[Main](walkthrough-iis-output-caching/samples/sample8.cmd)]

    > [!NOTE]
    > Replace the &lt;your image name&gt; entry with the names of your JPG files. If you have more JPG files, you can add a new transaction. Make sure you give each transaction a new ClassID.

    **The Distribution File**

    The distribution file tells WCAT how it should weigh requests. With the two URLs above, we do an even 50/50 distribution. Each ClassID gets requested 50% of the time.

    Create a file called *%systemdrive%\perftest\distribution.cfg* in the perftest directory and paste the following content into it:

    [!code-console[Main](walkthrough-iis-output-caching/samples/sample9.cmd)]

    **The Configuration File**

    Here are recommended parameters for the test:

    - Duration: 30 seconds
    - Warm-up: 5 seconds
    - Cooldown: 5 seconds
    - Simulated Http Clients: 20

    Create a file called config.cfg in the perftest directory and paste the following content into it:

    [!code-console[Main](walkthrough-iis-output-caching/samples/sample10.cmd)]
4. Start the controller by executing the following commands:

[!code-console[Main](walkthrough-iis-output-caching/samples/sample11.cmd)]

    As soon as all clients are connected, the perf test will start.
5. Because we only have one client, open another elevated command-shell and run the following:

[!code-console[Main](walkthrough-iis-output-caching/samples/sample12.cmd)]

    To do this with more clients, set NumClientMachines in config.cfg to a higher number, and connect clients to the controller via the wcclient command by specifying the name of the controller machine.   
  
Example: wcclient MyPerfTestControllerMachine

    > [!NOTE]
    > If you do this on a 64-Bit version of Windows, WCAT is installed in the "program files (x86)" directory and you must use %programfiles(x86)% to start WCAT.
6. Here are the results from the first run:

[!code-console[Main](walkthrough-iis-output-caching/samples/sample13.cmd)]

    The important number to look at is the requests per second. In this case, we get 14 requests per second.

    A word of caution - the bigger your JPG files, the fewer requests you will see. It is likely that your machine is network-bound: IIS will not be able to handle more requests because the network is saturated with the data you are sending. You see the best results with JPG files in the 200-300 KB range.

<a id="05"></a>

## Adding Output Caching

The code to dynamically insert the copyright message is fairly slow. Fourteen requests per second is not fast for a web server. IIS performs much better. All you must do is create a caching policy that puts URLs with the JPG extension into the kernel Mode cache. Here is how you add the cache policy:

### Adding a Cache Policy via the IIS Management Tool

1. Navigate to "Administrative Tools" and select "Internet Information Services (IIS) Manager".
2. Use the tree view on the left side to navigate to the "pictures" application.
3. Select the "Ouput Caching Rules" menu item.
4. Click "Add…" in the "Actions" menu.
5. Add JPG as the "File extension" to cache.
6. Select "At time intervals" in the "Monitor cached files" section and enter 00:00:10 as the time interval.
7. Check the "Headers" check-box and enter "Accept-Language".

> [!NOTE]
> The Output Cache User Interface is not available in versions before Windows Vista Service Pack 1.

### Adding a Cache Policy via Command-line

To do the same procedure with the appcmd tool, enter the following command:


[!code-console[Main](walkthrough-iis-output-caching/samples/sample14.cmd)]


Repeat the performance run to see what and how the configuration settings change.

1. Start the controller by executing the following commands:

[!code-console[Main](walkthrough-iis-output-caching/samples/sample15.cmd)]
2. Start the client with:

[!code-console[Main](walkthrough-iis-output-caching/samples/sample16.cmd)]

    > [!NOTE]
    > If you do this on a 64-Bit version of Windows, WCAT is installed in the "program files (x86)" directory and you must use %programfiles(x86)% to start WCAT.

### Sample Output


[!code-console[Main](walkthrough-iis-output-caching/samples/sample17.cmd)]

<a id="06"></a>

## Output Caching Advanced Topics

### Performance Counters

To ascertain the performance in the output cache, look at output cache counters in the "Reliability and Performance Monitor". There are many interesting counters. Here is one example of how to use the "Reliability and Performance Monitor" together with the output cache.

1. On Windows Server 2008, start PERFMON via the Start menu. Go to "Administrative Tools" and click "Reliability and Performance Monitor". On Vista, you find "Administrative Tools" in the Control Panel.
2. Select "Performance Monitor" in the tree view on the right and click the big "+" sign in the toolbar.
3. Navigate to the "Web Service Cache" counter and click it to open.
4. Add the "Total URIs Cached" counter.
5. Rerun the WCAT test.

You see that the number of cached URIs increases depending on how many items you request during the performance test.

### IIS Kernel Mode Caching Rules

The IIS output cache supports two cache policies. The regular output cache policy takes advantage of a cache that resides in an IIS worker process. The other cache policy is a kernel mode cache policy, in which case the cache resides in HTTP.SYS, a kernel-mode driver.

Caching your content in kernel-mode allows your web site to go faster. Modify the configuration of the pictures application to use the kernel-mode cache. Here is how the current configuration looks (%systemdrive%\inetpub\wwwroot\pictures\web.config):


[!code-xml[Main](walkthrough-iis-output-caching/samples/sample18.xml)]


Now change it to use kernel-mode caching:

1. Open %systemdrive%\inetpub\wwwroot\pictures\web.config.
2. Change the setting.


[!code-xml[Main](walkthrough-iis-output-caching/samples/sample19.xml)]


to the following:


[!code-xml[Main](walkthrough-iis-output-caching/samples/sample20.xml)]


You see that we do not use the varyByHeaders attribute anymore. This is because the kernelModeCache does not support some of the features that the user mode output cache supports.

### Limitations of the Kernel Mode Output Cache

There are two significant differences between user mode and kernel mode output cache.

- Kernel Mode Output cache does not support modules and features that must run in user mode, such as authentication or authorization. Example: If authentication schemes like Basic or Windows authentication are enabled, the cache policy will not work. The content is served but not cached. See "Troubleshoot Caching" on how to find out if the content gets cached. More details on why responses might not get cached in kernel-mode [is found in this Knowledge Base article](https://support.microsoft.com/kb/817445).
- The Kernel Mode Output Cache supports the varyByHeaders attribute but not varyByQuerystring.

### Troubleshoot Caching

Failed Request Event Buffering (FREB) is the best way to find out whether or not your request gets cached. FREB tells you why something does not get cached. Here is a sample of a FREB log. In this case, the HTTPSYS\_CACHEABLE event tells you that the request does not get cached because the kernel-mode cache is not enabled.

For more detailed information on how to work with FREB, see [this IIS.NET article](../../troubleshoot/using-failed-request-tracing/troubleshooting-failed-requests-using-tracing-in-iis.md).

Use the following command to find out which content is cached in kernel mode:


[!code-console[Main](walkthrough-iis-output-caching/samples/sample21.cmd)]


### Caching Intricacies

Even if you enable Output Caching, IIS does not immediately cache a request. It must be requested a few times before IIS considers a request to be "cache worthy". Cache worthiness can be configured via the ServerRuntime section described in this [MSDN article](https://msdn.microsoft.com/en-us/library/ms690574).

The two properties that determine cache-worthiness are frequentHitTimePeriod and frequentHitThreshold. A request is only cached if more than &lt;frequentHitThreshold&gt; requests for a cacheable URL arrive within the &lt;frequentHitTimePeriod&gt;.

The default setting for frequentHitTimePeriod is 10 seconds.

The default setting for frequentHitThreshold is 2.

### Caching Your Most Popular Pages

In the example above, we put all files with the extension JPG into the output cache. This does not always work because sometimes you want to be more selective and only put a particular document into the output cache. Here is how you do this with your most frequently requested page, your default document:

1. Create a file called default.aspx in the %systemdrive%\inetpub\wwwroot\pictures directory and add the following code:  

    [!code-aspx[Main](walkthrough-iis-output-caching/samples/sample22.aspx)]
2. Navigate to "Administrative Tools" and select "Internet Information Services (IIS) Manager".
3. Use the tree view on the left side to navigate to the "pictures" application.
4. Click "Content View" at the bottom of the page.
5. Select your default document, e.g. default.aspx page.
6. Click "Switch to feature view" in the "Actions" menu on the right. Every setting that you configure will now only be applied to the default document.
7. Open the "Output Caching Rules" setting.
8. Add ".aspx" as a file extension.
9. Select "kernel-mode caching" then we can select "At time intervals" and enable "Monitor cached files" and enter 00:00:30 as the time interval.
10. Browse to [http://localhost/pictures](http://localhost/pictures) with "Internet Explorer". By constantly refreshing the page (press Ctrl+F5 to make sure it does not come from the Browser cache), you see that the time will not change for 30 seconds.

<a id="07"></a>

## Summary

Using the IIS Output Cache feature for semi-dynamic content can improve your web site. You see a substantial improvement in performance and throughput capacity. A simple configuration change is enough to take advantage of this feature.

[Discuss in IIS Forums](https://forums.iis.net/1050.aspx)