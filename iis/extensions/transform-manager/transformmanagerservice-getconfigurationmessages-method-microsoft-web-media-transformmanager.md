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
- csharp
- jscript
- vb
- FSharp
- cpp
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
---

# GetConfigurationMessages Method

Returns configuration messages that are related to the IIS Transform Manager service.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetConfigurationMessages As Collection(Of ConfigurationMessage)
'Usage

  Dim instance As TransformManagerService
Dim returnValue As Collection(Of ConfigurationMessage)

returnValue = instance.GetConfigurationMessages()
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public Collection<ConfigurationMessage> GetConfigurationMessages()
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual Collection<ConfigurationMessage^>^ GetConfigurationMessages() sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetConfigurationMessages : unit -> Collection<ConfigurationMessage> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetConfigurationMessages : unit -> Collection<ConfigurationMessage> 
```

```jscript
  public final function GetConfigurationMessages() : Collection<ConfigurationMessage>
```

### Return Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[ConfigurationMessage](configurationmessage-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
The configuration messages.  

### Implements

[IManagementService.GetConfigurationMessages() () () ()](imanagementservice-getconfigurationmessages-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

