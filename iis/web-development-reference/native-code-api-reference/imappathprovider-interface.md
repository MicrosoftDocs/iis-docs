---
title: "IMapPathProvider Interface"
description: Learn how the IMapPathProvider interface retrieves information about a path that is being physically mapped.
ms.date: "10/07/2016"
ms.assetid: e4fbca50-3c9a-35c2-a23a-55c50e650886
---
# IMapPathProvider Interface
Retrieves information about a path that is being physically mapped.  
  
## Syntax  
  
```cpp  
class IMapPathProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IMapPathProvider` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetPhysicalPath](../../web-development-reference/native-code-api-reference/imappathprovider-getphysicalpath-method.md)|Retrieves the physical path for the current request.|  
|[GetUrl](../../web-development-reference/native-code-api-reference/imappathprovider-geturl-method.md)|Retrieves the relative URL for the request.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
|[SetPhysicalPath](../../web-development-reference/native-code-api-reference/imappathprovider-setphysicalpath-method.md)|Sets the physical path mapping for the current request.|  
  
## Remarks  
 When a Web client requests a resource on a server running IIS, IIS maps the relative URL to a physical path for processing. For example, if a Web client requests a Web page at http://www.example.com/default.asp, the relative URL on the server is /default.asp, and the physical path might be C:\Inetpub\Wwwroot\default.asp.  
  
 The `IMapPathProvider` interface allows developers to retrieve the relative URL and physical path by using the `GetUrl` and `GetPhysicalPath` methods, or to modify the physical path by using the `SetPhysicalPath` method.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IMapPathProvider`  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [CHttpModule::OnMapPath Method](../../web-development-reference/native-code-api-reference/chttpmodule-onmappath-method.md)
