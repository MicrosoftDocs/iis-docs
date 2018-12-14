---
title: "IFtpRoleProvider::IsUserInRole Method | Microsoft Docs"
ms.custom: ""
ms.date: "09/06/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: edb0aed7-253f-40ae-85f5-09f37fce2504
caps.latest.revision: 8
author: "shirhatti"
ms.author: "robmcm"
manager: "wpickett"
---
# IFtpRoleProvider::IsUserInRole Method
Checks to see whether a user is a member of a specific role.  
  
## Syntax  
  
```cpp#  
HRESULT IsUserInRole(  
   LPWSTR pszSessionId,  
   LPWSTR pszSiteName,  
   LPWSTR pszUserName,  
   LPWSTR pszRole,  
   long * pfIsInRole  
)  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Term|Definition|  
|`pszSessionId`|[IN] A pointer to a string that contains the session ID.|  
|`pszSiteName`|[IN] A pointer to a string that contains the site name.|  
|`pszUserName`|[IN] A pointer to a string that contains the user name.|  
|`pszRole`|[IN] A pointer to a string that contains the role name.|  
|`pfIsInRole`|[OUT] A pointer to a long integer that is set to `true` if the user is in the role; otherwise, `false`.|  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|||  
|-|-|  
|Value|Description|  
|S_OK|Indicates that the operation was successful.|  
  
## Example  
 The following code example illustrates how to use the `IFtpRoleProvider` interface to create a custom authentication module for the FTP service that implements role checks.  
  
```  
public:  
   STDMETHOD(IsUserInRole)(LPWSTR pszSessionId,  
      LPWSTR pszSiteName,  
      LPWSTR pszUserName,  
      LPWSTR pszRole,  
      long * pfIsInRole)  
   {  
      // Note: You would add your own custom logic here.  
      CString strUserName = L"MyUser";  
      CString strRoleName = L"MyRole";  
  
      // Verify that the user name and role name are valid.  
      // In this example, both the user name and  
      // the role name are case-insensitive.  
      if ((strUserName.CompareNoCase(pszUserName)==0) &&  
          (strRoleName.CompareNoCase(pszRole)==0))  
      {  
         *pfIsInRole = TRUE;  
      }  
      else  
      {  
         *pfIsInRole = FALSE;  
      }  
  
      return S_OK;  
   }  
```  
  
## Requirements  
  
|||  
|-|-|  
|Type|Description|  
|Client|-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on                                          [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on                                          [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on                                          [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on                                          [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on                                          [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on                                          [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on                                          [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)],                                          [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)],                                          [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)],                                          [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)],                                          [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]|  
|Reference|ftpext.tlb|  
  
## See Also  
 [IFtpRoleProvider Interface](../../../ftp-extenisibility-reference\native-code-api\ftp-native-api-ref/iftproleprovider-interface-native.md)