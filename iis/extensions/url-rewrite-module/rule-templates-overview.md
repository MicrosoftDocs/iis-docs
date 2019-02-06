---
title: "Rule Templates Overview"
author: ruslany
description: "Rule templates in URL Rewrite module provide a simple way of creating one or more rewrite rules for a certain scenario. Built-in rule templates URL rewriter..."
ms.date: 11/10/2008
ms.assetid: 1cd83eb9-9b27-4f98-aba7-83b36390be8e
msc.legacyurl: /learn/extensions/url-rewrite-module/rule-templates-overview
msc.type: authoredcontent
---
Rule Templates Overview
====================
by [Ruslan Yakushev](https://github.com/ruslany)

Rule templates in URL Rewrite module provide a simple way of creating one or more rewrite rules for a certain scenario.

## Built-in rule templates

URL rewriter module includes several rule templates for most common scenarios:

- [User Friendly URL](user-friendly-url-rule-template.md) - This rule template can be used to generate rewrite and redirect rules that make URLs for your dynamic web application more user and search engine friendly. The rule template helps you generate rewrite rule that transform the hierarchy based URLs to URLs with query strings. Also, optionally, it can generate a redirect rule that can be used to redirect web clients form URLs with query strings to clean URLs.
- [Rule with Rewrite Map](rule-with-rewrite-map-rule-template.md) - This rule template can be used to generate rewrite and redirect rules that use rewrite maps for storing static mappings between originally requested URLs and rewritten or redirected URLs. For more information about usage of rewrite maps refer to "[URL Rewrite Module Configuration Reference](url-rewrite-module-configuration-reference.md#Rewrite_maps)" and "[Using Rewrite Maps in URL Rewrite Module](using-rewrite-maps-in-url-rewrite-module.md)".
- [Request Blocking](request-blocking-rule-template.md) - this rule template can be used to generate a rule that blocks incoming requests based on various criteria. For example, requests can be blocked based on certain pattern within URL path or based on certain value in one of the request headers.

## Custom rule templates

URL Rewrite module provides an extensible framework for plugging in custom rule templates. For example, you could create a rule template that simplifies creation of rewrite rules for search engine optimization of the web site or for preventing content hot-linking. For a step by step guidance on how to extend URL Rewrite module user interface with rule templates refer to the article "[Developing rule template for URL Rewrite module](developing-rule-template-for-url-rewrite-module.md)".