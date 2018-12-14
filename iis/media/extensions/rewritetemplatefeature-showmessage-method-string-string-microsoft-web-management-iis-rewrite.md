---
title: RewriteTemplateFeature.ShowMessage Method (String, String) (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: ShowMessage Method (String, String)
ms:assetid: M:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.ShowMessage(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.showmessage(v=VS.90)
ms:contentKeyID: 46408202
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.ShowMessage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ShowMessage Method (String, String)

Shows a message box with the features specified by the parameters.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
ProtectedFunctionShowMessage ( _
    textAsString, _
    captionAsString _
) AsDialogResult
'Usage
DimtextAsStringDimcaptionAsStringDimreturnValueAsDialogResultreturnValue = Me.ShowMessage(text, _
    caption)
```

``` csharp
protectedDialogResultShowMessage(
    stringtext,
    stringcaption
)
```

``` c++
protected:
DialogResultShowMessage(
    String^ text, 
    String^ caption
)
```

``` jscript
protectedfunctionShowMessage(
    text : String, 
    caption : String
) : DialogResult
```

#### Parameters

  - text  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string value that contains the message box text.  

<!-- end list -->

  - caption  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string value that contains the message box caption.  

#### Return Value

Type: [System.Windows.Forms. . :: . .DialogResult](https://msdn.microsoft.com/en-us/library/5ahe29t9\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[ShowMessage Overload](rewritetemplatefeature-showmessage-method-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

