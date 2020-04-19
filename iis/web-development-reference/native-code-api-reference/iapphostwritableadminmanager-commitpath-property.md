---
title: "IAppHostWritableAdminManager::CommitPath Property"
ms.date: "10/07/2016"
ms.assetid: f712b0e8-f424-93b7-d623-48619b02f99c
---
# IAppHostWritableAdminManager::CommitPath Property
Gets or sets the configuration path where changes should be committed.  
  
## Syntax  
  
```cpp  
HRESULT get_CommitPath(  
   [out,  
   retval,  
   string] BSTR* pbstrCommitPath  
);  
HRESULT put_CommitPath(  
   BSTR bstrCommitPath  
);  
```  
  
### Parameters  
 `pbstrCommitPath`  
 A pointer to a `BSTR` that contains the configuration path where changes should be committed.  
  
 `bstrCommitPath`  
 A `BSTR` that contains the new commit path.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Example  
 The following code example demonstrates how to set the `CommitPath` property, change the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration, and then use the [IAppHostWritableAdminManager::CommitChanges](../../web-development-reference/native-code-api-reference/iapphostwritableadminmanager-commitchanges-method.md) method to commit those changes to the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
 [!code-cpp[IAppHostAdminLibrary#4](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostElementSetMetadata.cpp#4)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostWritableAdminManager Interface](../../web-development-reference/native-code-api-reference/iapphostwritableadminmanager-interface.md)