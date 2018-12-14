---
title: "IFtpAuthenticationProvider::AuthenticateUser Method | Microsoft Docs"
ms.custom: ""
ms.date: "09/06/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ab84c942-f9e5-4dc9-9c51-cb25906deb15
caps.latest.revision: 8
author: "shirhatti"
ms.author: "robmcm"
manager: "wpickett"
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
  
#### Parameters  
  
|||  
|-|-|  
|Term|Definition|  
|`pszSessionId`|A pointer to a string that contains the session ID.|  
|`pszSiteName`|A pointer to a string that contains the site name.|  
|`pszUserName`|A pointer to a string that contains the user name.|  
|`pszPassword`|A pointer to a string that contains the password.|  
|`ppszCanonicalUserName`|A pointer to a string that will contain the canonical name of the user.|  
|`pfAuthenticated`|A pointer to a long integer that will contain `true` if the user is authenticated; otherwise, `false`.|  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|||  
|-|-|  
|Value|Description|  
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
  
|||  
|-|-|  
|Type|Description|  
|Client|-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]|  
|Reference|ftpext.tlb|  
  
## See Also  
 [IFtpAuthenticationProvider Interface](../../../ftp-extenisibility-reference\native-code-api\ftp-native-api-ref/iftpauthenticationprovider-interface-native.md)