---
title: "ApplicationPool Class1"
ms.date: "10/07/2016"
ms.assetid: 73b72766-1004-e849-25e6-6984a483a6bb
---
# ApplicationPool Class1

Represents an IIS application pool.  
  
## Syntax  
  
```vbs  
class ApplicationPool : Object  
```  
  
## Methods  

 The following table lists the methods exposed by the `ApplicationPool` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Create](../wmi-provider/applicationpool-create-method.md)|Creates an application pool.|  
|[GetState](../wmi-provider/applicationpool-getstate-method.md)|Returns the run-time state of an application pool.|  
|[Recycle](../wmi-provider/applicationpool-recycle-method.md)|Recycles an application pool.|  
|[RevertToParent](../wmi-provider/applicationpool-reverttoparent-method.md)|Reverts an application pool's configuration value or values to those of its parent application pool.|  
|[Start](../wmi-provider/applicationpool-start-method.md)|Starts an application pool.|  
|[Stop](../wmi-provider/applicationpool-stop-method.md)|Stops an application pool.|  
  
## Properties  

 The following table lists the properties exposed by the `ApplicationPool` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AutoStart`|A read/write `boolean` value. `true` if the World Wide Web Publishing Service (WWW service) will start the application pool automatically either when the application pool is created or when IIS is started; otherwise, `false`. The default is `true`.|  
|`Cpu`|An [ApplicationPoolProcessorSettings](../wmi-provider/applicationpoolprocessorsettings-class.md) object that contains the CPU settings for an application pool.|  
|`Enable32BitAppOnWin64`|A read/write `boolean` value. `true` if 32-bit applications (both managed and native) can run on 64-bit versions of Windows; otherwise, `false`. The default is `false`.|  
|`Failure`|An [ApplicationPoolFailureSettings](../wmi-provider/applicationpoolfailuresettings-class.md) object that defines the properties that determine the actions to be taken when an application pool or worker process fails.|  
|`ManagedPipelineMode`|A read/write `sint32` value that indicates the managed pipeline mode. The possible values are listed in the Remarks section.|  
|`ManagedRuntimeVersion`|A read/write `string` value that contains the version of the common language runtime (CLR) that the application pool preloads. The default is "v2.0". If the property is written to, IIS recycles the application pool and loads the newly specified [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] version for it.|  
|`Name`|A read-only `string` value that contains the unique name of the application pool. The key property. The maximum length is 64 characters. Spaces and periods are permitted, but the following characters cannot be used:<br /><br /> & / \ : * ? &#124; " \< > [ ] + = ; , @|  
|`PassAnonymousToken`|A read/write `boolean` value. `true` if the Windows Process Activation Service (WAS) creates and passes a token for the built-in IUSR anonymous user account to the Anonymous authentication module; otherwise, `false`. The default is `true`.<br /><br /> The Anonymous authentication module uses the token to impersonate the built-in account. When `PassAnonymousToken` is `false,` the token will not be passed. **Note:**  The IUSR anonymous user account replaces the IIS_MachineName anonymous account. The IUSR account can be used by IIS or other applications. It does not have any privileges assigned to it during setup.|  
|`ProcessModel`|A [ProcessModelSettings](../wmi-provider/processmodelsettings-class.md) object that defines the configuration settings for IIS worker processes.|  
|`QueueLength`|A read/write `uint32` value that indicates the number of requests that HTTP.sys will queue for an application pool before rejecting further requests. The default is 1000. When the limit is exceeded, HTTP.sys rejects additional requests with a 503 (service unavailable) error.|  
|`Recycling`|A [RecyclingSettings](../wmi-provider/recyclingsettings-class.md) object that defines the recycling configuration settings for application pools and worker processes.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 An application pool is a group of one or more URLs that are served by a worker process or a set of worker processes. Application pools set boundaries for the applications they contain, which means that any applications that are running outside a specified application pool cannot affect the applications within that application pool.  
  
 If a managed application runs in an application pool with Integrated mode, the server will use the integrated request-processing pipelines of IIS and [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] to process the request. However, if a managed application runs in an application pool with ISAPI mode, the server will continue to route requests for managed code through Aspnet_isapi.dll and process requests as if they were running in IIS 6.0.  
  
 Most managed applications should run successfully in application pools with Integrated mode, but you may have to run applications in ISAPI mode for compatibility reasons. Test the applications in Integrated mode first to determine whether you really need ISAPI mode.  
  
 The following table lists the possible values for the `ManagedPipelineMode` property. The default is 0 (`Integrated`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Integrated`|The managed pipeline runs in Integrated mode.|  
|1|`Classic`|The managed pipeline runs in ISAPI mode.|  
  
## Example  

 The following example displays the name and mode (Integrated or ISAPI) of the application pools on a server.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Retrieve the application pools on the server.   
Set oAppPools = oWebAdmin.ExecQuery("SELECT * FROM ApplicationPool")  
  
For Each oAppPool In oAppPools  
    WScript.Echo "--------------------------------------"  
    WScript.Echo "Application pool name:    " & oAppPool.Name  
  
    If oAppPool.ManagedPipelineMode = 0 Then  
        sAppPoolMode = "Integrated"  
    ElseIf oAppPool.ManagedPipelineMode = 1 Then  
        sAppPoolMode = "ISAPI"  
    End if  
  
    WScript.Echo "Application pool mode:    " & sAppPoolMode  
Next  
```  
  
## Inheritance Hierarchy  

 [Object](../wmi-provider/object-class.md)  
  
 `Application Pool`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [Object Class](../wmi-provider/object-class.md)   
 [Configuring Application Pools in IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=64323)
