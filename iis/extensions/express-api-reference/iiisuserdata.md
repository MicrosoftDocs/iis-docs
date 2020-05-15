---
title: "IIISUserData"
ms.date: "10/07/2016"
ms.assetid: 7acb6312-1d49-4ed6-afe1-d31b94cd6f2c
---
# IIISUserData

Allows per-user IIS Express directories to be queried and created for [IIISVersion](../../extensions/express-api-reference/iiisversion.md) objects that describe IIS Express.  
  
## Syntax  
  
```cpp  
interface IIISUserData : IUnknown  
{  
    [propget]  
    HRESULT  
    IISDirectory(  
        [out, retval] BSTR * pbstrDirectory  
    );  
  
    HRESULT  
    SetupIISDirectory(  
        [in] BOOL fOverride  
    );  
  
    HRESULT  
    ClearIISDirectory(  
    );  
};  
```  
  
## See Also  

 [IISDirectory](../../extensions/express-api-reference/iisdirectory.md)   
 [SetupIISDirectory](../../extensions/express-api-reference/setupiisdirectory.md)   
 [ClearIISDirectory](../../extensions/express-api-reference/cleariisdirectory.md)
