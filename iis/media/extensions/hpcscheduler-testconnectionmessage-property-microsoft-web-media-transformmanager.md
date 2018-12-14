---
title: HpcScheduler.TestConnectionMessage Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TestConnectionMessage Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnectionMessage
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.testconnectionmessage(v=VS.90)
ms:contentKeyID: 35520871
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.get_TestConnectionMessage
- Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnectionMessage
- Microsoft.Web.Media.TransformManager.HpcScheduler.set_TestConnectionMessage
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.get_TestConnectionMessage
- Microsoft.Web.Media.TransformManager.HpcScheduler.set_TestConnectionMessage
- Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnectionMessage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TestConnectionMessage Property

Gets the connection message.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyTestConnectionMessageAsStringGetPrivateSet
'Usage
DiminstanceAsHpcSchedulerDimvalueAsStringvalue = instance.TestConnectionMessage
```

``` csharp
publicstringTestConnectionMessage { get; privateset; }
```

``` c++
public:
propertyString^ TestConnectionMessage {
    String^ get ();
    private: voidset (String^ value);
}
```

``` fsharp
memberTestConnectionMessage : stringwithget, privateset
```

``` jscript
function getTestConnectionMessage () : Stringprivatefunction setTestConnectionMessage (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A connection message that contains exception details.  

## See Also

#### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

