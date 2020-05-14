---
title: "AnonymousIdentificationSection Class1"
ms.date: "10/07/2016"
ms.assetid: 2dfffff0-93df-8dbd-4d01-36f83e72ca5b
---
# AnonymousIdentificationSection Class1
Specifies how cookies are used in a Web application.  
  
## Syntax  
  
```vbs  
class AnonymousIdentificationSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `AnonymousIdentificationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `AnonymousIdentificationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Cookieless`|A read/write `sint32` enumeration that specifies whether to use cookies for a Web application. The possible values are listed later in the Remarks section.|  
|`CookieName`|A read/write `string` value that specifies the name that is assigned to the cookie. The default is ".ASPXANONYMOUS".|  
|`CookiePath`|A read/write `string` value that specifies the path to the directory where the cookie is stored. The default is the root directory, specified by "/".|  
|`CookieProtection`|A read/write `sint32` enumeration that specifies the cookie protection scheme. The possible values are listed later in the Remarks section.|  
|`CookieRequireSSL`|A read/write `boolean` value. `true` if the cookie requires a Secure Sockets Layer (SSL) connection when it is transmitted to the client; otherwise, `false`. The default is `false`.<br /><br /> When the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] `Secure` authentication cookie property is set, the cookie is returned by the client only if an SSL connection is in use.|  
|`CookieSlidingExpiration`|A required read/write `boolean` value. `true` if the cookie expiration is initially set to the current date and time plus the value in minutes in the `CookieTimeout` property; otherwise, `false`. The default is `true`.<br /><br /> If `true`, the expiration date and time of the cookie will be automatically refreshed if less than half of the value in `CookieTimeout` remains and the user is still actively using the application. If `false`, the cookie automatically times out after the interval specified in the `CookieTimeout` property has passed. For more information, see the [System.Web.HttpCookie.Expires property](/dotnet/api/system.web.httpcookie.expires).|  
|`CookieTimeout`|A required read/write `datetime` value that specifies the cookie expiration time interval. The default is 69 days, 10 hours, and 40 minutes, which is equivalent to 10000 minutes.|  
|`Domain`|A read/write `string` value that specifies the cookie domain. The default is an empty string ("").<br /><br /> This property allows sharing of the anonymous identification cookie across domains that have a common Domain Name System (DNS) namespace (for example, all sites that end in "contoso.com"). To share anonymous identification cookies, the sites must share common decryption and validation keys. Other anonymous identification configuration attributes, such as cookie path and cookie name, must be the same for all the sites. For more information, see the [System.Web.HttpCookie class](/dotnet/api/system.web.httpcookie).|  
|`Enabled`|An optional read/write `boolean` value. `true` if anonymous identification is enabled; otherwise, `false`. If `true`, a cookie (or cookieless value) is used to manage the user's anonymous identifier. The default is `false`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The following table lists the possible values for the `Cookieless` property. The default is 1 (`UseCookies`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`UseUri`|Specifies that the calling feature uses the query string to store an identifier, regardless of whether the browser or device supports cookies.|  
|1|`UseCookies`|Specifies that cookies are used to persist user data, regardless of whether the browser or device supports cookies.|  
|2|`AutoDetect`|Specifies that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] determines whether the requesting browser or device supports cookies. If the requesting browser or device supports cookies, `AutoDetect` uses cookies to persist user data; otherwise, an identifier is used in the query string. If the browser or device supports the cookies, but cookies are currently disabled, the requesting feature still uses cookies.|  
|3|`UseDeviceProfile`|Specifies that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] determines whether to use cookies based on the [System.Web.Configuration.HttpCapabilitiesBase.Cookies property](/dotnet/api/system.web.configuration.httpcapabilitiesbase.cookies). If the setting indicates that the browser or device supports cookies, cookies are used; otherwise, an identifier is used in the query string.|  
  
 The following table lists the possible values for the `CookieProtection` property. The default is 1 (`Validation`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`None`|Specifies that the cookie information is not protected. Information in the cookie is stored in clear text and is not validated when the information is sent back to the server.|  
|1|`Validation`|Ensures that the information in the cookie has not been altered before the information is sent back to the server.|  
|2|`Encryption`|Encrypts the information in the cookie.|  
|3|`All`|Specifies that both the `Validation` and `Encryption` values are used to protect the information in the cookie.|  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `AnonymousIdentificationSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Configuration.SystemWebSectionGroup.AnonymousIdentification](/dotnet/api/system.web.configuration.systemwebsectiongroup.anonymousidentification)
 System.Web.HttpCookie.Expires  
 System.Web.HttpCookie.Secure  
 System.Web.HttpCookie
 System.Web.HttpCookieMode
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)
