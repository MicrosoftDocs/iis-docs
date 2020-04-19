---
title: "APPL_PHYSICAL_PATH Server Variable on Windows Vista RTM"
author: rmcmurray
description: "The original release of IIS 7.0 that shipped with Windows Vista returned a different value for the APPL_PHYSICAL_PATH server variable than that which was ret..."
ms.date: 02/19/2009
ms.assetid: 2359a956-fe32-40a8-8452-5a65c3898195
msc.legacyurl: /learn/application-frameworks/running-classic-asp-applications-on-iis-7-and-iis-8/applphysicalpath-server-variable-on-windows-vista-rtm
msc.type: authoredcontent
---
APPL_PHYSICAL_PATH Server Variable on Windows Vista RTM
====================
by [Robert McMurray](https://github.com/rmcmurray)

The original release of IIS 7.0 that shipped with Windows Vista returned a different value for the APPL\_PHYSICAL\_PATH server variable than that which was returned by previous or subsequent versions of IIS. In earlier versions of IIS, this server variable had a backslash "\" character appended to the path, but in the original release version of Windows Vista this server variable contained only the path. This was fixed in Windows Vista Service Pack 1 (SP1) and in the original release version of Windows Server 2008.

This means that if you are a Classic ASP developer and you are using the value in the APPL\_PHYSICAL\_PATH server variable to compute paths on the original release version of Windows Vista, your ASP code will have to account for the missing backslash character before migrating that application to another computer.

For example, the following ASP code computes the location of a Microsoft Access database in the App\_Data folder of the current application:

[!code-vb[Main](applphysicalpath-server-variable-on-windows-vista-rtm/samples/sample1.vb)]

If you were testing this code on a Windows XP computer that used IIS 5.1, this code would have worked successfully. However, if you upgraded your computer to the original release version of Windows Vista, the path of the database would be invalid and the connection to the database would fail. For example, if the ASP code was in a page in the root folder of the Default Web Site, the contents of the computed connection string might resemble the following:

[!code-console[Main](applphysicalpath-server-variable-on-windows-vista-rtm/samples/sample2.cmd)]

If you have [ASP configured to send errors to the browser](classic-asp-script-error-messages-no-longer-shown-in-web-browser-by-default.md), you will see the following error:

[!code-console[Main](applphysicalpath-server-variable-on-windows-vista-rtm/samples/sample3.cmd)]

To resolve this issue for Windows Vista, you can install Windows Vista SP1, or you can have your ASP code manually check for the backslash character and add the backslash if it is required. For example:

[!code-vb[Main](applphysicalpath-server-variable-on-windows-vista-rtm/samples/sample4.vb)]

## More Information

For more information about IIS server variables, see the following page on the Microsoft MSDN Web site:

**IIS Server Variables**  
[https://msdn.microsoft.com/library/ms524602.aspx](https://msdn.microsoft.com/library/ms524602.aspx)
