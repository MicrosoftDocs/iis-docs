---
title: "TypedElement Class"
ms.date: "10/07/2016"
ms.assetid: 4fc60971-e167-f204-984a-80a0eadb884f
---
# TypedElement Class

Defines a filter for a trace listener.  
  
## Syntax  
  
```vbs  
class TypedElement : EmbeddedObject  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `TypedElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`InitializeData`|A read/write `string` value that specifies the name of an event log or log file to which trace listener output is written, or other custom data that is used by the filter. The default is "".|  
|`Type`|A required read/write `string` value that specifies the type of the trace listener filter.|  
  
## Subclasses  

 The following table lists the subclasses exposed by the `TypedElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|[ListenerElement](../wmi-provider/listenerelement-class.md)|Contains a listener that monitors and formats trace output.|  
  
## Remarks  

 Instances of this class are contained in the `Filter` property of the [ListenerElement](../wmi-provider/listenerelement-class.md) class.  
  
## Inheritance Hierarchy  

 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `TypedElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [ListenerElement Class](../wmi-provider/listenerelement-class.md)
