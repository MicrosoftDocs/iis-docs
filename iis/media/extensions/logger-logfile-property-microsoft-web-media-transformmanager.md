---
title: Logger.LogFile Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: LogFile Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Logger.LogFile
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.logger.logfile(v=VS.90)
ms:contentKeyID: 35520985
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Logger.get_LogFile
- Microsoft.Web.Media.TransformManager.Logger.set_LogFile
- Microsoft.Web.Media.TransformManager.Logger.LogFile
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Logger.get_LogFile
- Microsoft.Web.Media.TransformManager.Logger.LogFile
- Microsoft.Web.Media.TransformManager.Logger.set_LogFile
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LogFile Property

Gets or sets a [StreamWriter](https://msdn.microsoft.com/en-us/library/3ssew6tk\(v=vs.90\)) object that represents the log file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyLogFileAsStreamWriterGetSet
'Usage
DiminstanceAsLoggerDimvalueAsStreamWritervalue = instance.LogFile

instance.LogFile = value
```

``` csharp
publicStreamWriterLogFile { get; set; }
```

``` c++
public:
virtualpropertyStreamWriter^ LogFile {
    StreamWriter^ get () sealed;
    voidset (StreamWriter^ value) sealed;
}
```

``` fsharp
abstractLogFile : StreamWriterwithget, setoverrideLogFile : StreamWriterwithget, set
```

``` jscript
finalfunction getLogFile () : StreamWriterfinalfunction setLogFile (value : StreamWriter)
```

#### Property Value

Type: [System.IO. . :: . .StreamWriter](https://msdn.microsoft.com/en-us/library/3ssew6tk\(v=vs.90\))  
The stream writer that represents the log file.  

#### Implements

[ILogger. . :: . .LogFile](ilogger-logfile-property-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[Logger Class](logger-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

