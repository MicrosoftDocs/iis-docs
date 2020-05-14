---
title: "GlobalizationSection Class"
ms.date: "10/07/2016"
ms.assetid: 287cc0cf-ca19-687e-ca3c-ec5a64d0a64d
---
# GlobalizationSection Class
Configures the globalization settings for a Web application.  
  
## Syntax  
  
```vbs  
class GlobalizationSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `GlobalizationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `GlobalizationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Culture`|An optional read/write `string` value that specifies the default culture for processing incoming Web requests. For valid culture strings, see the [System.Globalization.CultureInfo](https://go.microsoft.com/fwlink/?LinkId=67222) class. You can also set this property to "auto". **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`EnableBestFitResponseEncoding`|An optional read/write `boolean` value. `true` if the best-fit character encoding for a response is enabled; otherwise, `false`. The default is `false`. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`EnableClientBasedCulture`|An optional read/write `boolean` value. `true` if the `Culture` and `UICulture` properties should be based on the `AcceptLanguage` header field value that is sent by the client browser; otherwise, `false`. The default is `false`.<br /><br /> The `AcceptLanguage` header specifies the language that a given browser prefers. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`FileEncoding`|An optional read/write `string` value that specifies the default encoding for .aspx, .asmx, and .asax file parsing. Unicode and UTF-8 files that are saved with the byte order mark prefix are automatically recognized, regardless of the value of this property. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`RequestEncoding`|An optional read/write `string` value that specifies the assumed encoding of each incoming request, including posted data and the query string. The default is "UTF-8".<br /><br /> If the request includes a request header that contains an `Accept-Charset` attribute, it overrides this property value in the configuration. **Note:**  The default encoding is specified in the globalization section of the Machine.config file that was created when the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] was installed. If response encoding is not specified in a Machine.config or Web.config file, encoding is set to the default Regional Options locale for the computer. This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`ResourceProviderFactoryType`|An optional read/write `string` value that specifies the factory type of the resource provider.|  
|`ResponseEncoding`|An optional read/write `string` value that specifies the content encoding of responses. The default is "UTF-8". **Note:**  The default encoding is specified in the globalization section of the Machine.config file that was created when the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] was installed. If response encoding is not specified in a Machine.config or Web.config file, encoding is set to the default Regional Options locale for the computer. This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`ResponseHeaderEncoding`|An optional read/write `string` value that specifies the header encoding of HTTP responses. The default is "UTF-8". **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`UICulture`|An optional read/write `string` value that specifies the default culture for processing locale-dependent resource searches. For valid culture strings, see the [System.Globalization.CultureInfo](https://go.microsoft.com/fwlink/?LinkId=67222) class. You can also set this property to "auto". **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `GlobalizationSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Globalization.CultureInfo Class](https://go.microsoft.com/fwlink/?LinkId=67222)
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)
 [globalization Element (ASP.NET Settings Schema)](https://go.microsoft.com/fwlink/?LinkId=69316)
 [System.Web.Configuration.GlobalizationSection Properties](https://go.microsoft.com/fwlink/?LinkId=69317)
