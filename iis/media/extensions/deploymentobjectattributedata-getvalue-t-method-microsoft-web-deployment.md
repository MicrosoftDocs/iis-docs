---
title: DeploymentObjectAttributeData.GetValue(T) Method  (Microsoft.Web.Deployment)
TOCTitle: GetValue(T) Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttributeData.GetValue``1
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee402823(v=VS.90)
ms:contentKeyID: 22754011
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.GetValue``1
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.GetValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetValue(T) Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetValue(Of T) As T
'Usage
DiminstanceAsDeploymentObjectAttributeDataDimreturnValueAs T

returnValue = instance.GetValue()
```

``` csharp
public T GetValue<T>()
```

``` c++
public:
generic<typename T>
T GetValue()
```

``` jscript
JScript does not support generic types or methods.
```

#### Type Parameters

  - T  

#### Return Value

Type: T  
Returns [Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\)).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeData Class](deploymentobjectattributedata-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

