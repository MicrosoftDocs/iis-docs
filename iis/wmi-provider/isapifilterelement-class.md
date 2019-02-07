---
title: "IsapiFilterElement Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ed7f5df4-a6e4-bdc5-c585-4b9e7936bbc2
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IsapiFilterElement Class
Specifies an ISAPI filter.  
  
## Syntax  
  
```vbs  
class IsapiFilterElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `IsapiFilterElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`EnableCache`|A read/write `boolean` value. `true` if IIS allows HTTP.sys caching for requests that go through the ISAPI filter; otherwise, `false`. If `true`, a particular request goes through the filter only once. After that, the response is cached by HTTP.sys and the filter is no longer involved. The default is `false`.|  
|`Enabled`|A read/write `boolean` value. `true` if the ISAPI filter is enabled; otherwise, `false`. The default is `true`.|  
|`Name`|A read-only `string` value that specifies the name of the ISAPI filter. The only key property.|  
|`Path`|A required nonempty read/write `string` value that specifies the full physical path to the DLL file of the ISAPI filter.|  
|`PreCondition`|A read/write `string` value that specifies a condition that must be satisfied before the ISAPI filter is loaded. The possible values are listed later in the Remarks section.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `IsapiFilters` property of the [IsapiFiltersSection](../wmi-provider/isapifilterssection-class.md) class.  
  
 The following table lists the possible values for the `PreCondition` property. The default is `null`.  
  
|Value|Description|  
|-----------|-----------------|  
|`bitness32`|IIS loads the ISAPI filter only for 32-bit worker processes.|  
|`bitness64`|IIS loads the ISAPI filter only for 64-bit worker processes.|  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `IsapiFilterElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [IsapiFiltersSection Class](../wmi-provider/isapifilterssection-class.md)