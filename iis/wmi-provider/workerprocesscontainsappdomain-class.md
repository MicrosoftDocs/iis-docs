---
title: "WorkerProcessContainsAppDomain Class2"
ms.date: "10/07/2016"
ms.assetid: c7172642-0b13-5b01-450d-874b79e798d5
---
# WorkerProcessContainsAppDomain Class2
Provides a relationship between a worker process and its application domains.  
  
## Syntax  
  
```vbs  
class WorkerProcessContainsAppDomain : ObjectContainerAssociation  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `WorkerProcessContainsAppDomain` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Container`|(Inherited from [ObjectContainerAssociation](../wmi-provider/objectcontainerassociation-class.md).) A read-only [WorkerProcess](../wmi-provider/workerprocess-class.md) object that represents an IIS worker process. A key property.|  
|`Element`|(Inherited from `ObjectContainerAssociation`.) A read-only [AppDomain](../wmi-provider/appdomain-class.md) object that represents an IIS application domain. A key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This association class is useful for retrieving all the loaded application domains for each worker process on a Web server.  
  
## Example  
 The following example displays the loaded application domains on a Web server. The first part uses a WMI query. The second part uses the `WorkerProcessContainsAppDomain` association class.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get application domains on the server by using a WMI query.  
Set AppDomains = oWebAdmin.ExecQuery ("Select * from AppDomain")  
  
WScript.Echo "AppDomain Count: " & AppDomains.Count  
WScript.Echo  
For Each AppDomain In AppDomains  
    WScript.Echo "AppDomain site name: " + AppDomain.SiteName  
    WScript.Echo "AppDomain process ID: " & AppDomain.ProcessID  
    WScript.Echo "AppDomain ID: " + AppDomain.Id  
    WScript.Echo "AppDomain application path: " & _  
        AppDomain.ApplicationPath  
    WScript.Echo       
Next  
  
WScript.Echo  
  
' Get the application domains for each worker process by using  
' the WorkerProcessContainsAppDomain association.  
Set oWorkerProcesses = oWebAdmin.InstancesOf("WorkerProcess")  
  
For Each oWorkerProcess In oWorkerProcesses  
    WScript.Echo "Worker Process Process ID: " & oWorkerProcess.ProcessID  
    Set oAppDomains = _  
    oWorkerProcess.Associators_("WorkerProcessContainsAppDomain")  
  
    WScript.Echo "AppDomainCount: " & oAppDomains.Count  
    WScript.Echo  
    WScript.Echo "List of AppDomains"  
    WScript.Echo "------------------"  
    For Each oAppDomain In oAppDomains  
        WScript.Echo "Application domain process ID: " & _  
            oAppDomain.ProcessId  
        WScript.Echo "Application domain application path:" & _  
            oAppDomain.ApplicationPath  
        WScript.Echo " Application domain physical path: " & _  
            oAppDomain.PhysicalPath  
        WScript.Echo  
    Next   
Next  
```  
  
 Note the following syntax from the preceding code example.  
  
 `Set oAppDomains = _`  
  
 `oWorkerProcess.Associators_("WorkerProcessContainsAppDomain")`  
  
 To simplify your code, you can instead use the following syntax, which enables you to use the association without having to remember its exact name.  
  
 `Set oAppDomains = oWorkerProcess.Associators_(, "AppDomain")`  
  
## Inheritance Hierarchy  
 [ObjectContainerAssociation](../wmi-provider/objectcontainerassociation-class.md)  
  
 `WorkerProcessContainsAppDomain`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [AppDomain Class](../wmi-provider/appdomain-class.md)   
 [ObjectContainerAssociation Class](../wmi-provider/objectcontainerassociation-class.md)   
 [WorkerProcess Class](../wmi-provider/workerprocess-class.md)
