---
title: "ErrorInformation (IISExpress)"
ms.date: "10/07/2016"
ms.assetid: 81ec9163-68d2-4b00-8fd2-3afdab2c5d19
---
# ErrorInformation (IISExpress)
Defines detailed, localized error messages for IIS Express failure conditions.  
  
## Syntax  
  
```csharp  
public class ErrorInformation  
    {  
        /// <summary>  
        /// A localized error message that describes the error.  
        /// </summary>  
        public string Message  
        {  
            get;  
        }  
  
        /// <summary>  
        /// One or more localized strings that describe possible root causes for the failure.  
        /// </summary>  
        public IEnumerable<string> Causes  
        {  
            get;  
        }  
  
        /// <summary>  
        /// One or more localized strings that describe how to address the failure.  
        /// </summary>  
        public IEnumerable<string> Recommendations  
        {  
            get;  
        }  
  
        /// <summary>  
        /// One or more hyperlinks that reference additional readings.  
        /// </summary>  
        public IEnumerable<string> HyperLinks  
        {  
            get;  
        }  
    }  
  
```  
 
## See Also  
 [IIS Express API Reference](../../extensions/express-api-reference/express-api-reference.md)
