---
title: "IISDeveloperExpressDiagnostics"
ms.date: "10/07/2016"
ms.assetid: 504dde57-cd9d-4bcf-bbb9-6ca3357a4c6b
---
# IISDeveloperExpressDiagnostics

Returns diagnostics information for web server startup failures.  
  
## Syntax  
  
```csharp  
public static class IisDeveloperExpressDiagnostics  
{  
    /// <summary>   
    /// DiagnoseStartupError returns diagnostics information for web site startup failures.  
    /// </summary>   
    /// <param name="errorCode">A Win32 HRESULT that describes the failure.</param>   
    /// <param name="url">A string that describes the URL for the site that failed to launch.</param>   
    /// <returns>An ErrorInformation instance that provides diagnostic information for the startup  
    /// failure.</returns>  
  
    public static ErrorInformation DiagnoseStartupError(  
           long errorCode,  
           string url);  
}  
```  
  
## See Also  

 [Version Manager API (IIS Express)](../../extensions/express-api-reference/version-manager-api-iis-express.md)
