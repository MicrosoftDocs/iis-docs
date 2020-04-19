---
title: "IAppHostElement::Collection Property"
ms.date: "10/07/2016"
ms.assetid: 520835fe-cff6-7dbd-5154-a827a983b734
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
  
### Parameters  
 `ppCollection`  
 A pointer to a pointer for an [IAppHostElementCollection](../../web-development-reference/native-code-api-reference/iapphostelementcollection-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 A child element collection that is represented in the [IAppHostElement::ChildElements](../../web-development-reference/native-code-api-reference/iapphostelement-childelements-property.md) property differs from a nested element collection that is represented in the `IAppHostElement::Collection` property. Both collections contain pointers to [IAppHostElement](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) objects. However, you should use the `IAppHostElement::ChildElements` property when you query the configuration for unique child elements, such as the `system.webServer/asp` configuration section. In the following configuration example, the `<cache/>` element is a child elements of the `system.webServer/asp` configuration section.  
  
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
  
 [!code-cpp[IAppHostAdminLibrary#2](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostElementGetCollection.cpp#2)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostElement Interface](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md)