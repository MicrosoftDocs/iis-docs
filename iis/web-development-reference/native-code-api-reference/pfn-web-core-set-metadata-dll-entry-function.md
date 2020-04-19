---
title: "PFN_WEB_CORE_SET_METADATA_DLL_ENTRY Function"
ms.date: "10/07/2016"
ms.assetid: 378b9c64-303b-4c09-a3e5-48507650192e
---
# PFN_WEB_CORE_SET_METADATA_DLL_ENTRY Function
Sets metadata options for a web core activation.  
  
## Syntax  
  
```cpp  
typedef HRESULT(   * PFN_WEB_CORE_SET_METADATA_DLL_ENTRY)(  
   IN PCWSTR pszMetadataType,  
   IN PCWSTR pszValue  
);  
```  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|pszMetadataType|The data type for the metadata.|  
|pszValue|The option value.|  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_SERVICE_ALREADY_RUNNING|Indicates that an instance of the Hosted Web Core is already running in the process.|  
|ERROR_NOT_SUPPORTED|Indicates that the metadata being set is not supported|  
|ERROR_INVALID_DATA|Indicates that a configuration error occurred in the configuration file.|  
  
> [!NOTE]
>  If the `PFN_WEB_CORE_ACTIVATE` function returns an ERROR_INVALID_DATA message, the Event Viewer may contain additional details regarding the cause of the failure.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Hwebcore.h|