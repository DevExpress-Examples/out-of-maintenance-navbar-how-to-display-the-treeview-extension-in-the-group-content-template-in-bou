Imports System.Collections.Generic

Public Class CategoriesDataProvider
	Private Shared collection As New List(Of Category)()

	Public Shared Function GetCategoryData() As List(Of Category)
		If collection.Count = 0 Then
			collection.Add(New Category(1, 0, "Computer Cases"))
			collection.Add(New Category(2, 0, "Hard Drives"))
			collection.Add(New Category(3, 0, "Memory"))
			collection.Add(New Category(4, 0, "Input Devices"))
			collection.Add(New Category(5, 0, "Monitors"))

			collection.Add(New Category(10, 1, "Case Accessories"))
			collection.Add(New Category(11, 1, "Computer Cases"))
			collection.Add(New Category(12, 1, "External Enclosures"))
			collection.Add(New Category(13, 1, "Server Chassis"))

			collection.Add(New Category(20, 2, "Internal Hard Drives"))
			collection.Add(New Category(21, 2, "Laptop Hard Drives"))
			collection.Add(New Category(22, 2, "Network Hard Drives"))

			collection.Add(New Category(30, 3, "Desktop Memory"))
			collection.Add(New Category(31, 3, "Laptop Memory"))
			collection.Add(New Category(32, 3, "Server Memory"))

			collection.Add(New Category(40, 4, "Keyboards"))
			collection.Add(New Category(41, 4, "Mouse"))
			collection.Add(New Category(42, 4, "Tablets"))
			collection.Add(New Category(43, 4, "Web Cams"))

			collection.Add(New Category(50, 5, "CRT Monitors"))
			collection.Add(New Category(51, 5, "LCD Monitors"))
			collection.Add(New Category(52, 5, "Montior Accessories"))
			collection.Add(New Category(53, 5, "Touchscreen Monitors"))

			collection.Add(New Category(60, 30, "168-Pin SDRAM"))
			collection.Add(New Category(61, 30, "184-Pin DDR SDRAM"))
			collection.Add(New Category(62, 30, "184-Pin RDRAM (16bit)"))
			collection.Add(New Category(63, 30, "240-Pin DDR2 SDRAM"))
			collection.Add(New Category(64, 30, "240-Pin DDR3 SDRAM"))

			collection.Add(New Category(70, 63, "DDR2 400 (PC2 3200)"))
			collection.Add(New Category(71, 63, "DDR2 533 (PC2 4200)"))
			collection.Add(New Category(72, 63, "DDR2 533 (PC2 4300)"))
			collection.Add(New Category(73, 63, "DDR2 667 (PC2 5300)"))
			collection.Add(New Category(74, 63, "DDR2 667 (PC2 5400)"))
			collection.Add(New Category(75, 63, "DDR2 800 (PC2 6400)"))

		End If

		Return collection
	End Function
End Class