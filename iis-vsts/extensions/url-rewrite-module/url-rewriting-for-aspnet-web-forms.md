---
title: "URL Rewriting for ASP.NET Web Forms"
author: ruslany
description: "When you use the IIS URL Rewrite module with ASP.NET applications, it is important to ensure the correct behavior of your Web application with rewritten URLs..."
ms.date: 11/10/2008
ms.assetid: 657219fc-c621-4bb9-9db8-67903e2fc297
msc.legacyurl: /learn/extensions/url-rewrite-module/url-rewriting-for-aspnet-web-forms
msc.type: authoredcontent
---
URL Rewriting for ASP.NET Web Forms
====================
by [Ruslan Yakushev](https://github.com/ruslany)

When you use the IIS URL Rewrite module with ASP.NET applications, it is important to ensure the correct behavior of your Web application with rewritten URLs. This article explains scenarios in which URL rewriting can affect ASP.NET Web applications, and solutions to potential problems.

## Table of Contents

- [Setting the Postback URL for the Form Element](url-rewriting-for-aspnet-web-forms.md#Form_postback_URL)
- [Rewriting URLs for the AJAX UpdatePanel Control](url-rewriting-for-aspnet-web-forms.md#AJAX_UpdatePanel)
- [Using the "~" Operator in Web Server Controls](url-rewriting-for-aspnet-web-forms.md#Using_tilda)
- [Rewriting URLs and Site Navigation Controls](url-rewriting-for-aspnet-web-forms.md#Site_navigation_controls)
- [Prevent Rewriting of Requests for ASP.NET resources](url-rewriting-for-aspnet-web-forms.md#webresources)

<a id="Form_postback_URL"></a>

## Setting the Postback URL for the Form Element

ASP.NET Web Forms use postbacks extensively, and this makes it somewhat tricky to perform URL rewriting for ASP.NET pages. If the page contains one or more Web server controls, when ASP.NET renders the page, it sets the action attribute of the HTML form element to point back to the page where the form element is—that is, it points to itself. If URL rewriting is used for that page, the action attribute points to the rewritten URL, not to the URL that was requested from the browser. This causes the browser to display the rewritten URL in the address box any time a postback occurs.

To prevent the action attribute from pointing to the wrong URL, you can set the Action property of the HtmlForm instance on the page to the postback URL that was requested by the browser. You can obtain that URL from by using HttpRequest.RawUrl property. The following example shows how you can modify the ASP.NET page to set the action URL.


[!code-csharp[Main](url-rewriting-for-aspnet-web-forms/samples/sample1.cs)]


> [!NOTE]
> The HtmlForm.Action property is available starting with .NET Framework version 3.5 SP1.


If you are using ASP.NET master pages, you can add code to the Page\_Load method of the master page to set the postback action URL for all the pages that use that master page.

<a id="AJAX_UpdatePanel"></a>

## Rewriting URLs for the AJAX UpdatePanel Control

When you use the URL Rewrite module to rewrite the URL for a page that contains one or more UpdatePanel controls, the control will use the rewritten URL for all the actions that are performed by that UpdatePanel control. This can cause the controls in the UpdatePanel control to not work correctly, especially in cases when URL rewriting changes the directory hierarchy of the requested URL. For example, if you use the URL Rewrite module to rewrite /Products/Hardware to /Products.aspx, the UpdatePanel control will use the URL /Products/Hardware/Products.aspx for all actions within the UpdatePanel control. This results in a script error.

To prevent this from happening, set the Action property of the page's HtmlForm instance as described in [Setting the Postback URL for the Form Element](url-rewriting-for-aspnet-web-forms.md#Form_postback_URL) in the previous section.

<a id="Using_tilda"></a>

## Using the ~ Operator in Web Server Controls

You can use the ~ operator in ASP.NET Web server controls to reference the root of the application directory when you need to set a path. However, if URL rewriting changes the directory hierarchy of the requested URL, this can cause links that are specified with the ~ operator to be resolved incorrectly. For example, imagine that the Default.aspx page at the root of a Web application named app1 contains the following Image control:


[!code-aspx[Main](url-rewriting-for-aspnet-web-forms/samples/sample2.aspx)]


If URL rewriting changes the URL from http://localhost/app1/folder/file to http://localhost/app1/default.aspx, the links that are specified with the ~ operator will be resolved relative to the rewritten URL path, which would be relative to the /app1 folder. The following example shows the resulting HTML markup for the img element:


[!code-html[Main](url-rewriting-for-aspnet-web-forms/samples/sample3.html)]


Because the browser requested http://localhost/app1/folder/file, it will try to obtain the image from http://localhost/app1/folder/Images/MyImage.gif. This results in a 404 (File Not Found) error.

The URL Rewrite module for IIS includes an update for ASP.NET that fixes this behavior. The update causes the ~ operator in Web server controls to be resolved relative to the originally requested URL. In the previous example, the HTML markup in the response will contain the correct URL path for the img element, as shown in the following markup:


[!code-html[Main](url-rewriting-for-aspnet-web-forms/samples/sample4.html)]


The update for ASP.NET applies only to .NET Framework 3.5 SP1 and later. In order to get the update, upgrade the .NET Framework to version 3.5 SP1 and then run the IIS URL Rewrite module installer, which will install the ASP.NET update.

<a id="Site_navigation_controls"></a>

## Rewriting URLs and Site Navigation Controls

An ASP.NET sitemap can be used to describe the structure of a Web site so that the site navigation API and the site navigation controls can expose a logical (instead of physical) site structure. When you use the URL Rewrite module with an ASP.NET application that uses site navigation, you typically want the navigation controls to operate in terms of logical site structure that uses public or virtual URLs.

For example, you might define a sitemap as shown in the following example:


[!code-xml[Main](url-rewriting-for-aspnet-web-forms/samples/sample5.xml)]


You might then define rewrite rules that perform the following rewrites:

- /Products/ to /Products.aspx
- /Products/Hardware to /Products.aspx?category=Hardware
- /Products/Software to /Products.aspx?category=Software

Defining a sitemap by using these virtual URLs can cause the SystemWeb.SiteMap class to not work correctly. When you try to access the SiteMap.CurrentNode property in an ASP.NET page, the property may contain null. This can cause site navigation controls like SiteMapPath and Menu to work incorrectly.

The URL Rewrite module for IIS includes an update for ASP.NET that fixes the navigation controls so that they can work with virtual URLs that are rewritten. With this update, the SiteMap.CurrentNode property will refer to the SiteMapNode that corresponds to the currently requested virtual URL.

The update for ASP.NET applies only to .NET Framework 3.5 SP1 and later. In order to get the update, upgrade the .NET Framework to version 3.5 SP1 and then run the IIS URL Rewrite module installer, which will install the ASP.NET update.

<a id="webresources"></a>

## Prevent Rewriting of Requests for ASP.NET Web Resources

ASP.NET-based web applications very often make requests to WebResources.axd file to retrieve assembly resources and serve them to the Web browser. There is no such file exists on the server because ASP.NET generates the content dynamically when WebResources.axd is requested. So if you have a URL rewrite rule that does rewriting or redirection only if requested URL does not correspond to a file or a folder on a web server's file system, that rule may accidentally rewrite requests made to WebResources.axd and thus break your application.

This problem can be easily prevented if you add one extra condition to the rewrite rule:


[!code-xml[Main](url-rewriting-for-aspnet-web-forms/samples/sample6.xml)]