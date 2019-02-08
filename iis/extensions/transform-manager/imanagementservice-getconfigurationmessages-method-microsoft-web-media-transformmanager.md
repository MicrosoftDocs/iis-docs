---
title: IManagementService.GetConfigurationMessages Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetConfigurationMessages Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.GetConfigurationMessages
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.getconfigurationmessages(v=VS.90)
ms:contentKeyID: 35521099
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.GetConfigurationMessages
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.GetConfigurationMessages
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetConfigurationMessages Method

Returns configuration messages that are related to the IIS Transform Manager service.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
Function GetConfigurationMessages As Collection(Of ConfigurationMessage)
'Usage

  Dim instance As IManagementService
Dim returnValue As Collection(Of ConfigurationMessage)

returnValue = instance.GetConfigurationMessages()
```

``` csharp
[OperationContractAttribute]
Collection<ConfigurationMessage> GetConfigurationMessages()
```

``` c++
[OperationContractAttribute]
Collection<ConfigurationMessage^>^ GetConfigurationMessages()
```

``` fsharp
[<OperationContractAttribute>]
abstract GetConfigurationMessages : unit -> Collection<ConfigurationMessage> 
```

``` jscript
  function GetConfigurationMessages() : Collection<ConfigurationMessage>
```

#### Return Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[ConfigurationMessage](configurationmessage-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
The configuration messages.  

## See Also

#### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

