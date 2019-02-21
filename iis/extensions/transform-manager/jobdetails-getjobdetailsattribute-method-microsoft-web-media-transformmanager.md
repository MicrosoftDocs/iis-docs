---
title: JobDetails.GetJobDetailsAttribute Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDetailsAttribute Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobDetails.GetJobDetailsAttribute(Microsoft.Web.Media.TransformManager.JobDetailsField)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.getjobdetailsattribute(v=VS.90)
ms:contentKeyID: 35520757
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.GetJobDetailsAttribute
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.GetJobDetailsAttribute
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# GetJobDetailsAttribute Method

Returns the attribute name of a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function GetJobDetailsAttribute ( _
    field As JobDetailsField _
) As String
'Usage

  Dim field As JobDetailsField
Dim returnValue As String

returnValue = JobDetails.GetJobDetailsAttribute(field)
```

```csharp
  public static string GetJobDetailsAttribute(
    JobDetailsField field
)
```

```cpp
  public:
static String^ GetJobDetailsAttribute(
    JobDetailsField field
)
```

``` fsharp
  static member GetJobDetailsAttribute : 
        field:JobDetailsField -> string 
```

```jscript
  public static function GetJobDetailsAttribute(
    field : JobDetailsField
) : String
```

### Parameters

  - field  
    Type: [Microsoft.Web.Media.TransformManager.JobDetailsField](jobdetailsfield-enumeration-microsoft-web-media-transformmanager.md)  
    A value that is used to specify the name of a job attribute.  

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The attribute name of a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

