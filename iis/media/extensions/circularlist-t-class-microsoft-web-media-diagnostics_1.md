---
title: CircularList(T) Class (Microsoft.Web.Media.Diagnostics)
TOCTitle: CircularList(T) Class
ms:assetid: T:Microsoft.Web.Media.Diagnostics.CircularList`1
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ff728278(v=VS.95)
ms:contentKeyID: 46500561
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.CircularList`1
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.CircularList`1
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CircularList\<T\> Class

(Deprecated. Do not use) Implements a circular list. The caller defines maximum length when the list is constructed. When the list reaches the maximum, adding additional elements will cause the oldest element to be removed.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
  [System.Collections.Generic.List](https://msdn.microsoft.com/en-us/library/6sh2ey19\(v=vs.95\))\<T\>  
    Microsoft.Web.Media.Diagnostics.CircularList\<T\>  

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Class CircularList(Of T) _
    Inherits List(Of T)
'Usage

Dim instance As CircularList(Of T)
```

``` csharp
public class CircularList<T> : List<T>
```

``` c++
generic<typename T>
public ref class CircularList : public List<T>
```

``` fsharp
type CircularList<'T> =  
    class
        inherit List<'T>
    end
```

``` jscript
JScript does not support generic types and methods.
```

#### Type Parameters

  - T  
    The type of this generic list.

The CircularList\<T\> type exposes the following members.

## Constructors

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="circularlist-t-constructor-microsoft-web-media-diagnostics_1.md">CircularList&lt;T&gt;</a></td>
<td>(Deprecated. Do not use) Initializes a new instance of the CircularList&lt;T&gt; class.</td>
</tr>
</tbody>
</table>


Top

## Properties

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/y52x03h2(v=vs.95)">Capacity</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/27b47ht3(v=vs.95)">Count</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/0ebtbkkc(v=vs.95)">Item</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
</tbody>
</table>


Top

## Methods

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="circularlist-t-add-method-microsoft-web-media-diagnostics_1.md">Add</a></td>
<td>(Deprecated. Do not use) Adds an object to the end of the CircularList&lt;T&gt;.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/z883w3dc(v=vs.95)">AddRange</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/e78dcd75(v=vs.95)">AsReadOnly</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/w4e7fxsh(v=vs.95)">BinarySearch(T)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ftfdbfx6(v=vs.95)">BinarySearch(T, IComparer&lt;T&gt;)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/a1s5syxa(v=vs.95)">BinarySearch(Int32, Int32, T, IComparer&lt;T&gt;)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dwb5h52a(v=vs.95)">Clear</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bhkz42b3(v=vs.95)">Contains</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/73fe8cwf(v=vs.95)">ConvertAll&lt;TOutput&gt;</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/t69dktcd(v=vs.95)">CopyTo(array&lt;T[])</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4df7xky9(v=vs.95)">CopyTo(array&lt;T[], Int32)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/3eb2b9x8(v=vs.95)">CopyTo(Int32, array&lt;T[], Int32, Int32)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.95)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bfed8bca(v=vs.95)">Exists</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.95)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/x0b5b5bc(v=vs.95)">Find</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/fh1w7y8z(v=vs.95)">FindAll</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/x1xzf2ca(v=vs.95)">FindIndex(Predicate&lt;T&gt;)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/efasdh0s(v=vs.95)">FindIndex(Int32, Predicate&lt;T&gt;)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7eb596wz(v=vs.95)">FindIndex(Int32, Int32, Predicate&lt;T&gt;)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/5kthb929(v=vs.95)">FindLast</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/xzs5503w(v=vs.95)">FindLastIndex(Predicate&lt;T&gt;)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/0b9t5061(v=vs.95)">FindLastIndex(Int32, Predicate&lt;T&gt;)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/860a771k(v=vs.95)">FindLastIndex(Int32, Int32, Predicate&lt;T&gt;)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bwabdf9z(v=vs.95)">ForEach</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/b0yss765(v=vs.95)">GetEnumerator</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.95)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/21k0e39c(v=vs.95)">GetRange</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.95)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/e4w08k17(v=vs.95)">IndexOf(T)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/s8t42k5w(v=vs.95)">IndexOf(T, Int32)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dy8zse0c(v=vs.95)">IndexOf(T, Int32, Int32)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/sey5k5z4(v=vs.95)">Insert</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/884ee1fz(v=vs.95)">InsertRange</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="circularlist-t-isfull-method-microsoft-web-media-diagnostics_1.md">IsFull</a></td>
<td>(Deprecated. Do not use) Boolean value that indicates whether the list is full.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dsxfcba1(v=vs.95)">LastIndexOf(T)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/s088xd6w(v=vs.95)">LastIndexOf(T, Int32)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/haast0bw(v=vs.95)">LastIndexOf(T, Int32, Int32)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.95)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cd666k3e(v=vs.95)">Remove</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/wdka673a(v=vs.95)">RemoveAll</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/5cw9x18z(v=vs.95)">RemoveAt</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/y33yd2b5(v=vs.95)">RemoveRange</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/b0axc2h2(v=vs.95)">Reverse()</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/hf2ay11y(v=vs.95)">Reverse(Int32, Int32)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/b0zbh7b6(v=vs.95)">Sort()</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/234b841s(v=vs.95)">Sort(IComparer&lt;T&gt;)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/w56d4y5z(v=vs.95)">Sort(Comparison&lt;T&gt;)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/8ce6t5ad(v=vs.95)">Sort(Int32, Int32, IComparer&lt;T&gt;)</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/x303t819(v=vs.95)">ToArray</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.95)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms132207(v=vs.95)">TrimExcess</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/kdxe4x4w(v=vs.95)">TrueForAll</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
</tbody>
</table>


Top

## Explicit Interface Implementations

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb310301(v=vs.95)">IList.Add</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb339171(v=vs.95)">IList.Contains</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb335467(v=vs.95)">ICollection.CopyTo</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc673062(v=vs.95)">IEnumerable&lt;T&gt;.GetEnumerator</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb344752(v=vs.95)">IEnumerable.GetEnumerator</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb352278(v=vs.95)">IList.IndexOf</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb342775(v=vs.95)">IList.Insert</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb354714(v=vs.95)">IList.IsFixedSize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc672994(v=vs.95)">ICollection&lt;T&gt;.IsReadOnly</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb346454(v=vs.95)">IList.IsReadOnly</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb345109(v=vs.95)">ICollection.IsSynchronized</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb346281(v=vs.95)">IList.Item</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb343997(v=vs.95)">IList.Remove</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb356596(v=vs.95)">ICollection.SyncRoot</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.95)">List</a>&lt;T&gt;.)</td>
</tr>
</tbody>
</table>


Top

## Version Information

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

