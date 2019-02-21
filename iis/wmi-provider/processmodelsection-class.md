---
title: "ProcessModelSection Class"
ms.date: "10/07/2016"
ms.assetid: 84b9d2ef-bd3c-0271-4786-4eba0c08ef62
---
# ProcessModelSection Class
Configures the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] process model settings on a Web server that is running IIS.  
  
## Syntax  
  
```vbs  
class ProcessModelSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `ProcessModelSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `ProcessModelSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AutoConfig`|A read/write `boolean` value. `true` if [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] automatically configures certain attributes to achieve optimal performance that is based on the computer configuration; `false` if [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses the explicitly defined values for the attributes. The default is `false`. The configured attributes are listed later in the Remarks section. **Note:**  These attributes affect only [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications, not the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] client applications. **Note:**  The default for this property in the Machine.config file is `true`, which will override settings in lower configuration files. If you remove the `autoConfig` entry from Machine.config, the default will revert to `false`.|  
|`ClientConnectedCheck`|A read/write `datetime` value that specifies how long a request is left in the queue before [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] does a check to determine whether the client is connected. The default is 5 seconds.|  
|`ComAuthenticationLevel`|A read/write `sint32` value that specifies the level of authentication for DCOM security. The possible values are listed later in the Remarks section.|  
|`ComImpersonationLevel`|A read/write `sint32` value that specifies the authentication level for COM security. The possible values are listed later in the Remarks section.|  
|`CpuMask`|A read/write `sint32` value that specifies which processors (CPUs) on a multiprocessor server are qualified to run [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] processes. The default is 0xffffffff.<br /><br /> This value specifies a bit pattern that indicates the CPUs that are qualified to run [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] threads. For example, the hexadecimal value 0x0d represents the bit pattern 1101. On a computer that has four CPUs, this indicates that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] processes can be scheduled on CPUs 0, 2, and 3, but not on CPU 1. [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] starts one worker process for each qualified CPU. If the `WebGarden` property is `true`, `CpuMask` limits worker processes to the number of qualified CPUs. The maximum number of worker processes is equal to the number of CPUs. If the `WebGarden` property is `false` (the default value), `CpuMask` is ignored and only one worker process will run.|  
|`Enable`|A read/write `boolean` value. `true` if the process model is enabled; otherwise, `false`. The default is `true`.|  
|`IdleTimeout`|A read/write `datetime` value that specifies the period of inactivity after which [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] automatically ends the worker process. The default is infinite.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`LogLevel`|A read/write `sint32` value that specifies event types to write to the event log. The possible values are listed later in the Remarks section.|  
|`MaxAppDomains`|A read/write `sint32` value that specifies the maximum number of application domains that are allowed in one process. This attribute must be less than or equal to 2000. The default is 2000.|  
|`MaxIOThreads`|A read/write `sint32` value that specifies the maximum number of I/O threads (from 5 through 100) to use for the process on a per-CPU basis. The default is 20.<br /><br /> For example, if this value is 25 on a single-processor server, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] sets the process limit to 25. On a two-processor server, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] sets the limit to 50. The value of this property must be equal to or greater than the `MinFreeThread` property of the [HttpRuntimeSection](../wmi-provider/httpruntimesection-class.md) class.|  
|`MaxWorkerThreads`|A read/write `sint32` value that specifies the maximum number of worker threads (from 5 through 100) to use for the process on a per-CPU basis. The default is 20.<br /><br /> For example, if this value is 25 on a single-processor server, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses the runtime APIs to set the process limit to 25. On a two-processor server, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] sets the limit to 50. The value of this property must be equal to or greater than the `MinFreeThread` property of the `HttpRuntimeSection` class.|  
|`MemoryLimit`|A read/write `sint32` value that specifies the maximum allowed memory size, as a percentage of total system memory, that the worker process can consume before [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] starts a new process and reassigns existing requests. The default is 60.|  
|`MinIOThreads`|A read/write `sint32` value that specifies the minimum number of I/O threads to use for the process on a per-CPU basis. The default is 1.|  
|`MinWorkerThreads`|A read/write `sint32` value that specifies the maximum number of worker threads to use for the process on a per-CPU basis. The default is 1.|  
|`Password`|A read/write `string` value (if present) that causes, together with the `UserName` property, the worker process to run with the configured Microsoft Windows identity. The default is "AutoGenerate". **Note:**  See the `UserName` property for more information about the special names "System" and "Machine", which do not require a password, and for information about storing encrypted worker process credentials in the registry.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`PingFrequency`|A read/write `datetime` value that specifies the time interval at which the ISAPI extension pings the worker process to determine whether the process is running. The default is infinite.<br /><br /> If the worker process does not respond in the interval specified by the `PingTimeout` property, it is restarted.|  
|`PingTimeout`|A read/write `datetime` value that specifies the time interval after which a worker process that has stopped responding is restarted. The default is infinite.<br /><br /> The ISAPI extensions ping the worker process at the interval specified by the `PingFrequency` property. If the worker process does not respond in the interval specified by the `PingTimeout` property, it is restarted.|  
|`RequestLimit`|A read/write `sint32` value that specifies the number of requests that are allowed before [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] automatically starts a new worker process to take the place of the current one. The default is 2147483647.|  
|`RequestQueueLimit`|A read/write `sint32` value that specifies the number of requests that are allowed in the queue before [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] returns the message "503 – Server Too Busy" to new requests. The default is 5000.|  
|`ResponseDeadlockInterval`|A read/write `datetime` value that specifies the time interval after which the process is restarted if there are queued requests and there has not been a response during the specified interval. The default is 3 minutes.|  
|`ResponseRestartDeadlockInterval`|A read/write `datetime` value, provided for backward compatibility, that specifies the time interval after which the process is restarted if there are queued requests and there has not been a response during the specified interval. The default is 3 minutes. **Note:**  [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] no longer uses this property; it is provided for backward compatibility only. This property will not cause a configuration error if it is already present in a configuration file. The `ResponseDeadlockInterval` property now controls the restarting of deadlocked processes.|  
|`RestartQueueLimit`|A read/write `sint32` value that specifies the maximum number of requests that IIS queues while it waits for the worker process to restart after a nonstandard termination. This setting does not apply to a clean shutdown or standard restart. The default is 10.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`ServerErrorMessageFile`|A read/write `string` value that specifies the contents of a file to use instead of the default message "Server Unavailable" if a server unexpectedly stops responding. The file location is relative to the Machine.config file, or it can be an absolute path. If you do not specify this property value, IIS uses the default message "Server Unavailable".|  
|`ShutdownTimeout`|A read/write `datetime` value that specifies the amount of time that is allowed for the worker process to shut down. The default is 5 seconds. When the time-out expires, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] shuts down the worker process.|  
|`Timeout`|A read/write `datetime` value that specifies the number of minutes until [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] starts a new worker process to take the place of the current one. The default is infinite.|  
|`UserName`|A read/write `string` value that specifies that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] will run the worker process with a Windows identity that differs from the default process identity. The default is "Machine". By default, the process runs under a user account and password that are created automatically when [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] is installed. The user account is named ASPNET, and the password is cryptographically generated.<br /><br /> If valid credentials are presented in both the `UserName` and `Password` properties, the process is run with the given account. If the `UserName` value is "System" and the `Password` value is "AutoGenerate", the process runs with full administrative permissions for all [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] code that uses the process. **Note:**  The values of this property and the `Password` property are stored in clear text in the configuration file. Although IIS does not transmit .config files in response to a user agent request, configuration files can be read in other ways. For example, an authenticated user who has the required credentials on the domain for the server can read a configuration file. For security reasons, the `ProcessModelSection` class supports storage of encrypted `UserName` and `Password` properties in the registry. For more information, see [processModel Element (ASP.NET Settings Schema)](http://go.microsoft.com/fwlink/?LinkId=62307).|  
|`WebGarden`|A read/write `boolean` value. `true` if the `CpuMask` property is used to specify which CPUs are qualified to run [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] processes; `false` if only one worker process is run and CPU usage is scheduled by the Windows operating system. The default is `false`. **Note:**  A multiprocessor Web server is called a Web garden.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The `<processModel>` section can be set only in the Machine.config file and affects all [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications that are running on the server.  
  
> [!NOTE]
>  Changes to the `ProcessModelSection` class take effect only when the worker process is restarted, not immediately after the setting is changed.  
  
 The following table lists the attributes that are automatically configured when the `AutoConfig` property is `true`. For more information, see article 821268, "Contention, poor performance, and deadlocks when you make Web service requests from ASP.NET applications," in the Microsoft Knowledge Base at http://support.microsoft.com.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`maxWorkerThreads`|Specifies the maximum number of worker threads per CPU that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses.|  
|`maxIoThreads`|Specifies the maximum number of completion threads per CPU that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] uses.|  
|`minFreeThreads`|Corresponds to the `MinFreeThreads` property of the [HttpRuntimeSection](../wmi-provider/httpruntimesection-class.md) class.|  
|`minLocalRequestFreeThreads`|Corresponds to the `MinLocalRequestFreeThreads` property of the `HttpRuntimeSection` class.|  
|`maxConnection`|Corresponds to the `MaxConnection` property of the [ConnectionManagementElement](../wmi-provider/connectionmanagementelement-class.md) class.|  
  
 The following table lists the possible values for the `ComAuthenticationLevel` property. The default is 2 (`Connect`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`None`|Specifies no authentication.|  
|1|`Call`|Specifies that DCOM authenticates the credentials of the client when the server receives the request at the beginning of each remote procedure call.|  
|2|`Connect`|Specifies that DCOM authenticates the credentials of the client only when the client establishes a connection to the server.|  
|3|`Default`|Specifies that DCOM determines the authentication level by using its standard security negotiation algorithm.|  
|4|`Pkt`|Specifies that DCOM authenticates that all data received is from the expected client. Datagram transports always use `Pkt` authentication.|  
|5|`PktIntegrity`|Specifies that DCOM authenticates and verifies that none of the data that is transferred between the client and the server is modified.|  
|6|`PktPrivacy`|Specifies that DCOM authenticates all previous levels and encrypts the argument value of each remote procedure call.|  
  
 The following table lists the possible values for the `ComImpersonationLevel` property. The default is 4 (`Impersonate`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Default`|Specifies that DCOM determines the impersonation level by using its standard security negotiation algorithm.|  
|1|`Anonymous`|Specifies that the client is anonymous to the server. The server can impersonate the client, but the impersonation token will not contain any information. `Anonymous` is not supported in the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] version 1.1.|  
|2|`Delegate`|Specifies that the server process can impersonate the security context for the client when the server acts on behalf of the client. The server process can also use cloaking to make outgoing calls to other servers when the server acts on behalf of the client. The server can use the security context for the client on other computers to gain access to local and remote resources as the client. When the server is impersonating at this level, the impersonation token can be passed across any number of computer boundaries.|  
|3|`Identify`|Specifies that the server can obtain the identity for the client. The server can impersonate the client for access control list (ACL) checking, but it cannot access system objects as the client.|  
|4|`Impersonate`|Specifies that the server process can impersonate the security context for the client when the server acts on behalf of the client. The server can use this level of impersonation to access local resources, such as files. When the server is impersonating at this level, the impersonation token can be passed across only one computer boundary.|  
  
 The following table lists the possible values for the `LogLevel` property. The default is 2 (`Errors`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`None`|Specifies that no events are logged.|  
|1|`All`|Specifies that all process events are logged.|  
|2|`Errors`|Specifies that only unexpected shutdowns, memory limit shutdowns, and deadlock shutdowns are logged.|  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `ProcessModelSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [processModel Element (ASP.NET Settings Schema)](http://go.microsoft.com/fwlink/?LinkId=62307)   
 [CIM_DATETIME](http://go.microsoft.com/fwlink/?LinkId=57551)