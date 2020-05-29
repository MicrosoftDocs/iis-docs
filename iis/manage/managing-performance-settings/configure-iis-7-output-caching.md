---
title: "Configure IIS 7 Output Caching"
author: rick-anderson
description: "Internet Information Services (IIS) includes an output cache feature that can cache dynamic PHP content (or output from your Microsoft ® ASP.NET or classic A..."
ms.date: 11/15/2009
ms.assetid: 0ce77d45-ca2c-4071-9385-fcdfcf958712
msc.legacyurl: /learn/manage/managing-performance-settings/configure-iis-7-output-caching
msc.type: authoredcontent
---
# Configure IIS 7 Output Caching

by Tali Smith

Internet Information Services (IIS) includes an output cache feature that can cache dynamic PHP content (or output from your Microsoft® ASP.NET or classic ASP, or other dynamic pages) in memory. This can yield enormous performance improvements, since the script used to generate the dynamic output does not need to run for each request. The cache can vary the output that is cached based on query string values as well as HTTP headers sent from the client to the server. The cache is also integrated with the Http.sys kernel-mode driver, improving performance.

## When to Use Output Caching

Web content can be divided into two main categories: static content and dynamic content.

- Static content does not change from request to request. The content that gets returned to the Web browser is always the same. Examples of static content include HTML, JPG, or GIF files.
- Dynamic content is output that changes with every request. Examples include ASP.NET or PHP content.

Between these two categories is semi-dynamic content. Imagine a dynamic ASP.NET page that executes a database query. There is no reason to execute this query on every request if the underlying database tables change infrequently.

IIS automatically caches static content (such as HTML pages, images, and style sheets), since these types of content do not change from request to request. IIS also detects changes to the files when you make updates, and IIS flushes the cache as needed.

The IIS output caching feature targets semi-dynamic content. It lets you cache static responses for dynamic requests and increase scalability.

Note that not every dynamic page can take advantage of the output cache. Pages that are highly personalized (such as shopping cart or e-commerce transactions) are not good candidates because the dynamic output is not likely to be requested repeatedly, and the memory used to cache the content would be wasted. Content that is output as a result of a POST type request to an HTML form is also not cacheable.

The best candidates for the output cache are pages which generate data dynamically but are not likely to change from request to request based on the URL or the header information. For example, photo gallery–type applications that dynamically resize images for display in a Web page are great candidates for the output cache because caching the data saves the server from having to re-process the image resizing for each request. Another good example of a type of application that can take advantage of the output cache feature is a stock ticker application.

## Select a Cache Policies

IIS supports two types of cache policies:

- varyByQuerystring, in which the URL is the same but the query string value varies.
- varybyHeaders, which can vary the cache based on the HTTP headers that are sent from the client to the server.

## Invalidate the Cache

With dynamic content, data can change frequently and you must flush the cache, letting new data be retrieved and re-cached. Note that even if the data changes as frequently as every second, it may still be useful to cache the data; a site may get hundreds of requests per second or more, and caching can reduce trips to the database to retrieve data, saving the Web server and the database server from extra work.

IIS supports two ways to invalidate dynamic content:

- Use a simple timeout period - the configuration property is CacheForTimePeriod. 
- Detect a change to the underlying resource - the configuration property is CacheUntilChange. Use this type of invalidation scheme only when you want the cache flushed when the underlying resource changes.

## Configure Cache Worthiness

Even if you enable output caching, IIS does not immediately cache a request. It must be requested a few times before IIS considers a request to be "cache worthy." Cache worthiness can be configured via the ServerRuntime section described in the [ServerRuntimeSection Class](https://docs.microsoft.com/IIS/wmi-provider/serverruntimesection-class) article.

Two properties determine cache worthiness:

- frequentHitTimePeriod
- frequentHitThreshold

A request is only cached if more than `<frequentHitThreshold>` requests for a cacheable URL arrive within the `<frequentHitTimePeriod>`. The default setting for `frequentHitTimePeriod` is 10 seconds. The default setting for `frequentHitThreshold` is 2 hits.

## Configure Output Caching Through the IIS Manager

The cache is fairly easy to configure using the user interface feature in the new IIS administration tool.

1. From the **Start** menu, click **Administrative Tools**, and then click **Internet Information Services (IIS) Manager**.
2. In the tree view on the left side, find your application.
3. Select the **Output Caching** menu item.
4. In the right column, click **Add** in the **Action** menu. You can add your output caching rule here.
5. In the **File name extension** field, for example, type **.php**, and then select **User-mode caching**.
6. Click **Advanced**, and then select the **Query string variable(s)** check box.
7. Enter the appropriate variable(s) in the **Query string variable(s)** text box.

    [![](configure-iis-7-output-caching/_static/image2.jpg)](configure-iis-7-output-caching/_static/image1.jpg)

    *Figure 1: Output caching example*

## Configure Output Caching Through the Web.config File

You can also configure the caching feature in the local Web.config file, which is found in the content directory. Below is a sample of the configuration needed for a ShowStockPrice.asp page with a varyByQueryString parameter of \* (meaning cache all unique variations of querystring parameters) and a timeout of 1 second.

[!code-xml[Main](configure-iis-7-output-caching/samples/sample1.xml)]

If you want to cache this data in kernel for even faster performance, you just need to change the policy attribute to kernelCachePolicy.

> [!NOTE]
> Microsoft ASP.NET already includes an output cache feature; The IIS output cache feature works in parallel with the ASP.NET cache and works for all types of applications.

## Check Performance Counters

To see performance in the output cache, you can look at output cache counters in the reliability and performance monitor.

1. From the **Start** menu, click **Administrative Tools**, and then click **Reliability and Performance Monitor**. (On Windows Vista® or Windows® 7, Administrative Tools is found in the Control Panel.)
2. Select **Performance Monitor** in the tree view on the right, and then click **+** in the toolbar.
3. Navigate to the **Web Service Cache** counter, and then click on it to open it.
4. Add the **Total URIs Cached** counter.

If you run a performance test, you can see that the number of cached URIs increases with the number if items you request.

## Use Kernel-Mode Caching

The IIS output cache supports two cache policies:

- User-mode output cache policy, which uses a cache that resides in an IIS worker process.
- Kernel-mode cache policy, which uses a cache that resides in Http.sys, a kernel-mode driver.

Caching your content in kernel mode lets you speed Web site performance. An example of using kernel-mode caching can be found in the [IIS Output Caching](walkthrough-iis-output-caching.md) article.

Note that there are two significant differences between user-mode and kernel-mode output cache.

- The kernel-mode output cache does not support modules and features that must run in user mode, such as authentication or authorization. For example, if authentication schemes like basic authentication or Windows® authentication are enabled, the cache policy does not work. The content is served but not cached. You can find more details on why responses might not get cached in kernel mode in this [Knowledge Base article](https://support.microsoft.com/kb/817445).
- The kernel-mode output cache supports the varyByHeaders attribute, but not varyByQuerystring.

## Troubleshoot Caching

Failed Request Event Buffering (FREB) is the best way to find out whether or not your request gets cached; you can also find out why a request is not getting cached. For example, the HTTPSYS\_CACHEABLE event in an FREB log can tell you that a request is not getting cached because the kernel-mode cache is not enabled.

The following command can be used to find out which content is cached in kernel mode:

[!code-console[Main](configure-iis-7-output-caching/samples/sample2.cmd)]

## Cache Your Most Popular Pages

You can set the output cache to cache only your default page (the most frequently requested page):

1. Create a file called **default.aspx** in the **%systemdrive%\inetpub\wwwroot\\&lt;your application&gt;** directory and add the following code:

   [!code-aspx[Main](configure-iis-7-output-caching/samples/sample3.aspx)]

2. From the **Start** menu, click **Administrative Tools**, and then click **Internet Information Services (IIS) Manager**.
3. Use the tree view on the left side to navigate to your application.
4. Click **Content View** at the bottom of the page.
5. Select your default document (for example, Default.aspx page).
6. In the **Actions** menu on the right, click **Switch to feature** view. Every setting that you configure is now only applied to the default document.
7. Open the **Output Caching Rules** setting.
8. Add **.aspx** as a file extension.
9. Select **Kernel-mode caching**, select **At time intervals**, enable **Monitor cached files,** and then type a time interval, such as **00:00:30**.
10. Browse to `http://localhost//<your application>` with Windows® Internet Explorer®. By constantly refreshing the page (press **Ctrl**+**F5** to make sure you are not using the browser cache), you see that the time does not change for 30 seconds.

> [!NOTE]
> *This article is based on information from the article "[IIS 7 Output Caching for Dynamic Content - Speed Up Your ASP and PHP Applications](https://blogs.iis.net/bills/archive/2007/05/02/iis7-output-caching-for-dynamic-content-dramatically-speed-up-your-asp-and-php-applications.aspx)" by Bill Staples, published on May 2, 2007.*

## See also

- [IIS Output Caching](walkthrough-iis-output-caching.md)
- [PHP on IIS7 w/FastCGI](https://blogs.iis.net/bills/archive/2006/10/31/PHP-on-IIS.aspx)
