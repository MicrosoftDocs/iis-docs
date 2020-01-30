---
title: CircularList(T) Class (Microsoft.Web.Media.Diagnostics)
TOCTitle: CircularList(T) Class
ms:assetid: T:Microsoft.Web.Media.Diagnostics.CircularList`1
ms:mtpsurl: https://msdn.microsoft.com/library/Ff728278(v=VS.95)
ms:contentKeyID: 46500561
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.CircularList`1
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.CircularList`1
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CircularList\<T\> Class

(Deprecated. Do not use) Implements a circular list. The caller defines maximum length when the list is constructed. When the list reaches the maximum, adding additional elements will cause the oldest element to be removed.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  [System.Collections.Generic.List](https://msdn.microsoft.com/library/6sh2ey19\(v=vs.95\))\<T\>  
    Microsoft.Web.Media.Diagnostics.CircularList\<T\>  

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class CircularList(Of T) _
    Inherits List(Of T)
'Usage

Dim instance As CircularList(Of T)
```

```csharp
public class CircularList<T> : List<T>
```

```cpp
generic<typename T>
public ref class CircularList : public List<T>
```

``` fsharp
type CircularList<'T> =  
    class
        inherit List<'T>
    end
```

```jscript
JScript does not support generic types and methods.
```

#### Type Parameters

  - T  
    The type of this generic list.

The CircularList\<T\> type exposes the following members.

## Constructors

|                                                                                                                                                                             |                                        Name                                        |                                    Description                                    |
|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------|
| ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone") | [CircularList<T>](circularlist-t-constructor-microsoft-web-media-diagnostics_1.md) | (Deprecated. Do not use) Initializes a new instance of the CircularList<T> class. |

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Capacity](https://msdn.microsoft.com/library/y52x03h2(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Count](https://msdn.microsoft.com/library/27b47ht3(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Item](https://msdn.microsoft.com/library/0ebtbkkc(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|


## Methods

|                                                                                                                                                                                    |                                                Name                                                 |                                    Description                                    |
|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------|
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                [Add](circularlist-t-add-method-microsoft-web-media-diagnostics_1.md)                |    (Deprecated. Do not use) Adds an object to the end of the CircularList<T>.     |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                  [AddRange](https://msdn.microsoft.com/library/z883w3dc(v=vs.95))                   | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                 [AsReadOnly](https://msdn.microsoft.com/library/e78dcd75(v=vs.95))                  | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |               [BinarySearch(T)](https://msdn.microsoft.com/library/w4e7fxsh(v=vs.95))               | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |        [BinarySearch(T, IComparer<T>)](https://msdn.microsoft.com/library/ftfdbfx6(v=vs.95))        | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     | [BinarySearch(Int32, Int32, T, IComparer<T>)](https://msdn.microsoft.com/library/a1s5syxa(v=vs.95)) | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                    [Clear](https://msdn.microsoft.com/library/dwb5h52a(v=vs.95))                    | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                  [Contains](https://msdn.microsoft.com/library/bhkz42b3(v=vs.95))                   | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |             [ConvertAll<TOutput>](https://msdn.microsoft.com/library/73fe8cwf(v=vs.95))             | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |              [CopyTo(array<T[])](https://msdn.microsoft.com/library/t69dktcd(v=vs.95))              | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |          [CopyTo(array<T[], Int32)](https://msdn.microsoft.com/library/4df7xky9(v=vs.95))           | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |   [CopyTo(Int32, array<T[], Int32, Int32)](https://msdn.microsoft.com/library/3eb2b9x8(v=vs.95))    | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                   [Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))                    | (Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)  |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                   [Exists](https://msdn.microsoft.com/library/bfed8bca(v=vs.95))                    | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
| ![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone") |                  [Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))                   | (Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)  |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                    [Find](https://msdn.microsoft.com/library/x0b5b5bc(v=vs.95))                     | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                   [FindAll](https://msdn.microsoft.com/library/fh1w7y8z(v=vs.95))                   | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |           [FindIndex(Predicate<T>)](https://msdn.microsoft.com/library/x1xzf2ca(v=vs.95))           | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |       [FindIndex(Int32, Predicate<T>)](https://msdn.microsoft.com/library/efasdh0s(v=vs.95))        | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |    [FindIndex(Int32, Int32, Predicate<T>)](https://msdn.microsoft.com/library/7eb596wz(v=vs.95))    | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                  [FindLast](https://msdn.microsoft.com/library/5kthb929(v=vs.95))                   | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |         [FindLastIndex(Predicate<T>)](https://msdn.microsoft.com/library/xzs5503w(v=vs.95))         | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |     [FindLastIndex(Int32, Predicate<T>)](https://msdn.microsoft.com/library/0b9t5061(v=vs.95))      | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |  [FindLastIndex(Int32, Int32, Predicate<T>)](https://msdn.microsoft.com/library/860a771k(v=vs.95))  | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                   [ForEach](https://msdn.microsoft.com/library/bwabdf9z(v=vs.95))                   | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                [GetEnumerator](https://msdn.microsoft.com/library/b0yss765(v=vs.95))                | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                 [GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))                 | (Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)  |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                  [GetRange](https://msdn.microsoft.com/library/21k0e39c(v=vs.95))                   | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                   [GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))                   | (Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)  |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                 [IndexOf(T)](https://msdn.microsoft.com/library/e4w08k17(v=vs.95))                  | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |              [IndexOf(T, Int32)](https://msdn.microsoft.com/library/s8t42k5w(v=vs.95))              | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |          [IndexOf(T, Int32, Int32)](https://msdn.microsoft.com/library/dy8zse0c(v=vs.95))           | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                   [Insert](https://msdn.microsoft.com/library/sey5k5z4(v=vs.95))                    | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                 [InsertRange](https://msdn.microsoft.com/library/884ee1fz(v=vs.95))                 | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |             [IsFull](circularlist-t-isfull-method-microsoft-web-media-diagnostics_1.md)             |  (Deprecated. Do not use) Boolean value that indicates whether the list is full.  |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |               [LastIndexOf(T)](https://msdn.microsoft.com/library/dsxfcba1(v=vs.95))                | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |            [LastIndexOf(T, Int32)](https://msdn.microsoft.com/library/s088xd6w(v=vs.95))            | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |        [LastIndexOf(T, Int32, Int32)](https://msdn.microsoft.com/library/haast0bw(v=vs.95))         | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
| ![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone") |               [MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))               | (Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)  |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                   [Remove](https://msdn.microsoft.com/library/cd666k3e(v=vs.95))                    | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                  [RemoveAll](https://msdn.microsoft.com/library/wdka673a(v=vs.95))                  | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                  [RemoveAt](https://msdn.microsoft.com/library/5cw9x18z(v=vs.95))                   | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                 [RemoveRange](https://msdn.microsoft.com/library/y33yd2b5(v=vs.95))                 | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                  [Reverse()](https://msdn.microsoft.com/library/b0axc2h2(v=vs.95))                  | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |            [Reverse(Int32, Int32)](https://msdn.microsoft.com/library/hf2ay11y(v=vs.95))            | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                   [Sort()](https://msdn.microsoft.com/library/b0zbh7b6(v=vs.95))                    | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |             [Sort(IComparer<T>)](https://msdn.microsoft.com/library/234b841s(v=vs.95))              | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |             [Sort(Comparison<T>)](https://msdn.microsoft.com/library/w56d4y5z(v=vs.95))             | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |      [Sort(Int32, Int32, IComparer<T>)](https://msdn.microsoft.com/library/8ce6t5ad(v=vs.95))       | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                   [ToArray](https://msdn.microsoft.com/library/x303t819(v=vs.95))                   | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                  [ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))                   | (Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)  |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                 [TrimExcess](https://msdn.microsoft.com/library/ms132207(v=vs.95))                  | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |
|    ![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")     |                 [TrueForAll](https://msdn.microsoft.com/library/kdxe4x4w(v=vs.95))                  | (Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.) |

## Explicit Interface Implementations

||Name|Description|
|--- |--- |--- |
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[IList.Add](https://msdn.microsoft.com/library/bb310301(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[IList.Contains](https://msdn.microsoft.com/library/bb339171(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ICollection.CopyTo](https://msdn.microsoft.com/library/bb335467(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[IEnumerable<T>.GetEnumerator](https://msdn.microsoft.com/library/cc673062(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[IEnumerable.GetEnumerator](https://msdn.microsoft.com/library/bb344752(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[IList.IndexOf](https://msdn.microsoft.com/library/bb352278(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[IList.Insert](https://msdn.microsoft.com/library/bb342775(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[IList.IsFixedSize](https://msdn.microsoft.com/library/bb354714(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ICollection<T>.IsReadOnly](https://msdn.microsoft.com/library/cc672994(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[IList.IsReadOnly](https://msdn.microsoft.com/library/bb346454(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ICollection.IsSynchronized](https://msdn.microsoft.com/library/bb345109(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[IList.Item](https://msdn.microsoft.com/library/bb346281(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private method](images/Ff728198.privmethod(en-us,VS.90).gif "Private method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[IList.Remove](https://msdn.microsoft.com/library/bb343997(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|
|![Explicit interface implemetation](images/Ff728140.pubinterface(en-us,VS.90).gif "Explicit interface implemetation")![Private property](images/Ff728140.privproperty(en-us,VS.90).gif "Private property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ICollection.SyncRoot](https://msdn.microsoft.com/library/bb356596(v=vs.95))|(Inherited from [List](https://msdn.microsoft.com/library/6sh2ey19(v=vs.95))<T>.)|


## Version Information

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

