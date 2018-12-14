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
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# GetJobDetailsAttribute Method

Returns the attribute name of a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionGetJobDetailsAttribute ( _
    fieldAsJobDetailsField _
) AsString
'Usage
DimfieldAsJobDetailsFieldDimreturnValueAsStringreturnValue = JobDetails.GetJobDetailsAttribute(field)
```

``` csharp
publicstaticstringGetJobDetailsAttribute(
    JobDetailsFieldfield
)
```

``` c++
public:
staticString^ GetJobDetailsAttribute(
    JobDetailsFieldfield
)
```

``` fsharp
staticmemberGetJobDetailsAttribute : 
        field:JobDetailsField->string
```

``` jscript
publicstaticfunctionGetJobDetailsAttribute(
    field : JobDetailsField
) : String
```

#### Parameters

  - field  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetailsField](jobdetailsfield-enumeration-microsoft-web-media-transformmanager.md)  
    A value that is used to specify the name of a job attribute.  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The attribute name of a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

