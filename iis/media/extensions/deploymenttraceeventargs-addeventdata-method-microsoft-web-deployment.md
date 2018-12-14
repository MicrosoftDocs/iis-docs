---
title: DeploymentTraceEventArgs.AddEventData Method  (Microsoft.Web.Deployment)
TOCTitle: AddEventData Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentTraceEventArgs.AddEventData(System.String,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymenttraceeventargs.addeventdata(v=VS.90)
ms:contentKeyID: 20209223
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.AddEventData
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.AddEventData
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AddEventData Method

Adds data to the current event argument.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
ProtectedSubAddEventData ( _
    keyAsString, _
    valueAsObject _
)
'Usage
DimkeyAsStringDimvalueAsObjectMe.AddEventData(key, value)
```

``` csharp
protectedvoidAddEventData(
    stringkey,
    Objectvalue
)
```

``` c++
protected:
voidAddEventData(
    String^ key, 
    Object^ value
)
```

``` jscript
protectedfunctionAddEventData(
    key : String, 
    value : Object
)
```

#### Parameters

  - key  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The key to use for the new data.  

<!-- end list -->

  - value  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    The value of the data to add to the event argument.  

## Remarks

After data is added, it can be accessed through the [EventData](deploymenttraceeventargs-eventdata-property-microsoft-web-deployment.md) property. If the key already exists, the data is not added and no exceptions are thrown.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentTraceEventArgs Class](deploymenttraceeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

