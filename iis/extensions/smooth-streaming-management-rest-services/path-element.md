---
title: Path Element
TOCTitle: Path Element
ms:assetid: 6614def7-9f48-4b36-a478-7481e436a74f
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547044(v=VS.90)
ms:contentKeyID: 37836885
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Path Element

Specifies a path that overwrites the default archive path that is set in the server configuration.

    <Path useEventIdOnPath="true|false"> 
      "path"
    </Path>

## Attributes

|Attribute|Description|
|--- |--- |
|useEventIdOnPath|Optional. true to use the event ID on the path instead of the auto-generated timestamp value; otherwise, false. The default value is false.|

## Child Elements

None.

## Parent Element

[Archive Element](archive-element.md)

## Example

    <Archive enabled="true">
      <Path useEventIdOnPath="false">%systemdrive%\inetpub\media\archives</Path>
    </Archive>
