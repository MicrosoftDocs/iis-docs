---
title: DeploymentProviderSettingCollection.GetValueOrDefault(T) Method  (Microsoft.Web.Deployment)
TOCTitle: GetValueOrDefault(T) Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentProviderSettingCollection.GetValueOrDefault``1(System.String,``0)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd543411(v=VS.90)
ms:contentKeyID: 20209166
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderSettingCollection.GetValueOrDefault``1
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderSettingCollection.GetValueOrDefault
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetValueOrDefault(T) Method

Gets the value with the specified name, or uses a default value if the object is not found in the collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetValueOrDefault(Of T) ( _
    nameAsString, _
    defaultValueAs T _
) As T
'Usage
DiminstanceAsDeploymentProviderSettingCollectionDimnameAsStringDimdefaultValueAs T
DimreturnValueAs T

returnValue = instance.GetValueOrDefault(name, _
    defaultValue)
```

``` csharp
public T GetValueOrDefault<T>(
    stringname,
    T defaultValue
)
```

``` c++
public:
generic<typename T>
T GetValueOrDefault(
    String^ name, 
    T defaultValue
)
```

``` jscript
JScript does not support generic types or methods.
```

#### Type Parameters

  - T

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - defaultValue  
    Type: T  
    The default value to use if an object with the specified name is not found.  

#### Return Value

Type: T  
The value with the specified name, or uses a default value if the object is not found in the collection.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderSettingCollection Class](deploymentprovidersettingcollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

