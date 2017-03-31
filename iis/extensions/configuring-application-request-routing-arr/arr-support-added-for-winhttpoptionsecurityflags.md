---
title: "ARR: Support Added for WINHTTP_OPTION_SECURITY_FLAGS | Microsoft Docs"
author: rick-anderson
description: "The ARR update KB 2693489 adds support for WINHTTP_OPTION_SECURITY_FLAGS . Default Behavior: This is the same prior to the updated where ARR will ignore Comm..."
ms.author: iiscontent
manager: soshir
ms.date: 04/13/2012
ms.topic: article
ms.assetid: 
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/configuring-application-request-routing-arr/arr-support-added-for-winhttpoptionsecurityflags
msc.type: authoredcontent
---
ARR: Support Added for WINHTTP_OPTION_SECURITY_FLAGS
====================
by [Harsh Mittal](https://twitter.com/harshmittal)

The ARR update KB 2693489 adds support for WINHTTP\_OPTION\_SECURITY\_FLAGS .

**Default Behavior:** 

This is the same prior to the updated where ARR will ignore Common name mismatches in the SSL communication. With this change ARR implementsSECURITY\_FLAG\_IGNORE\_CERT\_CN\_INVALID as the default flag.

To change the settings add the following registry key.

1. Click Start, type regedit.exe in the Start Search box, and then press ENTER.
2. Expand the following registry key 

    [!code-console[Main](arr-support-added-for-winhttpoptionsecurityflags/samples/sample1.cmd)]
3. Right-click Parameters, click New, and then click DWORD (32-bit) Value.
4. In the **Value name** box, type SecureConnectionIgnoreFlags , and then press ENTER.
5. Double-click the SecureConnectionIgnoreFlags registry value and Enter 0.
6. Close Registry Editor.

The key can also be added from the command line with the following command:

[!code-console[Main](arr-support-added-for-winhttpoptionsecurityflags/samples/sample2.cmd)]

**Setting Additional Options**

The default value of 0 is the same as setting the SECURITY\_FLAG\_IGNORE\_CERT\_CN\_INVALID flag.

To set additional options you can combine the following settings by adding the following values together.

For example to Set both SECURITY\_FLAG\_IGNORE\_CERT\_CN\_INVALID and SECURITY\_FLAG\_IGNORE\_CERT\_DATE\_INVALID set the value = 0x00003000.

| Value | Description |
| --- | --- |
| 0x00001000 | SECURITY\_FLAG\_IGNORE\_CERT\_CN\_INVALID **(DEFAULT)** |
| 0x00002000 | SECURITY\_FLAG\_IGNORE\_CERT\_DATE\_INVALID |
| 0x00000100 | SECURITY\_FLAG\_IGNORE\_UNKNOWN\_CA |
| 0x00000200 | SECURITY\_FLAG\_IGNORE\_CERT\_WRONG\_USAGE |

· SECURITY\_FLAG\_IGNORE\_CERT\_WRONG\_USAGE

Allows the identity of a server to be established with a non-server certificate (for example, a client certificate).

SECURITY\_FLAG\_IGNORE\_CERT\_WRONG\_USAGE 0x00000200

***Reference***

**WINHTTP\_OPTION\_SECURITY\_FLAGS**

[https://msdn.microsoft.com/en-us/library/windows/desktop/aa384066(v=vs.85).aspx](https://msdn.microsoft.com/en-us/library/windows/desktop/aa384066(v=vs.85).aspx)