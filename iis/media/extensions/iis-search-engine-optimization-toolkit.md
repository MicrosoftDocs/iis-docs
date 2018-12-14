---
title: IIS Search Engine Optimization Toolkit
TOCTitle: IIS Search Engine Optimization Toolkit
ms:assetid: ccc9d948-83ad-454e-ada1-71d52d39af7c
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh943088(v=VS.90)
ms:contentKeyID: 46305583
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Search Engine Optimization Toolkit

The IIS Search Engine Optimization (SEO) Toolkit helps web developers, hosting providers, and web server administrators to improve their website's relevance in search results by recommending how to make the site content more search engine-friendly. The IIS SEO Toolkit includes the Site Analysis module, the Robots Exclusion module, and the Sitemaps and Site Indexes module, which let you perform detailed analysis and offer recommendations and editing tools for managing your Robots and Sitemaps files.

## In This Section

The IIS Search Engine Optimization (SEO) Toolkit contains the following extensibility points.

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Namespace</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="https://msdn.microsoft.com/en-us/library/ee690537(v=vs.90)">Microsoft.Web.Management.SEO.Crawler</a></p></td>
<td><p>Allows you to provide your own code to hook to the process of crawling a website in the Site Analysis process. By using this extensibility point, you can extend the built-in set of violation rules with your own. You can also gather additional information such as links or resource metadata, whether extracted from the content or from an external system.</p></td>
</tr>
<tr class="even">
<td><p><a href="https://msdn.microsoft.com/en-us/library/ee702728(v=vs.90)">Microsoft.Web.Management.SEO.SiteAnalyzer</a></p></td>
<td><p>Allows you to provide custom tasks to be exposed in the <strong>Site Analysis</strong> tool.</p></td>
</tr>
<tr class="odd">
<td><p><a href="https://msdn.microsoft.com/en-us/library/ee702744(v=vs.90)">Microsoft.Web.Management.SEO.Sitemaps</a></p></td>
<td><p>Allows you to provide custom tasks to be exposed in the <strong>Sitemaps and Sitemap Indexes</strong> tool.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Other Resources

[IIS Search Engine Optimization Toolkit](http://go.microsoft.com/fwlink/?linkid=247901)

