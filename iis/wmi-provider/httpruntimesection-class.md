---
title: "HttpRuntimeSection Class"
ms.date: "10/07/2016"
ms.assetid: de71149d-7086-8952-f32a-9a233d9991ec
---
# HttpRuntimeSection Class

Configures [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] HTTP run-time settings that determine how a request is processed for a given [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application.  

## Syntax  

```vbs  
class HttpRuntimeSection : ConfigurationSection  
```  

## Methods  

The following table lists the methods exposed by the `HttpRuntimeSection` class.  

|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  

## Properties  

The following table lists the properties exposed by the `HttpRuntimeSection` class.  

|Name|Description|  
|----------|-----------------|  
|`ApartmentThreading`|An optional read/write `boolean` value. `true` if apartment threading is enabled for classic ASP compatibility; otherwise, `false`. The default is `false`. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`AppRequestQueueLimit`|An optional read/write `sint32` value that specifies the maximum number of requests that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] queues for the application. The default is 5000. **Note:**  For the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] versions 1.0 and 1.1, the default is 100. <br /><br /> When there are not enough free threads to process a request, the requests are queued. When the number of requests in the queue exceeds the limit that is specified in this property, incoming requests are rejected with the error "503 - Server Too Busy".|  
|`DelayNotificationTimeout`|An optional read/write `datetime` value that specifies the time-out for delaying notifications. The default is 5 seconds. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`Enable`|An optional read/write `boolean` value. `true` if the application domain (AppDomain) is enabled to accept incoming requests at the current and child node levels; otherwise, `false`. The default is `true`. If `false`, the application is effectively turned off.|  
|`EnableHeaderChecking`|An optional read/write `boolean` value. `true` if [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] should check the request header for potential injection attacks; otherwise, `false`. The default is `true`. If an attack is detected, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] responds with an error. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`EnableKernelOutputCache`|An optional read/write `boolean` value. `true` if output caching is enabled; otherwise, `false`. The default is `true`.<br /><br /> This attribute is relevant only when IIS 6.0 or 7.0 is installed. The output caching configuration and type of request determines whether content can be cached.<br /><br /> To cache a response, you must ensure that the following criteria are met:<br /><br /> -   Caching must be explicitly enabled by a page directive or by using the caching API.<br />-   Caching must have an expiration policy so that the kernel recognizes when to discard the response.<br />-   Caching does not have any variable headers or parameters.<br />-   Authentication is not required.|  
|`EnableVersionHeader`|An optional read/write `boolean` value. `true` if [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] should output a version header; otherwise, `false`. The default is `true`.<br /><br /> [!INCLUDE[vsprvslong](../wmi-provider/includes/vsprvslong-md.md)] uses this property to determine which version of [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] is in use. This property is not necessary for production sites and can be disabled.|  
|`ExecutionTimeout`|An optional read/write `datetime` value that specifies the maximum time that a request is allowed to execute before [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] automatically stops it. The default is 1 minute, 50 seconds.<br /><br /> This time-out applies only if the `Debug` property in the [CompilationSection](../wmi-provider/compilationsection-class.md) class is `false`. To avoid shutting down the application while you are debugging, do not set this time-out to a large value.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`MaxRequestLength`|An optional read/write `sint32` value that specifies the limit, in kilobytes, for the input stream buffering threshold. The default is 4096 (4 MB).<br /><br /> You can use this limit to prevent denial of service attacks that are caused, for example, by users posting large files to the server.|  
|`MaxWaitChangeNotification`|An optional read/write `sint32` value that specifies the maximum time, in seconds, to wait after the first file change notification before the application domain restarts for a new request. The default is 0.<br /><br /> Set this property to a number that is greater than the length of time to complete any file copy processes. File change notifications are combined based on the value of this property and the `WaitChangeNotification` property. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`MinFreeThreads`|An optional read/write `sint32` value that specifies the minimum number of threads that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] keeps available for requests that require additional threads to complete processing. The default is 8.|  
|`MinLocalRequestFreeThreads`|An optional read/write `sint32` value that specifies the minimum number of threads that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] keeps available for local requests that require additional threads to complete processing. The default is 4. **Note:**  The specified number of threads is reserved for requests that come from the local host, in case some of these requests issue child requests during processing. This helps to prevent a possible deadlock with recursive reentry into the Web server.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`RequestLengthDiskThreshold`|An optional read/write `sint32` value that specifies, in bytes, the limit for the input stream buffering threshold. The default is 256.<br /><br /> This value should not exceed the value in the `MaxRequestLength` property. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`RequireRootedSaveAsPath`|An optional read/write `boolean` value. `true` if the `filename` parameter in a `SaveAs` method must be an absolute path; otherwise, `false`. The default is `true`.<br /><br /> The [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] process must have permission to create files in the specified location. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`SendCacheControlHeader`|An optional read/write `boolean` value. `true` if a cache control header that is set to Private is sent by default; otherwise, `false`. If `true`, client-side caching is disabled. The default is `true`. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`ShutdownTimeout`|An optional read/write `datetime` value that specifies the time that is allowed for a worker process to shut down. The default is 1 minute, 30 seconds.<br /><br /> When the time-out expires, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] shuts down the worker process. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`UseFullyQualifiedRedirectUrl`|An optional read/write `boolean` value. `true` if client-side redirects are fully qualified; otherwise, `false`. The default is `false`.<br /><br /> To fully qualify client-side redirects, use the format `http://server/path`. This format is required for some mobile controls. If `true`, all redirects that are not fully qualified are automatically converted to a fully qualified format. If `false`, relative redirects are sent to the client. **Note:**  If `false`, some browsers might encounter issues when loading pages that are in cookieless sessions.|  
|`WaitChangeNotification`|An optional read/write `sint32` value that specifies the time, in seconds, to wait for another file change notification before the application domain restarts. The default is 0.<br /><br /> Set this attribute to a number that is greater than the time between the updates of two file copy change notifications. File change notifications are combined based on the value of this property and the `MaxWaitChangeNotification` property. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  

## Subclasses  

This class contains no subclasses.  

## Inheritance Hierarchy

 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `HttpRuntimeSection`  

## Requirements  

|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  

## See Also  

 [System.Web.Configuration.SystemWebSectionGroup.HttpRuntime](/dotnet/api/system.web.configuration.systemwebsectiongroup.httpruntime)  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [CompilationSection Class](../wmi-provider/compilationsection-class.md)   
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)