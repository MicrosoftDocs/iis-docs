---
title: "HttpRequest Class"
ms.date: "10/07/2016"
ms.assetid: ed8a3b96-f70d-da12-6181-5f7a4ad734fd
---
# HttpRequest Class
Represents an HTTP request in a worker process.  
  
## Syntax  
  
```vbs  
class HttpRequest : Object  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `HttpRequest` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ClientIPAddress`|A read-only `string` value that contains the IP address of the client that made the request.|  
|`ConnectionId`|A read-only `string` value that contains a 128-bit GUID that uniquely identifies a request's connection.|  
|`CurrentModule`|A read-only `string` value that contains the name of the current module that the request is in.|  
|`HostName`|A read-only `string` value that contains the site domain name or computer name requested by the client.|  
|`GUID`|A read-only `string` value that contains a 128-bit GUID that uniquely identifies a request. The only key property.|  
|`LocalIPAddress`|A read-only `string` value that contains the IP address of the network adapter on which the request was received.|  
|`LocalPort`|A read-only `uint32` value that contains the port number on which the request was received.|  
|`PipelineState`|A read-only `uint32` value that contains the pipeline module state that the request is in. The possible values are listed in [Request-Processing Constants](../web-development-reference/native-code-api-reference/request-processing-constants.md).|  
|`SiteId`|A read-only `uint32` value that contains the site ID of the request.|  
|`TimeElapsed`|A read-only `uint32` value that contains the period of time, in milliseconds, that the request has been in process.|  
|`TimeInModule`|A read-only `uint32` value that contains the period of time, in milliseconds, that the request has been in the module in which it is currently located.|  
|`TimeInState`|A read-only `uint32` value that contains the period of time, in milliseconds, that the request has been in the current request notification.|  
|`Url`|A read-only `string` value that contains the requested URL.|  
|`Verb`|A read-only `string` value that contains the HTTP verb used in the request.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
  
## Example  
 The following example lists all the properties for each currently executing request on a Web server.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the worker processes.  
Set oW3WPs = oWebAdmin.InstancesOf("WorkerProcess")  
  
For Each oW3WP In oW3WPs  
  
    ' Get the requests queued for an individual worker process and  
    ' place them in an array.  
    oW3WP.GetExecutingRequests arrReqs  
  
    ' Show the number of requests queued.  
    If IsNull(arrReqs) Then  
                WScript.Echo "No currently executing requests."  
    Else  
  
        WScript.Echo "Number of currently executing requests: " & _  
            UBound(arrReqs) + 1  
        WScript.Echo  
  
        For Each oRequest In arrReqs  
            WScript.Echo "ClientIPAddress: " & oRequest.ClientIPAddress  
            WScript.Echo "ConnectionId: " & oRequest.ConnectionId  
            WScript.Echo "CurrentModule: " & oRequest.CurrentModule  
            WScript.Echo "GUID: "  &  oRequest.GUID  
            WScript.Echo "HostName: " & oRequest.HostName  
            WScript.Echo "LocalIPAddress: " &  oRequest.LocalIPAddress  
            WScript.Echo "LocalPort: " &  oRequest.LocalPort  
            WScript.Echo "PipelineState: " &  oRequest.PipelineState  
            WScript.Echo "Site ID: " &  oRequest.SiteID  
            WScript.Echo "TimeElapsed: " &  oRequest.TimeElapsed  
            WScript.Echo "TimeInModule: " &  oRequest.TimeInModule  
            WScript.Echo "TimeInState: " &  oRequest.TimeInState  
            WScript.Echo "Url: "  & oRequest.Url  
            WScript.Echo "Verb: " &  oRequest.Verb  
            WScript.Echo  
        Next  
    End If  
Next  
  
```  
  
## Inheritance Hierarchy  
 [Object](../wmi-provider/object-class.md)  
  
 `HttpRequest`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [Request-Processing Constants](../web-development-reference/native-code-api-reference/request-processing-constants.md)   
 [Object Class](../wmi-provider/object-class.md)   
 [View Currently Executing Requests in a Worker Process](https://go.microsoft.com/fwlink/?LinkId=60429)