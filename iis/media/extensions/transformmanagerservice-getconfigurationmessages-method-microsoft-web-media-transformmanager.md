---
title: TransformManagerService.GetConfigurationMessages Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetConfigurationMessages Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetConfigurationMessages
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getconfigurationmessages(v=VS.90)
ms:contentKeyID: 35521047
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetConfigurationMessages
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetConfigurationMessages
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
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionGetConfigurationMessagesAsCollection(OfConfigurationMessage)
'Usage
DiminstanceAsTransformManagerServiceDimreturnValueAsCollection(OfConfigurationMessage)

returnValue = instance.GetConfigurationMessages()
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicCollection<ConfigurationMessage> GetConfigurationMessages()
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualCollection<ConfigurationMessage^>^ GetConfigurationMessages() sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractGetConfigurationMessages : unit->Collection<ConfigurationMessage> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideGetConfigurationMessages : unit->Collection<ConfigurationMessage> 
```

``` jscript
publicfinalfunctionGetConfigurationMessages() : Collection<ConfigurationMessage>
```

#### Return Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[ConfigurationMessage](configurationmessage-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
The configuration messages.  

#### Implements

[IManagementService. . :: . .GetConfigurationMessages() () () ()](imanagementservice-getconfigurationmessages-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

