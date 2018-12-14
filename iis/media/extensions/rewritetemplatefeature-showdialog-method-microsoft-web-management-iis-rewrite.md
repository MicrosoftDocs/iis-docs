---
title: RewriteTemplateFeature.ShowDialog Method  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: ShowDialog Method
ms:assetid: M:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.ShowDialog(Microsoft.Web.Management.Client.Win32.DialogForm)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.showdialog(v=VS.90)
ms:contentKeyID: 20476389
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.ShowDialog
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.ShowDialog
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ShowDialog Method

Shows the specified [DialogForm](https://msdn.microsoft.com/en-us/library/ms634496\(v=vs.90\)) on the client.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
ProtectedFunctionShowDialog ( _
    formAsDialogForm _
) AsDialogResult
'Usage
DimformAsDialogFormDimreturnValueAsDialogResultreturnValue = Me.ShowDialog(form)
```

``` csharp
protectedDialogResultShowDialog(
    DialogFormform
)
```

``` c++
protected:
DialogResultShowDialog(
    DialogForm^ form
)
```

``` jscript
protectedfunctionShowDialog(
    form : DialogForm
) : DialogResult
```

#### Parameters

  - form  
    Type: [Microsoft.Web.Management.Client.Win32. . :: . .DialogForm](https://msdn.microsoft.com/en-us/library/ms634496\(v=vs.90\))  
    A The dialog form to display.  

#### Return Value

Type: [System.Windows.Forms. . :: . .DialogResult](https://msdn.microsoft.com/en-us/library/5ahe29t9\(v=vs.90\))  
A DialogResult from the displayed form.  

## Remarks

This method uses the [IManagementUIService](https://msdn.microsoft.com/en-us/library/ms634506\(v=vs.90\)) for the current feature to display the specified dialog form.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

