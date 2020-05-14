---
title: "SMTP Questions"
author: walterov
description: "Not out of the box. How does the SMTP module work with IIS? Can the source site of the SMTP message be determined? There are no SMTP changes in Windows Serve..."
ms.date: 12/22/2007
ms.assetid: 90abdb7f-14d9-4026-999a-a70dee034bc0
msc.legacyurl: /learn/web-hosting/frequently-asked-questions-faq/smtp-questions
msc.type: authoredcontent
---
# SMTP Questions

by [Walter Oliver](https://github.com/walterov)

#### Can SMTP logging be integrated with IIS logs?

Not out of the box.

#### How does the SMTP module work with IIS? Can the source site of the SMTP message be determined?

There are no SMTP changes in Windows Server® 2008.

#### The only SMTP Module that I can find in Windows Server 2008 is in features, but this requires old IIS 6.0 compatibility mode. Is that correct?

Yes, SMTP requires the Metabase system, so it is configured in IIS 6.0 compatibility mode. See the link below for more information about installing and configuring Metabase Compatibility Mode. For more information, see the article on metabase compatibility code at:

[https://www.iis.net/articles/view.aspx/IIS7/Use-IIS7-Administration-Tools/Using-XML-Configuration/Metabase-Compatibility-with-IIS7](../../manage/managing-your-configuration-settings/metabase-compatibility-with-iis-7-and-above.md) .
