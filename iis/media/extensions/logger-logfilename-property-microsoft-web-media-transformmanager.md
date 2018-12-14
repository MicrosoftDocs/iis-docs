---
title: Logger.LogFileName Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: LogFileName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Logger.LogFileName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.logger.logfilename(v=VS.90)
ms:contentKeyID: 35521002
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Logger.get_LogFileName
- Microsoft.Web.Media.TransformManager.Logger.LogFileName
- Microsoft.Web.Media.TransformManager.Logger.set_LogFileName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Logger.get_LogFileName
- Microsoft.Web.Media.TransformManager.Logger.LogFileName
- Microsoft.Web.Media.TransformManager.Logger.set_LogFileName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LogFileName Property

Gets or sets the name of the log file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyLogFileNameAsStringGetSet
'Usage
DiminstanceAsLoggerDimvalueAsStringvalue = instance.LogFileName

instance.LogFileName = value
```

``` csharp
publicstringLogFileName { get; set; }
```

``` c++
public:
propertyString^ LogFileName {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
memberLogFileName : stringwithget, set
```

``` jscript
function getLogFileName () : Stringfunction setLogFileName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The name of the log file.  

## See Also

#### Reference

[Logger Class](logger-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

