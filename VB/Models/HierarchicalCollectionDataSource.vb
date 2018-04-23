Imports System.Web.UI
Imports System.Collections.Generic

Public Class HierarchicalCollectionDataSource
	Inherits HierarchicalDataSourceControl
	Implements IHierarchicalDataSource

	Private rootCategoryId As Integer

	Public Sub New(Optional ByVal rootCategoryId As Integer = 0)
		Me.rootCategoryId = rootCategoryId
	End Sub

	Protected Overrides Function GetHierarchicalView(ByVal viewPath As String) As HierarchicalDataSourceView Implements IHierarchicalDataSource.GetHierarchicalView
		Return New HierarchicalCollectionDataSourceView(rootCategoryId)
	End Function
End Class

Public Class HierarchicalCollectionDataSourceView
	Inherits HierarchicalDataSourceView

	Private rootCategoryId As Integer

	Public Sub New(ByVal rootCategoryId As Integer)
		Me.rootCategoryId = rootCategoryId
	End Sub

	Public Overrides Function [Select]() As IHierarchicalEnumerable
		Dim collection As New CategoryHierarchicalEnumerable()

		For Each category As Category In CategoriesDataProvider.GetCategoryData()
			If category.ParentId = rootCategoryId Then
				collection.Add(category)
			End If
		Next category

		Return collection
	End Function
End Class

Public Class CategoryHierarchicalEnumerable
	Inherits List(Of Category)
	Implements IHierarchicalEnumerable

	Public Function GetHierarchyData(ByVal enumeratedItem As Object) As IHierarchyData Implements IHierarchicalEnumerable.GetHierarchyData
		Return TryCast(enumeratedItem, IHierarchyData)
	End Function
End Class

Public Class Category
	Implements IHierarchyData

	Public Property CategoryId() As Integer
	Public Property ParentId() As Integer
	Public Property Name() As String

	Public Sub New(ByVal CategoryId As Integer, ByVal ParentId As Integer, ByVal Name As String)
		Me.CategoryId = CategoryId
		Me.ParentId = ParentId
		Me.Name = Name
	End Sub

	Public Function GetChildren() As IHierarchicalEnumerable Implements IHierarchyData.GetChildren
		Dim children As New CategoryHierarchicalEnumerable()

		For Each category As Category In CategoriesDataProvider.GetCategoryData()
			If category.ParentId = Me.CategoryId Then
				children.Add(category)
			End If
		Next category

		Return children

	End Function

	Public Function GetParent() As IHierarchyData Implements IHierarchyData.GetParent
		For Each category As Category In CategoriesDataProvider.GetCategoryData()
			If category.CategoryId = Me.ParentId Then
				Return category
			End If
		Next category

		Return Nothing
	End Function

	Public ReadOnly Property HasChildren() As Boolean Implements IHierarchyData.HasChildren
		Get
			Dim children As List(Of Category) = TryCast(GetChildren(), List(Of Category))
			Return children.Count > 0
		End Get
	End Property

	Public ReadOnly Property Item() As Object Implements IHierarchyData.Item
		Get
			Return Me
		End Get
	End Property

	Public ReadOnly Property Path() As String Implements IHierarchyData.Path
		Get
			Return Me.CategoryId.ToString()
		End Get
	End Property

	Public ReadOnly Property Type() As String Implements IHierarchyData.Type
		Get
			Return Me.GetType().ToString()
		End Get
	End Property

	Public Overrides Function ToString() As String
		Return Me.Name
	End Function
End Class