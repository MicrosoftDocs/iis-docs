---
title: "IFtpProviderConstruct Interface | Microsoft Docs"
ms.custom: ""
ms.date: "09/06/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f4c8f1c8-f28e-4907-832d-05cccef42c0a
caps.latest.revision: 8
author: "shirhatti"
ms.author: "robmcm"
manager: "wpickett"
---
# IFtpProviderConstruct Interface
Provides an interface for passing configuration settings to a provider.  
  
## Syntax  
  
```cpp#  
interface IFtpProviderConstruct : IUknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IFtpRoleProvider` interface.  
  
|||  
|-|-|  
|Name|Definition|  
|[IFtpProviderConstruct::Construct Method](../../ftp-extenisibility-reference\native-code-api-reference\iftpproviderconstruct-construct-method.md)|Retrieves an array of key/value pairs from an FTP provider's configuration settings in the IIS ApplicationHost.config file.|  
  
## Remarks  
 You can specify parameters for an FTP provider in the IIS ApplicationHost.config file by adding an <`activation`> collection, which may contain a series of <`providerData`> elements that list additional settings for custom FTP providers. Each <`providerData`> element is paired with an entry in the <`providerDefinitions`> collection, and contains a series of key/value pairs that contain information that is specific to each provider.  
  
 The following configuration excerpt illustrates a custom FTP provider entry in the ApplicationHost.config file and its related information.  
  
```  
<system.ftpServer>  
   <providerDefinitions>  
      <add name="FtpDemo"  
         clsid="FtpDemo.DemoProvider" />  
      <activation>  
         <providerData name="FtpDemo">  
            <add key="one" value="1" />  
            <add key="two" value="2" />  
         </providerData>  
      </activation>  
   </providerDefinitions>  
</system.ftpServer>  
```  
  
## Example  
 The following code example iterates through the array of configuration settings and sends the key/value pairs to the debug stream.  
  
```  
public:  
   STDMETHOD(Construct)(SAFEARRAY * configurationEntries)  
   {  
      CONFIGURATION_ENTRY * pArray;  
      HRESULT hr = S_OK;  
      LONG lLbound = 0;  
      LONG lUbound = 0;  
  
      OutputDebugString(L"IFtpProviderConstruct::Construct\n");  
  
      // Retrieve the upper and lower bounds for the configuration array.  
      SafeArrayGetLBound( configurationEntries, 1, &lLbound );  
      SafeArrayGetUBound( configurationEntries, 1, &lUbound );  
  
      // Retrieve a pointer to the array of configuration settings.  
      hr = SafeArrayAccessData(configurationEntries, (void**)&pArray);  
      // Return an error if a failure occurs.  
      if (FAILED(hr))  
      {  
         return hr;  
      }  
  
      // Loop through the array of configuration setttings and  
      // output the key/value pairs to the debug channel.  
      for(LONG Index = lLbound; Index <= lUbound; Index ++)  
      {  
         OutputDebugString(pArray[Index].bstrKey);  
         OutputDebugString(pArray[Index].bstrValue);  
      }  
  
      // Release the pointer to the array of configuration settings.  
      hr = SafeArrayUnaccessData(configurationEntries);  
      // Return an error if a failure occurs.  
      if (FAILED(hr))  
      {  
         return hr;  
      }  
  
      return S_OK;  
   }  
```  
  
## Requirements  
  
|||  
|-|-|  
|Type|Description|  
|Client|-   IIS 7.5 on                                          Windows 7<br />-   IIS 8.0 on                                          Windows 8<br />-   IIS 10.0 on                                          Windows 10|  
|Server|-   IIS 7.5 on                                          Windows Server 2008 R2<br />-   IIS 8.0 on                                          Windows Server 2012<br />-   IIS 8.5 on                                          Windows Server 2012 R2<br />-   IIS 10.0 on                                          Windows Server 2016|  
|Product|-   IIS 7.0,                                          IIS 7.5,                                          IIS 8.0,                                          IIS 8.5,                                          IIS 10.0|  
|Reference|ftpext.tlb|