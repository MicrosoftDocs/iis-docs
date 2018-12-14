---
title: "IFtpRoleProvider Interface (Native) | Microsoft Docs"
ms.custom: ""
ms.date: "09/06/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 58e05545-9a67-4504-a897-f97b054765ab
caps.latest.revision: 8
author: "shirhatti"
ms.author: "robmcm"
manager: "wpickett"
---
# IFtpRoleProvider Interface (Native)
Provides an interface for authorization and role checks.  
  
## Syntax  
  
```cpp#  
interface IFtpRoleProvider : IUknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IFtpRoleProvider` interface.  
  
|||  
|-|-|  
|Name|Definition|  
|[IFtpRoleProvider::IsUserInRole Method](../../../ftp-extenisibility-reference\native-code-api\ftp-native-api-ref/iftproleprovider-isuserinrole-method.md)|Checks to see whether a user is a member of a specific role.|  
  
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
 [IFtpAuthenticationProvider Interface](../../../ftp-extenisibility-reference\native-code-api\ftp-native-api-ref/iftpauthenticationprovider-interface-native.md)