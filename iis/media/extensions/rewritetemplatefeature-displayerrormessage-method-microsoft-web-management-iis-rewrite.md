---
title: RewriteTemplateFeature.DisplayErrorMessage Method  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: DisplayErrorMessage Method
ms:assetid: M:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.DisplayErrorMessage(System.Exception,System.Resources.ResourceManager)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.displayerrormessage(v=VS.90)
ms:contentKeyID: 20476365
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.DisplayErrorMessage
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.DisplayErrorMessage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DisplayErrorMessage Method

Displays information about an exception on the user interface for the current feature.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
ProtectedSubDisplayErrorMessage ( _
    exAsException, _
    resourceManagerAsResourceManager _
)
'Usage
DimexAsExceptionDimresourceManagerAsResourceManagerMe.DisplayErrorMessage(ex, resourceManager)
```

``` csharp
protectedvoidDisplayErrorMessage(
    Exceptionex,
    ResourceManagerresourceManager
)
```

``` c++
protected:
voidDisplayErrorMessage(
    Exception^ ex, 
    ResourceManager^ resourceManager
)
```

``` jscript
protectedfunctionDisplayErrorMessage(
    ex : Exception, 
    resourceManager : ResourceManager
)
```

#### Parameters

  - ex  
    Type: [System. . :: . .Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.90\))  
    The exception used to obtain error information that should be displayed.  

<!-- end list -->

  - resourceManager  
    Type: [System.Resources. . :: . .ResourceManager](https://msdn.microsoft.com/en-us/library/2xsy4hac\(v=vs.90\))  
    The resource manager that is used to localize error messages.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>[ArgumentNullException]</td>
<td><p>The ex or resoureceManager parameters are null (Nothing in Visual Basic).</p></td>
</tr>
</tbody>
</table>


## Remarks

If the exception provided in ex does not contain a message value, and the inner exception contains a resource name, the provided resource manager is used to look for a localized exception message to display on the client.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

