---
title: "IFtpAuthenticationProvider Interface (Native)"
ms.date: "09/06/2017"
ms.assetid: 843eaeff-6349-465d-958f-12d940763122
ms.author: "robmcm"
---
# IFtpAuthenticationProvider Interface (Native)
Provides an interface for authentication checks.  
  
## Syntax  
  
```cpp#  
interface IFtpAuthenticationProvider : IUknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IFtpAuthenticationProvider` interface.  
  
|Name|Definition|
|---|---|
|[IFtpAuthenticationProvider::AuthenticateUser Method](../../ftp-extensibility-reference/native-code-api-reference/iftpauthenticationprovider-authenticateuser-method.md)|Checks to see whether a user name and password are valid.|  
  
## Example  
 The following code example illustrates how to use the `IFtpAuthenticationProvider` interface to create a custom authentication module that implements user name checks for the FTP service.  
  
```  
public:  
   STDMETHOD(AuthenticateUser)(LPWSTR pszSessionId,  
      LPWSTR pszSiteName,  
      LPWSTR pszUserName,  
      LPWSTR pszPassword,  
      LPWSTR * ppszCanonicalUserName,  
      long * pfAuthenticated)  
      {  
      // Note: You would add your own custom logic here.  
      *ppszCanonicalUserName = pszUserName;  
  
      CString strUserName = L"MyUser";  
      CString strPassword = L"MyPassword";  
  
      // Verify that the user name and password are valid.  
      // In this example, the user name is case-insensitive  
      // and the password is case-sensitive.  
      if ((strUserName.CompareNoCase(pszUserName)==0) &&  
          (strPassword.Compare(pszPassword)==0))  
      {  
         *pfAuthenticated = TRUE;  
      }  
      else  
      {  
         *pfAuthenticated = FALSE;  
   }  
      return S_OK;  
   }  
```  
  
## Requirements  
  
|Type|Description|
|---|---|
|Client|-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0|  
|Reference|ftpext.tlb|  
  
## See Also  
 [IFtpRoleProvider Interface](../../ftp-extensibility-reference/native-code-api-reference/iftproleprovider-interface-native.md)
