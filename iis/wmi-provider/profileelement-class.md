---
title: "ProfileElement Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c96ddeff-d6ed-49ef-8389-deb7b8e0ebd8
caps.latest.revision: 8
author: "shirhatti"
manager: "wpickett"
---
# ProfileElement Class
Configures an event profile that determines how an event is collected by [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and raised to providers.  
  
## Syntax  
  
```vbs  
class ProfileElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ProfileElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Custom`|A read/write `string` value that specifies the fully qualified type of a custom class that implements the [System.Web.Management.IWebEventCustomEvaluator](/dotnet/api/system.web.management.iwebeventcustomevaluator?view=netframework-4.7.2) interface. The default is an empty string ("").<br /><br /> The type reference is formed as follows (items in brackets are not required): *Namespace*.*Typename*, *Assemblyname*[,] [Version=*x*,] [Culture=*y*,] [PublicKeyToken=*z*] (for example, "ExampleNamespace.ExampleType, Example.Assembly, Version=%ASSEMBLY_VERSION%, Culture=neutral, PublicKeyToken=%MICROSOFT_PUBLICKEY%"). **Note:**  This property is new in the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] version 2.0.|  
|`MaxLimit`|A read/write `sint32` value that specifies the maximum number of times that events of the same type are raised. The default is 2147483647. For example, if the value is 10, the event will be raised 10 times and ignored thereafter.<br /><br /> This property must have a value greater than 0. You can make the value infinite by setting it to `MaxValue`. Invalid values may cause an exception to be thrown when the configuration section is saved.|  
|`MinInstances`|A read/write `sint32` value that specifies the minimum number of event occurrences before the event is raised to the provider. The default is 1. For example, a value of 5 means that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] will not raise an event to the provider until the fifth instance of the event occurs.<br /><br /> This property must have a value greater than 0. You can make the value infinite by setting it to `MaxValue`. If the value is `MaxValue`, no event will be raised to the provider. Invalid values may cause an exception to be thrown when the configuration section is saved.|  
|`MinInterval`|A read/write `datetime` value that specifies the minimum interval between two events of the same type. The default is 0 seconds.<br /><br /> You can make the value infinite by setting it to `MaxValue`. If the value is 0, there is no minimum interval. Invalid values may cause an exception to be thrown when the configuration section is saved.|  
|`Name`|A unique read-only `string` value that specifies the name of the profile setting. Duplicate profile setting names may cause a loss of data when the configuration section is saved. The key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Profiles` array property of the [ProfileSettings](../wmi-provider/profilesettings-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `ProfileElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Configuration.ProfileSettings](/dotnet/api/system.web.configuration.profilesettings?view=netframework-4.7.2)
 [System.Web.Management.IWebEventCustomEvaluator](/dotnet/api/system.web.management.iwebeventcustomevaluator?view=netframework-4.7.2)
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [ProfileSettings Class](../wmi-provider/profilesettings-class.md)   
 [System.Int32.MaxValue Field](http://go.microsoft.com/fwlink/?LinkId=69329)   
 [CIM_DATETIME](http://go.microsoft.com/fwlink/?LinkId=57551)