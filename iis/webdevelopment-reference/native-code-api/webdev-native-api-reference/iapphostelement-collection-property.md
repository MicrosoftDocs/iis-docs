---
title: "IAppHostElement::Collection Property | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 520835fe-cff6-7dbd-5154-a827a983b734
caps.latest.revision: 14
author: "shirhatti"
manager: "wpickett"
---
# IAppHostElement::Collection Property
Represents a collection of elements that belongs to a collection.  
  
## Syntax  
  
```cpp  
HRESULT get_Collection(  
   [out,  
   retval] IAppHostElementCollection** ppCollection  
);  
```  
  
#### Parameters  
 `ppCollection`  
 A pointer to a pointer for an [IAppHostElementCollection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelementcollection-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 A child element collection that is represented in the [IAppHostElement::ChildElements](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-childelements-property.md) property differs from a nested element collection that is represented in the `IAppHostElement::Collection` property. Both collections contain pointers to [IAppHostElement](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) objects. However, you should use the `IAppHostElement::ChildElements` property when you query the configuration for unique child elements, such as the `system.webServer/asp` configuration section. In the following configuration example, the `<cache/>` element is a child elements of the `system.webServer/asp` configuration section.  
  
```  
<system.webServer>  
    <asp>  
        <cache diskTemplateCacheDirectory="%SystemDrive%\inetpub\temp\ASP Compiled Templates" />  
    </asp>  
</system.webServer>  
```  
  
 You should use the `IAppHostElement::Collection` property when you query the configuration for child elements that contain a unique key or a multi-attribute key, such as the `system.webServer/sites` configuration section. In the following configuration example, the `<site/>` elements are collection elements and the `<applicationDefaults/>` element is a child element of the `system.applicationHost/sites` configuration section.  
  
```  
<system.applicationHost>  
    <sites>  
        <site name="Default Web Site" id="1">  
            <application path="/">  
                <virtualDirectory path="/"   
                                  physicalPath="%SystemDrive%\inetpub\wwwroot" />  
            </application>  
            <bindings>  
                <binding protocol="http" bindingInformation="*:80:" />  
            </bindings>  
        </site>  
        <site name="Microsoft.com" id="35">  
            <bindings>  
                <binding protocol="http"   
                         bindingInformation="*:80:microsoft.com" />  
            </bindings>  
        </site>  
        <siteDefaults>  
            <logFile customLogPluginClsid="{FF160663-DE82-11CF-BC0A-00AA006111E0}"   
                     directory="%SystemDrive%\inetpub\logs\LogFiles" />  
            <traceFailedRequestsLogging   
                     directory="%SystemDrive%\inetpub\logs\FailedReqLogFiles" />  
        </siteDefaults>  
        <applicationDefaults applicationPool="DefaultAppPool" />  
        <virtualDirectoryDefaults allowSubDirConfig="true" />  
    </sites>  
</system.applicationHost>  
```  
  
## Example  
 The following code example displays all the sites in the `system.webServer/sites` configuration section for the MACHINE/WEBROOT/APPHOST configuration path.  
  
<!-- TODO: review snippet reference  [!CODE [IAppHostAdminLibrary#2](IAppHostAdminLibrary#2)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostElement Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md)