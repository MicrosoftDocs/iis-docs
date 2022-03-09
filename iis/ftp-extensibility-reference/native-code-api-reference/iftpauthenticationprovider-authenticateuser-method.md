---
title: "IFtpAuthenticationProvider::AuthenticateUser Method"
ms.date: "09/06/2017"
ms.assetid: ab84c942-f9e5-4dc9-9c51-cb25906deb15
ms.author: "robmcm"
---
# IFtpAuthenticationProvider::AuthenticateUser Method
Checks to see whether a user name and password are valid.  
  
## Syntax  
  
```cpp#  
AuthenticateUser(  
   LPWSTR pszSessionId,  
   LPWSTR pszSiteName,  
   LPWSTR pszUserName,  
   LPWSTR pszPassword,  
   LPWSTR * ppszCanonicalUserName,  
   long * pfAuthenticated  
)  
```  
  
### Parameters  
  
|Term|Definition|
|---|---|
|`pszSessionId`|A pointer to a string that contains the session ID.|  
|`pszSiteName`|A pointer to a string that contains the site name.|  
|`pszUserName`|A pointer to a string that contains the user name.|  
|`pszPassword`|A pointer to a string that contains the password.|  
|`ppszCanonicalUserName`|A pointer to a string that will contain the canonical name of the user.|  
|`pfAuthenticated`|A pointer to a long integer that will contain `true` if the user is authenticated; otherwise, `false`.|  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|
|---|---|
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The `ppszCanonicalUserName` parameter can be used to canonicalize user names; the suggested canonical form is domain\user because previous versions of IIS FTP servers required the user name to be in the domain\user form.  
  
 A Windows authentication-based provider cannot be implemented with this method because that form of authentication does not allow user tokens to be returned.  
  
## Example  
 The following code example illustrates how to use the `IFtpAuthenticationProvider` interface to create a custom authentication module for the FTP service that implements user name checks.  
  
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
 [IFtpAuthenticationProvider Interface](../../ftp-extensibility-reference/native-code-api-reference/iftpauthenticationprovider-interface-native.md)
