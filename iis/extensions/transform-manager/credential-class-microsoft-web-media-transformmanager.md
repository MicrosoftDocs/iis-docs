---
title: Credential Class (Microsoft.Web.Media.TransformManager)
TOCTitle: Credential Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.Credential
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.credential(v=VS.90)
ms:contentKeyID: 35520755
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Credential Class

Provides credentials to run jobs and access resources.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..Credential  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataContractAttribute> _
Public Class Credential
'Usage

  Dim instance As Credential
```

```csharp
[DataContractAttribute]
public class Credential
```

```cpp
[DataContractAttribute]
public ref class Credential
```

``` fsharp
[<DataContractAttribute>]
type Credential =  class end
```

```jscript
  public class Credential
```

The Credential type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Credential](credential-constructor-microsoft-web-media-transformmanager.md)|Initializes a new instance of the Credential class.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Description](credential-description-property-microsoft-web-media-transformmanager.md)|Gets or sets the credential description.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Domain](credential-domain-property-microsoft-web-media-transformmanager.md)|Gets or sets the credential domain.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[DomainUserName](credential-domainusername-property-microsoft-web-media-transformmanager.md)|Gets or sets the credential domain that uses the credential user name.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Id](credential-id-property-microsoft-web-media-transformmanager.md)|Gets or sets an internal credential ID.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Password](credential-password-property-microsoft-web-media-transformmanager.md)|Gets or sets an internal credential password.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[ServiceCredentialId](credential-servicecredentialid-property-microsoft-web-media-transformmanager.md)|Gets the value of the credential GUID that IIS Transform Manager uses to run.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[UserName](credential-username-property-microsoft-web-media-transformmanager.md)|Gets or sets a credential user name.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

