---
title: DependencyCheckTraceEventArgs.Message Property  (Microsoft.Web.Deployment)
TOCTitle: Message Property
ms:assetid: P:Microsoft.Web.Deployment.DependencyCheckTraceEventArgs.Message
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.dependencychecktraceeventargs.message(v=VS.90)
ms:contentKeyID: 22753977
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DependencyCheckTraceEventArgs.Message
- Microsoft.Web.Deployment.DependencyCheckTraceEventArgs.get_Message
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DependencyCheckTraceEventArgs.get_Message
- Microsoft.Web.Deployment.DependencyCheckTraceEventArgs.Message
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Message Property

Gets the message that is passed to the dependency check trace event.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridesReadOnlyPropertyMessageAsString
'Usage
DiminstanceAsDependencyCheckTraceEventArgsDimvalueAsStringvalue = instance.Message
```

``` csharp
publicoverridestringMessage { get; }
```

``` c++
public:
virtualpropertyString^ Message {
    String^ get () override;
}
```

``` jscript
overridefunction getMessage () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
Contains a message to log for a dependency check trace event.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DependencyCheckTraceEventArgs Class](dependencychecktraceeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

