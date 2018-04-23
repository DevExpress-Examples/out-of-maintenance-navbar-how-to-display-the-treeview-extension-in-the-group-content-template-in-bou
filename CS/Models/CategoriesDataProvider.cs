using System.Collections.Generic;

public class CategoriesDataProvider {
    private static List<Category> collection = new List<Category>();

    public static List<Category> GetCategoryData() {
        if (collection.Count == 0) {
            collection.Add(new Category(1, 0, "Computer Cases"));
            collection.Add(new Category(2, 0, "Hard Drives"));
            collection.Add(new Category(3, 0, "Memory"));
            collection.Add(new Category(4, 0, "Input Devices"));
            collection.Add(new Category(5, 0, "Monitors"));

            collection.Add(new Category(10, 1, "Case Accessories"));
            collection.Add(new Category(11, 1, "Computer Cases"));
            collection.Add(new Category(12, 1, "External Enclosures"));
            collection.Add(new Category(13, 1, "Server Chassis"));

            collection.Add(new Category(20, 2, "Internal Hard Drives"));
            collection.Add(new Category(21, 2, "Laptop Hard Drives"));
            collection.Add(new Category(22, 2, "Network Hard Drives"));

            collection.Add(new Category(30, 3, "Desktop Memory"));
            collection.Add(new Category(31, 3, "Laptop Memory"));
            collection.Add(new Category(32, 3, "Server Memory"));

            collection.Add(new Category(40, 4, "Keyboards"));
            collection.Add(new Category(41, 4, "Mouse"));
            collection.Add(new Category(42, 4, "Tablets"));
            collection.Add(new Category(43, 4, "Web Cams"));

            collection.Add(new Category(50, 5, "CRT Monitors"));
            collection.Add(new Category(51, 5, "LCD Monitors"));
            collection.Add(new Category(52, 5, "Montior Accessories"));
            collection.Add(new Category(53, 5, "Touchscreen Monitors"));

            collection.Add(new Category(60, 30, "168-Pin SDRAM"));
            collection.Add(new Category(61, 30, "184-Pin DDR SDRAM"));
            collection.Add(new Category(62, 30, "184-Pin RDRAM (16bit)"));
            collection.Add(new Category(63, 30, "240-Pin DDR2 SDRAM"));
            collection.Add(new Category(64, 30, "240-Pin DDR3 SDRAM"));

            collection.Add(new Category(70, 63, "DDR2 400 (PC2 3200)"));
            collection.Add(new Category(71, 63, "DDR2 533 (PC2 4200)"));
            collection.Add(new Category(72, 63, "DDR2 533 (PC2 4300)"));
            collection.Add(new Category(73, 63, "DDR2 667 (PC2 5300)"));
            collection.Add(new Category(74, 63, "DDR2 667 (PC2 5400)"));
            collection.Add(new Category(75, 63, "DDR2 800 (PC2 6400)"));

        }

        return collection;
    }
}