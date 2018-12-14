---
title: JobDefinition.NotificationIncludeLogForFailedJob Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: NotificationIncludeLogForFailedJob Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.NotificationIncludeLogForFailedJob
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.notificationincludelogforfailedjob(v=VS.90)
ms:contentKeyID: 35520800
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.NotificationIncludeLogForFailedJob
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NotificationIncludeLogForFailedJob
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NotificationIncludeLogForFailedJob
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NotificationIncludeLogForFailedJob
- Microsoft.Web.Media.TransformManager.JobDefinition.NotificationIncludeLogForFailedJob
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NotificationIncludeLogForFailedJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# NotificationIncludeLogForFailedJob Property

Gets or sets a value that specifies that the log that is associated with a failed job will be included in a failure notification POST request.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyNotificationIncludeLogForFailedJobAsBooleanGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsBooleanvalue = instance.NotificationIncludeLogForFailedJob

instance.NotificationIncludeLogForFailedJob = value
```

``` csharp
[DataMemberAttribute]
publicboolNotificationIncludeLogForFailedJob { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyboolNotificationIncludeLogForFailedJob {
    boolget ();
    voidset (boolvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberNotificationIncludeLogForFailedJob : boolwithget, set
```

``` jscript
function getNotificationIncludeLogForFailedJob () : booleanfunction setNotificationIncludeLogForFailedJob (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the log that is associated with a failed job will be included in a failure notification POST request; otherwise, false.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

