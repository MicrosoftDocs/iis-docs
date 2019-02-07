---
title: "ClearIISDirectory | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: bdeb24c3-2917-4218-86b7-b78818649a6a
caps.latest.revision: 6
manager: "wpickett"
---
# ClearIISDirectory
Deletes the IIS Express directory for the current user.  
  
## Syntax  
  
```cpp  
HRESULT  
ClearIISDirectory();  
  
```  
  
## Return Value  
 `HRESULT`  
  
## Remarks  
 This function deletes all related content, including configuration files and log files.  
  
## See Also  
 [IISDirectory](../../\extensions/express-api-reference/iisdirectory.md)   
 [SetupIISDirectory](../../\extensions/express-api-reference/setupiisdirectory.md)