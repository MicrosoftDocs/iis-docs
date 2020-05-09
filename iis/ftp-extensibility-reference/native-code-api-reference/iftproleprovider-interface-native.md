---
title: "IFtpRoleProvider Interface (Native)"
ms.date: "09/06/2017"
ms.assetid: 58e05545-9a67-4504-a897-f97b054765ab
ms.author: "robmcm"
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
|[IFtpRoleProvider::IsUserInRole Method](../../ftp-extensibility-reference/native-code-api-reference/iftproleprovider-isuserinrole-method.md)|Checks to see whether a user is a member of a specific role.|  
  
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
|Client|-   IIS 7.5 on                                          Windows 7<br />-   IIS 8.0 on                                          Windows 8<br />-   IIS 10.0 on                                          Windows 10|  
|Server|-   IIS 7.5 on                                          Windows Server 2008 R2<br />-   IIS 8.0 on                                          Windows Server 2012<br />-   IIS 8.5 on                                          Windows Server 2012 R2<br />-   IIS 10.0 on                                          Windows Server 2016|  
|Product|-   IIS 7.0,                                          IIS 7.5,                                          IIS 8.0,                                          IIS 8.5,                                          IIS 10.0|  
|Reference|ftpext.tlb|  
  
## See Also  
 [IFtpAuthenticationProvider Interface](../../ftp-extensibility-reference/native-code-api-reference/iftpauthenticationprovider-interface-native.md)
