---
title: "FormsAuthenticationConfiguration Class"
ms.date: "10/07/2016"
ms.assetid: e1965678-d4ef-61b8-159b-78ac61d663a2
---
# FormsAuthenticationConfiguration Class
Configures Forms authentication for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application.  
  
## Syntax  
  
```vbs  
class FormsAuthenticationConfiguration : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `FormsAuthenticationConfiguration` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Cookieless`|A read/write `sint32` enumeration that specifies whether Forms authentication should use cookies. The possible values are listed later in the Remarks section.|  
|`Credentials`|A [FormsAuthenticationCredentials](../wmi-provider/formsauthenticationcredentials-class.md) value that contains a collection of user names and passwords to use during Forms authentication. **Note:**  When security is required, you should use alternative ways of storing user names and passwords (for example, in a database store). If you decide to use this collection, you should specify an encryption format in the `PasswordFormat` property of the `FormsAuthenticationCredentials` class.|  
|`DefaultUrl`|A read/write nonempty `string` value that specifies the default URL to which to direct the request after authentication. The default is "default.aspx".|  
|`Domain`|A read/write `string` value that specifies the domain name to be sent with Forms authentication cookies. The default is "". For Forms authentication cookies, this setting takes precedence over the setting in the `Domain` property of the [HttpCookiesSection](../wmi-provider/httpcookiessection-class.md) class.|  
|`EnableCrossAppRedirects`|A read/write `boolean` value. `true` if authenticated users can be redirected to URLs in other applications; otherwise, `false`. The default is `false`. If this property is `true`, the redirect is performed; otherwise, the browser is redirected to the page defined in the `DefaultUrl` property. **Note:**  When Forms authentication is enabled across multiple [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications, users are not required to reauthenticate when they switch between the applications. For more information, see [Forms Authentication Across Applications](https://go.microsoft.com/fwlink/?LinkId=69311).|  
|`LoginUrl`|A nonempty read/write `string` value that specifies the URL that the request is redirected to when the user is not authenticated or when no valid authentication cookie exists. The default is "login.aspx".|  
|`Name`|A nonempty read/write `string` value that specifies the name of the HTTP cookie to use for request authentication. The default is ".ASPXAUTH".|  
|`Path`|A nonempty read/write `string` value that specifies the path of the HTTP cookie to use for authentication. The path is transmitted along with the authentication cookie itself. The default is "/", which represents the Web-application root.|  
|`Protection`|A read/write `sint32` value that specifies the encryption method used for the cookie. The possible values are listed later in the Remarks section.|  
|`RequireSSL`|A read/write `boolean` value. `true` if a Secure Sockets Layer (SSL) connection is required for authentication; otherwise, `false`. The default is `false`. If this property is `true`, a Web application rejects all Forms authentication requests that do not use an SSL connection.|  
|`SlidingExpiration`|A read/write `boolean` value. `true` if the expiration for the authentication cookie will be set to the current date and time plus the value, in minutes, in the `Timeout` property; otherwise, `false`. The default is `true`.<br /><br /> If `true`, the expiration date and time of the cookie will be automatically reset if less than half of the value in `Timeout` remains and the user is still actively using the application. If `false`, the cookie automatically times out after the interval specified in the `Timeout` property has passed.|  
|`Timeout`|A read/write `datetime` value that specifies the amount of time after which the authentication expires. The default is 30 minutes.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Forms` property of the [AuthenticationSection](../wmi-provider/authenticationsection-class.md) class.  
  
 The following table lists the possible values for the `Cookieless` property. The default is 3 (`UseDeviceProfile`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`UseUri`|Specifies that the calling feature uses the query string to store an identifier, regardless of whether the browser or device supports cookies.|  
|1|`UseCookies`|Specifies that cookies are used to persist user data, regardless of whether the browser or device supports cookies.|  
|2|`AutoDetect`|Specifies that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] determines whether the requesting browser or device supports cookies. If the browser or device supports cookies, the requesting feature uses cookies to persist user data; otherwise, the requesting feature uses an identifier in the query string. If the browser or device supports the cookies, but cookies are currently disabled, the requesting feature still uses cookies.|  
|3|`UseDeviceProfile`|Specifies that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] determines whether to use cookies based on the `Cookies` property of the [System.Web.Configuration.HttpCapabilitiesBase class](/dotnet/api/system.web.configuration.httpcapabilitiesbase). If the setting indicates that the browser or device supports cookies, the requesting feature uses cookies; otherwise, the requesting feature uses an identifier in the query string.|  
  
 The following table lists the possible values for the `Protection` property. The default is 0 (`All`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`All`|Specifies that the application will use both data validation and encryption to help protect cookies. This option uses the data-validation algorithm specified in the [MachineKeySection](../wmi-provider/machinekeysection-class.md) class. The application uses the Triple Data Encryption Standard (Triple DES) for encryption if it is available and if the key is at least 48 bytes long. **Note:**  This is the recommended setting. To improve the protection of your cookie, you may also want to set the `RequireSSL` property to `true`.|  
|1|`None`|Specifies that encryption and validation are disabled. This setting is for sites with weaker security requirements that use cookies only for personalization. You should avoid using cookies in this manner; however, it is the least resource-intensive way to enable personalization using the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)].|  
|2|`Encryption`|Specifies that cookies are encrypted with Triple DES or DES. With this setting, data validation is not performed on the cookies, which makes them subject to plaintext security attacks.|  
|3|`Validation`|Specifies that the application will use a validation scheme to verify that the contents of an encrypted cookie have not been altered in transit. The cookie is created by concatenating a validation key with the cookie data, computing a Message Authentication Code (MAC), and appending the MAC to the outgoing cookie.|  
  
## Example  
 The following example displays the Forms authentication settings for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the authentication section.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "AuthenticationSection", oAuthSection  
  
' Assign the Forms property to a variable.  
Set oFormsAuthConfig = oAuthSection.Forms  
  
' Display the Forms authentication settings.  
WScript.Echo "Forms Authentication Settings"  
WScript.Echo "-----------------------------"  
  
WScript.Echo "Cookieless: [ " & _  
    CookielessText(oFormsAuthConfig.Cookieless)& " ]"  
  
WScript.Echo "Default Url: [ " & _  
    oFormsAuthConfig.DefaultUrl& " ]"  
  
WScript.Echo "Domain: [ " & oFormsAuthConfig.Domain& " ]"  
  
WScript.Echo "EnableCrossAppRedirects: [ " & _  
    oFormsAuthConfig.EnableCrossAppRedirects& " ]"  
  
WScript.Echo "LoginUrl: [ " & _  
    oFormsAuthConfig.LoginUrl & " ]"  
  
WScript.Echo "Name: [ " & oFormsAuthConfig.Name& " ]"  
  
WScript.Echo "Path: [ " & oFormsAuthConfig.Path& " ]"  
  
WScript.Echo "Protection: [ " & _  
    ProtectionText(oFormsAuthConfig.Protection)& " ]"  
  
WScript.Echo "RequireSSL: [ " & _  
    oFormsAuthConfig.RequireSSL& " ]"  
  
WScript.Echo "SlidingExpiration: [ " & _  
    oFormsAuthConfig.SlidingExpiration& " ]"  
  
WScript.Echo "Timeout: [ " & oFormsAuthConfig.Timeout& " ]"  
  
' Call a sub to display the credentials information.  
DisplayCredentials(oFormsAuthConfig.Credentials)  
  
' Convert the Cookieless enumeration values to text.  
Function CookielessText(enumValue)  
    Select Case enumValue  
        Case 0  
            CookielessText = "UseUri"  
        Case 1  
            CookielessText = "UseCookies"  
        Case 2  
            CookielessText = "AutoDetect"  
        Case 3  
            CookielessText = "UseDeviceProfile"  
        Case Else  
            CookielessText = "Undefined enumeration value."  
    End Select  
End Function  
  
' Convert the Protection enumeration values to text.  
Function ProtectionText(enumValue)  
    Select Case enumValue  
        Case 0  
            ProtectionText = "All"  
        Case 1  
            ProtectionText = "None"  
        Case 2  
            ProtectionText = "Encryption"  
        Case 3  
            ProtectionText = "Validation"  
        Case Else  
            ProtectionText = "Undefined enumeration value."  
    End Select  
End Function  
  
' Display the Forms authentication credentials.  
Sub DisplayCredentials(FA_Credentials)  
    WScript.Echo vbCrLf & "Forms Authentication Credentials"  
    WScript.Echo "--------------------------------"  
  
    ' Display the password encryption format.  
    WScript.Echo "Password Format: " & _  
        PwdFormatText(FA_Credentials.PasswordFormat) & VbCrLf  
  
    ' Display the Forms authentication users and passwords.  
    For Each FormsAuthUser In FA_Credentials.Credentials  
        WScript.Echo "    Name: [ " & FormsAuthUser.Name & " ]"  
        WScript.Echo "Password: [ " & _  
            FormsAuthUser.Password& " ]"  
        WScript.Echo  
    Next  
End Sub  
  
' Convert the PasswordFormat enumeration values to text.  
Function PwdFormatText(enumValue)  
    Select Case enumValue  
        Case 0  
            PwdFormatText = "Clear"  
        Case 1  
            PwdFormatText = "SHA1"  
        Case 2  
            PwdFormatText = "MD5"  
        Case Else  
            PwdFormatText = "Undefined enumeration value."  
    End Select  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `FormsAuthenticationConfiguration`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Configuration.AuthenticationMode](/dotnet/api/system.web.configuration.authenticationmode)
 [System.Web.Configuration.FormsAuthenticationConfiguration](/dotnet/api/system.web.configuration.formsauthenticationconfiguration)
 [System.Web.Configuration.HttpCapabilitiesBase](/dotnet/api/system.web.configuration.httpcapabilitiesbase)
 [AuthenticationSection Class](../wmi-provider/authenticationsection-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [FormsAuthenticationCredentials Class](../wmi-provider/formsauthenticationcredentials-class.md)   
 [FormsAuthenticationUser Class](../wmi-provider/formsauthenticationuser-class.md)   
 [MachineKeySection Class](../wmi-provider/machinekeysection-class.md)   
 [Forms Authentication Across Applications](https://go.microsoft.com/fwlink/?LinkId=69311)   
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)