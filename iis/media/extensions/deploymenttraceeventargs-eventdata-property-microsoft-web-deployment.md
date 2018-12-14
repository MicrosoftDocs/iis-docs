---
title: DeploymentTraceEventArgs.EventData Property  (Microsoft.Web.Deployment)
TOCTitle: EventData Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentTraceEventArgs.EventData
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymenttraceeventargs.eventdata(v=VS.90)
ms:contentKeyID: 20209066
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.EventData
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.get_EventData
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.EventData
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.get_EventData
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# EventData Property

Gets a dictionary of data associated with the current event argument.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyEventDataAsIDictionary(OfString, Object)
'Usage
DiminstanceAsDeploymentTraceEventArgsDimvalueAsIDictionary(OfString, Object)

value = instance.EventData
```

``` csharp
publicIDictionary<string, Object> EventData { get; }
```

``` c++
public:
propertyIDictionary<String^, Object^>^ EventData {
    IDictionary<String^, Object^>^ get ();
}
```

``` jscript
function getEventData () : IDictionary<String, Object>
```

#### Property Value

Type: [System.Collections.Generic. . :: . .IDictionary](https://msdn.microsoft.com/en-us/library/s4ys34ea\(v=vs.90\))\< (Of \< ( \<'[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\)), [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))\> ) \> ) \>  
An IDictionary\<string, object\> interface that is used to access data in the current event argument.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentTraceEventArgs Class](deploymenttraceeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

