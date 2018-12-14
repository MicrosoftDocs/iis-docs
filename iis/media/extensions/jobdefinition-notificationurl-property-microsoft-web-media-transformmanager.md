---
title: JobDefinition.NotificationUrl Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: NotificationUrl Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.NotificationUrl
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.notificationurl(v=VS.90)
ms:contentKeyID: 35521062
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NotificationUrl
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NotificationUrl
- Microsoft.Web.Media.TransformManager.JobDefinition.NotificationUrl
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NotificationUrl
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NotificationUrl
- Microsoft.Web.Media.TransformManager.JobDefinition.NotificationUrl
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# NotificationUrl Property

Gets or sets a URL to which HTTP POST request notifications are sent.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyNotificationUrlAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.NotificationUrl

instance.NotificationUrl = value
```

``` csharp
[DataMemberAttribute]
publicstringNotificationUrl { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ NotificationUrl {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberNotificationUrl : stringwithget, set
```

``` jscript
function getNotificationUrl () : Stringfunction setNotificationUrl (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The URL.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

