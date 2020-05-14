---
title: "WorkerProcess.GetExecutingRequests Method2"
ms.date: "10/07/2016"
ms.assetid: 9eeefc8d-cb05-4481-b113-e0b623f91941
---
# WorkerProcess.GetExecutingRequests Method2
Gets the requests that are currently assigned to a worker process.  
  
## Syntax  
  
```jscript#  
objWorkerProcess.GetExecutingRequests(RequestArray);  
```  
  
```vbs  
objWorkerProcess.GetExecutingRequests RequestArray  
```  
  
### Parameters  
  
|Name|Definition|  
|----------|----------------|  
|`RequestArray`|An array to hold [HttpRequest](../wmi-provider/httprequest-class.md) objects.|  
  
## Return Value  
 This method does not return a value.  
  
## Remarks  
 This method takes an empty array as an `OUT` parameter, which it fills with `HttpRequest` objects.  
  
## Example  
 The following example gets information about the requests that are currently queued for each worker process.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the worker processes.  
Set oW3WPs = oWebAdmin.InstancesOf("WorkerProcess")  
  
For Each oW3WP In oW3WPs  
  
    ' Place the requests queued for a process into an array.  
    oW3WP.GetExecutingRequests arrReqs  
  
    ' Show the number of queued requests.  
    If IsNull(arrReqs) Then  
        WScript.Echo "No currently executing requests."  
    Else  
        ' Display the number of requests.  
        WScript.Echo "Number of currently executing requests: " & _  
            UBound(arrReqs) + 1  
        WScript.Echo  
  
        ' List the properties of each request.  
        For Each oRequest In arrReqs  
            WScript.Echo "Module: " & "[" & oRequest.CurrentModule & "]"  
            WScript.Echo "Verb:" & "[" & oRequest.Verb & "]"  
            WScript.Echo "HostName: " & "[" & oRequest.HostName & "]"  
            WScript.Echo "Url: " & "[" & oRequest.Url & "]"  
            WScript.Echo  
        Next  
    End If  
Next  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [HttpRequest Class](../wmi-provider/httprequest-class.md)
 [View Currently Executing Requests in a Worker Process](https://go.microsoft.com/fwlink/?LinkId=60429)
 [WorkerProcess Class](../wmi-provider/workerprocess-class.md)
