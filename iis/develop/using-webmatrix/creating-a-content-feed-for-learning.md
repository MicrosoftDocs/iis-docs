---
title: "Creating a Content Feed for Learning | Microsoft Docs"
author: simtan
description: "If you are a content/documentation provider that writes articles or creates video to help others learn web development, you can have your learning content sy..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 05/20/2011
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/develop/using-webmatrix/creating-a-content-feed-for-learning
msc.type: authoredcontent
---
Creating a Content Feed for Learning
====================
by [Simon Tan](https://github.com/simtan)

## Creating a Content Feed for Learning

If you are a content/documentation provider that writes articles or creates video to help others learn web development, you can have your learning content syndicated inside the WebMatrix environment! Your content can be presented to users at opportune moments in the WebMatrix experience - for example, articles about databases can be shown right when WebMatrix users are working in the Databases workspace, or videos about JavaScript can be suggested as users are working in JavaScript files.

In order to take advantage of this integration, you will need to create a specially formatted [Atom](http://tools.ietf.org/html/rfc4287 "Atom") feed which tells WebMatrix what content you want to make available, and at what times (conditions) you want to make it available. You can put this file online and WebMatrix will query it and cache it, much like how RSS clients handle RSS feeds.

In this article, we will describe the integration experience through conditions in the app, how to create the feed in the right format, and how to add it to WebMatrix.

### Learning Triggers

WebMatrix has a selection of interesting states, or **triggers**, that it captures events for. When these occur, WebMatrix looks at the set of feeds it is currently indexing and opens a **learning panel** on the side of the application if there are any relevant entries in the feed for that event:

[![](creating-a-content-feed-for-learning/_static/image2.png)](creating-a-content-feed-for-learning/_static/image1.png)

So when the user is performing some action in the IDE, relevant content can be presented to them at that opportune time - likely when they would find it most useful. A trigger fires by matching a defined "Condition" that is specific to that event - for example, a user entering the Database workspace might trigger the condition named "DatabaseWorkspace".

The result is that any content marked with that condition name (i.e. "DatabaseWorkspace") in your feed will be shown at that time.

Conditions may also have **parameters** - for example, an application ID from the Web Application Gallery or a NuGet package name might be necessary to narrow down the scope of what the user would need content for. The currently available conditions (and their respective identifiers and parameters if any) in WebMatrix include:

| User Action | Condition Name | Parameters |
| --- | --- | --- |
| Being in the Site workspace with an Application Gallery app or template | KnownAppInSiteWorkSpace | appId (string identifier for the site/template from the WebPI feed) |
| Being in the Site workspace while working from scratch | UnknownAppInSiteWorkSpace | N/A |
| Focusing on a CSS File | CssFile | N/A |
| Focusing on a JScript File | JavaScriptFile | N/A |
| Focusing on a CSHTML File | CshtmlFile | N/A |
| Focusing on a VBHTML File | VbhtmlFile | N/A |
| Focusing on a PHP File | PhpFile | N/A |
| Focusing on an HTML File | HtmlFile | N/A |
| Entering Files workspace | EditorWorkspace | N/A |
| Entering Reports workspace (SEO) | ReportsWorkspace | N/A |
| Entering Databases workspace | DatabaseWorkspace | N/A |
| Opening Site Settings Page | SettingsPage | N/A |
| Opening Requests Page | RequestPage | N/A |
| Opening a database table | DatabaseTable | N/A |
| Opening a Report | Report | N/A |
| Installing a NuGet package | NuGet | packageID |

(This list is subject to change after WebMatrix 2 Beta.)

More triggers may be added in future versions of WebMatrix, or via WebMatrix extensions that users can install.

### Feed Structure

Your feed just needs to be in the Atom format with an additional custom namespace that adds a place for trigger definitions and [OPML style](http://www.opml.org/ "OPML") outlining capabilities:


[!code-unknown[Main](creating-a-content-feed-for-learning/samples/sample-127515-1.unknown)]


The custom namespace allows you to create two new kinds of tags in each Atom **&lt;entry&gt;** block - **ConditionRef** tags that are used to identify which trigger the content should launch on and **Outline** tags that are used to lay out a hierarchy of content (if necessary).

Average entries in the feed will just be single links, so they will not need Outline nodes. They might look something like this:


[!code-html[Main](creating-a-content-feed-for-learning/samples/sample2.html)]


The **&lt;title&gt;** and **&lt;link&gt;** elements are used to render the link in the sidebar. The **&lt;d:DynamicHelp&gt;** block contains one **&lt;d:ConditionRef&gt;** element that points to a specific trigger ("KnownAppInSiteWorkspace" above) and passes in the required parameter of "appId" so the content will only be shown with that application.

The **&lt;id&gt;** element must be a unique identifier for this **&lt;entry&gt;** node - these are used to determine which articles are "new" to the user and notifications will be presented to them accordingly. One simple way to ensure they are unique is to use the URL for the content as the ID string.

Things can be more complex when you'd like to lay out a detailed hierarchy (e.g. for courses or series) or include many links for one particular trigger - that is where the **&lt;d:Outline&gt;** nodes come in.

Here is an example where there are three consecutive parts of a series, represented using the **&lt;d:Outline&gt;** nodes:


[!code-html[Main](creating-a-content-feed-for-learning/samples/sample3.html)]


Just like in OPML, each &lt;d:Outline&gt; node can have the following attributes in addition to the required ***text*** attribute:

| Attribute | Details |
| --- | --- |
| type | *Required* for all nodes without children. Must be one of the following: - *article* - *video* - *series* Describes the kind of content this node represents. This in turn informs WebMatrix on how to label the node in the learning panel (with an icon). If this attribute is missing, the node **must** have children and this node will be interpreted as a header for those children. |
| uri | *Required* for all nodes without children. Must be a full URL, including a valid protocol. In the case of *article* or *video* types, this should be the URL to a web page containing the content. In the case of *series* types, this should be a URL to a page that describes the series more in-depth (like the website hosting the series). If this attribute is missing, the node **must** have children and this node will be interpreted as a header for those children. |

### Sample Files

This downloadable package includes:

- An example of an full feed file that has multiple kinds of nodes and hierarchy, and exercises many kinds of triggers
- A trigger definitions file which specifies all the available "ConditionRef" identifiers
- An XSD schema file for the feed - this can be used for validation purposes

Download the samples here: [DynamicHelpSamples.zip](creating-a-content-feed-for-learning/_static/creating-a-content-feed-for-learning-1032-dynamichelpsamples1.zip)

### Adding a feed to WebMatrix

Users can add additional feeds to WebMatrix wherever they find them on the web, just by adding URLs to valid feeds using the WebMatrix interface. So you can create separate feeds for different purposes and provide links to them for your visitors - they can then add the feeds to WebMatrix in order to stay aware of your latest content while working on their websites.

### Questions?

Please feel free to send questions to the author of this article, or post on the official [WebMatrix forums](https://forums.iis.net/1166.aspx).