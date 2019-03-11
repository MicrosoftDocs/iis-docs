---
title: "Using the IIS Search Engine Optimization Toolkit"
author: ruslany
description: "The IIS Search Engine Optimization (SEO) Toolkit provides a set of tools that can be used to improve a Web site’s relevance in search results by making the s..."
ms.date: 06/03/2009
ms.assetid: 036528c7-7f19-485a-b30d-75941f8dc014
msc.legacyurl: /learn/extensions/iis-search-engine-optimization-toolkit/using-the-iis-search-engine-optimization-toolkit
msc.type: authoredcontent
---
Using the IIS Search Engine Optimization Toolkit
====================
by [Ruslan Yakushev](https://github.com/ruslany)

## Introduction

The IIS Search Engine Optimization (SEO) Toolkit provides a set of tools that can be used to improve a Web site's relevance in search results by making the site's content more search engine-friendly. The IIS SEO Toolkit includes the Site Analysis module, the Robots Exclusion module, and the Sitemaps and Site Indexes module. These modules let you perform detailed analyses of a site's structure and content, obtain recommendations for best practices, and leverage editing tools for managing your Robots and Sitemaps files.

## Features

The components of IIS Search Engine Optimization Toolkit include the following features:

- Site Analysis:

    - **Fully featured site crawling engine** - in order to perform a detailed analysis of a site's structure and content, the Site Analysis tool uses a built-in Web crawler, called "iisbot", to download and cache all the publicly available Web site content. The Web crawler is fully compliant with the robots exclusion protocol.
    - **Report summary dashboard** - the results of the site analysis are presented in an easy-to-use dashboard page that serves as a start page for various types of analysis. In addition, this page includes a large set of pre-built queries for the most common reports.
    - **Query builder** - The Site Analysis tool includes a powerful and flexible query builder user interface that lets you create custom queries that are run against cached Web site content.
    - **Detailed URL information** - you can obtain many kinds of detailed information about every URL in your Web site, such as response headers and content, the pages that link to the URL, and all referenced URLs.
    - **Detailed Violations descriptions** - each content or SEO violation found on a Web site has both a detailed description and a recommended corrective action.
    - **Word Analysis** - any Web page can be analyzed to reveal the most commonly used words and phrases on the page. The results of that analysis can be used to select the keywords that most accurately describe the page's contents.
    - **Route Analysis**- unique routes to any page can be displayed in a separate report. This kind of information helps you get a better understanding of how search engine and site visitors reach a particular page on your Web site.
- Robots Exclusion

    - **User interface for editing robots.txt file** - the content of the robots exclusion file - robots.txt - can be edited by using the IIS Manager GUI.
    - **Selecting URL paths from the physical view of a Web site** - the paths that are specified for the "Allow" and "Disallow" directives in the Robots.txt file can be selected from the physical file system layout of your Web site.
    - **Selecting URL paths from the virtual view of a Web site** - the paths that are specified for the "Allow" and "Disallow" directives in the Robots.txt file can be selected from a logical view of your Web site obtained from the results of a site analysis.
- Sitemaps and Sitemap Indexes

    - **User interface for managing sitemap and sitemap indexes files** - the content of the sitemap and indexes files can be edited by using the IIS Manager GUI.
    - **Selecting URLs from the physical view of a Web site** - the URLs that are specified within a sitemap can be selected from the physical file system layout of your Web site.
    - **Selecting URLs from the virtual view of a Web site** - the URLs that are specified within a sitemap can be selected from the logical view of your Web site obtained from the results of a site analysis.

## Where to get the toolkit

[Download the x86 and x64 version for IIS 7](https://www.iis.net/downloads/microsoft/search-engine-optimization-toolkit "Download the x86 and x64 version for IIS 7")

## Using the toolkit

The following articles cover the functionality of the IIS Search Engine Optimization Toolkit and explain how to use it to accomplish common SEO related tasks.

### Learning the basics

- [Using IIS Site Analysis to Crawl a Web Site](using-site-analysis-to-crawl-a-web-site.md)
- [Using IIS Site Analysis Reports](understanding-site-analysis-reports.md)
- [Managing Robots.txt and Sitemaps](managing-robotstxt-and-sitemap-files.md)

### Video walkthrough

- [IIS Site Analysis - Video Walkthrough](iis-site-analysis-video-walkthrough.md)