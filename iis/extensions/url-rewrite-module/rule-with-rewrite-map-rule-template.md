---
title: "Rule with Rewrite Map - rule template"
author: ruslany
description: "Rule templates are used to provide a simple way of creating one or more rewrite rules for a certain scenario. URL rewriter module includes several rule templ..."
ms.date: 09/11/2008
ms.assetid: 286d2079-bda3-4991-a6a0-bad280527dde
msc.legacyurl: /learn/extensions/url-rewrite-module/rule-with-rewrite-map-rule-template
msc.type: authoredcontent
---
# Rule with Rewrite Map - rule template

by [Ruslan Yakushev](https://github.com/ruslany)

Rule templates are used to provide a simple way of creating one or more rewrite rules for a certain scenario. URL rewriter module includes several rule templates for some common usage scenarios. In addition to that URL rewrite module UI provides a framework for plugging in custom rule templates. This walkthrough will guide you through how to use "Rule with Rewrite Map" template that is included with URL rewrite module.

## Prerequisites

This walkthrough requires the following prerequisites:

1. IIS 7.0 or above with ASP.NET role service enabled;
2. URL rewrite module Go Live release installed.

## Setting up a test web page

We will be using a simple test asp.net page to verify that the rule created by the template works correctly. The test page simply reads the web server variables and outputs their values in browser.

Copy the following ASP.NET code and put it in the `%SystemDrive%\inetpub\wwwroot\` folder in a file called article.aspx:

[!code-aspx[Main](rule-with-rewrite-map-rule-template/samples/sample1.aspx)]

After copying this file, browse to `http://localhost/article.aspx` and check that the page was rendered correctly in a browser.

[![](rule-with-rewrite-map-rule-template/_static/image3.png)](rule-with-rewrite-map-rule-template/_static/image1.png)

## Using rule template to generate rewrite rule

The "Rule with Rewrite Map" template can be used to generate rewrite and redirect rules that use rewrite maps for storing static mappings between originally requested URLs and rewritten or redirected URLs. For more information about usage of rewrite maps refer to "[URL Rewrite Module Configuration Reference](url-rewrite-module-configuration-reference.md#Rewrite_maps)" and "[Using Rewrite Maps in URL Rewrite Module](using-rewrite-maps-in-url-rewrite-module.md)".

To use this template follow these steps:

1. Go to IIS Manager
2. Select "Default Web Site"
3. In the Feature View click "URL Rewrite"  
    [![](rule-with-rewrite-map-rule-template/_static/image6.png)](rule-with-rewrite-map-rule-template/_static/image5.png)
4. In the "Actions" pane on right hand side click on "**Add rules…**"  
    [![](rule-with-rewrite-map-rule-template/_static/image10.png)](rule-with-rewrite-map-rule-template/_static/image9.png)
5. In the "Add Rules" dialog select "Rule with Rewrite Map" and click "OK":  
    [![](rule-with-rewrite-map-rule-template/_static/image13.png)](rule-with-rewrite-map-rule-template/_static/image12.png)
6. In the "Add rule with rewrite map" dialog, choose "Rewrite" in the drop down list. In the "Choose the rewrite map:" combo box specify the name of the new rewrite map as **StaticRewrites**.  
     [![](rule-with-rewrite-map-rule-template/_static/image16.png)](rule-with-rewrite-map-rule-template/_static/image15.png)
7. Click "OK". This will create a rewrite map with the given name and a rewrite rule with name "Rewrite Rule 1 for StaticRewrites" that references that rewrite map.
8. After clicking "OK" you will be taken to the page where you can specify the mapping entries for the rewrite map. Click on "Add Mapping Entry..." in the Actions pane on right hand side and then enter the original and new value for the mapping entry as "**/article1**" and "**/article.aspx?id=1&amp;title=some-title**" respectively.  
    [![](rule-with-rewrite-map-rule-template/_static/image18.png)](rule-with-rewrite-map-rule-template/_static/image17.png)
9. Repeat previous step to add two more mapping entries as follows: 

    | Original Value: | New Value: |
    | --- | --- |
    | /some-title | /article.aspx?id=1&amp;title=some-title |
    | /post/some-title.html | /article.aspx?id=1&amp;title=some-title |

After completing these steps you should see the following rewrite map and rewrite rule created in `C:\inetpub\wwwroot\web.config` file.

[!code-xml[Main](rule-with-rewrite-map-rule-template/samples/sample2.xml)]

## Testing the rule

To test the generated rewrite rule that uses the "**StaticRewrites**" map, open web browser and request any of the following URLs:

`http://localhost/article1`  
`http://localhost/some-title`  
`http://localhost/post/some-title.html`

Any one of the URLs above should cause the URL to be rewritten in accordance to the mappings defined in the rewrite map. Your results should look like the following page:

[![](rule-with-rewrite-map-rule-template/_static/image21.png)](rule-with-rewrite-map-rule-template/_static/image19.png)

## Summary

In this walkthrough you have learned how to generate rewrite rules with rewrite maps by using "Rule with Rewrite Map" template included with URL rewrite module. This rule template can be used for creating a rule and a placeholder map that can contain large number of static rewriting and redirection mappings for your web application.
