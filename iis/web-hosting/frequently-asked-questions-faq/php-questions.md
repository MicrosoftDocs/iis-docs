---
title: "PHP Questions | Microsoft Docs"
author: walterov
description: "Microsoft does not support PHP. We started integration testing with 5.2.1. Most of the testing seen shows PHP working well, without specific integration issu..."
ms.author: iiscontent
manager: soshir
ms.date: 12/22/2007
ms.topic: article
ms.assetid: 0539b3e4-7d7b-4e34-9406-28ed9965c500
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/frequently-asked-questions-faq/php-questions
msc.type: authoredcontent
---
PHP Questions
====================
by [Walter Oliver](https://github.com/walterov)

#### What support is available for PHP running with FastCGI?

Microsoft does not support PHP. We started integration testing with 5.2.1. Most of the testing seen shows PHP working well, without specific integration issues (other than bugs on our side which we are fixing, or bugs in PHP which are independent of the FastCGI).

#### Can multiple versions of PHP run in the same Application Pool?

Yes. Several web sites in the same app pool can use different PHP versions when using the FastCGI components that we are releasing for IIS 6.0 and IIS 7.0. Here's an example of an .ini file:

[!code-console[Main](php-questions/samples/sample1.cmd)]

The PHP:1 and PHP:2 means that the extension applies to Web Site #1 and #2 respectively.

#### Is there a list of PHP applications that have been tested on Windows Server® 2008?

These [applications](../../application-frameworks/install-and-configure-php-applications-on-iis/index.md "PHP Applications") have been used on Windows Server 2008 and have no known issues.