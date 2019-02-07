---
title: "MimeMapElement Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a7659ca3-3b28-4d7d-17ea-ed98c46ce831
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# MimeMapElement Class
Specifies a MIME type associated with a file extension.  
  
## Syntax  
  
```vbs  
class MimeMapElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `MimeMapElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`FileExtension`|A required, unique, nonempty read-only `string` value that contains the file extension for `MimeType`. The key property.|  
|`MimeType`|A required nonempty read/write `string` value that contains the MIME type for the extension in `FileExtension`.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `StaticContent` array property of the [StaticContentSection](../wmi-provider/staticcontentsection-class.md) class.  
  
> [!NOTE]
>  IIS serves static content for only the MIME type and file extension combinations that the `MimeMapElement` class specifies. The MIME map tells the static file handler how to return requests of a specific type.  
  
## Example  
 The following example lists file extensions and their associated MIME maps in the ApplicationHost.config file at the server level.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the <staticContent> section in ApplicationHost.config.  
Set oSection = oWebAdmin.Get( _  
    "StaticContentSection.Path='MACHINE/WEBROOT/APPHOST',Location=''")  
  
' List the MIME maps by using the StaticContent property of the StaticContentSection class.  
For Each oMimeMapElement In oSection.StaticContent  
    WScript.Echo "File Extension: " & oMimeMapElement.FileExtension  
    WScript.Echo "Mime Type: " & oMimeMapElement.MimeType  
    WScript.Echo  
Next  
```  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `MimeMapElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [StaticContentSection Class](../wmi-provider/staticcontentsection-class.md)