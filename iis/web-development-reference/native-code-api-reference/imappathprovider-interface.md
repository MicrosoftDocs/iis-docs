---
title: "IMapPathProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e4fbca50-3c9a-35c2-a23a-55c50e650886
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
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
|[GetPhysicalPath](../../web-development-reference\webdev-native-api-reference/imappathprovider-getphysicalpath-method.md)|Retrieves the physical path for the current request.|  
|[GetUrl](../../web-development-reference\webdev-native-api-reference/imappathprovider-geturl-method.md)|Retrieves the relative URL for the request.|  
|[SetErrorStatus](../../web-development-reference\webdev-native-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference\webdev-native-api-reference/ihttpeventprovider-interface.md).)|  
|[SetPhysicalPath](../../web-development-reference\webdev-native-api-reference/imappathprovider-setphysicalpath-method.md)|Sets the physical path mapping for the current request.|  
  
## Remarks  
 When a Web client requests a resource on a server running IIS, IIS maps the relative URL to a physical path for processing. For example, if a Web client requests a Web page at http://www.example.com/default.asp, the relative URL on the server is /default.asp, and the physical path might be C:\Inetpub\Wwwroot\default.asp.  
  
 The `IMapPathProvider` interface allows developers to retrieve the relative URL and physical path by using the `GetUrl` and `GetPhysicalPath` methods, or to modify the physical path by using the `SetPhysicalPath` method.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference\webdev-native-api-reference/ihttpeventprovider-interface.md)  
  
 `IMapPathProvider`  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\webdev-native-api-reference/web-server-core-interfaces.md)   
 [CHttpModule::OnMapPath Method](../../web-development-reference\webdev-native-api-reference/chttpmodule-onmappath-method.md)